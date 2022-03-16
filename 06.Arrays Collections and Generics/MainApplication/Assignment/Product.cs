using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Abstractions;

namespace Assignment
{
    public class Product : IDisplay, IGenericRepository<Product>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
       
        public ProductStatus Status { get; set; }

        public static HashSet<Product> Products = new HashSet<Product>();

        public Product(int id, string name, float price, ProductStatus status)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Status = status;
        
        }

        public void Display()
        {
            Console.WriteLine($"ID: {this.Id} / Name: {this.Name} / Price: {this.Price} / Status: {this.Status}");
        }

        public IEnumerable<Product> GetAll()
        {
            return Products;
        }

        public Product GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public static void Insert(Product entity)
        {
            Products.Add(entity);
        }

        public void Update(Product entity)
        {
            Products.Remove(this);
            Products.Add(entity);
        }

        public void Delete()
        {
            Products.Remove(this);
        }

    }

    public enum ProductStatus
    {

        Selling,
        Sold,
        Lost,
        Stock,
        Heisted
    }
}
