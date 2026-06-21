using System;
using System.Globalization;

namespace CSharpConsoleHelpers
{
    /// <summary>
    /// Console utility helpers and input validators - Created by C#Fazza++
    /// </summary>
    public static class InputValidator
    {
        // Made the method public so it can be accessed outside of this class
        public static void PrintUserDateTime()
        {
            DateTime dDateOfBirth;
            Console.WriteLine("Please enter date of birth:\nExample of entering date of birth: 20/05/2026");
            
            string sInputDateOfBirth = Console.ReadLine();
            string[] sFormats = { "dd/MM/yyyy", "dd-MM-yyyy", "dd.MM.yyyy", "dd MM yyyy", "dd,MM,yyyy" };
            
            // Clean the input by replacing asterisks with slashes
            sInputDateOfBirth = sInputDateOfBirth.Replace("*", "/");
            
            // Validation loop: runs until the user enters a correctly formatted date
            while (!DateTime.TryParseExact(sInputDateOfBirth, sFormats, CultureInfo.InvariantCulture,
                           DateTimeStyles.None, out dDateOfBirth)) 
            {
                Console.WriteLine("❌ Sorry, the format you entered is not supported, please follow the instructions.");
                Console.Write("Enter again: ");
                
                // Get new input and clean it again inside the loop
                sInputDateOfBirth = Console.ReadLine();
                sInputDateOfBirth = sInputDateOfBirth.Replace("*", "/");
            }
            
            // Success: prints the final cleaned date without the time part
            Console.WriteLine($"The date of birth was successfully entered: {dDateOfBirth.ToShortDateString()}");
        }
    }
}
