using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_abstract_classes
{
    class Aspirant : Person
    {
        protected string subject;

        public string  Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public Aspirant(string Surname, int Course, int GradeBook, string Subject) :base (Surname,Course,GradeBook)
        {
            this.Subject = Subject;
        }

        public static int counter = 0;
        public Aspirant() { arr = new Aspirant[counter]; }

       public Aspirant[] arr; 

        //public Aspirant[] arr = new Aspirant[0];

        public Aspirant this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        public Aspirant[] Insert()
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i =arr.Length - 1; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите даннык {i + 1 } аспирaнта");
                arr[i] = new Aspirant();
                Console.Write($"Введите фамилию: ");
                arr[i].Surname = Program.CheckString();
                Console.Write($"Введите номер курса: ");
                arr[i].Course = Program.CheckNumber();
                Console.Write($"Введите номер зачетной книги: ");
                arr[i].GradeBook = Program.CheckNumber();
                Console.Write($"Введите предмет защиты кандидатской диссертации:  ");
                arr[i].Subject = Program.CheckString();
            }
            return arr;
        }
        public Aspirant[] RemoveAt()
        {
            Console.WriteLine("Введите индекс:");
            int x = Program.CheckNumber();
            arr[x - 1] = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = arr[arr.Length - 1];
                }
                Console.WriteLine("Аспирант удалён!");
            }
            Array.Resize(ref arr, arr.Length - 1);
            return arr;
        }
        public override void Print()
        {
            if (arr.Length != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Данные {i + 1} аспирант");
                    Console.WriteLine($"Фамилия = {arr[i].Surname} HashCode:{Math.Abs(arr[i].Surname.GetHashCode())} Курс обучения = {arr[i].Course} Номер зачетной книги = {arr[i].GradeBook} Предмет защиты кандидатской диссертации = {arr[i].Subject} ");
                }
            }
            else
            {
                Console.WriteLine("\nСписок аспирант пуст.\n");
            }
        }
        public void PrintIndex()
        {
            Console.WriteLine("Введите индекс ");
            int i = Program.CheckNumber();
            Console.WriteLine($"Фамилия = {arr[i - 1].Surname} Course = {arr[i - 1].Course} GradeBook = {arr[i - 1].GradeBook} Предмет защиты кандидатской диссертации = {arr[i-1].Subject}");
        }
    }
}
