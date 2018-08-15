namespace MicroOndasDigital.Dominio.Interface
{
    public interface IMicroOndasDigital
    {
        string Ligar(int tempo, int potencia);
        string Cancelar();
        string Pausar();
        string InicioRapido();
    }
}
