using System.Collections.Generic;
using System.Linq;

namespace FSE.Assignment21.Task02
{
    public class JobService : IJobService
    {
        public List<Job> OpeningJobs()
        {
            return GetJobs();
        }

        public List<Job> OpeningJobsByRole(string role)
        {
            return GetJobs().Where(job => job.Role == role).ToList();
        }

        private List<Job> GetJobs()
        {
            return new List<Job>
            {
                new Job {Id=1, Role="Developer" , Description="Full Stack Developer (Dot Net)"
                , Experience="5 to 7 years", Venue="Chennai"},
                new Job {Id=2, Role="Senior Developer" , Description="Full Stack Developer (Dot Net) & Cloud Knowledge"
                , Experience="7 to 10 years", Venue="Bangalore"},
                new Job {Id=3, Role="Developer" , Description="Full Stack Developer (JAVA)"
                , Experience="5 to 7 years", Venue="Bangalore"},
                new Job {Id=4, Role="Senior Developer" , Description="Full Stack Developer (JAVA) & Cloud Knowledge"
                , Experience="7 to 10 years", Venue="Chennai"}
            };
        }
    }
}
