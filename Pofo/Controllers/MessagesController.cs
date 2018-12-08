﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pofo.Models;

namespace Pofo.Controllers
{
    public class MessagesController : Controller
    {
        private PofoDbEntities db = new PofoDbEntities();
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddContact(Message message)
        {
            if (message.Name == null || message.Email == null || message.Subject == null)
            {
                Session["ContactError"] = true;
                return RedirectToAction("index");
            }
            message.Date = DateTime.Now;
            message.Status = false;

            db.Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        // For Admin panel messages
        public ActionResult ShowMessage()
        {

            return View(db.Message.ToList());
        }
 
        public ActionResult Details(int? id)
        {
            bool a = false;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = db.Message.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }


            if (a == false)
            {
                message.Status = true;
            }
            db.SaveChanges();
            return View(message);
        }
        
        // GET: Messages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = db.Message.Find(id);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }

        // POST: Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Message message = db.Message.Find(id);
            db.Message.Remove(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}