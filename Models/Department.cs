using System;
using System.Collections.Generic;
using System.Linq;
namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; }

        public Department() 
        {
            Sellers = new HashSet<Seller>();
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
            Sellers = new HashSet<Seller>();
        }

        public void AddSeller (Seller seller) 
        { 
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(sellers => sellers.TotalSales(initial, final));
        }
    }

}
