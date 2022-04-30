using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootBallProject3.Models;

namespace FootBallProject3.Controllers
{
    public class tblFootBallController : Controller
    {
        ado_assignmentEntities db = new ado_assignmentEntities();
        public ActionResult Index()
        {
            //List<tblFootball> result = db.tblFootballs.Where(x => x.Status == win).ToList();
            //return View(result);
            return View(db.tblFootballs.ToList());
        }
    }
}