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


                foreach(teamMember teamMember in myTeam)
                {
                    Console.WriteLine(teamMember.name);
                    Console.WriteLine(teamMember.skillLevel);
                    Console.WriteLine(teamMember.courageFactor);
                }
                }

        }
    }

