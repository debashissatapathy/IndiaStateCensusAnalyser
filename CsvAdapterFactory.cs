using IndiaStateCensusAnalyser.POCO;
using System;
using System.Collections.Generic;
using System.Text;


namespace IndiaStateCensusAnalyser                              
{
    public class CsvAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string CsvFilePath, string dataheaders)
        {
            switch(country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndiaCensusAdapter().LoadCensusData(CsvFilePath, dataheaders);
                    
                default:
                    throw new CensusAnalyserException("No Such Country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }

        }
    }
}
