using System;
namespace RectangleApplication
{
   class Rectangle
   {
      //member variables
      protected double length;
      protected double width;
      // Parent constructor initialization
      // Will call from child class
      public Rectangle(double l, double w)
      {
         length = l;
         width = w;
      }
      
      public double GetArea()
      {
         return length * width;
      }
      
      public void Display()
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle  
   
   // Tabletop class inherit from Rectangle Class
   class Tabletop : Rectangle
   {
      private double cost;
      // Call constructor parent class with base(l, w)
      // for initialization parent class
      // it's mean call Rectangle(l, w)
      // before execute Tabletop contructor body
      public Tabletop(double l, double w) : base(l, w)
      { }
      public double GetCost()
      {
         double cost;
         cost = GetArea() * 70;
         return cost;
      }
      public void Display()
      {
         base.Display();
         Console.WriteLine("Cost: {0}", GetCost());
      }
   }
   class ExecuteRectangle
   {
      static void Main(string[] args)
      {
         Tabletop t = new Tabletop(4.5, 7.5);
         t.Display();
         Console.ReadLine();
      }
   }
}