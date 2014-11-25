//MAIN CLASS - DefiningClassesPartI.cs
namespace DefiningClassesPartI
{
    using System;
    using System.Text;

    public class Display
    {
        private double displaySize;
        private int displayColors;

        public Display()
        {

        }

        public Display(double displaySize)
        {
            this.DisplaySize = displaySize;
        }

        public Display(double displaySize, int displayColors)
        {
            this.DisplaySize = displaySize;
            this.DisplayColors = displayColors;
        }

        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new IndexOutOfRangeException("Invalid value for display size must be in range 0-10"); //soon will be 10" gsm/tablet/laptop/carry_it_in_a_bag/phone  hahaha
                }
                this.displaySize = value;
            }
        }
        
        public int DisplayColors
        {
            get
            {
                return this.displayColors;
            }
            set
            {
                if (value < 1 || value > 16000000)
                {
                    throw new IndexOutOfRangeException("Invalid value for display colors must be in range 1-16 000 000");
                }
                this.displayColors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Display:");
            sb.AppendLine(string.Format("[Size : {0}]", this.DisplaySize));
            sb.AppendLine(string.Format("[Colors : {0}]", this.DisplayColors));
            sb.AppendLine("------------------------------");
            return sb.ToString();
        }
    }
}
