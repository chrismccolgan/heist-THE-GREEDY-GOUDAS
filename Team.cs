using System;
using System.Collections.Generic;

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
            foreach (TeamMember person in AllTeamMembers)
            {
                Console.WriteLine($"NAME: {person.Name}");
                Console.WriteLine($"SKILL LEVEL: {person.SkillLevel}");
                Console.WriteLine($"COURAGEOUSNESS: {person.CourageFactor}");
                Console.WriteLine();
            }
        }
    }
}