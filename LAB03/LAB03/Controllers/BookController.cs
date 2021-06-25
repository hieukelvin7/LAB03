using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB03.Models;
namespace LAB03.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            DBBook context = new DBBook();
            var listbook = context.books.ToList();
            return View(listbook);
        }
        [Authorize]
        public ActionResult Buy(int id)
        {
            DBBook context = new DBBook();
            book b = context.books.SingleOrDefault(p => p.id == id);
            if ( b== null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        public ActionResult Details(int id)
        {
            DBBook context = new DBBook();
            book db = context.books.FirstOrDefault(p => p.id == id);
            return View(db);
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(book b)
        {
            DBBook context = new DBBook();
            context.books.AddOrUpdate(b);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            DBBook context = new DBBook();
            book edit = context.books.SingleOrDefault(p => p.id == id);
            return View(edit);
        }
        [HttpPost]
        public ActionResult Edit(int id,book b)
        {
            DBBook context = new DBBook();
            book edit = context.books.SingleOrDefault(p=>p.id==id);
            if (edit != null)
            {
                context.books.AddOrUpdate(b);
                context.SaveChanges();
                return RedirectToAction("ListBook");
            }
            return this.Edit(id);
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            DBBook context = new DBBook();
            book delete = context.books.SingleOrDefault(p => p.id == id);
            return View(delete);
        }
        [HttpPost]
        public ActionResult DeleteBook(int id)
        {
            DBBook context = new DBBook();
            book delete = context.books.SingleOrDefault(p => p.id == id);
            if (delete != null)
            {
                context.books.Remove(delete);
                context.SaveChanges();
               
            }
            return RedirectToAction("ListBook");
        }
    }
    
}
    
