
using System.Linq;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var output = "";
        bool  capitalizeNext = false;
        var sb = new StringBuilder();

        foreach (var c in identifier)
        {
            if (c == '\0')
                sb.Append("CTRL");
            else if (c == ' ')
                sb.Append('_');
             else if (c == '-')
                capitalizeNext = true;
            else if (!char.IsLetter(c))
            {

            }
            else
            {
                sb.Append(capitalizeNext ? char.ToUpper(c) : c);
                capitalizeNext = false;
            }   
        }
        output = sb.ToString();

        return output;
    }
}
