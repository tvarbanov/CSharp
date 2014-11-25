//MAIN CLASS - DefiningClassesPartI.cs
namespace DefiningClassesPartI
{
    using System;

    public class GSMTest 
    {
        public static void GSMTester()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("*** --- GSMTest --- ****");
            Console.WriteLine();
            GSM[] test = new GSM[] { 
            new GSM("Galaxy S2","Samsung",1000,"Me",new Battery("1650MhA",480,18,BatteryType.Li_Ion),new Display(4.3,65000)), 
            new GSM("Galaxy S2","Samsung",1000,"Me",new Battery("1650MhA",480,18,BatteryType.Li_Ion),new Display(4.3,65000)), 
            new GSM("Galaxy S2","Samsung",1000,"Me",new Battery("1650MhA",480,18,BatteryType.Li_Ion),new Display(4.5,65000))
            };

            foreach (var gsm in test)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.iPhone4S);
        }
      
    }
}
