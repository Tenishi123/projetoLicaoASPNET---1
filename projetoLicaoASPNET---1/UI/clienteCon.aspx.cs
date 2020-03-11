using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projetoLicaoASPNET___1.UI
{
    public partial class clienteCon : System.Web.UI.Page
    {

        DAL.ClienteDAL categoriadal = new DAL.ClienteDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                gvResultado.DataSource = categoriadal.select();
                gvResultado.DataBind();

            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

            BLL.Cliente cliente = new BLL.Cliente();

            if (txtFiltro.Text == "")
            {

                gvResultado.DataSource = categoriadal.select();
                gvResultado.DataBind();

            }
            else
            {

                cliente.Nome = txtFiltro.Text;

                gvResultado.DataSource = categoriadal.select(cliente);
                gvResultado.DataBind();

            }
        }

        protected void gvResultado_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            BLL.Cliente cliente = new BLL.Cliente();

            if (e.CommandName == "cmdExcluir")
            {

                try
                {

                    cliente.CodUsuario = Convert.ToInt32(e.CommandArgument);

                    categoriadal.excluir(cliente);

                    Response.Write("<script> alert('Categoria excluida com sucesso !')</script>");

                }
                catch
                {

                    Response.Write("<script> alert('Falha ao excluir a categoria !')</script>");

                }

            }
            else
            {



            }
        }
    }
}