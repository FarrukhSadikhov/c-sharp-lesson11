using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_abstract_classes
{
    abstract class Person
    {
       

        public Person() { }
        public string Surname { get; set; }
        public int Course { get; set; }

        public int GradeBook { get; set; }

        public string Subject { get; set; }

        public Person(string Surname, int Course, int GradeBook, string Subject)
        {
            this.Surname = Surname;
            this.Course = Course;
            this.GradeBook = GradeBook;
            this.Subject = Subject;
        }

        public abstract void Print();
      
    }
}
