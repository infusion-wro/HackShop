using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackShop.Models;

namespace HackShop.Controllers
{
    [Authorize]
    public class CommentsController : Controller
    {
        
        static List<CommentModel> _comments = new List<CommentModel>()
        {
            new CommentModel()
            {
                Author = "Author KI",
                Comment = "Comment 1",
                Date = new DateTime(2011,11,11),
                Title = "Comment title 1"
            }
        };
        //
        // GET: /Comments/
        public ActionResult Index()
        {

            return View(_comments);
        }

        //
        // GET: /Comments/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Comments/Create
        [HttpPost]
        public ActionResult Create(CommentModel model)
        {
            try
            {
                var name = System.Web.HttpContext.Current.User.Identity.Name;
                model.Author = name;
                model.Date = DateTime.Now;
                _comments.Add(model);
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
    }
}
