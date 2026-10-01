using System;
using System.Collections.Generic;

namespace Generics.src
{
    internal class Course
    {
        public int Id { get; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Course(int id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
    }
}