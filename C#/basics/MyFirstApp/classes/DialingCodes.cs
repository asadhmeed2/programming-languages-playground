public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        new Dictionary<int, string>()
        {
        [1] = "United States of America",
        [55] = "Brazil",
        [91] = "India"
        }
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dict = new Dictionary<int,string>;
        dict[countryCode] = countryName;

        return dict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        throw new NotImplementedException($"Please implement the (static) AddCountryToExistingDictionary() method");
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        throw new NotImplementedException($"Please implement the (static) GetCountryNameFromDictionary() method");
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        throw new NotImplementedException($"Please implement the (static) CheckCodeExists() method");
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        throw new NotImplementedException($"Please implement the (static) UpdateDictionary() method");
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        throw new NotImplementedException($"Please implement the (static) RemoveCountryFromDictionary() method");
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        throw new NotImplementedException($"Please implement the (static) FindLongestCountryName() method");
    }
}
