namespace Celestia.Models.Utilities;

public static class DateUtilities
{ 
    public static int ToUnixSeconds(DateTime dateTime) => (int)dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
}