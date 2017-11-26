using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using TestVirtualMind.Controllers;
using TestVirtualMind.Mocks;
namespace UnitTestProject2
{
    [TestClass]
    public class UserControllerTest
    {
        private object UserController;

        [TestMethod]
        public void Creation_test()
        {
            var controlller = new UserController(new UserManagerMock());
            var result = controlller.CreateUser(new TestVirtualMind.Entidades.Usuario() { Apellido = "a", Nombre = "b", Email = "a", Password = "j" });
            Assert.IsTrue(result.GetType().Equals(typeof(OkResult)));

        }

        [TestMethod]
        public void Update_test_fail()
        {
            var controlller = new UserController(new UserManagerMock());
            var result = controlller.UpdateUser(new TestVirtualMind.Entidades.Usuario() { Apellido = "a", Nombre = "b", Email = "a", Password = "j" });
            Assert.IsFalse(result.GetType().Equals(typeof(OkResult)));

        }

        [TestMethod]
        public void Delete_test_success()
        {
            var controlller = new UserController(new UserManagerMock());
            var result = controlller.DeleteUser(1);
            Assert.IsTrue(result.GetType().Equals(typeof(OkResult)));

        }
    }
}
