using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void TestMakeModelProperty()
    {
      //Arrange
      var car = new Car();
      string expectedMakeModel = "Toyota Camry";

      //Act
      car.MakeModel = expectedMakeModel;
      string actualMakeModel = car.MakeModel;

      //Assert
      Assert.AreEqual(expectedMakeModel, actualMakeModel);
    }
  }
}