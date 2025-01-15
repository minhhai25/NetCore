﻿using Lab4_netcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab4_netcore.Controllers
{
    public class PeopleController : Controller
    {
        // GET: PeopleController
        public ActionResult Index()
        {
            var _people = DataLocal.GetPeoples();
            return View(_people);
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            People people= new People();

            return View(people);
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection , People model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count()>0 && files[0].Length>0)
                {
                    var file = files[0];
                    var FileName = file.Name;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\Images\\Avatar",FileName);
                    using(var stream = new FileStream(path,FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "Images/Avatar/" + FileName;
                    }
                }
                DataLocal._peoples.Add(model);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.error = ex.Message;
                return View(model);
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            var people = DataLocal.GetPeopleById(id);
            return View(people);
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, People model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count()>0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var FileName = file.Name;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\Avatar", FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "Images/Avatar/" + FileName;
                    }
                }
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples[i]= model;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            var peoples = DataLocal.GetPeopleById(id);
            return View(peoples);
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                for (int i = 0; i < DataLocal._peoples.Count; i++)
                {
                    if (DataLocal._peoples[i].Id == id)
                    {
                        DataLocal._peoples.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
