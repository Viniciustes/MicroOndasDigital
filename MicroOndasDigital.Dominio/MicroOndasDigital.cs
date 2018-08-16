using MicroOndasDigital.Dominio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MicroOndasDigital.Dominio
{
    public class MicroOndasDigital : IMicroOndasDigital
    {
        public MicroOndasDigital()
        {
        }

        public MicroOndasDigital(int tempo, int potencia)
        {
            Tempo = tempo;
            Potencia = potencia;

            Validacoes();
        }

        public int Tempo { get; }

        public int Potencia { get; }

        public bool EhValido { get; private set; }

        public string Mensagem { get; private set; }

        public MicroOndasDigital InicioRapido()
        {
            return new MicroOndasDigital(Constantes.TEMPO_RAPIDO, Constantes.POTENCIA_RAPIDA);
        }

        public IList<TipoAquecimento> ListarTiposAquecimento()
        {
            // Essas informações poderia vim de uma fonte externa como um banco de dados.
            var tiposAquecimento = new List<TipoAquecimento>
            {
                new TipoAquecimento { Id = 1, Nome = "Assar Frango", Potencia = 2, Tempo = 7 },
                new TipoAquecimento { Id = 2, Nome = "Cozinhar Carne", Potencia = 4, Tempo = 9 },
                new TipoAquecimento { Id = 3, Nome = "Estourar Pipoca", Potencia = 7, Tempo = 8 },
                new TipoAquecimento { Id = 4, Nome = "Miojo", Potencia = 9, Tempo = 4 },
                new TipoAquecimento { Id = 5, Nome = "Fritar Ovo", Potencia = 3, Tempo = 2 }
            };

            return tiposAquecimento;
        }

        public MicroOndasDigital Ligar(int tempo, int potencia)
        {
            return new MicroOndasDigital(tempo, potencia);
        }

        private void Validacoes()
        {
            if (Tempo < 1 || Tempo > 120)
            {
                Mensagem = Constantes.LIMITE_TEMPO;
                return;
            }

            if (Potencia < 1 || Potencia > 10)
            {
                Mensagem = Constantes.LIMITE_POTENCIA; ;
                return;
            }

            EhValido = true;
        }

        public TipoAquecimento RecuperarPorPrograma(int idPrograma)
        {
           return ListarTiposAquecimento().Where(x => x.Id == idPrograma).FirstOrDefault();
        }
    }
}
