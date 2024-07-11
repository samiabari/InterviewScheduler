namespace SchedulerCoreRazorEntityApp.Models
{
    public class Interviewtype
    {
        public int Interview_type_id { get; set; }
        public string Interview_type_name { get; set; }

        public Interviewtype(int interview_type_id_, string interview_type_name_)
        {
            this.Interview_type_id = interview_type_id_;
            this.Interview_type_name = interview_type_name_;
        }

        public Interviewtype()
        {
        }
    }
}
