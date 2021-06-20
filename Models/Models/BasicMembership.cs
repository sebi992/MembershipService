using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class BasicMembership : Membership
    {
        public BasicMembership() : base(AccessLevel.Basic)  //Construiesc clasa de baza cu accesul corespunzator
        {

        }
    }
}
