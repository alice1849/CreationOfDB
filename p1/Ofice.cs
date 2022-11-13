using System;
using System.Collections.Generic;

namespace HomeWork1
{
    public class Ofice
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Ofice()
        {
        }
    }
}

