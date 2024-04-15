﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student()
        {
            _id++;
            Id = _id;    
            
        }
        public override string ToString()
        {
            return $"Id; {Id}, Name:{Name}, Surname: {Surname}";
        }
    }
}
