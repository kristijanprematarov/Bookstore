using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Service
{
    public class UserService : IUserService
    {
        /// <summary>
        /// Get all existing roles to fillup dropdownlist for RoleId, currentRole is optional because it is used in EditUser
        /// </summary>
        public IQueryable<SelectListItem> GetSelectListRoles(IQueryable<IdentityRole> roles, string currentRole = "")
        {
            var selectList = new List<SelectListItem>();

            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select role..."
            });

            foreach (var role in roles)
            {
                if (role.Name.Equals(currentRole))
                {
                    selectList.Add(new SelectListItem
                    {
                        Value = role.Id,
                        Text = role.Name,
                        Selected = true
                    });
                }
                else
                {
                    selectList.Add(new SelectListItem
                    {
                        Value = role.Id,
                        Text = role.Name
                    });
                }
            }

            return selectList.AsQueryable();
        }

    }
}
