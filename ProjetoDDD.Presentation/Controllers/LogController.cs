using projetoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoDDD.Presentation.Controllers
{
    public class LogController : Controller
    {
        private IServiceLog _serviceLog;

        public LogController(IServiceLog serviceLog)
        {
            _serviceLog = serviceLog;
        }

        // GET: Log
        public ActionResult RegistrarAtividade()
        {
            _serviceLog.RegistrarAtividade();
            return View();
        }
    }
}