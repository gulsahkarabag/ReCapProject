using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal //: ICarDal
    {
     //   List<Car> _cars;
     //   public InMemoryCarDal(List<Car> cars)
     //   {
     //       _cars = cars;
     //   }

     //   public InMemoryCarDal()
     //  {
     //       _cars = new List<Car> {
     //           new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice= 200, ModelYear=2010, Description= "Opel Corsa"  },
     //           new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice= 350, ModelYear=2015, Description= "Renault Megane"  },
     //           new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice= 450, ModelYear=2019, Description= "Ford Focus"  },
     //           new Car{CarId=4, BrandId=2, ColorId=3, DailyPrice= 1200, ModelYear=2020, Description= "Bmw X5"  },
     //           new Car{CarId=5, BrandId=3, ColorId=5, DailyPrice= 900, ModelYear=2018, Description= "Mercedes"  },
     //  };
     //}
     //   public void Add(Car car)
     //   {
     //       _cars.Add(car);
     //   }

     //   public void Delete(Car car)
     //   {
     //       Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
     //       _cars.Remove(carToDelete);
     //   }

     //   public Car Get(Expression<Func<Car, bool>> filter)
     //   {
     //       throw new NotImplementedException();
     //   }

     //   public List<Car> GetAll()
     //   {
     //       return _cars;
     //   }

     //   public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
     //   {
     //       throw new NotImplementedException();
     //   }

     //   public List<Car> GetById(int carId)
     //   {
     //       return _cars.Where(c => c.CarId == carId).ToList();
     //   } 

     //   public void Update(Car car)
     //   {
     //       Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
     //       carToUpdate.BrandId = car.BrandId;
     //       carToUpdate.ColorId = car.ColorId;
     //       carToUpdate.DailyPrice = car.DailyPrice;
     //       carToUpdate.ModelYear = car.ModelYear;
     //       carToUpdate.Description = car.Description;
     //   }
    }
}
