using MicroOndasDigital.Dominio.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicroOndasDigital.Teste.DominioTestes
{
    [TestClass]
    public class MicroOndasDigitalTeste
    {
        private IMicroOndasDigital _microOndasDigital;

        public MicroOndasDigitalTeste()
        {
            _microOndasDigital = new Dominio.MicroOndasDigital();
        }

        [TestMethod]
        public void TempoMaximoDeveSer120Segundos()
        {
            var resultTrue = _microOndasDigital.Ligar(120, 2);
            Assert.AreEqual(true, resultTrue.EhValido);

            var resultFalse = _microOndasDigital.Ligar(121, 2);
            Assert.AreEqual(false, resultFalse.EhValido);
        }

        [TestMethod]
        public void TempoMinimoDeveSer1Segundos()
        {
            var result = _microOndasDigital.Ligar(0, 2);
            Assert.AreEqual(false, result.EhValido);
        }

        [TestMethod]
        public void LancarExcecaoCasoTempoForaDosLimites()
        {

        }

        [TestMethod]
        public void PotenciaMaximaDeveSer10()
        {

        }

        [TestMethod]
        public void PotenciaMinimaDeveSer1()
        {

        }

        [TestMethod]
        public void LancarExcecaoCasoPotenciaForaDosLimites()
        {

        }
    }
}
