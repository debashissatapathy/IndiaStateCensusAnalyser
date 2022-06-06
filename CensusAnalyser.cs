using IndiaStateCensusAnalyser.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndiaStateCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, USA, BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusMap(Country country, string CsvFilePath, string dataHeaders)
        {
            dataMap = new CsvAdapterFactory().LoadCsvData(country, CsvFilePath, dataHeaders);
            return dataMap;
        }

        
    }
}
