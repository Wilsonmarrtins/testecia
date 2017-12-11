using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TesteSeusConhecimentos.Domain;
using TesteSeusConhecimentos.Entities;
using TesteSeusConhecimentos.Infra;

namespace TesteSeusConhecimentos.Web.Infocast
{
    public partial class InfoEnterprise : System.Web.UI.Page
    {
        private IEnterpriseRepository EnterpriseRepository;

        private int IdEnterprise
        {
            set { ViewState["IdEnterprise"] = value; }
            get
            {
                if (ViewState["IdEnterprise"] != null)
                    return Convert.ToInt32(ViewState["IdEnterprise"]);

                return 0;
            }
        }
        public InfoEnterprise()
        {
            this.EnterpriseRepository = new EnterpriseRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetViewStateUser();
                UpdateForm();
            }
        }

        private void SetViewStateUser()
        {
            if (Request.QueryString["id"] != null)
                IdEnterprise = Convert.ToInt32(Request.QueryString["id"]);
            else
                IdEnterprise = 0;
        }

        private void UpdateForm()
        {
            Enterprise enterprise = this.EnterpriseRepository.GetById(IdEnterprise);

            if (enterprise != null)
            {
                formStatus2.InnerText = "Editar Empresa";
                txtEndereco.Text = enterprise.StreetAdress;
                txtCidade.Text = enterprise.City;
                txtEstado.Text = enterprise.State;
                TxtCep.Text = enterprise.ZipCode;
                txtAtividadeEmpresa.Text = enterprise.State;
            }
        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            Enterprise Enterprise = new Enterprise(IdEnterprise, txtEndereco.Text, txtCidade.Text, txtEstado.Text, TxtCep.Text, txtAtividadeEmpresa.Text);
            EnterpriseRepository.Save(Enterprise);

            Response.Redirect("~/Infocast/Users.aspx");
        }
    }
}