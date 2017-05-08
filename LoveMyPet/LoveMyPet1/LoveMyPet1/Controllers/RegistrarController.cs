using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.OleDb;
using System.Data;

namespace LoveMyPet1.Controllers
{
    public class RegistrarController : Controller
    {
        

        public ActionResult Index()
        {
            string Proveedor = @"Provider=Microsoft.Jet.OLDB.4.0;DataSource=Z:\LoveMyPet\LoveMyPet1\LoveMyPet.mdb";
        OleDbConnection conn= new OleDbConnection();
        conn.ConnectionString = Proveedor;
        conn.Open();
            return View();
        }

    }
}
