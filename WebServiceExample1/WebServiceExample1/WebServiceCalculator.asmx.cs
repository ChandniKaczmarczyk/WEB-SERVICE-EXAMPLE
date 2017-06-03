using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Xsl;

namespace WebServiceExample1
{
    /// <summary>
    /// Summary description for WebServiceCalculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCalculator : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        public int AddTwoNumbers(int num1, int num2)
        {

            List<string> calculations;

            if (Session["CALCULATION"] == null)
            {
                calculations = new List<string>();
            }
            else
            {
                calculations = (List<string>)Session["CALCULATION"];
            }

            string strRecentCalculation = num1.ToString() + " + " + num2.ToString() + " = " + (num1 + num2).ToString();
            calculations.Add(strRecentCalculation);

            Session["CALCULATION"] = calculations;

            return num1 + num2;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {
            if (Session["CALCULATION"] == null)
            {
                List<string> calculations = new List<string>();
                calculations.Add("You have not performed any calculations");
                return calculations;
            }
            else
            {
                return (List<string>)Session["CALCULATION"];
            }
        }

        //Method Overloading using MessageName Property

        [WebMethod(MessageName = "MultiplyTwoNumbers",Description = "This method Multiplies two numbers")]
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        [WebMethod]
        public int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

    }
}
