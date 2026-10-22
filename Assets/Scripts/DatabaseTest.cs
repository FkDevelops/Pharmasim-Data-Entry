using UnityEngine;
using System.Collections.Generic;

public class DatabaseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrugDatabase.loadDict();

        //tests 
        /*prints the name of the drug as a test
        Drug test = DrugDatabase.getByDin(23049649);
        Debug.Log(test.ChemicalName);
        //prints out an error
        test = DrugDatabase.getByDin(23293);

        //Test autofill
        List<Drug> amox = DrugDatabase.nameSearch("amOx");
        List<Drug> fail = DrugDatabase.nameSearch("xyz");
        List<Drug> oxy = DrugDatabase.nameSearch("OxYc");
        //returns oxycodone to the console
        foreach (Drug drug in oxy)
        {
            Debug.Log(drug.ChemicalName);
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
