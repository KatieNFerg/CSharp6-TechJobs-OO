using System;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(
            string name,
            Employer employerName,
            Location employerLocation,
            PositionType jobType,
            CoreCompetency jobCoreCompetency
        )
            : this() { 
                Name = name;
                EmployerName = employerName;
                EmployerLocation = employerLocation;
                JobType = jobType;
                JobCoreCompetency = jobCoreCompetency;
            }

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.
 public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id && Name == job.Name && EmployerName == job.EmployerName && EmployerLocation == job.EmployerLocation &&
                   JobType == job.JobType && JobCoreCompetency == job.JobCoreCompetency;
        }
         public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }
        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.
        public override string ToString()
        {
            string emptyField = "Data not available";
            string idString = $"ID: {Id}";
            string nameString = $"Name: {(Name == "" ? emptyField : Name)}";
            string employerString = $"Employer: {(EmployerName == null || EmployerName.Value == "" ? emptyField : EmployerName.Value)}";
            string employerLocationString = $"Location: {(EmployerLocation == null || EmployerLocation.Value == "" ? emptyField : EmployerLocation.Value)}";
            string jobTypeString = $"Position Type: {(JobType == null || JobType.Value == "" ? emptyField : JobType.Value)}";
            string coreCompetencyString = $"Core Competency: {(JobCoreCompetency == null || JobCoreCompetency.Value == "" ? emptyField : JobCoreCompetency.Value)}";
            return $"{Environment.NewLine}{idString}{Environment.NewLine}{nameString}{Environment.NewLine}{employerString}{Environment.NewLine}{employerLocationString}{Environment.NewLine}{jobTypeString}{Environment.NewLine}{coreCompetencyString}{Environment.NewLine}";
        }
    }
}
