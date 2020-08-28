using System;
using System.Collections.Generic;
using System.Linq;

namespace heist_goudas
{
    public class Team
    {
        private List<TeamMember> AllTeamMembers { get; set; }
        public Team()
        {
            AllTeamMembers = new List<TeamMember>();
        }
        public void AddTeamMember(TeamMember member)
        {
            AllTeamMembers.Add(member);
        }
        public void DisplayMembers()
        {
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("THE TEAM:");
            Console.WriteLine("-------------");
            foreach (TeamMember person in AllTeamMembers)
            {
                Console.WriteLine($"NAME: {person.Name}");
                Console.WriteLine($"SKILL LEVEL: {person.SkillLevel}");
                Console.WriteLine($"COURAGEOUSNESS: {person.CourageFactor}");
                Console.WriteLine();
            }
        }

        ///Sum the skill levels of the team. Save that number.
        public void SkillSum(int bankLevel)
        {
            int totalSkill = AllTeamMembers.Sum(memberSkill => memberSkill.SkillLevel);
            Console.WriteLine($"Your team's total skill level: {totalSkill}");
            Console.WriteLine($"The Bank's Difficulty: {bankLevel}");
            if (totalSkill >= bankLevel)
            {
                Console.WriteLine("Congratulations, you have successfully robbed a bank.  I hope you feel good about yourself, I guess...");
            }
            else
            {
                Console.WriteLine("Hope you have a good lawyer...");
            }
        }
    }
}