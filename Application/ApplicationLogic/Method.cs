using HighSchoolSystem1.Data;
using HighSchoolSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolSystem1.Application.ApplicationLogic
{
    public class Method
    {
        private HighSchoolSystemContext Context { get; set; }
        public Method()
        {
            Context = new();
        }

        public void GetEmployees()
        {
            while (true)
            {
                Console.WriteLine("Tryck 1 och Enter för att visa all personal");
                Console.WriteLine("Tryck 2 och Enter för att visa rektorer");
                Console.WriteLine("Tryck 3 och Enter för att visa administratörer");
                Console.WriteLine("Tryck 4 och Enter för att visa lärare");
                Console.WriteLine("Tryck 5 och Enter för att visa skolsköterskor");
                Console.WriteLine("Tryck 6 och Enter för att visa lokalvårdare");
                Console.WriteLine("Tryck 7 och Enter för att visa vaktmästare");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    var employees = Context.Employees.ToList();
                    Console.WriteLine("Visar alla anställda:");

                    foreach (var e in employees)
                    {
                        Console.WriteLine($"ID: {e.EmployeeId}, Namn: {e.FirstName} {e.LastName}, Titel: {e.Title}, Anställningsdatum: {e.HireDate}, Födelsedatum: {e.BirthDate}, Adress: {e.Address}, Postnummer: {e.Zip}");
                    }
                }
                else if (choice == "2")
                {
                    var principals = Context.Employees.Where(s => s.FkprofessionId == 2).ToList();
                    Console.WriteLine("Visar alla rektorer:");

                    foreach (var p in principals)
                    {
                        Console.WriteLine($"ID: {p.EmployeeId}, Namn: {p.FirstName} {p.LastName}, Titel: {p.Title}, Anställningsdatum: {p.HireDate}, Födelsedatum: {p.BirthDate}, Adress: {p.Address}, Postnummer: {p.Zip}");
                    }
                }
                else if (choice == "3")
                {
                    var administrators = Context.Employees.Where(s => s.FkprofessionId == 2).ToList();
                    Console.WriteLine("Visar alla administratörer:");

                    foreach (var a in administrators)
                    {
                        Console.WriteLine($"ID: {a.EmployeeId}, Namn: {a.FirstName} {a.LastName}, Titel: {a.Title}, Anställningsdatum: {a.HireDate}, Födelsedatum: {a.BirthDate}, Adress: {a.Address}, Postnummer: {a.Zip}");
                    }
                }
                else if (choice == "4")
                {
                    var teachers = Context.Employees.Where(s => s.FkprofessionId == 3).ToList();
                    Console.WriteLine("Visar alla lärare:");

                    foreach (var t in teachers)
                    {
                        Console.WriteLine($"ID: {t.EmployeeId}, Namn: {t.FirstName} {t.LastName}, Titel: {t.Title}, Anställningsdatum: {t.HireDate}, Födelsedatum: {t.BirthDate}, Adress: {t.Address}, Postnummer: {t.Zip}");
                    }
                }
                else if (choice == "5")
                {
                    var nurses = Context.Employees.Where(s => s.FkprofessionId == 4).ToList();
                    Console.WriteLine("Visar alla skolsköterskor:");

                    foreach (var n in nurses)
                    {
                        Console.WriteLine($"ID: {n.EmployeeId}, Namn: {n.FirstName} {n.LastName}, Titel: {n.Title}, Anställningsdatum: {n.HireDate}, Födelsedatum: {n.BirthDate}, Adress: {n.Address}, Postnummer: {n.Zip}");
                    }
                }
                else if (choice == "6")
                {
                    var cleaners = Context.Employees.Where(s => s.FkprofessionId == 5).ToList();
                    Console.WriteLine("Visar alla lokalvårdare:");

                    foreach (var c in cleaners)
                    {
                        Console.WriteLine($"ID: {c.EmployeeId}, Namn: {c.FirstName} {c.LastName}, Titel: {c.Title}, Anställningsdatum: {c.HireDate}, Födelsedatum: {c.BirthDate}, Adress: {c.Address}, Postnummer: {c.Zip}");
                    }
                }
                else if (choice == "7")
                {
                    var janitors = Context.Employees.Where(s => s.FkprofessionId == 6).ToList();
                    Console.WriteLine("Visar alla vaktmästare:");

                    foreach (var j in janitors)
                    {
                        Console.WriteLine($"ID: {j.EmployeeId}, Namn: {j.FirstName} {j.LastName}, Titel: {j.Title}, Anställningsdatum: {j.HireDate}, Födelsedatum: {j.BirthDate}, Adress: {j.Address}, Postnummer: {j.Zip}");
                    }
                }
                else
                {
                    Console.WriteLine("Felaktigt val");
                }
            }
        }

        public void GetStudents()
        {
            while (true)
            {
                Console.WriteLine("Tryck 1 och Enter för att visa alla elever sorterade efter förnamn");
                Console.WriteLine("Tryck 2 och Enter för att visa alla elever sorterade efter efternamn");
                Console.WriteLine("Tryck 3 och Enter för att visa alla elever i stigande sortering efter Elev-ID");
                Console.WriteLine("Tryck 4 och Enter för att visa alla elever i fallande sortering efter Elev-ID");


                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    var students = from s in Context.Students.OrderBy(s => s.FirstName)
                                   select s;

                    foreach (var s in students)
                    {
                        Console.WriteLine($"Namn: {s.FirstName} {s.LastName}, Personnummer: {s.PersonalNumber}, Adress: {s.Address}, Postnummer: {s.Zip}, Elev-ID: {s.StudentId}");
                    }
                }
                else if (choice == "2")
                {
                    var students = from s in Context.Students.OrderBy(s => s.LastName)
                                   select s;

                    foreach (var s in students)
                    {
                        Console.WriteLine($"Namn: {s.LastName} {s.FirstName}, Personnummer: {s.PersonalNumber}, Adress: {s.Address}, Postnummer: {s.Zip}, Elev-ID: {s.StudentId}");
                    }
                }
                else if (choice == "3")
                {
                    var students = from s in Context.Students
                                   orderby s.StudentId ascending
                                   select s;

                    foreach (var s in students)
                    {
                        Console.WriteLine($"Namn: {s.FirstName} {s.LastName}, Personnummer: {s.PersonalNumber}, Adress: {s.Address}, Postnummer: {s.Zip}, Elev-ID: {s.StudentId}");
                    }
                }
                else if (choice == "4")
                {
                    var students = from s in Context.Students
                                   orderby s.StudentId descending
                                   select s;

                    foreach (var s in students)
                    {
                        Console.WriteLine($"Namn: {s.FirstName} {s.LastName}, Personnummer: {s.PersonalNumber}, Adress: {s.Address}, Postnummer: {s.Zip}, Elev-ID: {s.StudentId}");
                    }
                }
            }
        }

        public void GetStudentsByClass()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Nedan följer en översikt över alla klasser");
            Console.WriteLine("Välj en klass genom att skriva klassens ID och tryck Enter:");
            Console.ResetColor();

            var classes = from c in Context.Classes
                          select c;

            foreach (var c in classes)
            {
                Console.WriteLine($"Namn: {c.ClassName}, Klass-ID: {c.ClassId}");
            }

            string userChoice = Console.ReadLine();
            int choice = Int32.Parse(userChoice);

            var students = Context.Students.Where(s => s.FkclassId == choice).ToList();

            Console.WriteLine($"Alla elever i klass med Klass-ID: {choice}:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        public void GetAllGradesByMonth()
        {
            var result = from cl in Context.CourseLists
                         join s in Context.Students on cl.FkstudentId equals s.StudentId
                         join c in Context.Courses on cl.FkcourseId equals c.CourseId
                         where cl.SetDate <= new DateTime(2023, 12, 17) && cl.SetDate <= new DateTime(2023, 11, 17)
                         select new
                         {
                             Elev = s.FirstName + " " + s.LastName,
                             Kurs = c.CourseInfo,
                             Betyg = cl.GradeInfo
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"Elev: {item.Elev}, Kurs: {item.Kurs}, Betyg: {item.Betyg}");
            }

        }

        public void GetCourses()
        {
            var query = from cl in Context.CourseLists
                        join c in Context.Courses on cl.FkcourseId equals c.CourseId
                        group cl by c.CourseInfo into g
                        select new
                        {
                            Kurs = g.Key,
                            Snittbetyg = g.Average(cl => Convert.ToDouble(cl.GradeInfo)),
                            HögstaBetyg = g.Max(cl => cl.GradeInfo),
                            LägstaBetyg = g.Min(cl => cl.GradeInfo)
                        };

            foreach (var item in query)
            {
                Console.WriteLine($"Kurs: {item.Kurs} ; Snittbetyg: {item.Snittbetyg} ; Högsta betyg: {item.HögstaBetyg} ; Lägsta betyg: {item.LägstaBetyg}");
            }
        }

        public void AddNewStudent()
        {
            Console.WriteLine("Ange Elev-ID:");
            string studId = Console.ReadLine();
            int studentId = Int32.Parse(studId);
            Console.WriteLine("Ange förnamn:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ange efternamn");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ange personnummer (YYYYMMDD-XXXX:");
            string personalNumber = Console.ReadLine();
            Console.WriteLine("Ange adress:");
            string address = Console.ReadLine();
            Console.WriteLine("Ange postnummer:");
            string zip = Console.ReadLine();
            Console.WriteLine("Ange Klass-ID:");
            string fkClId = Console.ReadLine();
            int fkClassId = Int32.Parse(fkClId);
            Console.Clear();

            var newStudent = new Student
            {
                StudentId = studentId,
                FirstName = firstName,
                LastName = lastName,
                PersonalNumber = personalNumber,
                Address = address,
                Zip = zip,
                FkclassId = fkClassId
            };
            Context.Students.Add(newStudent);

            Console.WriteLine("Ny elev har lagts till i databasen");

            Context.SaveChanges();
        }

        public void AddNewEmployee()
        {
            Console.WriteLine("Ange Anställnings-ID:");
            string empId = Console.ReadLine();
            int employeeId = Int32.Parse(empId);
            Console.WriteLine("Ange förnamn:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ange efternamn");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ange titel (mr, ms, mrs):");
            string title = Console.ReadLine();
            Console.WriteLine("Ange anställningsdatum (YYYY-MM-DD:");
            string hDate = Console.ReadLine();
            DateTime hireDate = DateTime.Parse(hDate);
            Console.WriteLine("Ange födelsedatum (YYYY-MM-DD):");
            string bDate = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(bDate);
            Console.WriteLine("Ange adress:");
            string address = Console.ReadLine();
            Console.WriteLine("Ange postnummer:");
            string zip = Console.ReadLine();
            Console.WriteLine("Ange befattnings-ID:");
            string fkProfId = Console.ReadLine();
            int fkProfessionId = Int32.Parse(fkProfId);
            Console.Clear();

            var newEmployee = new Employee
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                Title = title,
                HireDate = hireDate,
                BirthDate = birthDate,
                Address = address,
                Zip = zip,
                FkprofessionId = fkProfessionId
            };
            Context.Employees.Add(newEmployee);

            Console.WriteLine("Ny anställd har lagts till i databasen");

            Context.SaveChanges();
        }
    }
}
