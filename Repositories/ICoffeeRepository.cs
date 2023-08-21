using L05_crud.Models;

namespace L05_crud.Repositories;




public interface ICoffeeRepository
{
    IEnumerable<Coffee> GetAllCoffee();
    Coffee GetCoffeeById(int coffeeId);
    Coffee CreateCoffee(Coffee newCoffee);
    Coffee UpdateCoffee(Coffee newCoffee);
    void DeleteCoffeeById(int coffeeId);
}