using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace MicroOndasDigital.Dominio
{
    /// <summary>
    /// Essa classe foi criada para um armazenamento de dados fictício.
    /// Como não é possível criar banco de dados, ela guarda as informações cadastradas em tempo de execução.
    /// </summary>
    public class TipoAquecimentoMemoria
    {
        readonly ObjectCache cache = MemoryCache.Default;
        private IList<TipoAquecimento> tipoAquecimentos = new List<TipoAquecimento>();

        public IList<TipoAquecimento> RetornaTipoAquecimento()
        {
            var cacheEmMemoria = new CacheItemPolicy();

            if (!cache.Contains("tipoAquecimentos"))
            {
                tipoAquecimentos = ListarTiposAquecimento();

                cache.Add("tipoAquecimentos", tipoAquecimentos, cacheEmMemoria);
            }
            else
            {
                tipoAquecimentos = (List<TipoAquecimento>)cache.Get("tipoAquecimentos");
            }

            return tipoAquecimentos;
        }

        public TipoAquecimento AdicionarNovoTipoDeAquecimentoEmMemoria(TipoAquecimento tipoAquecimento)
        {
            tipoAquecimentos = (List<TipoAquecimento>)cache.Get("tipoAquecimentos");

            var idTipoAquecimento = tipoAquecimentos.OrderByDescending(x => x.Id).First().Id + 1;

            tipoAquecimento.Id = idTipoAquecimento;

            if (tipoAquecimento.EhValido)
                tipoAquecimentos.Add(tipoAquecimento);

            return tipoAquecimento;
        }

        /// <summary>
        /// Essas informações poderia vim de uma fonte externa como um banco de dados.
        /// </summary>
        /// <returns></returns>
        private IList<TipoAquecimento> ListarTiposAquecimento()
        {
            var tiposAquecimento = new List<TipoAquecimento>
            {
                new TipoAquecimento (1, "Assar Frango",  2,  7 ),
                new TipoAquecimento (2, "Cozinhar Carne",  4, 9 ),
                new TipoAquecimento (3, "Estourar Pipoca",  7,  8 ),
                new TipoAquecimento (4, "Miojo",  9,  4 ),
                new TipoAquecimento (5, "Fritar Ovo",  3,  2 )
            };

            return tiposAquecimento;
        }
    }
}
