namespace Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Services;

    /// <summary>
    /// Description résumée de LemonWayService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class LemonWayService : System.Web.Services.WebService
    {
        /// <summary>
        /// Calculate the Nth value in the Fibonacci sequence   
        /// </summary>
        /// <param name="n">Input value</param>
        /// <returns></returns>
        [WebMethod]
        public Int64 Fibonacci(int n)
        {             
            return FibonacciService.Compute(n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {
            return XmlToJsonService.GetJson(xml);
        }
    }
}
