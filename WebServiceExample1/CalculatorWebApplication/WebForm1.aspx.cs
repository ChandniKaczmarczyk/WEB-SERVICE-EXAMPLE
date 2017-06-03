using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorWebApplication.CalculatorService;

namespace CalculatorWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            CalculatorService.WebServiceCalculatorSoapClient client=new WebServiceCalculatorSoapClient();
            int result = client.AddTwoNumbers(Convert.ToInt32(txtFirstNumber.Text),
                Convert.ToInt32(txtSecondNumber.Text));
            lblResult.Text = result.ToString();
            GridView1.DataSource=client.GetCalculations();
            GridView1.DataBind();

            GridView1.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}