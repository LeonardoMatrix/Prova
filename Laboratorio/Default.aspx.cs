using ModeloDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        protected void CarregarLista()
        {
            DB_LaboratorioEntities context = new DB_LaboratorioEntities();
            List<tb_laboratorio> lstLaboratorio = context.tb_laboratorio.ToList<tb_laboratorio>();

            GVLaboratorio.DataSource = lstLaboratorio;
            GVLaboratorio.DataBind();

        }

        protected void GVLaboratorio_DataBound(object sender, EventArgs e)
        {

        }

        protected void GVLaboratorio_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            DB_LaboratorioEntities contextLaboratorio = new DB_LaboratorioEntities();
            tb_laboratorio laboratorio = new tb_laboratorio();

            laboratorio = contextLaboratorio.tb_laboratorio.First(c => c.id == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("Laboratorio.aspx?idItem=" + idItem);

            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextLaboratorio.tb_laboratorio.Remove(laboratorio);
                contextLaboratorio.SaveChanges();
                string msg = "Laboratorio excluido com sucesso!";
                string titulo = "Infomacao";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }

        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
            "MostrarPopupMensagem();", true);
        }

        protected void GVLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}