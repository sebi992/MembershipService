using System;
using System.Collections.Generic;
using System.Text;
using Models.Models;

namespace Models.Builders
{
    class MembershipCreator
    {
        private IMembershipBuilder _membershipBuilder;
        public MembershipCreator(IMembershipBuilder membershipBuilder)
        {
            _membershipBuilder = membershipBuilder;
        }

        public void CreateMembership(string name, int premiumPoints = 0)
        {
            _membershipBuilder.CreateMembership(premiumPoints);
            _membershipBuilder.SetName(name);
        }

        public Membership GetMembership()
        {
            return _membershipBuilder.GetMembership();
        }
    }
}
