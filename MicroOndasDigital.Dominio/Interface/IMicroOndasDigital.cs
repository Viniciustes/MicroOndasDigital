namespace MicroOndasDigital.Dominio.Interface
{
    public interface IMicroOndasDigital
    {
        MicroOndasDigital Ligar(int tempo, int potencia);
        MicroOndasDigital Pausar();
        MicroOndasDigital InicioRapido();
    }
}
