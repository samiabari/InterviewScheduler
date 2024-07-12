namespace SchedulerCoreRazorEntityApp.Models
{
    public class Status
    {
        public int Status_id { get; set; }
        public string Status_name { get; set; }

        public Status(int status_id_, string status_name_)
        {
            this.Status_id = status_id_;
            this.Status_name = status_name_;
        }

        public Status()
        {
        }
    }
}
