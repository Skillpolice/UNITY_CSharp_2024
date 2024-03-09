﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_42_Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persone persone;
            Mentor mentor = new Mentor("Tom", 8);
            persone = mentor;

            mentor = (Mentor)persone;

            Console.WriteLine(mentor.Name + mentor.NumberOfStudent);


        }

        class Persone
        {
            public string Name { get; private set; }

            public Persone(string name)
            {
                Name = name;
            }

            public void ShowName()
            {
                Console.WriteLine($"Я - {Name}");
            }
        }

        class Mentor : Persone
        {
            public int NumberOfStudent { get; private set; }

            public Mentor(string name, int numberOfStudent) : base(name)
            {
                NumberOfStudent = numberOfStudent;
            }
        }

        class Student : Persone
        {
            public int AverageScore { get; private set; }

            public Student(string name, int averageCore) : base(name)
            {
                AverageScore = averageCore;
            }

        }


    }
}

//Upcasting - восходящее преобразование