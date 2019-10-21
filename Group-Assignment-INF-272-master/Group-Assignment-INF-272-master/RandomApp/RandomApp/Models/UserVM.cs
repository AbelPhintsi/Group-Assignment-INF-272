using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomApp.Models
{
    public class UserVM
    {

        public USER User;

        public void RefreshGUID(DatabaseRandomEntities db)
        {
            db.Configuration.ProxyCreationEnabled = false;
            User.GUID = Guid.NewGuid().ToString();
            User.GUIDExpiry = DateTime.Now.AddMinutes(30);
            var guids = db.USERs.Where(user => user.GUID == User.GUID).Count();

            if (guids > 0)
                RefreshGUID(db);
            else
            {
                var b = db.USERs.Where(zz => zz.ID == User.ID).FirstOrDefault();
                db.Entry(b).CurrentValues.SetValues(User);
                db.SaveChanges();
            }

        }

        public bool UserLoggedIn(DatabaseRandomEntities db)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var guids = db.USERs.Where(user => user.GUID == User.GUID && user.GUIDExpiry > DateTime.Now).Count();
            if (guids > 0)
                return true;
            return false;

        }

        public bool UserLoggedIn(DatabaseRandomEntities db, string UserGUID)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var guids = db.USERs.Where(user => user.GUID == User.GUID && user.GUIDExpiry > DateTime.Now).Count();
            if (User != null)
                return true;
            return false;

        }
    }


}
