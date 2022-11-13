﻿using System;
using System.Collections.Generic;

namespace HomeWork1
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredDate{ get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int OficeId { get; set; }

        public Ofice Ofice { get; set; }

        public int TitleId { get; set; }

        public Title Title { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();

        public Employee()
        {
        }
    }
}

