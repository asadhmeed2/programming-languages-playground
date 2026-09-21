public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>()
        {
            [1] = "United States of America",
            [55] = "Brazil",
            [91] = "India"
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dict = new Dictionary<int, string>();
        dict[countryCode] = countryName;

        return dict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.TryGetValue(countryCode, out var value))
        {
            return existingDictionary;
        }

        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        var exists = existingDictionary.TryGetValue(countryCode, out var countryName);
        if (exists)
        {
            return countryName ?? string.Empty;
        }

        return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {

        var exists = existingDictionary.ContainsKey(countryCode);
        return exists;

    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!DialingCodes.CheckCodeExists(existingDictionary, countryCode))
        {
            return existingDictionary;
        }
        existingDictionary[countryCode] = countryName;

        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {

        if (!DialingCodes.CheckCodeExists(existingDictionary, countryCode))
        {
            return existingDictionary;
        }

        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        if (existingDictionary.Keys.Count == 0)
        {
            return String.Empty;
        }

        int longestValueCount = 0;
        string longestValue = String.Empty;
        foreach (var value in existingDictionary.Values)
        {
            if (value.Length > longestValueCount)
            {
                longestValueCount = value.Length;
                longestValue = value;
            }
        }

        return longestValue;
    }
}
