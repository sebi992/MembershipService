using Models.Factories;
using System;

namespace MembershipService
{
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFactory factory = null;
            Console.WriteLine("Enter membership type:");
            var membershipType = Console.ReadLine();

            Console.WriteLine("Enter the name:");
            var name = Console.ReadLine();
            if (membershipType == "Basic")
            {
                 factory = new BasicMembershipFactory(name);

            }else if(membershipType == "Premium")
            {
                factory = new PremiumMembershipFactory(name);
            }
            var newMember = factory.GetMembership();
            Console.WriteLine($"Can {newMember.Name} Access pool:{newMember.CanAccessPool()}");
        }
    }
}
