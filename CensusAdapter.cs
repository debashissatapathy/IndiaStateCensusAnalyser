using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndiaStateCensusAnalyser
{
    
        public abstract class CensusAdapter
        {
            protected string[] GetCensusData(string CsvFilePath, string DataHeaders)
            {
                string[] censusData;
                if (!File.Exists(CsvFilePath))
                {
                    throw new CensusAnalyserException("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
                }
                if (Path.GetExtension(CsvFilePath) != ".Csv")
                {
                    throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
                }
                censusData = File.ReadAllLines(CsvFilePath);
                if (censusData[0] != DataHeaders)
                {
                    throw new CensusAnalyserException("Incorrect header in data", CensusAnalyserException.ExceptionType.INCORRECT_HEADER);
                }
                return censusData;
            }
        }
    
}
