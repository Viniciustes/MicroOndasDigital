using MicroOndasDigital.Dominio.Interface;
using MicroOndasDigital.Servico.Interface;

namespace MicroOndasDigital.Servico
{
    public class ServicoMicroOndas : IServicoMicroOndas
    {
        private readonly IMicroOndasDigital _microOndasDigital;

        public ServicoMicroOndas()
        {
        }

        public ServicoMicroOndas(int tempo, int potencia)
        {
            _microOndasDigital = new Dominio.MicroOndasDigital(tempo, potencia);
        }

        public string Cancelar()
        {
            return _microOndasDigital.Cancelar();
        }

        public string InicioRapido()
        {
            var tempo = 30;
            var potencia = 8;

            return Ligar(tempo, potencia);
        }

        public string Ligar(int tempo, int potencia)
        {
            return _microOndasDigital.Ligar(tempo, potencia);
        }

        public string Pausar()
        {
            return _microOndasDigital.Pausar();
        }
    }
}