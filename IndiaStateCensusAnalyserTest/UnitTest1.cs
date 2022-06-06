using static IndiaStateCensusAnalyser.CensusAnalyser;
using IndiaStateCensusAnalyser.POCO;
using IndiaStateCensusAnalyser;
using System.Collections.Generic;
using Newtonsoft.Json;
using NUnit.Framework;

namespace IndiaStateCensusAnalyserTest
{
    public class IndiaStateCensusAnalyserTest
    {
        static string IndiaStateCensusHeaders = "State,	Population,	AreaInSqKm,	DensityPerSqKm";
        static string IndiaStateCodeHeaders = "SrNo, State Name, TIN, StateCode";
        static string IndiaStateCensusFilePath = @"D:\C#\IndiaStateCensusAnalysis\IndiaStateCensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";
        static string DelimiterIndiaStateCensusFilePath= @"D:\C#\IndiaStateCensusAnalysis\IndiaStateCensusAnalyserTest\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string IndiaStateCodeFilePath = @"D:\C#\IndiaStateCensusAnalysis\IndiaStateCensusAnalyserTest\CSVFiles\IndiaStateCode.csv";

        IndiaStateCensusAnalyser.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> CountryRecord;
        Dictionary<string, CensusDTO> StateRecord;


        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            CountryRecord = new Dictionary<string, CensusDTO>();
            StateRecord = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void GivenIndiaStateCensusData_WhenRead_ShouldCensusDataCount()
        {
            CountryRecord = censusAnalyser.LoadCensusData(Country INDIA, IndiaStateCensusFilePath, IndiaStateCensusHeaders);
            StateRecord = censusAnalyser.LoadCensusData(Country INDIA, IndiaStateCodeFilePath, IndiaStateCodeHeaders);
            Assert.AreEqual(29, CountryRecord.Count);
            Assert.AreEqual(37, StateRecord.Count);            
        }
        

    }
}