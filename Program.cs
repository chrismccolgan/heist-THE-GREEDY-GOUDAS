using System;

namespace heist_goudas
{
    class Program
    {
        static void Main(string[] args)
        {
            Team newTeam = new Team();
            bool loop = true;

            int BankDifficulty = 100;

            Console.WriteLine("Plan Your Heist!");

            while (loop)
            {
                Console.WriteLine();
                Console.Write("What is your name? ");
                string name = Console.ReadLine();

                if (name != "")
                {
                    Console.Write("What is your skill level? ");
                    string stringSkill = Console.ReadLine();
                    int skill = Int32.Parse(stringSkill);

                    Console.Write("How courageous are you? ");
                    string stringCourage = Console.ReadLine();
                    double courage = double.Parse(stringCourage);

                    TeamMember newMember = new TeamMember(name);
                    newMember.SkillLevel = skill;
                    newMember.CourageFactor = courage;

                    newTeam.AddTeamMember(newMember);
                }
                else
                {
                    loop = false;
                }
            }

            newTeam.DisplayMembers();
            newTeam.SkillSum(BankDifficulty);

            // if (BankDifficulty > newTeam.SkillSum)

        }
    }
}