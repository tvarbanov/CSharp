//MAIN CLASS - DefiningClassesPartI.cs
namespace DefiningClassesPartI
{
    using System;
    using System.Text;

    public class Battery
    {
        private string batteryModel;
        private int idleHours;
        private int talkHours;

        public BatteryType BatteryType { get; set; }

        public Battery()
        {

        }

        public Battery(string batteryModel)
        {
            this.BatteryModel = batteryModel;
        }

        public Battery(string batteryModel, int idleHours)
        {
            this.BatteryModel = batteryModel;
            this.IdleHours = idleHours;
        }

        public Battery(string batteryModel, int idleHours, int talkHours,BatteryType batteryType)
        {
            this.BatteryModel = batteryModel;
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.BatteryType = batteryType;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                this.batteryModel = value;
            }
        }

        public int IdleHours
        {
            get
            {
                return this.idleHours;
            }
            set
            {
                if(value < 0 || value > 1000)
                {
                    throw new IndexOutOfRangeException("Invalid value for idle hours must be in range 0-1000");
                }
                this.idleHours = value;
            }
        }
       
        public int TalkHours
        {
            get
            {
                return this.talkHours;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new IndexOutOfRangeException("Invalid value for talk hours must be in range 0-100");
                }
                this.talkHours = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Battery:");
            sb.AppendLine(string.Format("[Model : {0}]", this.BatteryModel));
            sb.AppendLine(string.Format("[Idle Hours : {0}]", this.IdleHours));
            sb.AppendLine(string.Format("[Talk Hours : {0}]", this.TalkHours));
            return sb.ToString();
        }
    }



}
