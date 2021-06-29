using System;
using System.Collections.Generic;
using System.Text;
using Models.Models;

namespace Models.Builders
{
    interface IMembershipBuilder
    {
        void CreateMembership(int premiumPoints = 0);
        void SetName(string name);
        Membership GetMembership();
    }
}
