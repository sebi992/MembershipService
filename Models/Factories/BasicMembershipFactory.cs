using System;
using System.Collections.Generic;
using System.Text;
using Models.Builders;
using Models.Models;

namespace Models.Factories
{
    public class BasicMembershipFactory : MembershipFactory
    {
        private string _name;
        public BasicMembershipFactory(string Name)
        {
            _name = Name;
        }

        public override Membership GetMembership()
        {
            var builder = new BasicMembershipBuilder();
            builder.CreateMembership();
            builder.SetName(_name);
            return builder.GetBasicMembership();
        }
    }
}
