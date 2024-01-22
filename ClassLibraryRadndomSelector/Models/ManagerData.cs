using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRadndomSelector.Models
{
    public  class ManagerData
    {
        // public static void WriteToFile(string filePath, List<Employee> employees, bool AddOneEmployee)
        //{
        //    try
        //    {
        //        string Headers = "Id,Name,Experience level";

        //        using (StreamWriter writer = new StreamWriter(filePath, AddOneEmployee))
        //        {
        //            if (!AddOneEmployee) { writer.WriteLine(Headers); }

        //            foreach (Employee employee in employees)
        //            {
        //                writer.WriteLine($"{employee.Id},{employee.Name},{employee.IdLevel}");
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine($"Error writing to file: {ex.Message}");
        //    }
        //}

        //public static void deleteLineInFile(string filePath, string lineToDelete)
        //{
        //    try
        //    {
        //        using (StreamReader reader = new StreamReader(filePath, false))

        //        {
        //            string line;
        //            using (StreamWriter writer = new StreamWriter("Temp.txt"))
        //            {
        //                while ((line = reader.ReadLine()) != null)
        //                {
        //                    if (line != lineToDelete)
        //                    {
        //                        writer.WriteLine(line);
        //                    }

        //                }
        //            }
        //        }
        //        File.Delete(filePath);
        //        File.Move("temp.txt", filePath);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error writing to file: {ex.Message}");
        //    }
        //}


        //public static List<Employee> ReadFromFile(string filePath)
        //{
        //    List<Employee> employees = new List<Employee>();

        //    try
        //    {
        //        using (StreamReader reader = new StreamReader(filePath))
        //        {
        //            reader.ReadLine();
        //            string line;
        //            while ((line = reader.ReadLine()) != null)
        //            {

        //                var employeeLine = line.Split(',')
        //                        .Select((value, index) => new { Index = index, Value = value.Trim() })
        //                        .ToDictionary(pair => pair.Index, pair => pair.Value);

        //                var employeeModel = new Employee
        //                {
        //                    Id = employeeLine.ContainsKey(0) ? int.Parse(employeeLine[0]) : 0,
        //                    Name = employeeLine.ContainsKey(1) ? employeeLine[1] : "",
        //                    IdLevel = employeeLine.ContainsKey(2) ? int.Parse(employeeLine[2]) : 0
        //                };

        //                employees.Add(employeeModel);

        //            }

        //            return employees;

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine($"Error reading to file: {ex.Message}");
        //    }

        //    return employees;
        //}



        //public static void SaveEmployees(string filePath, EmployeeService employeeService, bool AddOneEmployee)
        //{
        //    List<Employee> employees = employeeService.GetAllEmployees();
        //    WriteToFile(filePath, employees, AddOneEmployee);
        //}
         

        //public static void LoadEmployees(string filePath, EmployeeService employeeService)
        //{
        //    List<Employee> loadEmpployees = ReadFromFile(filePath);
        //    foreach (var employee in loadEmpployees)
        //    {
        //        employeeService.AddEmployee(employee);
        //    }
        //}

    }
}
