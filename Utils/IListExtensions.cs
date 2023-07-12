namespace Utils;

public static class IListExtensions
{
    public static void Replace(this System.Collections.IList list, int index, object? value)
    {
        if (index > list.Count) throw new ArgumentOutOfRangeException(string.Format("{0} is out of range.", nameof(index)));
        if (list.IsReadOnly || list.IsFixedSize) throw new NotSupportedException("Method is not supported for this list.");
        if (value == null) throw new ArgumentNullException(string.Format("{0} cannot be null.", nameof(value)));
        if (index == list.Count) { list.Add(value); }
        else { list.RemoveAt(index); list.Insert(index, value); }
    }
}
