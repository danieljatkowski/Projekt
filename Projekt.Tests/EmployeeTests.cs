namespace Projekt.Tests
{
    public class Tests
    {
        [Test]
        public void CheckSumOfScores()
        {
            //arrange 

            var employee = new Employee("Jan", "Kowalski", 53);
            employee.AddScore(10);
            employee.AddScore(6);
            employee.AddScore(-1);
            //act

            var result = employee.ScoreResult;
            //assert


            Assert.That(result, Is.EqualTo(16));
        }
    }
}