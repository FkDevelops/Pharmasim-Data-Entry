
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
        drugHolding.Add(new Drug(18347241, "Acetaminophen", 325, "Caplet", false, false));
        drugHolding.Add(new Drug(18347242, "Acetaminophen", 326, "Caplet", false, false));
        drugHolding.Add(new Drug(18347243, "Acetaminophen", 327, "Caplet", false, false));
        drugHolding.Add(new Drug(18347244, "Acetaminophen", 328, "Caplet", false, false));
        drugHolding.Add(new Drug(18347245, "Acetaminophen", 329, "Caplet", false, false));
        drugHolding.Add(new Drug(18347246, "Acetaminophen", 321, "Caplet", false, false));
        drugHolding.Add(new Drug(18347247, "Acetaminophen", 322, "Caplet", false, false));
        drugHolding.Add(new Drug(18347248, "Acetaminophen", 323, "Caplet", false, false));
        drugHolding.Add(new Drug(18347249, "Acetaminophen", 324, "Caplet", false, false));
        drugHolding.Add(new Drug(18347240, "Acetaminophen", 320, "Caplet", false, false));


        return drugHolding;
    }
    

}


