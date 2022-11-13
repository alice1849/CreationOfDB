using System;
using System.Collections.Generic;

namespace HomeWork1
{
    public class Title
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Title()
        {
        }
    }
}

