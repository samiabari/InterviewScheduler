namespace SchedulerCoreRazorEntityApp.Models
{
    public class Coretech
    {
        public int Core_tech_id { get; set; }
        public string Core_tech_name { get; set; }

        public Coretech(int core_tech_id_, string core_tech_name_)
        {
            this.Core_tech_id = core_tech_id_;
            this.Core_tech_name = core_tech_name_;
        }

        public Coretech()
        {
        }
    }
}
