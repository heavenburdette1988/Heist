using System;
using System.Collections.Generic;
// create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.


namespace Heist {


//team member object to build team members
    public class teamMember 
    {  //created a class for teamMember 
        public string name { get; set; }
        public int skillLevel { get; set; }
        public double courageFactor { get; set; }

// CreateTeamMember method
    public void createTeamMember(string nameInput, int skillLevelInput, double courageFactorInput)
    {
        name = nameInput;
        skillLevel = skillLevelInput;
        courageFactor= courageFactorInput;
    }


    }

}