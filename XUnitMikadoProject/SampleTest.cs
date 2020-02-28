using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using MikadoProject.Controllers;
using MikadoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace XUnitMikadoProject
{
    public class SampleTest
    {
        [Fact]
        public void MyTest_ShouldReturn_true()
        {
            // Creation de la connection
            using(var connection = ContextFactory.CreateDbFactory())
            {
                // Preparation de la data
                User testUser = new User("a", "a", "a", "a", 1);
                ActionResult result = null;

                using(var context = connection.CreateContext())
                {
                    // Execute test
                    var controlleur = new UserController(context);
                    result = controlleur.CreateUser(testUser);
                    connection.Close();
                }

                using (var context = connection.CreateContext())
                {
                    // Validate test
                    var user = context.User.Where(u => u.Nom == testUser.Nom);

                    user.Should().NotBeNull();
                    result.Should().NotBeNull();
                    result.Should().BeOfType<OkResult>();
                    connection.Close();

                }
            }
        }
    }
}
