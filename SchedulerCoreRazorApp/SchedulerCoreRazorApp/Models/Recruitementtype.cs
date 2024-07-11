namespace SchedulerCoreRazorEntityApp.Models
{
    public class Recruitementtype
    {
        public int Recruitement_type_id { get; set; }
        public string Recruitement_type_name { get; set; }

        public Recruitementtype(int recruitement_type_id_, string recruitement_type_name_)
        {
            this.Recruitement_type_id = recruitement_type_id_;
            this.Recruitement_type_name = recruitement_type_name_;
        }

        public Recruitementtype()
        {
        }
    }
}
