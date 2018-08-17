namespace MicroOndasDigital.Dominio
{
    public class EntidadeBasica
    {
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public bool EhValido { get; protected set; }
        public string Mensagem { get; protected set; }

        protected void ValidacoesBasicas()
        {
            if (Tempo < 1 || Tempo > 120)
            {
                Mensagem = Constantes.LIMITE_TEMPO;
                return;
            }

            if (Potencia < 1 || Potencia > 10)
            {
                Mensagem = Constantes.LIMITE_POTENCIA;
                return;
            }

            EhValido = true;
        }
    }
}
