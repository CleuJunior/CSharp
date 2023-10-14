using System;
using System.Text;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => DateTime.Now.CompareTo(appointmentDate) > 0;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) =>
        appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate)
    {
        StringBuilder appointmentDateMessage = new("You have an appointment on ");

        appointmentDateMessage.Append(appointmentDate.Month);
        appointmentDateMessage.Append('/');
        appointmentDateMessage.Append(appointmentDate.Day);
        appointmentDateMessage.Append('/');
        appointmentDateMessage.Append(appointmentDate.Year);
        appointmentDateMessage.Append(' ');

        string hour = appointmentDate.Hour < 12 ? $"{appointmentDate.Hour}" : $"{appointmentDate.Hour - 12}";

        appointmentDateMessage.Append(hour);
        appointmentDateMessage.Append(PatternString(appointmentDate.Minute));
        appointmentDateMessage.Append(PatternString(appointmentDate.Second));
        appointmentDateMessage.Append(' ');
        
        string systemAmOrPm = appointmentDate.Hour > 12 ? "PM." : "AM.";
        appointmentDateMessage.Append(systemAmOrPm);

        return appointmentDateMessage.ToString();
    }

    private static string PatternString(int time) => time < 10 ? $":0{time}" : $":{time}";

    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 9, 15);
}