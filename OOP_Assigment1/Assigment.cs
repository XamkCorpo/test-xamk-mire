using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment1
{
    public static class Calculator
    {
        //decimal offical documentation: https://learn.microsoft.com/en-us/dotnet/api/system.decimal?view=net-7.0

        public static decimal Sum(decimal a, decimal b)
        {
            //Assigment 1: Return the sum of a and b.
            throw new NotImplementedException();
        }

        public static decimal Divide(decimal a, decimal b)
        {
            //Assigment 2: Return the result of dividing a by b.
            //Note no need to check for divide by zero, but you can do if you want
            throw new NotImplementedException();
        }

        public static decimal Multiply(decimal a, decimal b)
        {
            //Assigment 3: Return the result of multiplying a by b.
            throw new NotImplementedException();
        }

        public static decimal Subtract(decimal a, decimal b)
        {
            //Assigment 4: Return the result of subtracting b from a.
            throw new NotImplementedException();
        }

        public static decimal ConvertPoundsToKg(decimal pounds)
        {
            //Assigment 5: Return the result of converting pounds to kg. Round to 2 decimals.
            throw new NotImplementedException();
        }

        public static decimal ConvertFahreheitToCelcius(decimal fahrenheit)
        {
            //Assigment 6: Return the result of converting fahrenheit to celcius.  Round to 2 decimals.
            throw new NotImplementedException();
        }
    }

    public static class DateTimeHelper
    {

        public static int CalculateAge(DateTime birthDate)
        {
            //Assigment 7: Calculate the age of the person born using the birthDate parameter.
            throw new NotImplementedException();
        }

        public static DateTime ConvertToDateTime(string date)
        {
            //Assigment 8: Return the first day of the month of the date parameter.
            //The input string format is 2022-07-31
            throw new NotImplementedException();
        }

        public static bool IsLeapYear(DateTime date)
        {
            //Assigment 9: Return true if date is leap year
            throw new NotImplementedException();
        }

        public static int DaysUntilNextBirthday(DateTime birthDate, DateTime currentTime)
        {
            //Assigment 10: Calculate the number of days until the next birthday.
            //Note that this is not easily unit tested because the result depends on the current date!!!
            //So this assignment is not tested in the unit tests.
            throw new NotImplementedException();
        }


        public static string GetCurrentDateTime()
        {
            //Assigment 11: Return the current date and time in the format: "yyyy-MM-dd HH:mm:ss".
            throw new NotImplementedException();
        }

    }


    public static class RoleChecker
    {
        public enum Role
        {
            Admin,
            User,
            Guest
        }

        public static bool IsAdmin(Role role)
        {
            //Assigment 11: Return true if role is Admin, otherwise return false.
            throw new NotImplementedException();
        }
       

        public static bool HasPrivligies(Role role, DateTime validUntill) 
        {
            //Assigment 12: Return true if role is Admin or User and validUntill is in the future, otherwise return false.
            throw new NotImplementedException();
        }

        public static string RoleToString(Role role)
        {
            //Assigment 13: Implement a method RoleToString(Role role) that converts the Role enum to its string representation.
             throw new NotImplementedException();
        }

        public static Role StringToRole(string roleString)
        {
            //Assigment 14: Write a method StringToRole(string roleString) that converts a string to the corresponding Role enum. 
            //If the string does not match any role, throw an appropriate exception.
            //Hint: Remember how conversion worked on ints (especially TryParse)
            throw new NotImplementedException();
        }

    }
}
