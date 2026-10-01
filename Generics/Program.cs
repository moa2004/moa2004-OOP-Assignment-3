using Generics.src;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentStore = new Store<Student>();
            studentStore.Add(new Student(1, "Ahmed"));
            studentStore.Add(new Student(2, "Mohamed"));
            studentStore.Add(new Student(3, "Ali"));
            studentStore.Add(new Student(4, "Omar"));
            studentStore.Add(new Student(5, "Sara"));
            var courseStore = new Store<Course>();
            courseStore.Add(new Course(101, "C# Basics", 1500m));
            courseStore.Add(new Course(102, "OOP", 2000m));
            courseStore.Add(new Course(103, "Data Structures", 2500m));
            var s = studentStore.GetById(3);
            Console.WriteLine($"Got Student: {s?.Name}");
            var c = courseStore.GetById(102);
            Console.WriteLine($"Got Course: {c?.Title}");
            try
            {
                studentStore.Add(new Student(1, "Duplicate Ahmed"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Caught: {ex.Message}");
            }
            Console.WriteLine("\n--- Page 2 of Students (Size 2) ---");
            var studentPage2 = studentStore.GetAll().Page(2, 2);
            foreach (var st in studentPage2)
            {
                Console.WriteLine($"ID: {st.Id}, Name: {st.Name}");
            }
            var plainCourseList = new List<Course>
            {
                new Course(201, "Java", 1000m),
                new Course(202, "Python", 1200m)
            };
            var foundCourse = plainCourseList.FindById(202);
            Console.WriteLine($"\nFound in plain list: {foundCourse?.Title}");
        }
    }
}
