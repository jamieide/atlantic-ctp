using AtlanticCovidTracker.Client.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client.Models
{
    public class StateData
    {
        public string DataQualityGrade { get; set; }
        [JsonConverter(typeof(DateConverter))]
        public DateTime Date { get; set; }
        public int? Death { get; set; }
        public int? DeathConfirmed { get; set; }
        public int? DeathIncrease { get; set; }
        public int? DeathProbable { get; set; }
        public string Fips { get; set; }
        public int? HospitalizedCumulative { get; set; }
        public int? HospitalizedCurrently { get; set; }
        public int? HospitalizedIncrease { get; set; }
        public int? InIcuCumulative { get; set; }
        public int? InIcuCurrently { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Older data contains nulls</remarks>
        [JsonConverter(typeof(NullableDateTimeConverter))]
        public DateTime? LastUpdateEt { get; set; }
        public int? Negative { get; set; }
        public int? NegativeIncrease { get; set; }
        public int? NegativeTestsViral { get; set; }
        public int? OnVentilatorCumulative { get; set; }
        public int? OnVentilatorCurrently { get; set; }
        public int? Pending { get; set; }
        public int? Postive { get; set; }
        public int? PositiveCasesViral { get; set; }
        public int? PostiveIncrease { get; set; }
        public int? PositiveTestsViral { get; set; }
        public int? Recovered { get; set; }
        public string State { get; set; }
        public int? TotalTestResults { get; set; }
        public int? TotalTestResultsIncrease { get; set; }
        public int? TotalTestsViral { get; set; }
    }
}
