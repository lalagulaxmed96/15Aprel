using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class Classroom
    {
        private static int _id;
        public int Id { get; set; }
        Student[] _students;
        
        public Classroom()
        {
            _students = new Student[] { };
        }

        public void StudentAdd(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }

        public void FindId(int id)
        {
            Student[] filteredStudents = { };
            foreach(Student student in _students)
            {

            }
        }

        public void Delete(int id)
        {
            Student[] filteredStudents = { };
            foreach (Student student in _students)
            {
                if (student.Id != id)
                { 
                    Array.Resize(ref filteredStudents, _students.Length + 1);
                    filteredStudents[filteredStudents.Length - 1] = student;
                }
            }
        }
        _students = filteredStudents;
    }
}
