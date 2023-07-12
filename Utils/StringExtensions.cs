using static Utils.Regexes;

namespace Utils;

public static class StringExtensions
{
    public static string ReplaceWhitespace(this string inputStr, string replacementStr)
    => Regex_AllWhitespace.Replace(inputStr, replacementStr);

    public static bool IsValidEmailAddress(this string email)
    {
        var trimmedEmail = email.Trim();
        if (trimmedEmail.EndsWith('.'))
        {
            return false;
        }

        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == trimmedEmail;
        }
        catch { return false; }
    }
}
