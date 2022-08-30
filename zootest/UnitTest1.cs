using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace kurs1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Reg()
        {
            bool proverka;
            ZOOPARK db = new ZOOPARK();
            reg();
            if ((db.Staff.Where(user => user.Login_staff == "321" && user.Password_staff == "321").FirstOrDefault()) == null)
            {
               proverka  = true;
            }
            else
            {
                proverka = false;
            }
            Assert.IsNotNull(proverka);
        }

            

        [TestMethod]
        public void Auth()
        {
            ZOOPARK db = new ZOOPARK();
            reg();
            Staff auth = null;
            auth = db.Staff.Where(user => user.Login_staff == "321" && user.Password_staff == "321").FirstOrDefault();
            Assert.IsNotNull(auth);
        }



        public void reg()
        {
            ZOOPARK db = new ZOOPARK();
            string log = "321";
            string passw = "321";
            string Name = "Вася";
            string Surname = "Пупкин";
            string Patronymic = "Алёшкин";
            string position = "Staff";
            Staff regs = new Staff
            {
                Name = Name,
                Surname = Surname,
                Patronymic = Patronymic,
                Position = position,
                Login_staff = log,
                Password_staff = passw,
            };
            db.Staff.Add(regs);
            db.SaveChanges();
        }
        [TestMethod]
        public void UpdateDataGrid()
        {
            bool obnova;
            ZOOPARK db = new ZOOPARK();
            List<Operations> OperL = new List<Operations>();
            OperL = db.Operations.ToList();
            if (OperL != null)
            {
                obnova = true;
            }
            else
            {
                obnova = false;
            }
            Assert.IsTrue(obnova);
        }
        [TestMethod]
        public void RemoveDataGrid()
        {
            ZOOPARK db = new ZOOPARK();
            reg();
            bool del;
                db.Staff.Remove(db.Staff.Where(user => user.Login_staff == "321" && user.Password_staff == "321").FirstOrDefault());
                db.SaveChanges();

            if ((db.Staff.Where(user => user.Login_staff == "321" && user.Password_staff == "321").FirstOrDefault()) == null)
            {
                del = true;
                
            }
            else
            {
                del = false;
            }
            Assert.IsFalse(del);
        }
    }
}
