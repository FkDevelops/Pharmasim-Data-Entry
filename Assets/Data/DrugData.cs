
using System.Collections.Generic;
class DrugData
{

    public static List<Drug> GetDrugs()
    {
        List<Drug> drugHolding = new List<Drug>();
        //Creating Drug Objects
        drugHolding.Add(new Drug(23049648, "Amoxicillin", 250, "Tablet", false, true));
        drugHolding.Add(new Drug(23049649, "Amoxicillin", 500, "Tablet", false, true));
        drugHolding.Add(new Drug(89023845, "Oxycodone", 5, "Tablet", true, true));
        drugHolding.Add(new Drug(18347248, "Acetaminophen", 325, "Caplet", false, false));
        

        return drugHolding;
    }
    

}


