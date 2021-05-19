using System.Collections.Generic;
using cSharpGregsList.DB;
using cSharpGregsList.Models;

namespace cSharpGregsList.Services
{
  public class CarsService
  {
    internal IEnumerable<Car> GetAll()
    {
      return FakeDb.Cars;
    }
    internal Car GetById(string id)
    {
      Car found = FakeDb.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new System.Exception("Invalid Id");
      }
      return found;
    }
    internal Car Create(Car newCar)
    {
      FakeDb.Cars.Add(newCar);
      return newCar;
    }
    internal Car EditById(Car editedCar)
    {
      Car oldCar = GetById(editedCar.Id);
      oldCar.Make = editedCar.Make;
      oldCar.Model = editedCar.Model;
      oldCar.Year = editedCar.Year;
      oldCar.Price = editedCar.Price;
      oldCar.Description = editedCar.Description;
      oldCar.ImgUrl = editedCar.ImgUrl;
      return oldCar;
    }
    internal void DeleteById(string id)
    {
      Car found = GetById(id);
      FakeDb.Cars.Remove(found);
    }
  }
}