using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.src
{
    internal class StudentStore
    {
        private List<Student> students = new();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public Student? GetById(int id)
        {
            foreach (var student in students)
            {
                if(student.Id==id) return student;
            }
            return null;
        }
        public List<Student> GetAll() => students;
        public void Remove(int id)
        {
            var studentToRemove = GetById(id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
            }
            else
            {
                Console.WriteLine("ID Not Found");
            }
        }

    }
}
