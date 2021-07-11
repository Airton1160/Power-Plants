using BibliotecaPlants.BLL;
using BibliotecaPlants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaPlants.Site.Plantas
{
    public partial class CadastroEdicaoPlanta : System.Web.UI.Page
    {
        private TipoBo _tipoBo;
        private PlantasBo _plantasBo;
        private OrigemBo _origemBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //quando nao for page load carrega eles!!
            if (!Page.IsPostBack)
            {
                CarregarTiposNaCombo();
                CarregarOrigemNaCombo();
            }
        }
        protected void btnGravar_Click(object sender, EventArgs e)
        {
            _plantasBo = new PlantasBo();
            //criar um objeto planta para mapear tudo oque vem da tela pra ca
            //1 passo instanciar classe planta
            var planta = new Planta();

            // aqui seria o mapeamento?? duvidas aqui...
            planta.Titulo = txtTitulo.Text;
            planta.Preco = string.IsNullOrWhiteSpace(ValorPago.Text) ? (double?)null : Convert.ToDouble(ValorPago.Text);
            planta.DataEntrada = string.IsNullOrWhiteSpace(DataCompra.Text) ? (DateTime?)null : Convert.ToDateTime(DataCompra.Text);
            planta.TipoID = Convert.ToInt32(DdlTipo.SelectedValue);
            planta.OrigemID = Convert.ToInt32(DdlOrigem.SelectedValue);

            try
            {
                // no caso da imagem ira pegar somente o nome dela !!!!!!
                planta.Imagem = GravarImagemDisco();
            }
            catch (Exception)
            {
                lblMensagem.Text = "Erro ao gravar imagem";
            }

            try
            {
                _plantasBo.InserirNovaPlanta(planta);
                lblMensagem.ForeColor = System.Drawing.Color.DarkOliveGreen;
                lblMensagem.Text = "Planta cadastrada com Sucesso !";
                // travar o botao
                btnGravar.Enabled = false;
            }
            catch (Exception)
            {
                lblMensagem.ForeColor = System.Drawing.Color.DarkRed;
                lblMensagem.Text = "Erro ao gravar nova planta";
            }

        }

        // tratamento de files uploads
        private string GravarImagemDisco()
        {
            // se estiver um arquivo ou se usuario selecionou algum arquivo
            if (FileUpLoadImg.HasFile)
            {
                try
                {
                    var caminho = $"{AppDomain.CurrentDomain.BaseDirectory}Content\\imagensPlants\\";
                    var fileName = $"{DateTime.Now.ToString("yyyyMMddhhmmss")}_{FileUpLoadImg.FileName}";
                    FileUpLoadImg.SaveAs($"{caminho}{fileName}");
                    return fileName;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                return null;
            }
        }













        public void CarregarTiposNaCombo()
        {
            _tipoBo = new TipoBo();
            var tipos = _tipoBo.ObterTodosTipos();

            DdlTipo.DataSource = tipos;
            DdlTipo.DataBind();
        }

        public void CarregarOrigemNaCombo()
        {
            _origemBo = new OrigemBo();
            var origems = _origemBo.ObterOrigem();

            DdlOrigem.DataSource = origems;
            DdlOrigem.DataBind();
        }

    }
}