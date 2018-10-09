using CandyApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using Xunit;

namespace CandyApp.Tests
{
    public class HomeControllerTests
    {
        private ICandyRepository candyRepo;
        private HomeController underTest;

        public HomeControllerTests()
        {
            candyRepo = Substitute.For<ICandyRepository>();
            underTest = new HomeController(candyRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_AllCandies()
        {
            underTest.Index();

            candyRepo.Received().GetAll();
        }
    }
}
