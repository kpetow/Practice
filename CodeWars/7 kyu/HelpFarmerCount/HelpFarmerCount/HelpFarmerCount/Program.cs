using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bob can only count total number of heads, total number of legs and total number of horns of animals on the farm. Help Bob to figure out how many 
//    chickens, rabbits and cows does he have?

//All chickens have 2 legs, 1 head and no horns; all rabbits have 4 legs, 1 head and no horns; all cows have 4 legs, 1 head and 2 horns.

//Your task is to write a function

//get_animals_count(legs_number, heads_number, horns_number)
//Dictionary<string, int> get_animals_count(int legs_number, int heads_number, int horns_number)
//
//, which returns a dictionary

//{"rabbits" : rabbits_count, "chickens" : chickens_count, "cows" : cows_count}
//new Dictionary<string, int>() { { "rabbits", rabbits_count }, { "chickens", chickens_count }, { "cows", cows_count } }
//Parameters legs_number, heads_number, horns_number are integer, all tests have valid input.

//Example:

//get_animals_count(34, 11, 6); # Should return {"rabbits" : 3, "chickens" : 5, "cows" : 3}
//get_animals_count(154, 42, 10); # Should return {"rabbits" : 30, "chickens" : 7, "cows" : 5}
//get_animals_count(34, 11, 6); //Should return  Dictionary<string, int>(){{"rabbits", 3},{"chickens", 5},{"cows", 3}}
//get_animals_count(154, 42, 10); //Should return Dictionary<string, int>(){{"rabbits", 30},{"chickens", 7},{"cows", 5}}

namespace HelpFarmerCount
{
    public Dictionary<string, int> get_animals_count(int legs_number, int heads_number, int horns_number)
    {
        int rabbits;
        int chickens;
        int cows;

        cows = horns_number / 2;
        
        legs_number -= cows * 4; //total legs of chickens and rabbits
        heads_number -= cows; //total number of rabbits + chickens

        rabbits = (legs_number - 2*heads_number)/2;

        chickens = heads_number - rabbits;

        Dictionary<string, int> result = new Dictionary<string, int>();
        result.Add("rabbits", rabbits);
        result.Add("chickens", chickens);
        result.Add("cows", cows);

        return result;
    }
}