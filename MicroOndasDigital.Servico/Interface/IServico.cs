using MicroOndasDigital.Servico.Dtos;
using System.Collections.Generic;

namespace MicroOndasDigital.Servico.Interface
{
    public interface IServico
    {
        DtoTipoAquecimento RecuperarPorPrograma(int idPrograma);
        DtoMicroOndasDigital Ligar(int tempo, int potencia);
        DtoMicroOndasDigital InicioRapido();
        IList<DtoTipoAquecimento> ListarTiposAquecimento();
        DtoTipoAquecimento AdicionarPrograma(DtoTipoAquecimento tipoAquecimento);
    }
}
