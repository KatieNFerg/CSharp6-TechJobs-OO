namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();


        Job job4 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            int difference = job2.Id - job1.Id;
            Assert.AreEqual(1, difference);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
               Job job = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.Value);
            Assert.AreEqual("Desert", job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job.JobType.Value);
         //   Assert.AreEqual("Persistance", job.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
             Job job1 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );
 Job job2 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );
        Assert.IsFalse(job1.Equals(job2));

        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Job job = new Job();
            string result = job.ToString();
            Assert.IsTrue(result.StartsWith($"{Environment.NewLine}") && result.EndsWith($"{Environment.NewLine}"));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
Job job = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );
        string result = job.ToString();
       Assert.IsTrue(result.Contains($"Name: Product tester") && result.Contains("Employer: ACME") && result.Contains("Location: Desert") && result.Contains("Position Type: Quality control") && result.Contains("Core Competency: Persistence"));
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Job job = new Job();
            string result = job.ToString();
            string expected = $"{Environment.NewLine} ID:{job.Id}{Environment.NewLine} Name: Data not available {Environment.NewLine} Employer: Data not available {Environment.NewLine} Position Type: Data not available {Environment.NewLine} Core Competency: Data not available";
        }
    }
}
