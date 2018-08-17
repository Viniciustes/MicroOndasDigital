using System.Collections.Generic;

namespace MicroOndasDigital.Dominio.Interface
{
    public interface ITipoAquecimento
    {
        TipoAquecimento RecuperarPorPrograma(int idPrograma);
        IList<TipoAquecimento> ListarTiposAquecimento();
        TipoAquecimento AdicionarPrograma(TipoAquecimento tipoAquecimento);
    }
}
