using System;

namespace heist_goudas
{
    class Program
    {
        static void Main(string[] args)
        {
            Team newTeam = new Team();
            bool loop = true;

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

            //After the user enters the team information, prompt them to enter the number of trial runs the program should perform.

            Console.Write("How many test runs? ");

            string StringRuns = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("------------");
            int runs = Int32.Parse(StringRuns);
            for (int i = 0; i < runs; i++)
            {

                Console.WriteLine();
                Console.WriteLine("-----");

                int luck = new Random().Next(-10, 10);
                Console.WriteLine($"Your luck: {luck}");
                int BankDifficulty = 100 + luck;
                newTeam.SkillSum(BankDifficulty);

                Console.WriteLine("-----");
                Console.WriteLine();
            }

        }
    }
}