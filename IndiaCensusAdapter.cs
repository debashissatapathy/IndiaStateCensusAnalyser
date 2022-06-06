using IndiaStateCensusAnalyser.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    
namespace IndiaStateCensusAnalyser
{
    public class IndiaCensusAdapter : CensusAdapter
    {
        string[] censusData;
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO>LoadCensusData(string CsvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string, CensusDTO>();
            censusData = GetCensusData(CsvFilePath, dataHeaders);
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains(","))
                {
                    throw new CensusAnalyserException("File containing wrong Delimiter", CensusAnalyserException.ExceptionType.INCORRESCT_DELIMITER);
                }
                string[] column = data.Split(",");
                if (CsvFilePath.Contains("IndiaStateCode.Csv"))
                {
                    dataMap.Add(column[1], new CensusDTO(new StateCodeDAO(column[0], column[1], column[2], column[3])));
                }
                if (CsvFilePath.Contains("IndiaStateCensusData.Csv"))
                {
                    dataMap.Add(column[0], new CensusDTO(new StateCodeDAO(column[0], column[1], column[2], column[3])));
                }
            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}
