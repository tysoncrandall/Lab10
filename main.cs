using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Object Oriented Programming - Cat");

    Employee unknown = new Employee();
    unknown.Intro();

    Employee robert = new Employee("Robert", "Downey", "12321", 12, 100);
    robert.Intro();

    Employee john = new Employee("John", "Smith", "S0089", 38, 50000);
    john.Intro();
    john.IncreaseSalary(-0.02);
    john.RemoveEmployee();

    Employee maria = new Employee("Maria", "Lambert", "S0100", 26, 80000);
    maria.Intro();
    maria.IncreaseSalary(.07);
    maria.RemoveEmployee();
    maria.RemoveEmployee();

    /*Cat unknown = new Cat();//constructor with no parameters
    unknown.Intro();  
    unknown.Cookies=5;
    unknown.eat(2);
   
    Cat snowbell = new Cat("snowbell", 1111, -3);//constructor with parameters
    snowbell.Intro();
    Console.WriteLine("My age is " + snowbell.Age);
    snowbell.Age = 11;
    Console.WriteLine("My age is " + snowbell.Age);
    
    snowbell.Cookies = 20;

    snowbell.play();
    snowbell.sleep();
    snowbell.eat(2);
    snowbell.sleep();
    snowbell.play();
    snowbell.eat(5);

    Dog debo = new Dog("Debo", 1234, 4);
    debo.Intro();
    debo.Bark();*/
    
  }
}