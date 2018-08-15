using MicroOndasDigital.Dominio.Interface;
using System;
using System.Collections.Generic;

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

        public IList<TipoAquecimento> TiposAquecimentos { get; }

        public MicroOndasDigital InicioRapido()
        {
            var tempo = 30;
            var potencia = 8;

            return new MicroOndasDigital(tempo, potencia);
        }

        public MicroOndasDigital Ligar(int tempo, int potencia)
        {
            return new MicroOndasDigital(tempo, potencia);
        }

        public MicroOndasDigital Pausar()
        {
            throw new NotImplementedException();
        }

        private void Validacoes()
        {
            if (Tempo < 1 || Tempo > 120)
            {
                Mensagem = "Tempo deve ser no mínimo 1 segundo ou no máximo 2 minutos.";
                return;
            }

            if (Potencia < 1 || Potencia > 10)
            {
                Mensagem = "Potência deve ser no mínimo 1 ou no máximo 10.";
                return;
            }

            EhValido = true;
        }
    }
}
