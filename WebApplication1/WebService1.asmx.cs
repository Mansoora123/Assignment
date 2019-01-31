using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

     
        [WebMethod]
        public string Add(int n1, int n2)
        {
            int res = n1 + n2;
            return "Sum=" + res.ToString();
        }
        [WebMethod]
        public string Subtarct(int n1, int n2)
        {
            int res= n1 - n2;
            return "The result is"+res.ToString();
        }
        [WebMethod]
        public string Multiply(int n1, int n2)
        {
            int res = n1 * n2;
            return "Product=" + res.ToString();
        }
    }
}
