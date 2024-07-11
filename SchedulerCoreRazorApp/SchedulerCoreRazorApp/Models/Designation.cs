namespace SchedulerCoreRazorEntityApp.Models
{
    public class Designation
    {
        public int Designation_id { get; set; }
        public string Designation_name { get; set; }

        public Designation(int designation_id_, string designation_name_)
        {
            this.Designation_id = designation_id_;
            this.Designation_name = designation_name_;
        }

        public Designation()
        {
        }
    }
}
