
using System.Globalization;

static class Appointment
{
    static private string[] validDateFormats = { "MM/dd/yyyy hh:mm:ss", "MMM dd, yyyy hh:mm:ss", "DDD, MMM dd, yyyy hh:mm:ss" };
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
        throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
    }

    public static string Description(DateTime appointmentDate)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
    }

    public static DateTime AnniversaryDate()
    {
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
