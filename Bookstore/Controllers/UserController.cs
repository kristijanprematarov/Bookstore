namespace Bookstore.Controllers
{
    using Bookstore.Areas.Identity;
    using Bookstore.Service.Interfaces;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Roles = "admin")]
    public class UserController : Controller
    {
        //Identity --> no need for private READONLY !
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IPasswordHasher<IdentityUser> _passwordHasher;
        private readonly IUserService _userService;

        public UserController(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IPasswordHasher<IdentityUser> passwordHasher,
            IUserService userService)
        {
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._passwordHasher = passwordHasher;
            this._userService = userService;
        }


        // GET: UserController
        public ActionResult Index()
        {
            var users = _userManager.Users;
            return View(users);
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            IdentityUser theUser = await _userManager.FindByIdAsync(id);

            if (theUser != null)
            {
                var getUserRoles = await _userManager.GetRolesAsync(theUser);

                var roles = _roleManager.Roles;

                var roleID = "";

                foreach (var role in roles)
                {
                    if (role.Name == getUserRoles[0])
                    {
                        roleID += role.Id;
                    }
                }

                var userModel = new UserModel
                {
                    Id = theUser.Id,
                    Email = theUser.Email,
                    Name = theUser.UserName,
                    RoleId = roleID,
                    RoleName = getUserRoles[0],
                };

                return View(userModel);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            var roles = _roleManager.Roles;
            var userModel = new UserModel();
            userModel.Roles = _userService.GetSelectListRoles(roles, "");

            return View(userModel);
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                //Mapping
                IdentityUser appUser = new IdentityUser
                {
                    UserName = userModel.Name,
                    Email = userModel.Email,
                    EmailConfirmed = true //directly handling Authorization
                };

                //Result

                IdentityResult result = await _userManager.CreateAsync(appUser, userModel.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, userModel.RoleName); //form the UserRole row in the Linking table UserRole

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(userModel);
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            IdentityUser theUser = await _userManager.FindByIdAsync(id);

            var roles = _roleManager.Roles;

            if (theUser != null)
            {
                var getUserRoles = await _userManager.GetRolesAsync(theUser);

                var userModel = new UserModel
                {
                    Id = theUser.Id,
                    Email = theUser.Email,
                    Roles = _userService.GetSelectListRoles(roles, getUserRoles[0]),
                };

                return View(userModel);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, string email, string password, string roleName)
        {
            IdentityUser theUser = await _userManager.FindByIdAsync(id);

            var getUserRoles = await _userManager.GetRolesAsync(theUser);

            if (theUser != null)
            {
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrWhiteSpace(email))
                    theUser.Email = email;
                else
                    ModelState.AddModelError("", "Email cannot be empty");

                //if (!string.IsNullOrEmpty(password) && !string.IsNullOrWhiteSpace(password))
                //    theUser.PasswordHash = _passwordHasher.HashPassword(theUser, password);
                //else
                //    ModelState.AddModelError("", "Password cannot be empty");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrWhiteSpace(email))
                {
                    IdentityResult result = await _userManager.UpdateAsync(theUser);
                    if (result.Succeeded)
                    {
                        await _userManager.RemoveFromRoleAsync(theUser, getUserRoles[0]);
                        await _userManager.AddToRoleAsync(theUser, roleName);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return RedirectToAction(nameof(Index));
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            IdentityUser theUser = await _userManager.FindByIdAsync(id);

            if (theUser != null)
            {
                var getUserRoles = await _userManager.GetRolesAsync(theUser);

                var roles = _roleManager.Roles;

                var roleID = "";

                foreach (var role in roles)
                {
                    if (role.Name == getUserRoles[0])
                    {
                        roleID += role.Id;
                    }
                }

                var userModel = new UserModel
                {
                    Id = theUser.Id,
                    Email = theUser.Email,
                    Name = theUser.UserName,
                    RoleId = roleID,
                    RoleName = getUserRoles[0],
                };

                return View(userModel);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }

        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(UserModel userModel)
        {
            string userId = userModel.Id;
            IdentityUser theUser = await _userManager.FindByIdAsync(userId);

            if (theUser != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(theUser);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return RedirectToAction(nameof(Index));
        }


    }
}
