using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panel_zarządzający;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panel_zarządzający.Tests
{
    [TestClass()]
    public class RejestracjaTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Rejestracja test = new Rejestracja();
            int liczbaA = 2;
            int liczbaB = 2;
            int wynik = 4;
            int actual;
            actual = test.Add(liczbaA, liczbaB);
            Assert.AreEqual(wynik, actual);
            
        }

        [TestMethod()]
        public void SubTest()
        {
            Rejestracja test = new Rejestracja();
            int liczbaA =4;
            int liczbaB = 2;
            int wynik = 2;
            int actual;
            actual = test.Sub(liczbaA, liczbaB);
            Assert.AreEqual(wynik, actual);
            
        }

        [TestMethod()]
        public void MulTest()
        {
            Rejestracja test = new Rejestracja();
            int liczbaA = 2;
            int liczbaB = 2;
            int wynik = 4;
            int actual;
            actual = test.Mul(liczbaA, liczbaB);
            Assert.AreEqual(wynik, actual);
         
        }

        [TestMethod()]
       
        public void DivTest()
        {
            Rejestracja test = new Rejestracja();
            int liczbaA = 4;
            int liczbaB = 2;
            int wynik = 2;
            int actual;
            actual = test.Div(liczbaA, liczbaB);
            Assert.AreEqual(wynik, actual);
            
        }

       

       
    }
}