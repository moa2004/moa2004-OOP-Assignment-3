using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.src
{
    internal class Student
    {

        public int Id { get;}
        public string Name { get; set; }
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
