using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kurs1;
using System.Linq;

namespace kurs1.Tests.registration
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            ZOOPARK db = new ZOOPARK();
            Assert.IsNotNull(db.Staff.Where(user => user.Login_staff == "321" && user.Password_staff == "321").FirstOrDefault());
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
    }
}
