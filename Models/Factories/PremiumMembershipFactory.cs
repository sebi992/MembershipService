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


        public PremiumMembershipFactory(string Name)
        {
            _name = Name;
        }

        public override Membership GetMembership()
        {
            var builder = new PremiumMembershipBuilder();
            builder.CreateMembership(100);
            builder.SetName(_name);
            return builder.GetPremiumMembership();
        }
    }
}
