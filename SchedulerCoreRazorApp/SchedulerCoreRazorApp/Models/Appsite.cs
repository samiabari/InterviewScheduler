namespace SchedulerCoreRazorEntityApp.Models
{
    public class Appsite
    {
        public int App_site_id { get; set; }
        public string App_site_name { get; set; }

        public Appsite(int app_site_id_, string app_site_name_)
        {
            this.App_site_id = app_site_id_;
            this.App_site_name = app_site_name_;
        }

        public Appsite()
        {
        }
    }
}
