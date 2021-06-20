using Models.Factories;
using Models.Models;
using System;
using Xunit;

namespace UnitTests
{
    public class FactoryTestUnit
    {
        [Fact]
        public void Should_Create_BasicMembership_From_BasicMembershipFactory()
        {
            //arrange
            var name = "Aurel";
            var basicMembershipFactory = new BasicMembershipFactory(name);
            //act
            var model = basicMembershipFactory.GetMembership();
            //assert
            Assert.Equal(AccessLevel.Basic, model.AccessLevel);
            Assert.Equal(name, model.Name);
        }

        [Fact]
        public void Should_Create_PremiumMembership_From_PremiumMembershipFactory_With_PremiumPoints()
        {
            //arrange
            var name = "Aurel";
            var premiumMembershipFactory = new PremiumMembershipFactory(name);
            //act
            var model = premiumMembershipFactory.GetMembership();
            //assert
            Assert.Equal(100, model.PremiumPoints);
            Assert.Equal(AccessLevel.Premium, model.AccessLevel);
            Assert.Equal(name, model.Name);
        }
    }
}
