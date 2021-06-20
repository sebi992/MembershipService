using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public abstract class Membership
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public AccessLevel AccessLevel { get; }
        public int PremiumPoints { get; set; }
        public Membership(AccessLevel accessLevel) { 
            this.AccessLevel = accessLevel;
            
        }

        public bool CanAccessPool()
        {
            if (AccessLevel == AccessLevel.Premium)
            {
                Console.WriteLine($"Member {Name} with access level {AccessLevel} can go to pool");
                return true;
            }
            else
            {
                Console.WriteLine($"Member {Name} with access level {AccessLevel} can not go to pool");
                return false;
            }
        }
    }
}
