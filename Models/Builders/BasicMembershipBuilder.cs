using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Builders
{
    public class BasicMembershipBuilder : IMembershipBuilder
    {
        private BasicMembership _membership = null;

        public void CreateMembership(int premiumPoints = 0)
        {
            _membership = new BasicMembership();
        }

        public void SetName(string name)
        {
            _membership.Name = name;
        }

        public Membership GetMembership()
        {
            return _membership;
        }
    }
}
