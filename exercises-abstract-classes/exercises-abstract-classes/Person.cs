using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_abstract_classes
{
    abstract class Person
    {

        public Person() { }

        protected string surname;

        public  string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public override int GetHashCode()
        {
            return Surname.GetHashCode();
        }


        protected int course;

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        protected int gradebook;

        public int GradeBook
        {
            get { return gradebook; }
            set { gradebook = value; }
        }

        public Person(string Surname, int Course, int GradeBook)
        {
            this.Surname = Surname;
            this.Course = Course;
            this.GradeBook = GradeBook;
           
        }

        public abstract void Print();
      
    }
}
