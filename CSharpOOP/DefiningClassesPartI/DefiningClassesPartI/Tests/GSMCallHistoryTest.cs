//MAIN CLASS - DefiningClassesPartI.cs
namespace DefiningClassesPartI
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSMCallHistoryTest
    {
        public static void GSMCallHistoryTester()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("*** --- GSMCallHistoryTest --- ****");
            Console.WriteLine();
            GSM test = new GSM("Galaxy S2", "Samsung", 1000, "Me", new Battery("1650MhA", 480, 18, BatteryType.Li_Ion), new Display(4.3, 16000000));
            Call Call1 = new Call("0888123456", 55);
            Call Call2 = new Call("0888133456", 35);
            Call Call3 = new Call("0888176421", 75);
            test.AddCall(Call1);
            test.AddCall(Call2);
            test.AddCall(Call3);

            //Pritn call history
            PrintCallHistory(test.GetCallHistory());

            //Set price per minute and print the sum of all calls
            Console.WriteLine("--- Print the total price of all calls");
            float callPricePerMinute = 0.37f;
            Console.WriteLine("Total calls price: {0:C}", test.CalculateTotalPrice(callPricePerMinute));

            //Finds the call with longest duration
            int longestCallDuration = 0;
            int longestCallIndex = 0;
            int tempIndex = 0;
            foreach (var call in test.GetCallHistory())
            {
                if (call.Duration > longestCallDuration) longestCallIndex = tempIndex;
                tempIndex++;
            }
            //Deletes the longest call and print result
            Console.WriteLine("--- Print the total price of all calls with deleted longest call");
            test.DeleteCall(longestCallIndex);
            Console.WriteLine("Total calls price: {0:C}", test.CalculateTotalPrice(callPricePerMinute));
            //Clear history
            Console.WriteLine("--- Print the call history after it's cleared");
            test.ClearCallHistory();
            PrintCallHistory(test.GetCallHistory());
        }

        //Method for printing all entries in CallHistory array
        private static void PrintCallHistory(List<Call> CallHistory)
        {
            if (CallHistory.Count == 0) //if it's empty
            {
                Console.WriteLine("Call history is empty!");
                return;
            }
            Console.WriteLine("Calls in call history:");
            foreach (var call in CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
