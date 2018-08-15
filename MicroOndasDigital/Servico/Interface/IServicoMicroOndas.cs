namespace MicroOndasDigital.Servico.Interface
{
    public interface IServicoMicroOndas
    {
        string Ligar(int tempo, int potencia);
        string Cancelar();
        string Pausar();
        string InicioRapido();
    }
}
