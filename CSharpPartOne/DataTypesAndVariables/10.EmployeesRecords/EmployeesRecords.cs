using System;
class EmployeesRecords
{
    static void Main()
    {
        /*A marketing firm wants to keep record of its employees. 
         * Each record would have the following characteristics – first name, family name, age, gender (m or f), 
         * ID number, unique employee number (27560000 to 27569999). 
         * Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.*/

        string firstName = "Teodor";
        string lastName = "Varbanov";
        byte age = 22;
        char gender = 'm';
        uint idNumber = 58948756;
        uint uniqueEmployeeNum = 27560101;
        //Test output
        Console.WriteLine("Full Name: {0} {1} Age: {2} Gender: {3} ID Number: {4} UEN: {5}", firstName, lastName, age, gender, idNumber, uniqueEmployeeNum);
    }
}
