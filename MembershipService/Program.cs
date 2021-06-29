
using Models.Factories;
using System;

namespace MembershipService
{
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFactory factory = null;

            Console.WriteLine("Enter the name:");
            var name = Console.ReadLine();

            while (factory == null)
            {
                Console.WriteLine("Enter membership type (Basic or Premium):");
                var membershipType = Console.ReadLine();

                if (membershipType == "Basic")
                {
                    factory = new BasicMembershipFactory(name);

                }
                else if (membershipType == "Premium")
                {
                    Console.WriteLine("Number of premium points:");
                    int points = Int32.Parse(Console.ReadLine());
                    factory = new PremiumMembershipFactory(name, points);
                }
            }

            var newMember = factory.GetMembership();
            newMember.CanAccessPool();
            Console.Read();
        }
    }
}
