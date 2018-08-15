using MicroOndasDigital.Dominio.Interface;
using System;

namespace MicroOndasDigital.Dominio
{
    public class MicroOndasDigital : IMicroOndasDigital
    {
        public MicroOndasDigital(int tempo, int potencia)
        {
            Tempo = tempo;
            Potencia = potencia;

            Validacoes();
        }

        public int Tempo { get; }

        public int Potencia { get; }

        public string InicioRapido()
        {
            throw new NotImplementedException();
        }

        public string Cancelar()
        {
            throw new NotImplementedException();
        }

        public string Ligar(int tempo, int potencia)
        {
            return "Ligado";
        }

        public string Pausar()
        {
            throw new NotImplementedException();
        }

        private string Validacoes()
        {
            if (Tempo < 1 || Tempo > 120)
            {
                return "Tempo deve ser no mínimo 1 segundo ou no máximo 2 minutos.";
            }

            if (Potencia < 1 || Potencia > 10)
            {
                return "Potência deve ser no mínimo 1 ou no máximo 10.";
            }

            return string.Empty;
        }
    }
}
