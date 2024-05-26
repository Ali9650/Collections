﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Student
    {
        public Dictionary<string, List<int>> Grades { get; }


        public Student()
        {
            Grades = new Dictionary<string, List<int>>();
        }

        public void AddGrade(string name, List<int> grades)
        {
            Grades.Add(name, grades);
        }

        public void RemoveGrade(string name)
        {
            Grades.Remove(name);
        }

        public void GetAverageGrade (string name) 
        {
            if (Grades.Keys.Contains(name))
            {
                var result = Grades[name].Average();
                Console.WriteLine(result);
            }
        }

        public List<int> GetAllGradesByStudent(string name)
        {
             return Grades.ContainsKey(name) ? Grades[name] : new List<int>();
        }

    }
}
