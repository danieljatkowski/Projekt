using Projekt;

List<Employee> employeeList = new List<Employee>();
int maxScore = 0;

Employee employee1 = new Employee("Tomasz", "Kozłowski", 34);
Employee employee2 = new Employee("Jan", "Poniatowski", 53);
Employee employee3 = new Employee("Grzegorz", "Brzęczyszczykiewicz", 44);

employeeList.Add(employee1);
employeeList.Add(employee2);
employeeList.Add(employee3);

Random random = new Random();
for (int i = 0; i < 3; i++)
{
    employee1.AddScore(random.Next(1, 11));
    employee2.AddScore(random.Next(1, 11));
    employee3.AddScore(random.Next(1, 11));
}

Employee best = null;


foreach (var employee in employeeList)
{
    Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Age + " lat, suma punktów: " + employee.ScoreResult);
    
    if (maxScore < employee.ScoreResult)
    {
        maxScore = employee.ScoreResult;
        best = employee;
        
    }
}

Console.WriteLine();
Console.WriteLine("Pracownikiem z największą ilością punktów jest: " + best.Name + " " + best.Surname + " z ilością punktów: " + best.ScoreResult);
