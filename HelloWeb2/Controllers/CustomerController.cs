using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWeb2.Models;

namespace HelloWeb2.Controllers
{
    public class CustomerBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string custCode = objContext.Request.Form["txtCustomerCode"];
            string custName = objContext.Request.Form["txtCustomerName"];

            Customer obj = new Customer()
            {
                CustomerCode = custCode,
                CustomerName = custName
            };
            return obj;
        }
    }
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj = new Customer
            {
                CustomerCode = "1001",
                CustomerName = "RajName"
            };
            return View("CustomerView", obj);
        }

        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }

        public ActionResult SubmitAct1([ModelBinder(typeof(CustomerBinder))]
            Customer obj)
        {
            //CustomerBinder
            /*Customer obj = new Customer
            {
                CustomerCode = Request.Form["CustomerCode"],
                CustomerName = Request.Form["CustomerName"]
            };*/
            return View("CustomerView", obj);
        }
    }
}