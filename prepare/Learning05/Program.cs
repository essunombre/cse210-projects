using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5, "Blue");
        Rectangle rectangle1 = new Rectangle(5, 6, "Red");
        Circles circle1 = new Circles(20, "Yellow");
     
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());

        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());

        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());

        
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine("");

        }

        // Console.WriteLine("Hello Learning05 World!");
        // HourlyEmployee hEmployee = new HourlyEmployee();
        // hEmployee.SetName("Jose");
        // hEmployee.SetIdNumber("123ABC");
        // hEmployee.SetPayRate(15);
        // hEmployee.SetHoursWorked(35);

        // SalaryEmployee sEmployee = new SalaryEmployee();
        // sEmployee.SetName("David");
        // sEmployee.SetIdNumber("456DEF");
        // sEmployee.SetSalary(60000);

        // DisplayEmployeeInformation(hEmployee);
        // DisplayEmployeeInformation(sEmployee);

        // List<Employee> employees = new List<Employee>();
        // employees.Add(hEmployee);
        // employees.Add(sEmployee);

        // foreach (Employee emp in employees)
        // {
        //     float pay = emp.GetPay();
        // }
    }
    // public static void DisplayEmployeeInformation(Employee employee)
    // {
    //     float pay =employee.GetPay();
    //     Console.WriteLine($"{employee.GetName()}, will be earning: {pay}");
    // }

    //if it is virtual you have the option of override, if it is abstract you mustr override it
}