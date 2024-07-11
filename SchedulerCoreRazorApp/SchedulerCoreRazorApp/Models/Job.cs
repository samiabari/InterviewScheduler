namespace SchedulerCoreRazorEntityApp.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string Job_uid { get; set; }
        public string Company_name { get; set; }
        public int Job_country_id { get; set; }
        public int Designation_id { get; set; }
        public int Core_tech_id { get; set; }
        public int Experience_require_year { get; set; }
        public int Position_type_id { get; set; }
        public int Workstation_type_id { get; set; }
        public int Job_type_id { get; set; }
        public string Jd { get; set; }
        public int Applied_on_site_id { get; set; }
        public string Job_post_link { get; set; }
        public decimal Company_salary_structure { get; set; }
        public decimal Salary_expected { get; set; }
        public int Company_interview_steps { get; set; }
        public int Current_interview_stage { get; set; }
        public int Interview_type_id { get; set; }
        public DateTime Interview_date { get; set; }
        public TimeSpan Interview_time { get; set; }
        public int Recruitment_type_id { get; set; }
        public string Recruiter_name { get; set; }
        public string Recruiter_number { get; set; }
        public string Recruiter_email { get; set; }
        public string Email_tag { get; set; }
        public string Description { get; set; }

        public Job(int jobid_, string job_uid_, string company_name_, int job_country_id_, int designation_id_, int core_tech_id_, int experience_require_year_, int position_type_id_, int workstation_type_id_, int job_type_id_, string jd_, int applied_on_site_id_, string job_post_link_, decimal company_salary_structure_, decimal salary_expected_, int company_interview_steps_, int current_interview_stage_, int interview_type_id_, DateTime interview_date_, TimeSpan interview_time_, int recruitment_type_id_, string recruiter_name_, string recruiter_number_, string recruiter_email_, string email_tag_, string description_)
        {
            this.JobId = jobid_;
            this.Job_uid = job_uid_;
            this.Company_name = company_name_;
            this.Job_country_id = job_country_id_;
            this.Designation_id = designation_id_;
            this.Core_tech_id = core_tech_id_;
            this.Experience_require_year = experience_require_year_;
            this.Position_type_id = position_type_id_;
            this.Workstation_type_id = workstation_type_id_;
            this.Job_type_id = job_type_id_;
            this.Jd = jd_;
            this.Applied_on_site_id = applied_on_site_id_;
            this.Job_post_link = job_post_link_;
            this.Company_salary_structure = company_salary_structure_;
            this.Salary_expected = salary_expected_;
            this.Company_interview_steps = company_interview_steps_;
            this.Current_interview_stage = current_interview_stage_;
            this.Interview_type_id = interview_type_id_;
            this.Interview_date = interview_date_;
            this.Interview_time = interview_time_;
            this.Recruitment_type_id = recruitment_type_id_;
            this.Recruiter_name = recruiter_name_;
            this.Recruiter_number = recruiter_number_;
            this.Recruiter_email = recruiter_email_;
            this.Email_tag = email_tag_;
            this.Description = description_;
        }


        public Job()
        {

        }

    }
}
