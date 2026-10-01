using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.src
{
    internal class CourseStore
    {
        private List<Course> courses = new List<Course>();

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public Course? GetById(int id)
        {
            foreach (var course in courses)
            {
                if (course.Id == id) return course;
            }
            return null;
        }

        public List<Course> GetAll() => courses;
        public void Remove(int id)
        {
            var courseToRemove = GetById(id);
            if (courseToRemove != null)
            {
                courses.Remove(courseToRemove);
            }
            else
            {
                Console.WriteLine("Course ID Not Found");
            }
        }
    }
}
