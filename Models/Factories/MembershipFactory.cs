using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Factories
{
    public abstract class MembershipFactory
    {
        public abstract Membership GetMembership(); 
    }
}
