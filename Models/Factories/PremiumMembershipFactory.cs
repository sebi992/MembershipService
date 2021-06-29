using System;
using System.Collections.Generic;
using System.Text;
using Models.Builders;
using Models.Models;

namespace Models.Factories
{
    public class PremiumMembershipFactory : MembershipFactory
    {
        private string _name;
        private int _premiumPoints;


        public PremiumMembershipFactory(string Name, int premiumPoints)
        {
            _name = Name;
            _premiumPoints = premiumPoints;
        }

        public override Membership GetMembership()
        {
            var membershipCreator = new MembershipCreator(new PremiumMembershipBuilder());
            membershipCreator.CreateMembership(_name, _premiumPoints);
            return membershipCreator.GetMembership();
        }
    }
}
