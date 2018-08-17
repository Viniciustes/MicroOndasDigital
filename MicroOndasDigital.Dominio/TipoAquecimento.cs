using MicroOndasDigital.Dominio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MicroOndasDigital.Dominio
{
    public class TipoAquecimento : EntidadeBasica, ITipoAquecimento
    {
        public TipoAquecimento() { }

        public TipoAquecimento(int id, string nome, int potencia, int tempo)
        {
            Id = id;
            Tempo = tempo;
            Potencia = potencia;
            Nome = nome;

            Validacoes();
        }

        public int Id { get; set; }

        public string Nome { get; }

        public TipoAquecimento RecuperarPorPrograma(int idPrograma)
        {
            return ListarTiposAquecimento().Where(x => x.Id == idPrograma).FirstOrDefault();
        }

        public IList<TipoAquecimento> ListarTiposAquecimento()
        {
            return new TipoAquecimentoMemoria().RetornaTipoAquecimento();
        }

        public TipoAquecimento AdicionarPrograma(TipoAquecimento tipoAquecimento)
        {
            return new TipoAquecimentoMemoria().AdicionarNovoTipoDeAquecimentoEmMemoria(tipoAquecimento);
        }

        private void Validacoes()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem = Constantes.NOME_EM_BRANCO;
                EhValido = false;
                return;
            }

            ValidacoesBasicas();
        }
    }
}
