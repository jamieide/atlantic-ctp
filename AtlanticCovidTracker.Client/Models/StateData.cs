using AtlanticCovidTracker.Client.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client.Models
{
    public class StateData
    {
        [Display(Name = "Data Quality Grade", Description = "The COVID Tracking Project grade of the completeness of the data reporting by a state.")]
        public string DataQualityGrade { get; set; }

        [JsonConverter(typeof(DateConverter))]
        [Display(Name = "Date", Description = "Date on which data was collected by The COVID Tracking Project.")]
        public DateTime Date { get; set; }

        [Display(Name = "Total Deaths", Description = "Total fatalities with confirmed OR probable COVID-19 case diagnosis (per the expanded CSTE case definition of April 5th, 2020 approved by the CDC). In states where the information is available, it only tracks fatalities with confirmed OR probable COVID-19 case diagnosis where COVID-19 is an underlying cause of death according to the death certificate based on WHO guidelines.")]
        public int? Death { get; set; }

        [Display(Name = "Confirmed Deaths", Description = "Total fatalities with confirmed COVID-19 case diagnosis (per the expanded CSTE case definition of April 5th, 2020 approved by the CDC). In states where the information is available, it only tracks fatalities with confirmed COVID-19 case diagnosis where COVID-19 is an underlying cause of death according to the death certificate based on WHO guidelines.")]
        public int? DeathConfirmed { get; set; }

        [Display(Name = "Deaths Increase", Description = "Daily difference in death.")]
        public int? DeathIncrease { get; set; }

        [Display(Name = "Probable Deaths", Description = "Total fatalities with probable COVID-19 case diagnosis (per the expanded CSTE case definition of April 5th, 2020 approved by the CDC). In states where the information is available, it only tracks fatalities with confirmed OR probable COVID-19 case diagnosis where COVID-19 is an underlying cause of death according to the death certificate based on WHO guidelines.")]
        public int? DeathProbable { get; set; }

        [Display(Name = "FIPS Code", Description = "Federal Information Processing Standards (FIPS) code for the state or territory.")]
        public string Fips { get; set; }

        [Display(Name = "Total Hospitalized", Description = "Individuals who are currently hospitalized with COVID-19. Definitions vary by state / territory. Where possible, we report hospitalizations with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? HospitalizedCumulative { get; set; }

        [Display(Name = "Currently Hospitalized", Description = "Individuals who are currently hospitalized with COVID-19. Definitions vary by state / territory. Where possible, we report hospitalizations with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? HospitalizedCurrently { get; set; }

        [Display(Name = "Hospitalized Increase", Description = "Daily difference in hospitalized.")]
        public int? HospitalizedIncrease { get; set; }

        [Display(Name = "Total ICU", Description = "Total number of individuals who have ever been hospitalized in the Intensive Care Unit with COVID-19. Definitions vary by state / territory. Where possible, we report patients in the ICU with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? InIcuCumulative { get; set; }

        [Display(Name = "Current ICU", Description = "Individuals who are currently hospitalized in the Intensive Care Unit with COVID-19. Definitions vary by state / territory. Where possible, we report patients in the ICU with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? InIcuCurrently { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Older data contains nulls</remarks>
        [JsonConverter(typeof(NullableDateTimeConverter))]
        public DateTime? LastUpdateEt { get; set; }

        [Display(Name = "Negative Tests", Description = "Individuals with a completed viral test that returned a negative result. For states / territories that do not report this number directly, we compute it using one of several methods, depending on which data points the state provides.")]
        public int? Negative { get; set; }

        [Display(Name = "Negative Tests", Description = "Completed viral tests that returned negative results.")]
        public int? NegativeTestsViral { get; set; }

        [Display(Name = "Total On Ventilator", Description = "Individuals who are currently hospitalized under advanced ventilation with COVID-19. Definitions vary by state / territory. Where possible, we report patients on ventilation with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? OnVentilatorCumulative { get; set; }

        [Display(Name = "Currently On Ventilator", Description = "Individuals who are currently hospitalized under advanced ventilation with COVID-19. Definitions vary by state / territory. Where possible, we report patients on ventilation with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? OnVentilatorCurrently { get; set; }

        [Display(Name = "Pending Tests", Description = "Tests whose results have not yet been reported.")]
        public int? Pending { get; set; }

        [Display(Name = "Positive Cases", Description = "Individuals with confirmed or probable COVID-19 per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? Positive { get; set; }

        [Display(Name = "Positive Cases Viral", Description = "Individuals with a completed viral test that returned a positive result.")]
        public int? PositiveCasesViral { get; set; }

        [Display(Name = "Positive Increase", Description = "Increase in positive computed by subtracting the value of positive from the previous day from the value of positive for the current day.")]
        public int? PositiveIncrease { get; set; }

        [Display(Name = "Positive Tests", Description = "Completed viral tests that returned positive results.")]
        public int? PositiveTestsViral { get; set; }

        [Display(Name = "Recovered", Description = "Individuals who have recovered from COVID-19. Definitions vary by state / territory.")]
        public int? Recovered { get; set; }

        [Display(Name = "Postal Code", Description = "Two-letter abbreviation for the state or territory.")]
        public string State { get; set; }

        [Display(Name = "Total Test Results", Description = "Currently computed by adding positive and negative values to work around reporting lags between positives and total tests and because some states do not report totals.")]
        public int? TotalTestResults { get; set; }

        [Display(Name = "Total Test Results Increase", Description = "Daily Difference in totalTestResults.")]
        public int? TotalTestResultsIncrease { get; set; }

        [Display(Name = "Total Tests", Description = "Completed viral tests.")]
        public int? TotalTestsViral { get; set; }
    }
}
