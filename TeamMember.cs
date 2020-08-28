using System;

namespace heist_goudas
{
    public class TeamMember
    {
        private string _name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public TeamMember(string name)
        {
            _name = name;
        }
        public void DisplayTeamMember(TeamMember person)
        {
            Console.WriteLine($"NAME: {person._name}");
            Console.WriteLine($"SKILL LEVEL: {person.SkillLevel}");
            Console.WriteLine($"COURAGEOUSNESS: {person.CourageFactor}");

        }
    }
}

// name, a skill Level and a courage factor

/*
 public void DisplayBuilding(Building building)
        {
            Console.WriteLine(building._address);
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Designed by {building._designer}");
            Console.WriteLine($"Constructed on {building._dateConstructed}");
            Console.WriteLine($"Owned by {building._owner}");
            Console.WriteLine($"{building.volume} cubic meters of space");

        }
*/