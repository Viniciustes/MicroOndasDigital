using MicroOndasDigital.Dominio.Interface;

namespace MicroOndasDigital.Dominio
{
    public class MicroOndasDigital : EntidadeBasica, IMicroOndasDigital
    {
        public MicroOndasDigital() { }

        public MicroOndasDigital(int tempo, int potencia)
        {
            Tempo = tempo;
            Potencia = potencia;

            ValidacoesBasicas();
        }

        public MicroOndasDigital InicioRapido()
        {
            return new MicroOndasDigital(Constantes.TEMPO_RAPIDO, Constantes.POTENCIA_RAPIDA);
        }

        public MicroOndasDigital Ligar(int tempo, int potencia)
        {
            return new MicroOndasDigital(tempo, potencia);
        }
    }
}
