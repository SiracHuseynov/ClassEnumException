using Core.Enums;
using Core.Helpers;
using Core.Models;

namespace EnumExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string className;
            byte classType;
            string name;
            string surname;
            int id;

            do
            {
                Console.Write("Classroom adini daxil edin: ");
                className = Console.ReadLine();
            }
            while (!Helper.CheckClassroom(className));

            do
            {
                Console.WriteLine("1.Backend");
                Console.WriteLine("2.Frontend");
                Console.Write("Class type daxil edin: ");
            }
            while (!(byte.TryParse(Console.ReadLine(), out classType) && (classType == 1 || classType == 2)) );

            Classroom classroom = new Classroom(className, (ClassType)classType);

            do
            {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.GetAllStudent");
                Console.WriteLine("3.StudentFindid");
                Console.WriteLine("4.StudentRemove");
                Console.WriteLine("0.Exit");

                do
                {
                    Console.Write("Choose one: ");
                }
                while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case (byte)Menu.AddStudent:                     
                        do
                        {
                            Console.Write("Telebenin adini daxil edin: ");
                            name = Console.ReadLine();
                        }
                        while (!Helper.CheckName(name));

                        do
                        {
                            Console.Write("Telebenin soyadini daxil edin: ");
                            surname = Console.ReadLine();
                        }
                        while (!Helper.CheckSurname(surname));                     
                      
                        Student student = new Student(name, surname, (ClassType)classType);

                        classroom.AddStudent(student);

                        break;
                    case (byte)Menu.GetAllStudent:
                        foreach(Student item in classroom.GetAllStudents())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case (byte)Menu.StudentFindId:
                        do
                        {
                            Console.Write("Axtarmag istediyiniz telebenin id daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out id));
                        if(classroom.GetStudentFindId(id) != null)
                        {
                            Console.WriteLine(classroom.GetStudentFindId(id));
                        }
                        else
                        {
                            Console.WriteLine($"ID'i {id} olan bir telebe yoxdur!");
                        }
                        break;
                    case (byte)Menu.StudentRemove:
                        do
                        {
                            Console.Write("Axtarmag istediyiniz telebenin id daxil edin: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out id));

                        foreach(Student item in classroom.RemoveStudent(id))
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }

            while (choice != 0);
        }
    }
}