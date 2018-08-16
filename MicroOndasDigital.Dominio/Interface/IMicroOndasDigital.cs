using System.Collections.Generic;

namespace MicroOndasDigital.Dominio.Interface
{
    public interface IMicroOndasDigital
    {
        TipoAquecimento RecuperarPorPrograma(int idPrograma);
        MicroOndasDigital Ligar(int tempo, int potencia);
        MicroOndasDigital InicioRapido();
        IList<TipoAquecimento> ListarTiposAquecimento();
    }
}
