using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppSettingsTest31.Controllers
{
    public class PingController : Controller
    {
        // GET: Ping
        [ProducesResponseType(typeof(Envelope), 200)]
        public IActionResult  Index([FromServices] IWebHostEnvironment environment)
        {
            return Ok(environment.EnvironmentName);
        }

        // GET: Ping/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ping/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ping/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ping/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ping/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ping/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ping/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}