
using System;
using System.Collections.Generic;
using System.Linq;
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

    //if the din is found then return the drug otherwise error to console
    public static Drug getByDin(int din)
    {
        Drug result;
        
        if (drugStorage.TryGetValue(din, out result))
        {
            return result;
        }
        else
        {
            Debug.Log("error finding Din");
            return null;
        }
    }

    //autocomplete for the textbox
    public static List<Drug> nameSearch(string name)
    {
        List<Drug> acList = new List<Drug>();
        //returns empty list if user types less than 3 characters
        if (name.Length < 3)
        {
            return acList;
        }
        else
        {
            //loops through each drug and loads all potential matches into a list
            foreach (Drug drug in drugStorage.Values)
            {

                if (drug.ChemicalName.StartsWith(name, StringComparison.OrdinalIgnoreCase))
                {
                    acList.Add(drug);
                }
            }
            return acList;
        }

    }

}

