using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_lab_2.Tests
{
    [TestClass()]
    public class logicForIfTaskTests
    {
        //Тест №1 19 рублей 83 копейки
        [TestMethod()]
        public void SintTest1()
        {
            int ruble = 19;
            int penny = 83;
            var message = logicForIfTask.SintRub(ruble, penny) + " " + logicForIfTask.SintPenny(penny);
            Assert.AreEqual("19 рублей 83 копейки", message);
        }
        //тест №2 один рубль ровно
        [TestMethod()]
        public void SintTest2()
        {
            int ruble = 1;
            int penny = 0;
            var message = logicForIfTask.SintRub(ruble, penny);
            Assert.AreEqual("один рубль ровно", message);
        }
        //тест №3 89 копеек 
        [TestMethod()]
        public void SintTest3()
        {
            int penny = 89;
            var message = logicForIfTask.SintPenny(penny);
            Assert.AreEqual("89 копеек", message);
        }
        //Тест №4 2 рубля 23 копейки
        [TestMethod()]
        public void SintTest4()
        {
            int ruble = 2;
            int penny = 23;
            var message = logicForIfTask.SintRub(ruble, penny) + " " + logicForIfTask.SintPenny(penny);
            Assert.AreEqual("2 рубля 23 копейки", message);
        }
        //Тест №5 1 рубль 1 копейка
        [TestMethod()]
        public void SintTest5()
        {
            int ruble = 1;
            int penny = 1;
            var message = logicForIfTask.SintRub(ruble, penny) + " " + logicForIfTask.SintPenny(penny);
            Assert.AreEqual("1 рубль 1 копейка", message);
        }

    }
}
