using ModeloDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio
{
    public partial class Laboratorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            int qtdComputadores = Convert.ToInt32(txtQtdComputadores.Text);
            int qtdAlunos = Convert.ToInt32(txtQtdAlunos.Text);
            Boolean projetor = cbxProjetor.Checked;
            string software1 = txtSoftware1.Text;
            string software2 = txtSoftware2.Text;
            string software3 = txtSoftware3.Text;
            string sistemaOperacional = txtSistemaOperacional.Text;

            if ((qtdComputadores <= 1) || (qtdAlunos <= 4) || (software1 == null) || (software2 == null) || (software3 == null) || (nome.Length <= 2))
            {
                SendMSG("Informações inválidas");
            }
            else
            {
                tb_laboratorio l = new tb_laboratorio()
                {
                    nome = nome,
                    qtdComputadores = qtdComputadores,
                    qtdAlunos = qtdAlunos,
                    projetor = projetor,
                    software1 = software1,
                    software2 = software2,
                    software3 = software3,
                    sistemaOperacional = sistemaOperacional
                };

                DB_LaboratorioEntities contextLaboratorio = new DB_LaboratorioEntities();
                string valor = Request.QueryString["idItem"];


                if (String.IsNullOrEmpty(valor))
                {
                    contextLaboratorio.tb_laboratorio.Add(l);
                    lblmsg.Text = "Registro Inserido";
                    Clear();
                }
                else
                {
                    int id = Convert.ToInt32(valor);
                    tb_laboratorio laboratorio = contextLaboratorio.tb_laboratorio.First(c => c.id == id);
                    laboratorio.nome = l.nome;
                    laboratorio.qtdComputadores = l.qtdComputadores;
                    laboratorio.qtdAlunos = l.qtdAlunos;
                    laboratorio.projetor = l.projetor;
                    laboratorio.software1 = l.software1;
                    laboratorio.software2 = l.software2;
                    laboratorio.software3 = l.software3;
                    laboratorio.sistemaOperacional = l.sistemaOperacional;
                    lblmsg.Text = "Registro Alterado";
                }

                contextLaboratorio.SaveChanges();

                if (!projetor)
                {
                    SendMSG("Para utilização do projetor é necessário abrir uma solicitação para o help desk");
                }

            }
        }


        private void SendMSG(string msg)
        {
            this.ClientScript.RegisterStartupScript(this.GetType(), "ERROR", "<script language=\"javaScript\">" + "alert('" + msg + "');" + "window.location.href='Default.aspx';" + "<" + "/script>");
        }

        private void Clear()
        {


            txtNome.Text = "";
            txtQtdComputadores.Text = "";
            txtQtdAlunos.Text = "";
            cbxProjetor.Checked = false;
            txtSoftware1.Text = "";
            txtSoftware2.Text = "";
            txtSoftware3.Text = "";
            txtSistemaOperacional.Text = "";

            txtNome.Focus();
        }

        private void CarregarDadosPagina()
        {
            string valor = Request.QueryString["idItem"];
            int idItem = 0;

            tb_laboratorio laboratorio = new tb_laboratorio();
            DB_LaboratorioEntities contextLaboratorio = new DB_LaboratorioEntities();

            if (!String.IsNullOrEmpty(valor))
            {
                idItem = Convert.ToInt32(valor);
                laboratorio = contextLaboratorio.tb_laboratorio.First(c => c.id == idItem);



                txtNome.Text = laboratorio.nome;
                txtQtdComputadores.Text = Convert.ToString(laboratorio.qtdComputadores);
                txtQtdAlunos.Text = Convert.ToString(laboratorio.qtdAlunos);
                cbxProjetor.Checked = Convert.ToBoolean(laboratorio.projetor);
                txtSoftware1.Text = laboratorio.software1;
                txtSoftware2.Text = laboratorio.software2;
                txtSoftware3.Text = laboratorio.software3;
                txtSistemaOperacional.Text = laboratorio.sistemaOperacional;


            }
        }
    }
}