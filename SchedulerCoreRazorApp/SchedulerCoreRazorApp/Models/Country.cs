namespace SchedulerCoreRazorEntityApp.Models
{
    public class Country
    {
        public int Country_id { get; set; }
        public string Country_name { get; set; }

        public Country(int country_id_, string country_name_)
        {
            this.Country_id = country_id_;
            this.Country_name = country_name_;
        }

        public Country()
        {
        }
    }
}
