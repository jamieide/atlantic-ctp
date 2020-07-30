using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AtlanticCovidTracker.Client.Models
{
    public class StateMetadata
    {
        [Display(Name = "COVID-19 Site", Description = "URL to the state's COVID website.")]
        public string Covid19Site { get; set; }

        [Display(Name = "Old COVID-19 Site", Description = "URL to the state's old COVID website.")]
        public string Covid19SiteOld { get; set; }

        [Display(Name = "Secondary COVID-19 Site", Description = "URL to the state's secondary COVID website.")]
        public string Covid19SiteSecondary { get; set; }

        [Display(Name = "Tertiary COVID-19 Site", Description = "URL to the state's tertiary COVID website.")]
        public string Covid19SiteTertiary { get; set; }

        [Display(Name = "FIPS Code", Description = "The census FIPS code.")]
        public string Fips { get; set; }

        [Display(Name = "State Name", Description = "The name of the state.")]
        public string Name { get; set; }

        [Display(Name = "Notes", Description = "Notes about the state.")]
        public string Notes { get; set; }

        [Display(Name = "Postal Code", Description = "The state postal code.")]
        public string State { get; set; }

        [Display(Name = "Twitter", Description = "The state's COVID-related Twitter handle.")]
        public string Twitter { get; set; }
    }
}
