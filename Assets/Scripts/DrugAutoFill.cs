using UnityEngine;
using TMPro;
using System.Collections.Generic;


public class DrugAutoFill : MonoBehaviour
{

    public TMP_InputField userInput;
    public TMP_Text recommendations;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //DrugDatabase.loadDict(); //blanked out since on start program already loads dict
        //when user enters anything in the textbox it runs the OnValueEntered method
        userInput.onValueChanged.AddListener(OnValueEntered);
    }

    //loads a list with drugs as the user is typing and recommends matches.
    void OnValueEntered(string value)
    {
        List<Drug> output = DrugDatabase.nameSearch(value);
        foreach (Drug drug in output)
        {
            //for testing prints out matches to console
            Debug.Log($"{drug.ChemicalName}: {drug.Strength} \n");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
