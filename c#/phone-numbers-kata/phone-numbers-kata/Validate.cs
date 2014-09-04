using System;

class Validate
{
    public static string PhoneNumber(string telephoneNumber)
    {
        string numberToCheck = telephoneNumber;
        numberToCheck = numberToCheck.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(",", "");

        if (!(numberToCheck.StartsWith("9"))) return "invalid";
        if (!(numberToCheck.Length > 10)) return "invalid";
        if (!(numberToCheck.Length < 12)) return "invalid";
       // if (!Information.IsNumeric(numberToCheck)) return "invalid";

        return numberToCheck;

    }

}