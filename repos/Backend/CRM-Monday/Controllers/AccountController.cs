using CRM_Monday.Data.DbContexts;
using CRM_Monday.Models.DbContextModels;
using CRM_Monday.Models.InputModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CRM_Monday.Controllers
{
    public class AccountController : Controller
    {
        #region Private Variables
        private readonly UserDbContext _userDbContext;
        #endregion

        #region Constructor
        public AccountController(UserDbContext userDbContext)
        {
            this._userDbContext = userDbContext;
        }
        #endregion

        // GET: AccountController
        public async Task<ActionResult> Index()
        {
            var data = _userDbContext.Users;
            return View();
        }

        public async Task<ActionResult> Registration()
        {
            //var response = new UserLogin();
            //response.Country_Code = //api-call
            return View();
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Register
        [HttpPost]
        public async Task<ActionResult> Register(User user)
        {
            _userDbContext.Users.Add(user);
            _userDbContext.SaveChanges();
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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
