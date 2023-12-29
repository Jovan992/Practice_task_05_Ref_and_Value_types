namespace Practice_task_05_Ref_and_Value_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student() { Name = "Mike"};

            Console.WriteLine($"Student s1 name: {s1.Name}");
            RefChange(s1);
            Console.WriteLine("Student s1 changed name because it is reference type and we passed its reference to RefChange method.");
            Console.WriteLine($"Student s1 name is now: { s1.Name}");

            int a = 200;
            Console.WriteLine($"\nValue of a is: a = {a}");
            ValChange(a);
            Console.WriteLine("Integer a is not changed because it is value type and we passed its copy of value to ValChange method.");
            Console.WriteLine($"Value of a is still the same: a = {a}");

            Console.ReadKey();
        }

        public static void RefChange(Student s)
        {
            s.Name = "John";
        }

        public static void ValChange(int a)
        {
            a = 100;
        }
    }

    public class Student
    {
        public string Name;
    }
}
