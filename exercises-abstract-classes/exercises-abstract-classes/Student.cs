using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_abstract_classes
{
    class Student : Person
    {
        public static int counter = 0;
        public Student() { data = new Student[counter]; }

        public Student[] data;

        public Student this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public override void Print()
        {
            if (data.Length != 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine($"Данные {i + 1} студента");
                    Console.WriteLine($"Фамилия = {data[i].Surname} HashCode:{Math.Abs(data[i].Surname.GetHashCode())} Курс обучения = {data[i].Course} Номер зачетной книги = {data[i].GradeBook}");
                }
            }
            else
            {
                Console.WriteLine("\nСписок студентов пуст.\n");
            }
        }
        public void PrintIndex()
        {
            Console.WriteLine("Введите индекс ");
            int i = Program.CheckNumber();
            Console.WriteLine($"Фамилия = {data[i - 1].Surname} Course = {data[i - 1].Course} GradeBook = {data[i - 1].GradeBook}");
        }
        public Student[] Insert()
        {
            Array.Resize(ref data, data.Length + 1);
            for (int i = data.Length - 1; i < data.Length; i++)
            {
                Console.WriteLine($"Введите даннык {i + 1 } студента");
                data[i] = new Student();
                Console.Write($"Введите фамилию студента:  ");
                data[i].Surname = Program.CheckString();
                Console.Write($"Введите номер курса: ");
                data[i].Course = Program.CheckNumber();
                Console.Write($"Введите номер зачетной книги: ");
                data[i].GradeBook = Program.CheckNumber();
            }
            return data;
        }
        public Student[] RemoveAt()
        {
            Console.WriteLine("Введите индекс:");
            int x = Program.CheckNumber();
            data[x - 1] = null;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == null)
                {
                    data[i] = data[data.Length - 1];
                }
                Console.WriteLine("Студент удалён!");
            }
            Array.Resize(ref data, data.Length - 1);
            return data;
        }
    }
}
