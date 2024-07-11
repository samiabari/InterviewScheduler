namespace SchedulerCoreRazorEntityApp.Models
{
    public class Jobtype
    {
        public int Job_type_id { get; set; }
        public string Job_type_name { get; set; }

        public Jobtype(int job_type_id_, string job_type_name_)
        {
            this.Job_type_id = job_type_id_;
            this.Job_type_name = job_type_name_;
        }

        public Jobtype()
        {
        }
    }
}
