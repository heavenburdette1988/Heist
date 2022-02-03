using System;
using System.Collections.Generic;

namespace Heist
{
                // created a class for teamList
        public class teamList{
         List<teamMember> myTeam {get; set;} = new List<teamMember>();

         public void addMember( teamMember person) 
         {
             myTeam.Add(person);
         }
    }
}