using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using CapitanTioApp.Business;

namespace CapitanTioApp.Tests
{
    [TestClass]
    public class VinetaTests
    {
        [TestMethod]
        public void UnaVinetaTieneDosParticipantes()
        {
            var vineta = new Vineta();

            Assert.AreEqual(vineta.interlocutor.Length,2);
            Assert.IsNotNull(vineta.interlocutor[0]);
            Assert.IsNotNull(vineta.interlocutor[1]);

        }

        [TestMethod]
        public void UnaVinetaTieneUnBocadilloAsociadoQueEsUnaCadena()
        {
            var vineta = new Vineta();

            Assert.IsNotNull(vineta.bocadillo);
        }

        [TestMethod]
        public void LosInterlocutoresDeLaVinetaTieneUnNombre()
        {
            var vineta = new Vineta();

            Assert.IsNotNull(vineta.interlocutor[1].nombre);
            Assert.IsNotNull(vineta.interlocutor[0].nombre);

        }
    }
}