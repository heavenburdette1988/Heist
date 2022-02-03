using System;
using System.Collections.Generic;

namespace Heist
{

    class Program
    {
        static void Main(string[] args)
        {
             
            //   empty list to fill with myTeam using TeamMember  
             List<teamMember> myTeam = new List<teamMember>();
           
           
            Console.WriteLine("Plan your Heist");

            Console.WriteLine("How difficult would you like the bank to be?");
            int bankDifficulty = int.Parse(Console.ReadLine());
            //get bankDifficulty to find to compare it with teams skills below
            // int i = 0;
            // for (int i = 0; i == i; i++){  
                while(true)            {
                //using loop to reiterate questions so we can get multiple team members
                // i++;
            Console.WriteLine($" Enter team member { myTeam.Count + 1}'s name?");
            string name = Console.ReadLine();
                if(name == ""){
                    break;
                }
                // this breaks the loop if no name is entered so you can get total team # and skills to run trials

            Console.WriteLine($" What is the member { myTeam.Count + 1}'s skill level?");
            int skillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine($"What is member {myTeam.Count + 1}'s courage factor?");
            double courageFactor = double.Parse(Console.ReadLine());

            Console.WriteLine($" Hello {name}. Your skill Level is {skillLevel} and your courage factor is {courageFactor}.");
                // teamMember ben = new teamMember();
                // ben.name = "ben";
                teamMember newMember = new teamMember();
                newMember.createTeamMember(name, skillLevel, courageFactor);                
                Console.WriteLine(newMember.name);

               
                myTeam.Add(newMember);
            }

              Console.WriteLine($"There are {myTeam.Count} members on your team. How many trials would you like to run?");
            
             int trials = int.Parse(Console.ReadLine());
                     int failedTrials = 0;
                    int successfulTrails = 0;


            for(int i = 0; i < trials; i++){

           
            
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
                       
                    Console.WriteLine($"Your team Succeeded {successfulTrails} times");
                    Console.WriteLine($"Your team failed {failedTrials} times");

                }

                
        }
    }

