using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Builders
{
    public class BasicMembershipBuilder
    {
        private BasicMembership _membership = null;

        public void CreateMembership()
        {
            _membership = new BasicMembership();
        }

        public void SetName(string name)
        {
            _membership.Name = name;
        }

        public BasicMembership GetBasicMembership()
        {
            return _membership;
        }
    }
}
