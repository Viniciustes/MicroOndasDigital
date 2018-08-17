using System.Collections.Generic;
using System.Linq;
using MicroOndasDigital.Dominio.Interface;
using MicroOndasDigital.Servico.Dtos;
using MicroOndasDigital.Servico.Interface;

namespace MicroOndasDigital.Servico
{
    public class Servico : IServico
    {
        private readonly ITipoAquecimento _tipoAquecimento;
        private readonly IMicroOndasDigital _microOndasDigital;

        public Servico()
        {
            _tipoAquecimento = new Dominio.TipoAquecimento();
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
            var microOndasDigital = _tipoAquecimento.RecuperarPorPrograma(idPrograma);
            return TransformarObjetoParaDto(microOndasDigital);
        }

        public IList<DtoTipoAquecimento> ListarTiposAquecimento()
        {
            var listaTiposAquecimento = _tipoAquecimento.ListarTiposAquecimento();
            return TransformarObjetoParaDto(listaTiposAquecimento);
        }

        public DtoTipoAquecimento AdicionarPrograma(DtoTipoAquecimento dtoTipoAquecimento)
        {
            var tipoAquecimento = _tipoAquecimento.AdicionarPrograma(TransformarDtoParaObjeto(dtoTipoAquecimento));
            return TransformarObjetoParaDto(tipoAquecimento);
        }

        private Dominio.TipoAquecimento TransformarDtoParaObjeto(DtoTipoAquecimento dtoTipoAquecimento)
        {
            return new Dominio.TipoAquecimento(dtoTipoAquecimento.Id, dtoTipoAquecimento.Nome, dtoTipoAquecimento.Potencia, dtoTipoAquecimento.Tempo);
        }

        private DtoTipoAquecimento TransformarObjetoParaDto(Dominio.TipoAquecimento tipoAquecimento)
        {
            return new DtoTipoAquecimento()
            {
                Id = tipoAquecimento.Id,
                Nome = tipoAquecimento.Nome,
                Potencia = tipoAquecimento.Potencia,
                Tempo = tipoAquecimento.Tempo,
                EhValido = tipoAquecimento.EhValido,
                Mensagem = tipoAquecimento.Mensagem,
            };
        }

        private IList<DtoTipoAquecimento> TransformarObjetoParaDto(IList<Dominio.TipoAquecimento> tipoAquecimentos)
        {
            return tipoAquecimentos
                .Select(tipo => new DtoTipoAquecimento
                {
                    Id = tipo.Id,
                    Nome = tipo.Nome,
                    Potencia = tipo.Potencia,
                    Tempo = tipo.Tempo,
                    EhValido = tipo.EhValido,
                    Mensagem = tipo.Mensagem
                })
                .ToList();
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