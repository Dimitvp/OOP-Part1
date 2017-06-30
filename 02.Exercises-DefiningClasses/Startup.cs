using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exercises_DefiningClasses
{
    class Startup
    {
        static void Main(string[] args)
        {
            //1
            //Type personType = typeof(Person);
            //FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //Console.WriteLine(fields.Length);

            //2
            //Type personType = typeof(Person);
            //ConstructorInfo emptyCtor = personType.GetConstructor(new Type[] { });
            //ConstructorInfo ageCtor = personType.GetConstructor(new[] { typeof(int) });
            //ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string), typeof(int) });
            //bool swapped = false;
            //if (nameAgeCtor == null)
            //{
            //    nameAgeCtor = personType.GetConstructor(new[] { typeof(int), typeof(string) });
            //    swapped = true;
            //}

            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());

            //Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            //Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            //Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            //Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            //Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
            //Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);

            //3
            //MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            //MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            //if (oldestMemberMethod == null || addMemberMethod == null)
            //{
            //    throw new Exception();
            //}

            //var familySize = int.Parse(Console.ReadLine());
            //var family = new Family();
            //for (int i = 0; i < familySize; i++)
            //{
            //    var person = Console.ReadLine().Split();
            //    family.AddMember(new Person(person[0],int.Parse(person[1])));
            //}
            //Console.WriteLine($"{family.GetOldestMember().name} {family.GetOldestMember().age}");

            // 4
            //var familySize = int.Parse(Console.ReadLine());
            //var family = new Family();
            //for (int i = 0; i < familySize; i++)
            //{
            //    var person = Console.ReadLine().Split();
            //    family.AddMember(new Person(person[0], int.Parse(person[1])));
            //}

            //foreach (var person in family.people.Where(x => x.age>30).OrderBy(x => x.name))
            //{
            //    Console.WriteLine($"{person.name} - {person.age}");
            //}

            //5
            //var date1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var date2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var diff = new DateModifier(new DateTime(date1[0], date1[1], date1[2]), new DateTime(date2[0], date2[1], date2[2]));
            //Console.WriteLine(diff.GetDiference());

            //6
            var size = int.Parse(Console.ReadLine());
            var company = new List<Employee>();
            for (int i = 0; i < size; i++)
            {

                var data = Console.ReadLine().Split().ToArray();
                var name = data[0];
                var sallary = double.Parse(data[1]);
                var position = data[2];
                var department = data[3];

                var employee = new Employee(name, sallary, position, department);
                if (data.Length == 5)
                {
                    if (data[4].Contains("@"))
                    {
                        employee.Email = data[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(data[4]);
                    }

                }

                if (data.Length == 6)
                {
                    employee.Email = data[4];
                    employee.Age = int.Parse(data[5]);
                    //if (data[4].Contains("@"))
                    //{
                    //    employee.Email = data[4];
                    //    employee.Age = int.Parse(data[5]);
                    //}
                    //else
                    //{
                    //    employee.Age = int.Parse(data[4]);
                    //    employee.Email = data[5];
                    //}
                }
                company.Add(employee);

            }

            var highestAverageSalary = double.MinValue;
            var highestAverageSalaryDepartment = "";
            var departments = company.Select(x => x.Department).Distinct().ToArray();


            foreach (var dept in departments)
            {
                var departmentSalary = company.Where(x => x.Department == dept).Sum(x => x.Salary);
                if (departmentSalary > highestAverageSalary)
                {
                    highestAverageSalary = departmentSalary;
                    highestAverageSalaryDepartment = dept;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");
            foreach (var emp in company.Where(x => x.Department == highestAverageSalaryDepartment).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
            }

        }

    }
}

