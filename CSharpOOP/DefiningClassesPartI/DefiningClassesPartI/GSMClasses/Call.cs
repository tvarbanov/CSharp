//MAIN CLASS - DefiningClassesPartI.cs
namespace DefiningClassesPartI
{
    using System;
    using System.Text;

    public class Call
    {
        private DateTime dateAndTime;
        private string phoneNumber;
        private uint duration;

        public Call(): this("[Unknown number]", 0)
        {
        }

        public Call(string phoneNumber, uint duration)
        {
            this.DateAndTime = DateTime.Now;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            private set
            {
                this.dateAndTime = DateTime.Now;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid number - can't be null or empty!");
                }
                if ((value.Length != 10 && value.Length != 13) || (value[0] != '0' && value[0] != '+'))
                {
                    throw new ApplicationException("Phonenumber must be in format +359xxxxxxxxx OR 0xxxxxxxxx !");
                }
                this.phoneNumber = value; 
            }
        }

        public uint Duration
        {
            get { return duration; }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Invalid value for call duration - must be > 0");
                }
                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("[Date and time : {0}]", this.DateAndTime));
            sb.AppendLine(string.Format("[Phone Number : {0}]", this.PhoneNumber));
            sb.AppendLine(string.Format("[Duration : {0}]", this.Duration));
            return sb.ToString();
        }
    }
}
