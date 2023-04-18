using Microsoft.VisualStudio.TestTools.UnitTesting;
using BogCafe.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.model;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BogCafe.Manager.Tests
{
    [TestClass()]
    public class MerchantManagerTests
    {
        private MerchantManager mrg = new MerchantManager();

        [TestMethod()]
        [DataRow(null)]
        public void CreateMerchant()
        {
            //Arrange


            //Act
            

            //Assert
            

        }

        [TestMethod()]
        public void DeleteTest()
        {
            //Arrange


            //Act
            

            //Assert
        }

        [TestMethod()]
        [DataRow(null)]
        public void GetAllTest()
        {
            //Arange
            int expectedresult = 1;

            //Act
            List<Merchant> result = mrg.GetAll();

            //Assert
            Assert.AreEqual(expectedresult, result.Count);
        }

        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("      ")]
        public void GetnameTest(string name)
        {
            //Arange
            int expectedresult = 0;

            //Act
            List<Merchant> result = mrg.Getname(name);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedresult, result.Count);
        }

        [TestMethod()]
        [DataRow("cecilie")]
        [DataRow("CecIlie")]
        public void GetnameTest2(string name)
        {
            //Arange
            int expectedresult = 1;

            //Act
            List<Merchant> result = mrg.Getname(name);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedresult, result.Count);
        }

        [TestMethod()]
        [DataRow("Olga")]  
        public void GetnameTest3(string name)
        {
            //Arange
            int expectedresult = 1;

            //Act
            List<Merchant> result = mrg.Getname(name);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedresult, result.Count);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            //Arrange


            //Act


            //Assert
        }
    }
}