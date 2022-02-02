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
        Console.WriteLine("How difficult would you like the bank to be?");
        int bankDifficulty = int.Parse(Console.ReadLine());
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

              Console.WriteLine($"There are {myTeam.Count} members on your team. How many trials would you like to run?");
            
             int trials = int.Parse(Console.ReadLine());
                     int failedTrials = 0;
                    int successfulTrails = 0;


            for(int i = 0; i< trials; i++){

           
            
            int luckFactor = new Random().Next(-10, 10);
            int bankTotalDifficulty = bankDifficulty + luckFactor;

            int teamSkillLevel = 0;

           

            foreach(teamMember member in myTeam){
                teamSkillLevel += member.skillLevel;
            };

             Console.WriteLine($"The team's skill level is {teamSkillLevel}");
            Console.WriteLine($"The banks's difficulty level is {bankTotalDifficulty}");

            if (teamSkillLevel > bankTotalDifficulty)
            {
                Console.WriteLine("Congrats");
                    successfulTrails += 1;
                        }else{
                            Console.WriteLine("Do Better! Get a new team!");
                            failedTrials += 1;
                        }

                    

             Console.WriteLine(teamSkillLevel);
            }

        
                // foreach(teamMember teamMember in myTeam)
                // {
                //     Console.WriteLine(teamMember.name);
                //     Console.WriteLine(teamMember.skillLevel);
                //     Console.WriteLine(teamMember.courageFactor);
                // }
                
                        
                    Console.WriteLine($"Your team Suceeded {successfulTrails} times");
                    Console.WriteLine($"Your team failed {failedTrials} times");

                }

                
        }
    }

