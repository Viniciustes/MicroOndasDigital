using MicroOndasDigital.Dominio.Interface;
using MicroOndasDigital.Servico.Dtos;
using MicroOndasDigital.Servico.Interface;

namespace MicroOndasDigital.Servico
{
    public class ServicoMicroOndas : IServicoMicroOndas
    {
        private readonly IMicroOndasDigital _microOndasDigital;

        public ServicoMicroOndas()
        {
            _microOndasDigital = new Dominio.MicroOndasDigital();
        }

        public ServicoMicroOndas(int tempo, int potencia)
        {
            _microOndasDigital = new Dominio.MicroOndasDigital(tempo, potencia);
        }

        public DtoMicroOndasDigital InicioRapido()
        {
            var microOndasDigital = _microOndasDigital.InicioRapido();
            return TransformarObjetoParaDto(microOndasDigital);
        }

        public DtoMicroOndasDigital Ligar(int tempo, int potencia)
        {
            var microOndasDigital = _microOndasDigital.Ligar(tempo,potencia);
            return TransformarObjetoParaDto(microOndasDigital);
        }

        public DtoMicroOndasDigital Pausar()
        {
            var microOndasDigital = _microOndasDigital.Pausar();
            return TransformarObjetoParaDto(microOndasDigital);
        }

        private DtoMicroOndasDigital TransformarObjetoParaDto(Dominio.MicroOndasDigital microOndasDigital)
        {
            return new DtoMicroOndasDigital()
            {
                Tempo = microOndasDigital.Tempo,
                Potencia = microOndasDigital.Potencia,
                EhValido = microOndasDigital.EhValido,
                Mensagem = microOndasDigital.Mensagem
            };
        }
    }
}