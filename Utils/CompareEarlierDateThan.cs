using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Utils;

[AttributeUsage(AttributeTargets.Property)]
public class CompareEarlierDateThan : ValidationAttribute
{
    private string? otherDisplayName;
    public string OtherPropertyName { get; }

    public CompareEarlierDateThan(string otherProperty)
    {
        OtherPropertyName = otherProperty;
    }

    public override string FormatErrorMessage(string name) => string.Format(CultureInfo.CurrentCulture, ErrorMessage ?? "", name);

    //      ToValidateProp   OtherProp       |   Action
    //      -------------------------------- | ---------
    // #1   >Wrong Type      >Don't care     |   >Throw
    // #2   >Don't care      >Doesn't exist  |   >Throw
    //                       OR Wrong Type   |
    // #3   >NULL            >NULL           |   >Valid
    // #4   >NULL            >not NULL       |   >Invalid
    // #5   >not NULL        >NULL           |   >Valid
    // #6   >not NULL        >not NULL       |   >Compare
    // 
    //              ## WARNING: UNTESTED ##
    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    {
        // Case #1
        var otherProperty = context.ObjectType.GetProperty(OtherPropertyName)
            ?? throw new InvalidOperationException($"Object '{context.ObjectInstance}' does not contain a property named '{OtherPropertyName}'.");
        if (otherProperty.PropertyType != typeof(DateTime) && otherProperty.PropertyType != typeof(DateTime?))
        {
            throw new InvalidOperationException($"Object '{context.ObjectInstance}' contains a property named '{OtherPropertyName}' but not of type DateTime or DateTime?.");
        }

        // Case #2
        if (value != null && value is not DateTime)
        {
            throw new ArgumentException($"{nameof(value)} is not of DateTime type.", nameof(value));
        }

        // Cases #3 & #5
        var otherDate = (DateTime?)otherProperty.GetValue(context.ObjectInstance);
        if (otherDate == null)
        {
            return ValidationResult.Success;
        }
        else
        {
            // Case #4
            otherDisplayName = ((DisplayNameAttribute?)GetCustomAttribute(otherProperty, typeof(DisplayNameAttribute)))?
                .DisplayName;
            if (value == null)
            {
                return !string.IsNullOrEmpty(ErrorMessage)
                    ? new ValidationResult(FormatErrorMessage(context.DisplayName))
                    : new ValidationResult($"{context.DisplayName} is required when {otherDisplayName ?? OtherPropertyName} has a value.");
            }
            // Case #6
            else
            {
                var date = (DateTime)value;
                if (date.Date > otherDate?.Date)
                {
                    return !string.IsNullOrEmpty(ErrorMessage)
                        ? new ValidationResult(FormatErrorMessage(context.DisplayName))
                        : new ValidationResult($"{context.DisplayName} must not be later than {otherDisplayName ?? OtherPropertyName}");
                }
                else return ValidationResult.Success;
            }
        }
    }
}
