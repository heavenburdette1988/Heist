using System;
using System.Collections.Generic;

namespace Heist
{

    class Program
    {
        static void Main(string[] args)
        {
             
             
             
             List<teamMember> myTeam = new List<teamMember>();
           
           
            Console.WriteLine("Plan your Heist");
            for (int i = 0; i == i; i++){
            Console.WriteLine(" What is your name?");
            string name = Console.ReadLine();
                if(name == ""){
                    break;
                }
            Console.WriteLine(" What is your skill level?");
            int skillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your courage factor?");
            double courageFactor = double.Parse(Console.ReadLine());

            Console.WriteLine($" Hello {name}. Your skill Level is {skillLevel} and your courage factor is {courageFactor}.");

                var newMember = new teamMember();
                newMember.createTeamMember(name, skillLevel, courageFactor);                
                Console.WriteLine(newMember.name);

               
                myTeam.Add(newMember);
            }

              Console.WriteLine($"There are {myTeam.Count} members on your team.");
              //need to get this to work
            int bankDifficulty = 100;
            int luckFactor = new Random().Next(-10, 10);
            int bankTotalDifficulty =bankDifficulty + luckFactor;

            int teamSkillLevel = 0;

           ;

            foreach(teamMember member in myTeam){
                teamSkillLevel += member.skillLevel;
            };

             Console.WriteLine($"The team's skill level is {teamSkillLevel}");
            Console.WriteLine($"The banks's difficulty level is {bankTotalDifficulty}");

            if (teamSkillLevel > bankTotalDifficulty)
            {
                Console.WriteLine("Congrats");
                        }else{
                            Console.WriteLine("Do Better! Get a new team!");
                        }

                    

             Console.WriteLine(teamSkillLevel);
        
                // foreach(teamMember teamMember in myTeam)
                // {
                //     Console.WriteLine(teamMember.name);
                //     Console.WriteLine(teamMember.skillLevel);
                //     Console.WriteLine(teamMember.courageFactor);
                // }
                }

        }
    }

