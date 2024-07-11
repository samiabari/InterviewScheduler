namespace SchedulerCoreRazorEntityApp.Models
{
    public class Workstation
    {
        public int Workstation_id { get; set; }
        public string Workstation_name { get; set; }

        public Workstation(int workstation_id_, string workstation_name_)
        {
            this.Workstation_id = workstation_id_;
            this.Workstation_name = workstation_name_;
        }

        public Workstation()
        {
        }
    }
}
