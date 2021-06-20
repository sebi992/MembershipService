using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class PremiumMembership : Membership
    {
        
        public PremiumMembership(int premiumPoints) : base(AccessLevel.Premium)// premiumPoints)
        {
            PremiumPoints = premiumPoints;
        }
    }
}
