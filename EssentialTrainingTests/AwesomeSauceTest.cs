﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tabasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailer Trash");

            //expext to pass
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
