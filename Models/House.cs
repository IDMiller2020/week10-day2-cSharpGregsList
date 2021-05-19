using System;

namespace cSharpGregsList.Models
{
  public class House
  {
    public string Id { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Levels { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImgUrl { get; set; }
    public House(int bedrooms, int bathrooms, int levels, int year, string description, decimal price, string imgUrl)
    {
      Id = Guid.NewGuid().ToString();
      Bedrooms = bedrooms;
      Bathrooms = bathrooms;
      Levels = levels;
      Year = year;
      Description = description;
      Price = price;
      ImgUrl = imgUrl;
    }
  }
}