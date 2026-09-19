
using System.Globalization;

static class Appointment
{
    static private string[] validDateFormats = { "M/d/yyyy H:mm:ss", "MMMM d, yyyy H:mm:ss", "dddd, MMMM d, yyyy H:mm:ss" };
    //dates format that will be used in this function are 
    //"7/25/2019 13:45:00",
    //"July 25, 2019 13:45:00"
    //"Thursday, July 25, 2019 13:45:00"
    public static DateTime Schedule(string appointmentDateDescription)
    {
        bool isValidDate = DateTime.TryParseExact(
    appointmentDateDescription,
    validDateFormats,
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime parsedDate
);
        if (!isValidDate)
        {
            return DateTime.MinValue;
        }

        return parsedDate;

    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if(appointmentDate < DateTime.Now)
        {
            return true;
        }
        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)=> appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString()}.";
    
    

    public static DateTime AnniversaryDate()=> new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
