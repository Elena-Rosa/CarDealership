using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace Dealership.Tests
{
  [TestClass]
  public class CarTests 
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Car newCar = new Car("Hi buy me");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
    [TestMethod]
    public void carGet_returnCarSet_Make()
    {
      string make = "Toyotatata";
      Car newCar = new Car(make);
      Assert.AreEqual(make, newCar.Make);
    }
    [TestMethod]
    public void carGet_returnCarSet_Make()
    {
      string make = "Toyotatata";
      Car newCar = new Car(make);
      Assert.AreEqual(make, newCar.Make);
    }
  }
}


