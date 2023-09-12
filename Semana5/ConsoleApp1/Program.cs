//using System;
//using System.Collections.Generic;

//class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public List<string> Courses { get; set; }

//    public Student(string name, int age)
//    {
//        Name = name;
//        Age = age;
//        Courses = new List<string>();
//    }

//    public void AddCourse(string courseName)
//    {
//        //Courses.Add(courseName);
//    }

//    public override string ToString()
//    {
//        return $"Nombre: {Name}, Edad: {Age}, Curso: {string.Join(", ", Courses)}";
//    }
//}

//class Program
//{
//    static List<Student> students = new List<Student>();

//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.WriteLine("Multilista de Estudiantes y Cursos");
//            Console.WriteLine("1. Agregar Estudiante");
//            Console.WriteLine("2. Agregar Curso a Estudiante");
//            Console.WriteLine("3. Mostrar Estudiantes");
//            Console.WriteLine("4. Salir");
//            Console.Write("Digite Opcion: ");

//            int choice;
//            if (!int.TryParse(Console.ReadLine(), out choice))
//            {
//                Console.WriteLine("Entrada no válida. Introduce un número del menú.");
//                continue;
//            }

//            switch (choice)
//            {
//                case 1:
//                    AddStudent();
//                    break;
//                case 2:
//                    AddCourseToStudent();
//                    break;
//                case 3:
//                    ShowStudents();
//                    break;
//                case 4:
//                    Environment.Exit(0);
//                    break;
//                default:
//                    Console.WriteLine("Opción no válida. Introduce un número válido del menú.");
//                    break;
//            }
//        }
//    }

//    static void AddStudent()
//    {
//        Console.Write("Nombre del estudiante: ");
//        string name = Console.ReadLine();
//        Console.Write("Edad del estudiante: ");
//        if (!int.TryParse(Console.ReadLine(), out int age))
//        {
//            Console.WriteLine("Edad no válida. Introduce un número.");
//            return;
//        }

//        Student student = new Student(name, age);
//        students.Add(student);
//        Console.WriteLine("Estudiante agregado exitosamente.");
//    }

//    static void AddCourseToStudent()
//    {
//        if (students.Count == 0)
//        {
//            Console.WriteLine("No hay estudiantes registrados.");
//            return;
//        }

//        Console.WriteLine("Lista de Estudiantes:");
//        for (int i = 0; i < students.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {students[i].Name}");
//        }

//        Console.Write("Selecciona el número de estudiante al que deseas agregar un curso: ");
//        if (!int.TryParse(Console.ReadLine(), out int studentIndex) || studentIndex < 1 || studentIndex > students.Count)
//        {
//            Console.WriteLine("Selección no válida. Introduce un número válido.");
//            return;
//        }

//        Student selectedStudent = students[studentIndex - 1];
//        Console.Write("Nombre del curso a agregar: ");
//        string courseName = Console.ReadLine();

//        selectedStudent.AddCourse(courseName);
//        Console.WriteLine($"Curso '{courseName}' agregado al estudiante '{selectedStudent.Name}'.");
//    }

//    static void ShowStudents()
//    {
//        if (students.Count == 0)
//        {
//            Console.WriteLine("No hay estudiantes registrados.");
//            return;
//        }

//        Console.WriteLine("Lista de Estudiantes:");
//        for (int i = 0; i < students.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {students[i]}");
//        }
//    }
//}
