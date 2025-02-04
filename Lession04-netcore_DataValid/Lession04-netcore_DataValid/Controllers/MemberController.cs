using Lession04_netcore_DataValid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Lession04_netcore_DataValid.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members= new List<Member>() { 
        new Member{}
        };
        // GET: MemberController
        public ActionResult Index()
        {
             
            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member )
        {
            var check = true;
            var msg = "";
            if (member.UserName.Length < 3 || member.UserName.Length>20) {
            check = false;
                msg = "<p>Username phải có nhiều hơn 3 ký tự và nhỏ hớn 20 ký tự</p>";
            }
            if (member.FullName.Length < 3 || member.FullName.Length > 20)
            {
                check = false;
                msg += "<p>Fullname phải có nhiều hơn 3 ký tự và nhỏ hớn 20 ký tự</p>";
            }

            var regxEmail = "[\\w+-]+(?:\\.[\\w+-]+)*@[\\w+-]+(?:\\.[\\w+-]+)*(?:\\.[a-zA-Z]{2,4})";
            if (!Regex.IsMatch(member.Email, regxEmail)){
                check = false;
                msg += "<p>Email chưa đúng định dạng</p>";
            }
            if (check)
            {
                members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.msg ="<div class='alert alert-danger'>"+ msg +"</div>";
             
            }
            return View();


        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
