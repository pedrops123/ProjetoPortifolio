using ProjetoPortifolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ProjetoPortifolio.ViewModel
{
    public class ParametrosPaginacaoPrincipal
    {
        public IPagedList<itemFotoGaleriaPrincipal> imagens { get; set; }
        public ItemsPaginaGeral dadosPagina { get; set; }
    }
}
