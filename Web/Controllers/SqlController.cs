using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class SqlController : Controller
    {
        // GET: Sql
        public string Index() {

            var str = ConfigurationManager.AppSettings["webpages:Enabled"];
            var conn = new SqlConnection();
            return str;
        }
    }
}