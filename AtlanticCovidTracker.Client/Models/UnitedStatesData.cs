using AtlanticCovidTracker.Client.Infrastructure;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AtlanticCovidTracker.Client.Models
{
    public class UnitedStatesData
    {
        [JsonConverter(typeof(DateConverter))]
        [Display(Name ="Date", Description = "Date on which data was collected by The COVID Tracking Project.")]
        public DateTime Date { get; set; }

        [Display(Name ="Death", Description = "Total fatalities with confirmed OR probable COVID-19 case diagnosis (per the expanded CSTE case definition of April 5th, 2020 approved by the CDC). In states where the information is available, it only tracks fatalities with confirmed OR probable COVID-19 case diagnosis where COVID-19 is an underlying cause of death according to the death certificate based on WHO guidelines.")]
        public int? Death { get; set; }

        [Display(Name ="Death Increase", Description = "Increase in death computed by subtracting the value of death for the previous day from the value of death for the current day.")]
        public int? DeathIncrease { get; set; }

        public string Hash { get; set; }

        [Display(Name ="Hospitalized Cumulative", Description = "Total number of individuals who have ever been hospitalized with COVID-19. Definitions vary by state / territory. Where possible, we report hospitalizations with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? HospitalizedCumulative { get; set; }

        [Display(Name ="Hospitalized Currently", Description = "Individuals who are currently hospitalized with COVID-19. Definitions vary by state / territory. Where possible, we report hospitalizations with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? HospitalizedCurrently { get; set; }

        [Display(Name = "Hospitalized Increase", Description = "Increase in hospitalizedCumulative computed by subtracting the value of hospitalizedCumulative for the previous day from the value of hospitalizedCumulative for the current day.")]
        public int? HospitalizedIncrease { get; set; }

        [Display(Name ="In ICU Cumulative", Description = "Total number of individuals who have ever been hospitalized in the Intensive Care Unit with COVID-19. Definitions vary by state / territory. Where possible, we report patients in the ICU with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? InIcuCumulative { get; set; }

        [Display(Name ="In ICU Currently", Description = "Individuals who are currently hospitalized in the Intensive Care Unit with COVID-19. Definitions vary by state / territory. Where possible, we report patients in the ICU with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? InIcuCurrently { get; set; }

        [Display(Name ="Negative", Description = "Individuals with a completed viral test that returned a negative result. For states / territories that do not report this number directly, we compute it using one of several methods, depending on which data points the state provides.")]
        public int? Negative { get; set; }

        [Display(Name ="Negative Increase", Description = "Increase in negative computed by subtracting the value of negative for the previous day from the value for negative from the current day.")]
        public int? NegativeIncrease { get; set; }

        [Display(Name ="On Ventilator Cumulative", Description = "Total number of individuals who have ever been hospitalized under advanced ventilation with COVID-19. Definitions vary by state / territory. Where possible, we report patients on ventilation with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? OnVentilatorCumulative { get; set; }

        [Display(Name ="On Ventilator Currently", Description = "Individuals who are currently hospitalized under advanced ventilation with COVID-19. Definitions vary by state / territory. Where possible, we report patients on ventilation with confirmed or probable COVID-19 cases per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? OnVentilatorCurrently { get; set; }

        [Display(Name ="Pending", Description = "Tests whose results have not yet been reported.")]
        public int? Pending { get; set; }

        [Display(Name ="Positive", Description = "Individuals with confirmed or probable COVID-19 per the expanded CSTE case definition of April 5th, 2020 approved by the CDC.")]
        public int? Positive { get; set; }

        [Display(Name ="Postive Increase", Description = "Increase in positive computed by subtracting the value of positive from the previous day from the value of positive for the current day.")]
        public int? PositiveIncrease { get; set; }

        [Display(Name ="Recovered", Description = "Individuals who have recovered from COVID-19. Definitions vary by state / territory.")]
        public int? Recovered { get; set; }

        public int States { get; set; }

        [Display(Name ="Total Test Results", Description = "Computed by adding positive and negative values to work around reporting lags between positives and total tests and because some states do not report totals.")]
        public int? TotalTestResults { get; set; }
    }
}
