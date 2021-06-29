
using Models.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests
{
    public class BuilderUnitTests
    {
        [Fact]
        public void Should_Build_BasicMembership_From_BasicMembershipBuilder()
        {
            //arrange
            var name = "Sebi";
            var basicMembershipBuilder = new BasicMembershipBuilder();
            basicMembershipBuilder.CreateMembership();
            basicMembershipBuilder.SetName(name);
            //act
            var model = basicMembershipBuilder.GetMembership();
            //assert
            Assert.False(model.CanAccessPool());
            Assert.Equal(name, model.Name);
        }

        [Fact]
        public void Should_Build_PremiumMemberShip_From_PremiumMembershipBuilder()
        {
            //arrange
            var name = "Sebi";
            var premiumMembershipBuilder = new PremiumMembershipBuilder();
            premiumMembershipBuilder.CreateMembership(200);
            premiumMembershipBuilder.SetName(name);
            //act
            var model = premiumMembershipBuilder.GetMembership();
            //assert
            Assert.True(model.CanAccessPool());
            Assert.Equal(name, model.Name);
            Assert.Equal(200, model.PremiumPoints);
        }
    }
}
