﻿
namespace BankSystem
{
    using System;

    class IndividualCustomer : Customer
    {
        private int egn;

        public int EGN
        {
            get { return this.egn; }
            set { this.egn = value; }
        }

        public IndividualCustomer(string name, int egn, string address, string telephoneNumber)
            : base(name, address, telephoneNumber)
        {
            this.EGN = egn;
        }

        public override string ToString()
        {
            string individualInfo = base.ToString() + "EGN: " + this.egn + Environment.NewLine;
            return individualInfo;
        }
    }
}