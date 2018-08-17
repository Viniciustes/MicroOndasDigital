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
            Assert.IsTrue(resultTrue.EhValido);

            var resultFalse = _microOndasDigital.Ligar(121, 2);
            Assert.IsFalse(resultFalse.EhValido);
        }

        [TestMethod]
        public void TempoMinimoDeveSer1Segundos()
        {
            var resultTrue = _microOndasDigital.Ligar(1, 5);
            Assert.IsTrue(resultTrue.EhValido);

            var resultFalse = _microOndasDigital.Ligar(0, 5);
            Assert.IsFalse(resultFalse.EhValido);
        }

        [TestMethod]
        public void LancarExcecaoCasoTempoForaDosLimites()
        {
            var resultTrue = _microOndasDigital.Ligar(121, 8);
            Assert.IsNotNull(resultTrue.Mensagem);

            var resultFalse = _microOndasDigital.Ligar(0, 4);
            Assert.IsNotNull(resultFalse.Mensagem);
        }

        [TestMethod]
        public void PotenciaMaximaDeveSer10()
        {
            var resultTrue = _microOndasDigital.Ligar(45, 10);
            Assert.IsTrue(resultTrue.EhValido);

            var resultFalse = _microOndasDigital.Ligar(55, 11);
            Assert.IsFalse(resultFalse.EhValido);
        }

        [TestMethod]
        public void PotenciaMinimaDeveSer1()
        {
            var resultTrue = _microOndasDigital.Ligar(25, 1);
            Assert.IsTrue(resultTrue.EhValido);

            var resultFalse = _microOndasDigital.Ligar(33, 0);
            Assert.IsFalse(resultFalse.EhValido);
        }

        [TestMethod]
        public void LancarExcecaoCasoPotenciaForaDosLimites()
        {
            var resultTrue = _microOndasDigital.Ligar(15, 0);
            Assert.IsNotNull(resultTrue.Mensagem);

            var resultFalse = _microOndasDigital.Ligar(0, 11);
            Assert.IsNotNull(resultFalse.Mensagem);
        }

        [TestMethod]
        public void InicioRapidoDeveTerTempo30ePotencia8()
        {
            var resultTrue = _microOndasDigital.InicioRapido();
            Assert.AreEqual(30, resultTrue.Tempo);
            Assert.AreEqual(8, resultTrue.Potencia);
        }

        //[TestMethod]
        //public void NaoPodeCadastarTipoAquecimentoComTempoSuperiorAoPermitido
        //{

        //}

        //[TestMethod]
        //public void NaoPodeCadastarTipoAquecimentoComTempoInferiorAoPermitido
        //{

        //}

        //[TestMethod]
        //public void NaoPodeCadastarTipoAquecimentoComPotenciaSuperiorAoPermitido
        //{

        //}

        //[TestMethod]
        //public void NaoPodeCadastarTipoAquecimentoComPotenciaInferiorAoPermitido
        //{

        //}

        //[TestMethod]
        //public void NaoPodeCadastarTipoAquecimentoSemNome
        //{

        //}
    }
}
