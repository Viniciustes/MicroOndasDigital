using MicroOndasDigital.Dominio.Interface;
using MicroOndasDigital.Servico.Interface;

namespace MicroOndasDigital.Servico
{
    public class ServicoMicroOndas : IServicoMicroOndas
    {
        private readonly IMicroOndasDigital _microOndasDigital;

        public ServicoMicroOndas()
        {
            _microOndasDigital = new Dominio.MicroOndasDigital(1, 1);
        }

        public string Cancelar()
        {
            return _microOndasDigital.Cancelar();
        }

        public string InicioRapido()
        {
            return _microOndasDigital.InicioRapido();
        }

        public string Ligar(int tempo, int potencia)
        {
            return _microOndasDigital.Ligar(1, 1);
        }

        public string Pausar()
        {
            return _microOndasDigital.Pausar();
        }
    }
}
