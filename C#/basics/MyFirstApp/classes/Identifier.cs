
public static class Identifier
{
    public static string Clean(string identifier)
    {
 	var outputStr = "";

        for(int i = 0; i <= identifier.Length; i++)
	{
	char c = identifier[i];

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
