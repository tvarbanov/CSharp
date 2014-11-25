//MAIN CLASS - DefiningClassesPartI.cs
namespace DefiningClassesPartI
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class GSM 
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private List<Call> callHistory = new List<Call>();

        private static readonly GSM iphone4S = new GSM("iPhone 4S", "Apple", 1400, "Steve Jobs", new Battery("1300MhA", 450, 20, BatteryType.Li_Ion), new Display(4.0, 16000000));
        
        //Constructors
        public GSM(string model)
        {
            this.Model = model;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //Properties
        public string Model
        {
            get 
            { 
                return this.model; 
            }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model name!");
                }
                this.model = value; 
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery { get; set; }

        public Display Display { get; set; }

        public static GSM iPhone4S
        {
            get
            {
                return iphone4S;
            }
        }

        //Call history methods
        public void AddCall(Call newCall)
        {
            this.callHistory.Add(newCall);
        }

        public void DeleteCall(Call myCall) 
        {
            this.callHistory.Remove(myCall);
        }

        public void DeleteCall(int index) 
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public List<Call> GetCallHistory()
        {
            return this.callHistory;
        }

        public float CalculateTotalPrice(float pricePerMinute)
        {
            float totalPrice = 0;
            foreach (var call in callHistory)
            {
                totalPrice += call.Duration * pricePerMinute / 60;
            }
            return totalPrice;
        }        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("GSM:");
            sb.AppendLine(string.Format("[Model : {0}]", this.Model));
            sb.AppendLine(string.Format("[Manufacturer : {0}]", this.Manufacturer));
            if (this.Price != 0)
            {
                sb.AppendLine(string.Format("[Price : {0}]", this.price));
            }
            if (!string.IsNullOrEmpty(Owner))
            {
                sb.AppendLine(string.Format("[Owner : {0}]", this.owner));
            }
            if (this.Battery != null)
            {
                sb.AppendLine(this.Battery.ToString());
            }
            if (this.Display != null)
            {
                sb.AppendLine(this.Display.ToString());
            }
            return sb.ToString();
        }

    }
}
