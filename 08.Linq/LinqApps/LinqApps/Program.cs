using System;
using Linq.Repo;
using System.Linq;
using System.Collections.Generic;

namespace Linq;

class Program
{
    static List<Student> students = new();
    static void Main(string[] args)
    {
        AddStudents();
    }
    private static void AddStudents()
    {
        students = new List<Student>() 
        {
            new Student(){Id=1, FirstName = "Ion", LastName = "Popescu", Age = 23, University = "Universitatea Politehnica Timisoara", Year = 4, FacultyId = 1, isWorking = true},
            new Student(){Id=2, FirstName = "Maria", LastName = "Mircea", Age = 20, University = "Babes Bolyai", Year = 2, FacultyId = 2, isWorking = false},
            new Student(){Id=3, FirstName = "Bianca", LastName = "Popovici", Age = 21, University = "Victor Babes", Year = 3, FacultyId = 3, isWorking = false},
            new Student(){Id=4, FirstName = "Larisa", LastName = "Muntean", Age = 24, University = "Victor Babes", Year = 1, FacultyId = 3, isWorking = false},
            new Student(){Id=5, FirstName = "Andrei", LastName = "Tudor", Age = 21, University = "Universitatea Vest Timisoara", Year = 4, FacultyId = 1, isWorking = true},
            new Student(){Id=6, FirstName = "Sebastian", LastName = "Ionescu", Age = 22, University = "Universitatea Politehnica Timisoara", Year = 2, FacultyId = 1, isWorking = false},
            new Student(){Id=7, FirstName = "Gigi", LastName = "Becali", Age = 22, University = "Universitatea Vest Timisoara", Year = 3, FacultyId = 4, isWorking = false},
            new Student(){Id=8, FirstName = "Cristi", LastName = "Borcea", Age = 20, University = "Universitatea Politehnica Timisoara", Year = 5, FacultyId = 1, isWorking = true},
            new Student(){Id=9, FirstName = "Bianca", LastName = "Dragusanu", Age = 19, University = "Babes Bolyai", Year = 4, FacultyId = 2, isWorking = true},
            new Student(){Id=10, FirstName = "Dan", LastName = "Bilzerian", Age = 23, University = "Victor Babes", Year = 4, FacultyId =3, isWorking = false},
            new HomeStudent(){Id=11, FirstName = "Andreea", LastName = "Mantea", Age = 19, University = "Babes Bolyai", Year = 4, FacultyId = 2, isWorking = true, Address = "Str. Ion Roata Nr 2"},
            new HomeStudent(){Id=12, FirstName = "Mihai", LastName = "Bendeac", Age = 23, University = "Victor Babes", Year = 4, FacultyId =3, isWorking = false, Address = "Str. Lalelelor Nr 24"},
        };
    } 

    // Where
    // OrderBy
    // Select
    // SelectMany
    // Anonymous Types
    // LINQ Query Synthax
    // Deffered Execution

}