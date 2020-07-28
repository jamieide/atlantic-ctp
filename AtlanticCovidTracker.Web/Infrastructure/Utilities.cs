using System.Collections.Generic;

namespace AtlanticCovidTracker.Web.Infrastructure
{
    public static class Utilities
    {
        public static string FormatNullableInt(int? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToString("N0");
            }
            return "N/A";
        }

        private static IReadOnlyDictionary<string, string> _usStates = new Dictionary<string, string>
        {
            { "AK", "Alaska" },
            { "AL", "Alabama" },
            { "AR", "Arkansas" },
            { "AS", "American Samoa" },
            { "AZ", "Arizona" },
            { "CA", "California" },
            { "CO", "Colorado" },
            { "CT", "Connecticut" },
            { "DC", "District of Columbia" },
            { "DE", "Delaware" },
            { "FL", "Florida" },
            { "GA", "Georgia" },
            { "GU", "Guam" },
            { "HI", "Hawaii" },
            { "IA", "Iowa" },
            { "ID", "Idaho" },
            { "IL", "Illinois" },
            { "IN", "Indiana" },
            { "KS", "Kansas" },
            { "KY", "Kentucky" },
            { "LA", "Louisiana" },
            { "MD", "Maryland" },
            { "MA", "Massachusetts" },
            { "ME", "Maine" },
            { "MI", "Michigan" },
            { "MN", "Minnesota" },
            { "MO", "Missouri" },
            { "MP", "Northern Mariana Islands" },
            { "MS", "Mississippi" },
            { "MT", "Montana" },
            { "NC", "North Carolina" },
            { "ND", "North Dakota" },
            { "NE", "Nebraska" },
            { "NH", "New Hampshire" },
            { "NJ", "New Jersey" },
            { "NM", "New Mexico" },
            { "NV", "Nevada" },
            { "NY", "New York" },
            { "OH", "Ohio" },
            { "OK", "Oklahoma" },
            { "OR", "Oregon" },
            { "PA", "Pennsylvania" },
            { "PR", "Puerto Rico" },
            { "RI", "Rhode Island" },
            { "SC", "South Carolina" },
            { "SD", "South Dakota" },
            { "TN", "Tennessee" },
            { "TX", "Texas" },
            { "UT", "Utah" },
            { "VA", "Virginia" },
            { "VI", "Virgin Islands" },
            { "VT", "Vermont" },
            { "WA", "Washington" },
            { "WV", "West Virginia" },
            { "WI", "Wisconsin" },
            { "WY", "Wyoming" }
        };

        public static string GetStateName(string postalCode)
        {
            if (_usStates.TryGetValue(postalCode, out var stateName))
            {
                return stateName;
            }
            return postalCode;
        }

        public static bool HasValue(this string s)
        {
            return !string.IsNullOrEmpty(s);
        }
    }
}
