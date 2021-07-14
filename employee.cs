using System;
class Employee {
    //Fields

    public int age;
    private double totalsalary = 0;
    private int yearlysalary;

    private string FirstName{get; set;}
    private string LastName{get; set;}

    public int Age {
      get{ return age; }
      set{
        if (value < 18)
          age = 18;
        else
          age = value;
      }
    }

    public int YearlySalary {
      get{ return yearlysalary; }
      set{
        if (value < 1000)
          yearlysalary = 1000;
        else
        {
          yearlysalary = value;
        }          
      }
    }

    private string Id{get; set;}
    public string EmploymentStatus = "active";

    public Employee()//Constructor with no parameters
    {
      firstname = "Unknown";
      lastname = "Unknown";
      id = "Unknown";
      age = 0;
    }
    private string firstname;
    private string lastname;
    private string id;

    public Employee(string FirstName, string LastName, string Id, int age, int yearlysalary)
    {
      firstname = FirstName;
      lastname = LastName;
      id = Id;
      Age = age;
      YearlySalary = yearlysalary;
    }

    public void Intro()
    {
      Console.WriteLine("First name: " + firstname);
      Console.WriteLine("Last name: " + lastname);
      Console.WriteLine("Id: " + id);
      Console.WriteLine("Age: " + Age);
      Console.WriteLine("Salary: " + yearlysalary);
    }

    public void IncreaseSalary(double percent)
    {
      if (percent >= 0){
        totalsalary = (yearlysalary*percent);
        totalsalary = (totalsalary+yearlysalary);
        Console.WriteLine("Yearly salary updated to " + totalsalary);
      }
      else {
        Console.WriteLine("Invalid input. Yearly Salary not updated");
      }
    }

    public void RemoveEmployee()
    {
      if (EmploymentStatus == "inactive")
        {
          Console.WriteLine("Employee already inactive");
        }
        else{
          EmploymentStatus = "inactive";
          Console.WriteLine("Employee removed successfully!");
        } 
    }
}