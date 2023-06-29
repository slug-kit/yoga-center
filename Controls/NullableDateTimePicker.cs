namespace YogaCenterWinApp_Group9.Controls;

#nullable disable

public class NullableDateTimePicker : DateTimePicker
{
    private DateTimePickerFormat oldFormat = DateTimePickerFormat.Long;
    private string oldCustomFormat = null;
    private bool hasNull = false;
    private readonly DateTime minDate;

    private string _nullFormat;

    public string NullFormat
    {
        get => _nullFormat;
        set => _nullFormat = value;
    }

    public NullableDateTimePicker() : base()
    {
        minDate = DateTime.MinValue < MinDate ? MinDate : DateTime.MinValue;
    }

    public new DateTime Value
    {
        // If we return MinDate when this control hasNull, when the user changes the datetime from the GUI,
        // any bound Binding with formatting on (needed to format DataSource null) will reformat and set
        // our Value to MinDate, making our control unuseable.
        get => base.Value;
        set
        {
            if (value == minDate)
            {
                // HACK #2: These serve to cause the property to be marked as modified by the Binding,
                // forcing a Parse even when the Value has not been changed.
                DateTime oldValue = base.Value;
                base.Value = MaxDate;
                base.Value = oldValue;

                if (!hasNull)
                {
                    oldFormat = Format;
                    oldCustomFormat = CustomFormat;
                    hasNull = true;

                    // HACK #1: These ugly things are here because Windows recreates the control handle
                    // whenever we change its format, resetting all properties and pushing fresh
                    // data from the DataSource, nullifying all of our work.
                    // The call to re-apply the Custom format causes another PushData, but the format
                    // sticks, so do NOT change the order of the 3 statements.
                    Format = DateTimePickerFormat.Custom;
                    if (Format != DateTimePickerFormat.Custom) Format = DateTimePickerFormat.Custom;
                    // HACK #2 in HACK #1: We always perform this set-reset to cause the property to be
                    // marked as modified even in the event of a handle recreation.
                    //if (base.Value != oldValue)
                    {
                        // Future-proofing ;)
                        var maxDate = MaxDate == oldValue ? MaxDate.AddMilliseconds(-1337) : MaxDate;
                        base.Value = maxDate;
                        base.Value = oldValue;
                    }
                    if (!hasNull) hasNull = true;
                }
                // Set the custom format again to re-apply the Null Format 
                // in case it has changed.
                CustomFormat = _nullFormat;
            }
            else
            {
                if (hasNull)
                {
                    Format = oldFormat;
                    CustomFormat = oldCustomFormat;
                    hasNull = false;
                }
                base.Value = value;
            }
        }
    }

    protected override void OnCloseUp(EventArgs eventargs)
    {
        if (Control.MouseButtons == MouseButtons.None && hasNull)
        {
            // HACK #1: These ugly things are here for the same reasons as the ones in
            // the Value setter: As a workaround to Windows recreating the control
            // handle when its format is changed.
            DateTime oldValue = base.Value;
            Format = oldFormat;
            // HACK #2 in HACK #1: We always perform this set-reset to cause the property to be
            // marked as modified even in the event of a handle recreation.
            //if (base.Value != oldValue)
            {
                // Future-proofing ;)
                var maxDate = MaxDate == oldValue ? MaxDate.AddMilliseconds(-1337) : MaxDate;
                base.Value = maxDate;
                base.Value = oldValue;
            }

            CustomFormat = oldCustomFormat;
            hasNull = false;
        }
        base.OnCloseUp(eventargs);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
        if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            Value = minDate;
    }
}
