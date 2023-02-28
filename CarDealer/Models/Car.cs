using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Car
  {
    public string NickName { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Condition { get; set; }
    public int Year { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string nickName, string make, string model, string color, string condition, int year)
    {
      NickName = nickName;
      Make = make;
      Model = model;
      Color = color;
      Condition = condition;
      Year = year;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
