using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorData.ConsoleApp;
using System;

namespace TesteData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DataInvalida()
        {
            DateTime dateTime = new DateTime(2021, 06, 28);
            Assert.AreEqual("Data Invalida", new Converte().ValidarData(dateTime));
        }
        [TestMethod]
        public void TesteSegundos()
        {
            DateTime dateTimeSecunds = new DateTime(2021, 05, 26, 15, 35, 10);
            Assert.AreEqual("Dez segundos atras", new Converte().ValidarData(dateTimeSecunds));
        }
        [TestMethod]
        public void TesteMinutos()
        {
            DateTime dateTimeMinutes = new DateTime(2021, 05, 26, 15, 25, 20);
            Assert.AreEqual("Dez minutos atras", new Converte().ValidarData(dateTimeMinutes));
        }
        [TestMethod]
        public void TesteHoras()
        {
            DateTime dateTimeHour = new DateTime(2021, 05, 26, 13, 35, 20);
            Assert.AreEqual("Dois horas atras", new Converte().ValidarData(dateTimeHour));
        }
        [TestMethod]
        public void TesteUmdia()
        {
            DateTime dateTimeOneDay = new DateTime(2021, 05, 25, 15, 35, 20);
            Assert.AreEqual("Um dia atras", new Converte().validaDias(dateTimeOneDay));
        }
        [TestMethod]
        public void TesteDoisDias()
        {
            DateTime dateTimeTwoDays = new DateTime(2021, 05, 24, 15, 35, 20);
            Assert.AreEqual("Dois dias atras", new Converte().validaDias(dateTimeTwoDays));
        }
        [TestMethod]
        public void TesteUmaSemana()
        {
            DateTime dateTimeOneWeek = new DateTime(2021, 05, 19, 15, 35, 20);
            Assert.AreEqual("Um semana atras", new Converte().validaDias(dateTimeOneWeek));
        }
        [TestMethod]
        public void TesteDuasSemana()
        {
            DateTime dateTimeTwoWeeks = new DateTime(2021, 05, 12, 15, 35, 20);
            Assert.AreEqual("Dois semanas atras", new Converte().validaDias(dateTimeTwoWeeks));
        }
        [TestMethod]
        public void TesteUmMes()
        {
            DateTime dateTimeOneMonth = new DateTime(2021, 04, 26, 15, 35, 20);
            Assert.AreEqual("Um mes atras", new Converte().ValidaMes(dateTimeOneMonth));
        }
        [TestMethod]
        public void TesteDoiMes()
        {
            DateTime dateTimeTwoMonth = new DateTime(2021, 03, 26, 15, 35, 20);
            Assert.AreEqual("Dois meses atras", new Converte().ValidaMes(dateTimeTwoMonth));
        }
        [TestMethod]
        public void TesteDoiMeseUmaSemana()
        {
            DateTime dateTimeTwoMonthTwoWeek = new DateTime(2021, 03, 19, 15, 35, 20);
            Assert.AreEqual("Dois meses e um semana atras", new Converte().ValidaMes(dateTimeTwoMonthTwoWeek));
        }
        [TestMethod]
        public void TesteUmAno()
        {
            DateTime dateTimeOneYaer = new DateTime(2020, 05, 26, 15, 35, 20);
            Assert.AreEqual("Um ano atras", new Converte().validadeAno(dateTimeOneYaer));
        }
        [TestMethod]
        public void TesteUmAnoEumMes()
        {
            DateTime dateTimeOneYaerOneMonth = new DateTime(2020, 04, 26, 15, 35, 20);
            Assert.AreEqual("Um ano e um mes atras", new Converte().validadeAno(dateTimeOneYaerOneMonth));
        }
    }
}
