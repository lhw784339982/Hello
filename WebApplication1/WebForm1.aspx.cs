using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            form1.InnerHtml = "<div id='" + r.Next(999999) + "' style='color:#" + (int)(r.NextDouble() * 1000000) + ";text-align:center;font-size:40px'>" + DateTime.Now.ToString() + "</div>";
        }
    }
}