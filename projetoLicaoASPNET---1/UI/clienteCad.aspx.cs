using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoLicaoASPNET___1.UI
{
    public partial class clienteCad : System.Web.UI.Page
    {
        DAL.ClienteDAL categoriaDal = new DAL.ClienteDAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCasdatrar_Click(object sender, EventArgs e)
        {
            try
            {

                BLL.Cliente categoriaBLL = new BLL.Cliente();

                categoriaBLL.Nome = txtNome.Text;

                categoriaDal.cadastrar(categoriaBLL);

                lblMsg.Text = "Cadastro executado com sucesso";

            }
            catch
            {

                lblMsg.Text = "Cadastro Falhou";

            }
        }
    }
}