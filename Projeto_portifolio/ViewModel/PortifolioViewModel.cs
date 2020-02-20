using ProjetoPortifolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace ProjetoPortifolio.ViewModel
{
    public class PortifolioViewModel
    {
        public ItemsPaginaGeral dadosPagina { get; set; }
        public IPagedList<ImagensPortifolio> imagens { get; set; }
        public IPagedList<itemFotoGaleriaPrincipal> imagensPrincipais { get; set; }
        public List<ButtonSite> botoes { get; set; }
        public List<string> formularios { get; set; }
        public List<ItemsPaginaGeral> listaPaginasSistema { get; set; }
        public string mainFoto { get; set; }
        public ValidaUser login { get; set; }
        public ModelCadastroLink cadastroLink { get; set; }
        public ItemsPaginaGeral cadastroTela { get;set; }

    }
}
