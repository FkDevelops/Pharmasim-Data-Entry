using UnityEngine;

public class DatabaseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrugDatabase.loadDict();
        //prints the name of the drug as a test
        Drug test = DrugDatabase.getByDin(23049649);
        Debug.Log(test.ChemicalName);
        //prints out an error
        test = DrugDatabase.getByDin(23293);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
