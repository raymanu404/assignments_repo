using System;
using Linq.Repo;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Linq
{

    class Program
    {
        static List<Car> cars = new();
        static List<Company> companies = new();
        static Car defaultCar = new Car { Brand = "Default", Model = "Default", Year = DateTime.Now.Year };
        static void Main(string[] args)
        {
            AddStudents();
            AddFaculties();

            //Filtering();

            //Ordering();

            //Quantifiers();

            //Projection();

            //Grouping();

            //Generation();

            //ElementOperators();

            //DataConversion();

            //Aggregation();

            //SetOperations();

            Joins();

        }

        private static void Filtering()
        {
            //Where 
            cars.Where(x => x.IsFullOption).PrintCollection();

            //Take
            cars.Take(2).PrintCollection(); //ia primele 2 resultate un fel de limit din SQL

            //Skip
            cars.Skip(6).PrintCollection(); // omite primele 6 resultate si afiseaza next

            //TakeWhile
            cars.TakeWhile(x => x.Year == 2018).PrintCollection();

            //SkipWhile
            cars.SkipWhile(x => x.Year == 2018).PrintCollection();

            //Distinct
            cars.Distinct().PrintCollection();

            //Chunk
            var chunked = cars.Chunk(2);
            foreach (var chunk in chunked)
            {
                chunk.PrintCollection();
            }

            //OfType
            cars.OfType<EletricCar>().PrintCollection(); //afiseaza doar cei din type-ul respectiv

        }


        private static void Ordering()
        {
            //OrderBy, ThenBy
            cars.OrderBy(x => x.Brand).ThenBy(x => x.Model).PrintCollection();

            //OrderByDescending, ThenByDescending
            cars.OrderByDescending(x => x.Brand).PrintCollection();

            //Reverse
            cars.Reverse(); //face reverse-ul la lista originala
            cars.PrintCollection();
        }
        private static void Quantifiers()
        {
            var car = new Car() { Id = 1, Brand = "Audi", Model = "A7", MaxSpeed = 300, Year = 2012, Colour = "yellow", CompanyId = 1, IsFullOption = true };

            //Contains           
            var containsFlag = cars.Contains(car);
            Console.WriteLine(containsFlag);

            //Any
            var anyFlag = cars.Any(x => x.Year >= 2018);
            Console.WriteLine(anyFlag);

            //All
            var allFlag = cars.All(x => x.IsFullOption);
            Console.WriteLine(allFlag);


            //SequenceEqual
            var sequenceEqualFlag = cars.SequenceEqual(cars); //compara doua liste daca sunt identice dupa comparator
            Console.WriteLine(sequenceEqualFlag);
        }

        private static void Projection()
        {
            // Select (anonymus types)
            cars.Select((x, index) => new { x.Brand , x.Year}).PrintCollection(); //ca si cum ai selecta coloanele

            // SelectMany
            var selectMany = companies.SelectMany(x => x.Cars);
            selectMany.PrintCollection();
        }

        private static void Grouping()
        {
            //GroupBy
            var groupedStudents = cars.GroupBy(x => x.Year); //grupare dupa an

            foreach(var item in groupedStudents)
            {
                Console.WriteLine(item.Key);
                item.PrintCollection();
            }
        }

        private static void Generation()
        {
            // DefaultIfEmpty
           
            List<Car> emptyList = new List<Car>();
            emptyList.DefaultIfEmpty(defaultCar).PrintCollection(); //returneaza default daca avem empty

            // Range
            IEnumerable<int> integers = Enumerable.Range(1, 10);
            integers.PrintCollection();

            // Repeat
            IEnumerable<Car> myStudents = Enumerable.Repeat(new Car { Brand = "Audi", Model = "A7", Year = 2020 },2);
            myStudents.PrintCollection();
        }

        private static void ElementOperators()
        {
            // First, FirstOrDefault
            var firstCar = cars.First().ToString();
            Console.WriteLine(firstCar);
            Func<Car, bool> predicate = (x) => x.CompanyId == 4;
            var firstCarWithPredicate = cars.First(predicate).ToString();
            Console.WriteLine(firstCarWithPredicate);
            Console.WriteLine(cars.FirstOrDefault(defaultCar)); //la fel doar ca returneaza defaultul daca nu gaseste studenti


            // Last, LastOrDefault
            Console.WriteLine(cars.Last()); //la fel ca sus

            // Single, SingleOrDefault
            //Console.WriteLine(students.SingleOrDefault()); //returneaza exceptie daca avem mai mult de un element in lista

            // ElementAt, ElementAtOrDefault
            Console.WriteLine(cars.ElementAt(7));
        }
        private static void DataConversion()
        {
            // Cast (throws InvalidCastException if unable to cast an item in the collection)
            cars.Cast<Car>();

            // ToDictionary (simply by a key or with element selector)
            Dictionary<int,string> dictionary = cars.ToDictionary(student => student.Id, student => student.Brand); //key -urile trebuiesc sa fie unice ca la dictionar
            Console.WriteLine("dictionary : ");
            foreach(var item in dictionary)
            {
                Console.WriteLine($"KEY : {item.Key}");
                Console.WriteLine($"Value : {item.Value}");
            }
            

            // ToLookup
            ILookup<int,string> lookup = cars.ToLookup(x => x.Year, x=> x.Model);
            Console.WriteLine("lookup:");
            foreach(var item in lookup)
            {
                Console.WriteLine(item.Key);
                item.PrintCollection();
            }
        }

        private static void Aggregation()
        {
            // Aggregate
            var allNames = cars.Aggregate(":", (prevresult, result) => prevresult + " " +  result.Brand, names => names);
            Console.WriteLine(allNames);

            // Average
            var average = cars.Average(x => x.Year);
            Console.WriteLine($"The average is : {(int)average}");

            // Count, LongCount
            var count = cars.Count();
            count.PrintInConsole("Count");
            var countPredicate = cars.Count(x => x.Year >= 2014);
            countPredicate.PrintInConsole("Older or equal than 2014 years : ");

            // Max, MaxBy
            var maxSpeed = cars.Max(x => x.MaxSpeed);
            maxSpeed.PrintInConsole("Maxim speed is");
            var maxById = cars.MaxBy(x => x.Id);
            maxById.PrintInConsole("Maxim by id");

            // Min, MinBy
            var minYear = cars.Min(x => x.Year);
            minYear.PrintInConsole("Minimum year ");
            var minBySpeed = cars.MinBy(x => x.MaxSpeed);
            minBySpeed.PrintInConsole("Minimum by speed");

            // Sum
            var sumOfMaxSpeed = cars.Sum(x => x.MaxSpeed);
            sumOfMaxSpeed.PrintInConsole("Sum of maximum speed");
        }

        private static void SetOperations()
        {
            // Distinct, DistinctBy
            //cars.Distinct(new CarsComparer()).PrintCollection();
            cars.DistinctBy(x => x.Brand).PrintCollection();

            // Except, ExeceptBy
            List<Car> carsToExcept = new List<Car>() { 
                new Car() {Brand = "Skoda"}, 
            };
            //cars.Except(carsToExcept).PrintCollection();

            static string carBrandSelector(Car car) => car.Brand;
            cars.ExceptBy(carsToExcept.Select(carBrandSelector), carBrandSelector).PrintCollection(); //facem keySelector-ul acelasi pentru ambele liste

            // Intersect, IntersectBy
            List<Car> carsToIntersect = new List<Car>() {
                new Car() {Brand = "Skoda",Model = "Superb"},
                new Car() {Brand = "Audi", Model = "A7"},
                new Car() {Brand = "Mustang", Model ="modelul S"},
            };

            //cars.Intersect(carsToIntersect, new CarsComparer()).PrintCollection();
            cars.IntersectBy(carsToIntersect.Select(carBrandSelector), carBrandSelector).PrintCollection();

            // Union, UnionBy (distinct union)
            var unionCars = cars.Union(carsToIntersect);
            unionCars.PrintCollection();
            var unionByBrand = cars.UnionBy(carsToIntersect, carBrandSelector);
            unionByBrand.PrintCollection();

            // Concat (non distinct)
            cars.Concat(carsToIntersect).PrintCollection(); //aici concatenam tot indiferent de dublaje
        }
        private static void Joins()
        {
            // Join (also with query language)
            Console.WriteLine("Join ");

            var joinQuery = cars.Join(
                companies,
                car => car.CompanyId,
                company => company.Id,
                (car,comp) => new {car.Brand, car.Year, comp.Country}
                ); 

            joinQuery.PrintCollection();

            Console.WriteLine("Query join");
            var query = from car in cars
                        join company in companies on car.CompanyId equals company.Id
                        select new {car.Brand, car.Model, company.Country};
            query.PrintCollection();


            // GroupJoin
            var countryGroups = from company in companies
                                join car in cars on company.Id equals car.CompanyId into countryCompany
                                select new {
                                   company.Country,
                                   countryCompany
                                };
            //schema la groupJoin e ca tu cand vrei sa faci grupare dupa ceva, trebe sa tii cont de acel ceva in select
            //cum avem noi company.Country , iar aliasul e countryCompany si el automat stie ca se face groupBy dupa company.Country

            foreach (var countryGroup in countryGroups)
            {

                Console.WriteLine($"----------------- {countryGroup.Country}----------------");              
                foreach(var item in countryGroup.countryCompany)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();    
            }

            // Zip
            Console.WriteLine("ZIP");
            var selectIDs = cars.Select(car => car.Id);
            var resultOfZip = selectIDs.Zip(cars, (id, car) => id + " - " + car.Brand);
            resultOfZip.PrintCollection();
        }

        private static void AddStudents()
        {
            cars = new List<Car>()
            {
                new Car(){Id=1, Brand = "Audi", Model = "A7", MaxSpeed = 300, Year = 2012,Colour= "yellow", CompanyId = 1, IsFullOption= true},
                new Car(){Id=2, Brand = "Volswagen", Model = "Passat CC", MaxSpeed = 200, Year = 2017,Colour= "black", CompanyId = 2, IsFullOption = false},
                new Car(){Id=3, Brand = "Volswagen", Model = "Arteon", MaxSpeed = 310,  Year = 2018,Colour= "purple", CompanyId = 3, IsFullOption = false},
                new Car(){Id=4, Brand = "Skoda", Model = "Superb", MaxSpeed = 240,  Year = 2014,Colour= "orange", CompanyId = 3, IsFullOption = false},
                new Car(){Id=5, Brand = "Tesla", Model = "3", MaxSpeed = 210,  Year = 2016,Colour= "red", CompanyId = 1, IsFullOption = true},
                new Car(){Id=6, Brand = "BMW", Model = "I7", MaxSpeed = 220, Year = 2020,Colour= "green", CompanyId = 5, IsFullOption = false},
                new Car(){Id=7, Brand = "Audi", Model = "A7", MaxSpeed = 220,  Year = 2022,Colour= "black", CompanyId = 4, IsFullOption = false},
                new Car(){Id=8, Brand = "Audi", Model = "A5", MaxSpeed = 200, Year = 2022,Colour= "white", CompanyId = 1, IsFullOption = true},
                new Car(){Id=9, Brand = "Mercedes", Model = "CLS", MaxSpeed = 190,  Year = 2021,Colour= "white", CompanyId = 2, IsFullOption = true},
                new Car(){Id=10, Brand = "Dacia", Model = "Logan", MaxSpeed = 230,  Year = 2019,Colour= "red", CompanyId =3, IsFullOption = false},
                new EletricCar(){Id=11, Brand = "Lamborghini", Model = "Aventador", MaxSpeed = 190, Year = 2020, Colour= "rose",CompanyId = 2, IsFullOption = true, Autonomy = 600},
                new EletricCar(){Id=12, Brand = "Porsche", Model = "Panamera", MaxSpeed = 230, Year = 2012,Colour= "orange", CompanyId =3, IsFullOption = false, Autonomy = 500},
            };
        }


        private static void AddFaculties()
        {
            companies = new List<Company>()
        {
             new Company { Name = "Audi", Id = 1, Country = "Germany",
                    Cars = new List<Car> { new Car() { Brand = "Audi" }, new Car { Brand = "Volswagen"} }
             },
                new Company { Name = "Mercedes", Id = 2, Country = "Germany",
                    Cars = new List<Car> { new Car() { Brand = "Audi" }, new Car { Brand = "Volswagen"} }
                },
                new Company { Name = "Alfa Romeo", Id = 3, Country = "Italy",
                    Cars = new List<Car> { new Car() { Brand = "Audi" }, new Car { Brand = "Volswagen"} }
                },
                new Company { Name = "Renault", Id = 4,Country = "France",
                  Cars = new List<Car> { new Car() { Brand = "Audi" }, new Car { Brand = "Volswagen"} }
                },
                new Company { Name = "Dacia", Id = 5, Country = "Romania",
                  Cars = new List<Car> { new Car() { Brand = "Dacia" }, new Car { Brand = "Logan"} }
                },
        };
        }

    }

    public static class ExtensionMethods
    {
        public static void PrintCollection<T>(this IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void PrintCollectionInLine<T>(this IEnumerable<T> items)
        {
            foreach(var item in items)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        public static void PrintInConsole<T>(this T item,string message)
        {
            Console.WriteLine($"{message} : {item}");
        }
    }

    public class CarsComparer : IEqualityComparer<Car>
    {
        
        public bool Equals(Car x, Car y)
        {
            return x.Brand == (y.Brand) && x.Model == (y.Model);
        }

        public int GetHashCode([DisallowNull] Car obj)
        {
            return obj.GetHashCode();
        }
    }

}