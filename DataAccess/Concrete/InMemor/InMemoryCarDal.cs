using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemor
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear="2015",Description="Süper son model araç"},
            new Car{CarId=2,BrandId=1,ColorId=4,DailyPrice=150,ModelYear="2016",Description="Süper son model araç1"},
            new Car{CarId=3,BrandId=2,ColorId=3,DailyPrice=120,ModelYear="2017",Description="Süper son model araç2"},
            new Car{CarId=4,BrandId=2,ColorId=1,DailyPrice=140,ModelYear="2021",Description="Süper son model araç3"},
            new Car{CarId=5,BrandId=3,ColorId=5,DailyPrice=160,ModelYear="2020",Description="Süper son model araç4"},
            new Car{CarId=6,BrandId=3,ColorId=7,DailyPrice=190,ModelYear="2018",Description="Süper son model araç5"},
            new Car{CarId=7,BrandId=3,ColorId=1,DailyPrice=210,ModelYear="2018",Description="Süper son model araç6"},
            new Car{CarId=8,BrandId=4,ColorId=1,DailyPrice=1000,ModelYear="2020",Description="Süper son model araç7"},
            new Car{CarId=9,BrandId=4,ColorId=3,DailyPrice=250,ModelYear="2017",Description="Süper son model araç8"},
            new Car{CarId=10,BrandId=5,ColorId=8,DailyPrice=350,ModelYear="2015",Description="Süper son model araç9"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.FirstOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<Car> GetByModel(string modelYear)
        {
            return _cars.Where(c => c.ModelYear == modelYear).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(x => x.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
