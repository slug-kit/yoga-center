using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Linq;

namespace Utils;

[AttributeUsage(AttributeTargets.Property)]
public class DateRangeFromNowAttribute : ValidationAttribute
{
    private readonly DateTime _minDate;
    private readonly DateTime _maxDate;
    private readonly DateTime _now = DateTime.Now.Date;

    public DateRangeFromNowAttribute(int minDateAsYearsFromNow, int maxDateAsYearsFromNow)
    {
        _minDate = _now.AddYears(minDateAsYearsFromNow).Date;
        _maxDate = _now.AddYears(maxDateAsYearsFromNow).Date;
    }

    public override string FormatErrorMessage(string name) => string.Format(CultureInfo.CurrentCulture, ErrorMessage ?? "", name, _minDate, _maxDate);

    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    {
        if (_minDate > _maxDate) { throw new InvalidOperationException($"Minimum value '{_minDate}' must not be greater than maximum value '{_maxDate}'"); }

        if (value == null) { return ValidationResult.Success; }
        if (value is not DateTime date) { throw new ArgumentException($"{nameof(value)} is not of DateTime type.", nameof(value)); }

        if (date.Date < _minDate || date.Date > _maxDate)
        {
            return !string.IsNullOrEmpty(ErrorMessage)
                ? new ValidationResult(FormatErrorMessage("Date"))
                : new ValidationResult($"{context.DisplayName} must be within the range of {_minDate:d} to {_maxDate:d}");
        }
        else return ValidationResult.Success;
    }
}
