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
    }
}
