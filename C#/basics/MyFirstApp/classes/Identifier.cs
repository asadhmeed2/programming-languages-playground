
public static class Identifier
{
    public static string Clean(string identifier)
    {
 	var outputStr = "";

        foreach(char c in identifier)
	{
	
	if(c == ' ')
	{
		outputStr = $"{outputStr}_";
	}
	else{
		outputStr = $"{outputStr}{c}";
	}
	
	}
	return outputStr;
    }
}
