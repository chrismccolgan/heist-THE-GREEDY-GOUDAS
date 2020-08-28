using System;
using System.Collections.Generic;

namespace heist_goudas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your skill level? ");
            string stringSkill = Console.ReadLine();
            int skill = Int32.Parse(stringSkill);

            Console.Write("How courageous are you? ");
            string stringCourage = Console.ReadLine();
            double courage = double.Parse(stringCourage);

            TeamMember firstMember = new TeamMember(name);
            firstMember.SkillLevel = skill;
            firstMember.CourageFactor = courage;

            firstMember.DisplayTeamMember(firstMember);
        }

    }

}