using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller
{
    public IActionResult EmployeeDetails()
    {
        Employee e1 = new Employee()
        {
        Fullname = "Biswas Shrestha",
        Sex = Gender.Male,
        JoinDate = new DateTime(2010, 7, 12),
        Designation = "Software Engineer",
        Department= "IT"
        };

        Employee e2 = new Employee()
        {
        Fullname = "Sarita Shrestha",
        Sex = Gender.Female,
        JoinDate = new DateTime(2009, 7, 12),
        Designation = "Sr. Software Engineer",
        Department= "IT",
        };

        Employee e3 = new Employee()
        {
        Fullname = "Ram Karki",
        Sex = Gender.Male,
        JoinDate = new DateTime(2007, 7, 12),
        Designation = "Business Analyst",
        Department= "Business/Technical",
        };

        List<Employee> employees = new List<Employee>() { e1, e2, e3};
        return View(employees);
    }
}    