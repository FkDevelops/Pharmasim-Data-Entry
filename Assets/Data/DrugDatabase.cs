
using System.Collections.Generic;
using UnityEngine;

class DrugDatabase
{

    //Dictionary maps a drugs DIN number to an object drug 
    private static Dictionary<int, Drug> drugStorage = new Dictionary<int, Drug>();

    public static void loadDict()
    {
        //import all drugs 
        List<Drug> drugList = DrugData.GetDrugs();

        //loop through the list and add drug object with DIN as the key
        foreach (Drug drug in drugList)
        {
            drugStorage.Add(drug.Din, drug);
        }
    }

    public static Drug getByDin(int din)
    {
        Drug result;
        //if the din is found then return the drug otherwise error to console
        if (drugStorage.TryGetValue(din, out result))
        {
            return drugStorage[din];
        }
        else
        {
            Debug.Log("error finding Din");
            return null;
        }
    }

}

