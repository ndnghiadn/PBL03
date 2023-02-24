using CineProject.Data;
using CineProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineProject.Controllers
{
    public class UserController : Controller
    {
        private readonly CineManagementDbContext _context;

        public UserController(CineManagementDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<User> users = _context.Users.ToList();

            return View(users);
        }

        public IActionResult Details(int Id)
        {
            User user = _context.Users.Where(p => p.Id == Id).FirstOrDefault();
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            User user = _context.Users.Where(p => p.Id == Id).FirstOrDefault();
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            User user = _context.Users.Where(p => p.Id == Id).FirstOrDefault();
            return View(user);
        }
        [HttpPost]
        public IActionResult Delete(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _context.Attach(user);
            _context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
