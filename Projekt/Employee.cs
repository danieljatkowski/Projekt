using System.Threading.Tasks.Sources;

namespace Projekt
{
    public class Employee
    {
        private List<int> scores = new List<int>();
        public string Name
        {
            get; private set;
        }
        public string Surname
        {
            get; private set;
        }
        public int Age
        {
            get; private set;
        }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string AddScore(int score)
        {
            if (score < 1 || score > 10)
            {
                return "Możesz dodać ocenę od 1 do 10";
            }
            this.scores.Add(score);
            return "Ocena dodana" + score;

        }

        public int ScoreResult
        {
            get
            {
                return scores.Sum();
            }
        }

    }
}
