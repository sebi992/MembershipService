using Models.Factories;
using System;

namespace MembershipService
{
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFactory factory = null;
            var membershipType = Console.ReadLine();

            var name = Console.ReadLine();
            if (membershipType == "Basic")
            {
                 factory = new BasicMembershipFactory(name);

            }else if(membershipType == "Premium")
            {
                factory = new PremiumMembershipFactory(name);
            }
            var newMember = factory.GetMembership();
            newMember.CanAccessPool();
        }
    }
}
