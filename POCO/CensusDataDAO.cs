using System;
using System.Collections.Generic;
using System.Text;

namespace IndiaStateCensusAnalyser.POCO
{
    public class CensusDataDAO
    {
        public string State;
        public long Population;
        public long Area;
        public long Density;

        public CensusDataDAO(string State, string Population, string Area, string Density   )
        {
            this.State = State;
            this.Population = Convert.ToInt32(Population);
            this.Area = Convert.ToInt32(Area);
            this.Density = Convert.ToInt32(Density);
        }
    }
}
