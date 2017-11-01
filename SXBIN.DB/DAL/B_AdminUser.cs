using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMA.DB;
using SXBIN.DB.Model;

namespace SXBIN.DB.DAL
{
    public class B_AdminUser
    {
        public static AdminUser Login(string userName,string password)
        {
            using (var db=new DBContext())
            {
                var model = db.AdminUser.FirstOrDefault(x => x.UserName == userName && x.Password == password && x.UserType==UserType.Admin);
                return model;
            }
        }

        public static AdminUser FindById(Guid id)
        {
            using (var db = new DBContext())
            {
                var model = db.AdminUser.FirstOrDefault(x => x.Id==id);
                return model;
            }
        }


        public static int GetAllCount()
        {
            using (var db = new DBContext())
            {
                return db.AdminUser.Count();
            }

        }

        public static bool Add(AdminUser user)
        {
            using (var db=new DBContext())
            {
                db.AdminUser.Add(user);
                return db.SaveChanges() > 0;
            }
        }
    }
}
