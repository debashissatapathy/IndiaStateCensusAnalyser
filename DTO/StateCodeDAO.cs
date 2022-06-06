using System;
using System.Collections.Generic;
using System.Text;

namespace IndiaStateCensusAnalyser.POCO
{
    public class StateCodeDAO
    {
        public int SerialNumber;
        public string StateName;
        public int Tin;
        public string StateCode;

        public StateCodeDAO(string SerialNumber, string StateName, string Tin, string StateCode)
        {
            this.SerialNumber = Convert.ToInt32(SerialNumber);
            this.StateName = StateName;
            this.Tin = Convert.ToInt32(Tin);
            this.StateCode = StateCode;
        }
    }
}
