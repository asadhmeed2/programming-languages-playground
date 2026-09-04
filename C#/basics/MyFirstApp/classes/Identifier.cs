
public static class Identifier
{
    public static string Clean(string identifier)
    {
 	var outputStr = "";

        for(int i = 0; i < identifier.Length; i++)
	{
	char c = identifier[i];
	
	Console.WriteLine(c);

	if(c == ' ')
	{
		outputStr = $"{outputStr}_";
	}
	else if(c == '\\')
	{
		if(i < identifier.Length && identifier[i+1] == '0')
		{
		i++;
   		outputStr = $"{outputStr}CTRL";
		}
	}
	else{
		outputStr = $"{outputStr}{c}";
	}
	
	}
	return outputStr;
    }
}
