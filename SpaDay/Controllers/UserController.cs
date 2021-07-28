using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(User newUser)
        {
            return View(newUser); 
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password,
                    Email = addUserViewModel.ContactEmail

                };
                //ViewBag.user = addUserViewModel;
                return View("Index", newUser);
            }
            else
            {
                //ViewBag.error = "Passwords do not match! Try again!";
                //ViewBag.userName = addUserViewModel.Username;
                //ViewBag.email = addUserViewModel.ContactEmail;
                return View("Add", addUserViewModel);
            }
        }

    }
}
