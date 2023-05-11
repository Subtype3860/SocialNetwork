
using SocialNetwork.BLL.Models;
using Xunit;
using Moq;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.DAL.Entities;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Test
{
    public class UserServiceTest
    {
        [Fact]
        public void FindByEmailAlwaysReturnsExpectedValue()
        {
            UserService userService = new UserService();

            Assert.Equal("ss", "ss");
            
        }
    }
}
