﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetByBrand(int brandId);
        List<Car> GetByColor(int colorId);
        List<Car> GetByModel(string modelYear);
        List<Car> GetById(int carId);


    }
}
