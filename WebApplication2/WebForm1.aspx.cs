using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.IService1 iservice = new ServiceReference1.Service1Client();
            ServiceReference1.productData prod = new ServiceReference1.productData();
            prod.ProductQuantity = 10;
            prod.PerProductCost = 21;
            prod.ProductName = "Apple";
            Response.Write(iservice.getTotalCost(prod));
        }
    }
}