using Projekt;
using System.Threading.Tasks.Sources;

Employee employee1 = new Employee("Tomasz", "Kozłowski", 34);
Employee employee2 = new Employee("Jan", "Poniatowski", 53);
Employee employee3 = new Employee("Grzegorz", "Brzęczyszczykiewicz", 44);

Random random = new Random();
for (int i = 0; i < 3; i++)
{
    employee1.AddScore(random.Next(1, 11));
    employee2.AddScore(random.Next(1, 11));
    employee3.AddScore(random.Next(1, 11));
}



if (employee1.ScoreResult > employee2.ScoreResult && employee1.ScoreResult > employee3.ScoreResult)
{
    Console.WriteLine("Pan/i " + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " zdobył/a największą liczbę punktów bo aż " + employee1.ScoreResult);
}
else if (employee2.ScoreResult > employee1.ScoreResult && employee2.ScoreResult > employee3.ScoreResult)
{
    Console.WriteLine("Pan/i " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " zdobył/a największą liczbę punktówbo aż " + employee2.ScoreResult);
}
else if (employee3.ScoreResult > employee1.ScoreResult && employee3.ScoreResult > employee2.ScoreResult)
{
    Console.WriteLine("Pan/i " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " zdobył/a największą liczbę punktów bo aż " + employee3.ScoreResult);

}
else
{
    Console.Write("Z powodu EX AEQUO brak pracownika z największą ilością punktów");
}