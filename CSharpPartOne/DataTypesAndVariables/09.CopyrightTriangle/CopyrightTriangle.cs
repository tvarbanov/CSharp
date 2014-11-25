using System;
class CopyrightTriangle
{
    static void Main()
    {
        char copyrightChar = '\u00A9';

        //Math.Abs - cast the number to decimal(without sign)
        /* Example how the cycle works
         * 0,1 0,2 (0,3) 0,4 0,5 0,6 -> vertical = 0
         * 1,1 (1,2) (1,3) (1,4) 1,5 1,6 -> vertical = 1
         * (2,1) (2,2) (2,3) (2,4) (2,5) 2,6 -> vertical = 2
         * */

        for (int vertical = 0; vertical < 3; vertical++)
        {
            for (int horizontal = 1; horizontal < 6; horizontal++)
            {
                Console.Write("{0}", Math.Abs(3 - horizontal) > vertical ? ' ' : copyrightChar);
            }
            Console.WriteLine();
        }
    }
}
