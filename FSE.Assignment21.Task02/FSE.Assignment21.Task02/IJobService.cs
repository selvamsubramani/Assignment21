using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace FSE.Assignment21.Task02
{
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        List<Job> OpeningJobs();

        [OperationContract]
        List<Job> OpeningJobsByRole(string role);
    }

    [DataContract]
    public class Job
    {
        [DataMember(Name = "Job Id")]
        public int Id { get; set; }
        [DataMember(Name = "Job Role")]
        public string Role { get; set; }
        [DataMember(Name = "Job Description")]
        public string Description { get; set; }
        [DataMember(Name = "Experience")]
        public string Experience { get; set; }
        [DataMember(Name = "Location")]
        public string Venue { get; set; }
    }
}
