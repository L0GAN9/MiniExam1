using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Name");
    var name = Console.ReadLine();
    Console.WriteLine ("Enter Height in Inches");
    var x = Convert.ToInt32(Console.ReadLine());
    double height = Convert.ToDouble(x);

    Console.WriteLine ("Enter Weight in Pounds");
    var y = Convert.ToInt32(Console.ReadLine());
    double weight = Convert.ToDouble(y);
    double bmi = (703*weight)/(height*height);
    
    Console.WriteLine("BMI for " + name + " is " + bmi);

    if (bmi < 18.5)
    {
      Console.WriteLine(name + " is underweight");
    }
    if (bmi >= 18.5) {
      if (bmi <= 24.9) {
        Console.WriteLine(name + " is Normal or Healthy Weight");
      }
    }

    if (bmi >= 25) {
      if (bmi <= 29.9) {
        Console.WriteLine(name + " is Overweight");
      }
    }

    if (bmi >= 30)
    {
      Console.WriteLine(name + " is Obese");
    }
  }
}
