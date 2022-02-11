using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Repositories
{
    public interface ICoffeeRepository
    {
        void Add(Coffees coffee);
        void Delete(int id);
        Coffees Get(int id);
        List<Coffees> GetAll();
        void Update(Coffees coffee);
    }
}