using BogCafe.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogCafeTests.Manager
{
    [TestClass]
    public class BookTest
    {
        private BookManager _mrg;

        [TestInitialize]
        public void BeforeEachTest()
        {
            _mrg = new BookManager();
        }


        [TestMethod]
        [DataRow()]
        [DataRow()]
        [DataRow()]
        public void GetBookByGenre()
        {
            //Arrange
            

            //Act
            

            //Assert


        }
    }
}
