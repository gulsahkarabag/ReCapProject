using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var c in carManager.GetAll())
            {
                System.Console.WriteLine(c.Description+ " " + c.DailyPrice);
            }
            
        }
    }
}
