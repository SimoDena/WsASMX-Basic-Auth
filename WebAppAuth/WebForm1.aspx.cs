using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAuth
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServizioAuthSoapClient client = new ServiceReference1.ServizioAuthSoapClient();
            client.ClientCredentials.UserName.UserName = TextBoxUser.Text;
            client.ClientCredentials.UserName.Password = TextBoxPassword.Text;

            try
            {
                int risultato = client.Aggiungi(5, 6);
                LabelStatus.Text = risultato.ToString() + "\n" + client.HelloWorld();
            }
            catch(Exception ex)
            {
                LabelStatus.Text = ex.Message;
            }
        }
    }
}