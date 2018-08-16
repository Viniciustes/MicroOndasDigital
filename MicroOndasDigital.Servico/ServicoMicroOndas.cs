using System.Collections.Generic;
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

        public DtoMicroOndasDigital InicioRapido()
        {
            var microOndasDigital = _microOndasDigital.InicioRapido();
            return TransformarObjetoParaDto(microOndasDigital);
        }

        public DtoMicroOndasDigital Ligar(int tempo, int potencia)
        {
            var microOndasDigital = _microOndasDigital.Ligar(tempo, potencia);
            return TransformarObjetoParaDto(microOndasDigital);
        }

        public DtoTipoAquecimento RecuperarPorPrograma(int idPrograma)
        {
            var microOndasDigital = _microOndasDigital.RecuperarPorPrograma(idPrograma);
            return TransformarObjetoParaDto(microOndasDigital);
        }

        public IList<DtoTipoAquecimento> ListarTiposAquecimento()
        {
            var listaTiposAquecimento = _microOndasDigital.ListarTiposAquecimento();
            return TransformarObjetoParaDto(listaTiposAquecimento);
        }

        private DtoTipoAquecimento TransformarObjetoParaDto(Dominio.TipoAquecimento tipoAquecimento)
        {
            return new DtoTipoAquecimento()
            {
                Id = tipoAquecimento.Id,
                Nome = tipoAquecimento.Nome,
                Potencia = tipoAquecimento.Potencia,
                Tempo = tipoAquecimento.Tempo
            };
        }

        private IList<DtoTipoAquecimento> TransformarObjetoParaDto(IList<Dominio.TipoAquecimento> tipoAquecimentos)
        {
            var listDtoTipoAquecimento = new List<DtoTipoAquecimento>();

            foreach (var item in tipoAquecimentos)
            {
                listDtoTipoAquecimento.Add(
                    new DtoTipoAquecimento()
                    {
                        Id = item.Id,
                        Nome = item.Nome,
                        Potencia = item.Potencia,
                        Tempo = item.Tempo
                    });
            }
            return listDtoTipoAquecimento;
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