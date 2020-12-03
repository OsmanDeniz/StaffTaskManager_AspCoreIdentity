using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Contexts;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfAppUserRepository : IAppUserDAL
    {
        public List<AppUser> GetNonAdmin()
        {
            using var context = new TaskContext();
            return context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
            {
                user = resultTable.user,
                userRole = resultTable.userRole,
                roles = resultRole
            }).Where(i => i.roles.Name == "Member").Select(i => new AppUser()
            {
                Id = i.user.Id,
                Name = i.user.Name,
                Surname = i.user.Surname,
                Picture = i.user.Picture,
                Email = i.user.Email,
                UserName = i.user.UserName
            }).ToList();
        }
    }
}
