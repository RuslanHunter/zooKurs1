using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ZOOPARK db = new ZOOPARK();
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(db.Staff.Where(user => user.Login_staff == "321" && user.Password_staff == "321"));
        }

        public void reg()
        {
            
            string log = "321";
            string passw = "321";
            string Name = "Vasya";
            string Surname = "Pupkin";
            string Patronymic = "Pupochkin";
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