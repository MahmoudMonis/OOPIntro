public abstract class Employee
{    private string firstName;
    private string lastName;

    public Employee(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public abstract void PrintDetails();

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
}

public class Manager : Employee
{
    private string department;

    public Manager(string firstName, string lastName, string department) : base(firstName, lastName)
    {
        this.department = department;
    }

    public override void PrintDetails()
    {
        Console.WriteLine($"Manager: {GetFullName()}, Department: {department}");
    }
}

public class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string firstName, string lastName, string programmingLanguage) : base(firstName, lastName)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public override void PrintDetails()
    {
        Console.WriteLine($"Developer: {GetFullName()}, Programming Language: {programmingLanguage}");
    }
}

public interface IWork
{
    void Work();
}

public class TeamLeader : IWork
{
    public void Work()
    {
        Console.WriteLine("Team Leader is managing the team.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager("Mahmoud", "Taha", "HR");
        Developer developer = new Developer("Salah", "Mohammad", "C#");

        Employee[] employees = { manager, developer };


        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.GetFullName());
            employee.PrintDetails();
        }

        IWork teamLeader = new TeamLeader();
        teamLeader.Work();
    }
}
