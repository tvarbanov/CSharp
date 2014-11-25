using System;
class StringToObject
{
    static void Main()
    {
        /*Declare two string variables and assign them with “Hello” and “World”. 
         * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
         * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/
        string strVar1 = "Hello ";
        string strVar2 = "World";
        object objVar = strVar1 + strVar2;
        string strObjVar = (string)objVar;
        Console.WriteLine(strObjVar);
    }
}
