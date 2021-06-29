using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Builders
{
    public class PremiumMembershipBuilder : IMembershipBuilder
    {
        private PremiumMembership _membership = null;

        public void CreateMembership(int premiumPoints)
        {
            _membership = new PremiumMembership(premiumPoints);
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

