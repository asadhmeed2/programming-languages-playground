
public static class Identifier
{
    public static string Clean(string identifier)
    {
        var output = "";

        for(int i =0; i < identifier.Length; i++)
        {
            if(Char.IsControl(identifier, i))
            {
                output = $"{output}CTRL";
            }
            else
            {
                 output = $"{output}{identifier[i]}";
            }
        }

        output = identifier.Replace(" ", "_");
        return output;
    }
}
