using SXBIN.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SXBIN.DB.DAL;
using SXBIN.DB.Model;
using SXBIN.Tool;

namespace SXBIN.Web.App_Start
{
	public class SystemConfig
	{
		public static void Run()
		{
            int count = B_AdminUser.GetAllCount();
            if (count == 0)
            {
                var adminUser = new AdminUser
                {
                    UserName = "admin",
                    Id = Guid.NewGuid(),
                    Password = Common.Md5Password("123456"),
                    CreateTime = DateTime.Now,
                    IsLocked = false,
                    PhoneNumber = "13456866836",
                    Status = AdminUserStatus.Normal,
                    Token = Guid.NewGuid().ToString(),
                    UserType = UserType.Admin
                };
                B_AdminUser.Add(adminUser);
            }
        }
	}
}