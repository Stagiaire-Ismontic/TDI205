using WindowsFormsApp2.Data;
using WindowsFormsApp2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2.Services
{

    public class AdminService
    {
        private AppModel _Context; 

        public AdminService()
        {
            _Context = new AppModel();
        }


        public void Add(Admins ad) {
            this._Context.admins.Add(ad);
            this._Context.SaveChanges();
        }


        public void Delete(int id) {
            var db_admin = this._Context.admins.Find(id);
            if (db_admin != null)
            {
                _Context.admins.Remove(db_admin);
                _Context.SaveChanges();
            }
    
        }

       
        public void Update(Admins a) {
            var db_admin = this._Context.admins.Find(a.Id);
            if (db_admin != null)
            {
                db_admin.Nom = a.Nom;
                db_admin.Prenom = a.Prenom;
                db_admin.Passwsord = a.Passwsord;
                _Context.SaveChanges();
            }
        }

        

        public List<Admins> getAdmins() {
           return  _Context.admins.ToList();
        }
    }
}
