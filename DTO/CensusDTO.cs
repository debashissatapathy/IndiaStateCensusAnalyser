using System;
using System.Collections.Generic;
using System.Text;

namespace IndiaStateCensusAnalyser.POCO
{
    public class CensusDTO
    {
        public int SerialNumber;
        public string StateName;
        public String State;
        public int Tin;
        public string StateCode;
        public long Population;
        public long Area;
        public long Density;
        public long HousingUnit;
        public double TotalArea;
        public double WaterArea;
        public double LandArea;
        public double PopulationDensity;
        public double HousingDensity;

        public CensusDTO(StateCodeDAO stateCodeDao)
        {
            this.SerialNumber = stateCodeDao.SerialNumber;
            this.StateName = stateCodeDao.StateName;
            this.Tin = stateCodeDao.Tin;
            this.StateCode = stateCodeDao.StateCode;
        }
        public CensusDTO(CensusDataDAO censusDataDao)
        {
            this.State = censusDataDao.State;
            this.Population = censusDataDao.Population;
            this.Area = censusDataDao.Area;
            this.Density = censusDataDao.Density;
        }
    }
}
