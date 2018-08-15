using MicroOndasDigital.Servico.Dtos;

namespace MicroOndasDigital.Servico.Interface
{
    public interface IServicoMicroOndas
    {
        DtoMicroOndasDigital Ligar(int tempo, int potencia);
        DtoMicroOndasDigital Pausar();
        DtoMicroOndasDigital InicioRapido();
    }
}
