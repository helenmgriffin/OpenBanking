using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeProject;
using CollegeProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CollegeProject.Test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private IConfiguration _configuration;

        public HomeControllerTest(IConfiguration Configuration)
        {
            _configuration = Configuration;
        }
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_configuration);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(_configuration);
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(_configuration);
            // Act
            ViewResult result = controller.Contact() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}