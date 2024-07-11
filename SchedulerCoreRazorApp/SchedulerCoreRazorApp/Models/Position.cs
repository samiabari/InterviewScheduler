namespace SchedulerCoreRazorEntityApp.Models
{
    public class Position
    {
        public int Position_type_id { get; set; }
        public string Position_type_name { get; set; }

        public Position(int position_type_id_, string position_type_name_)
        {
            this.Position_type_id = position_type_id_;
            this.Position_type_name = position_type_name_;
        }

        public Position()
        {
        }
    }
}
