using BibliotecaPlants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaPlants.Site.Plantas;
using BibliotecaPlants.BLL.Autenticacao;

namespace BibliotecaPlants.Site.Plantas
{
    public partial class Catalogo : System.Web.UI.Page
    {
        private PlantasBo _plantasBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregaJogos();
            }
        }

        // obter algumas plantas
        private void CarregaJogos()
        {
            _plantasBo = new PlantasBo();

            RepeaterPlantas.DataSource = _plantasBo.AllPlants();

            // faz commit 
            RepeaterPlantas.DataBind();

        }



    }
}