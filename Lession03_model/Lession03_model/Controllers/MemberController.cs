using Microsoft.AspNetCore.Mvc;
using Lession03_model.Models.DataModels;
namespace Lession03_model.Controllers
{
    public class MemberController : Controller
    {
      private static List<Member> members = new List<Member>()
    {
        new Member{MemberId = Guid.NewGuid().ToString(), UserName = "member1", password = "123456", Email = "tv1@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), UserName = "member2",  password = "123456", Email = "tv2@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), UserName = "member3", password = "123456", Email = "tv3@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), UserName = "member4", password = "123456", Email = "tv4@gmail.com"},
        new Member{MemberId = Guid.NewGuid().ToString(), UserName = "member5", password = "123456", Email = "tv5@gmail.com"}
    };

        public IActionResult Index()
        {
            Member member = new Member();
            member.MemberId = "1";
            member.UserName = "Devmaster";
            member.Email = "scds@gmail.com";
            member.Phone = "028432687432";
            member.password = "password";
            ViewBag.member = member;
            return View();
        }
         public IActionResult Index1()
        {
            Member member = new Member();
            member.MemberId = "1";
            member.UserName = "Devmaster";
            member.Email = "scds@gmail.com";
            member.Phone = "028432687432";
            member.password = "password";
           
            return View(member);
        }
        public IActionResult GetMembers()
        {

            ViewBag.member = members;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Member member) {
            member.MemberId = Guid.NewGuid().ToString();
            members.Add(member);

        return RedirectToAction("GetMembers");
        }
        public IActionResult Edit(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetMembers");
            }
            var member = members.Where(member => member.MemberId == id).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public IActionResult Edit(Member member)
        {
            for(int i = 0; i < members.Count; i++)
            {
                if (members[i].MemberId == member.MemberId)
                {
                    members[i].UserName = member.UserName;
                    members[i].Email = member.Email;
                    members[i].Phone = member.Phone;
                    members[i].password = member.password;
                   
                }
            }
            return RedirectToAction("GetMembers");
        }
        public IActionResult Delete(string? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetMembers");
            }
            var member = members.Where(member => member.MemberId == id).FirstOrDefault();
            members.Remove(member);
            return RedirectToAction("GetMembers");
        }
        public IActionResult Detail(string id)
        {
            if (id == null) { return RedirectToAction("GetMembers"); }

        
        var member = members.Where(member => member.MemberId == id).FirstOrDefault();

            return View(member);
        }
    }
}
