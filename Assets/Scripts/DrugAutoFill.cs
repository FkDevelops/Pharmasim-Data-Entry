using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Threading;


public class DrugAutoFill : MonoBehaviour
{

    public TMP_InputField userInput;
    public TMP_Text recommendations;
    public Transform drugRecommendation;
    public GameObject drugButton;
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
        //destroy all current reccomendations
        foreach(Transform button in drugRecommendation)
        {
            Destroy(button.gameObject);
        }

        //load a list with current results if more than 3 characters
        List<Drug> output = DrugDatabase.nameSearch(value);
        foreach (Drug drug in output)
        {
            //create the button inside drugRecommendation container and name it with the current recommendation and strength
            GameObject recommendation = Instantiate(drugButton, drugRecommendation);
            TMP_Text recommendationText = recommendation.GetComponentInChildren<TMP_Text>();
            recommendationText.text = $"{drug.ChemicalName}: {drug.Strength}";
            //for testing prints out matches to console
            Debug.Log($"{drug.ChemicalName}: {drug.Strength} \n");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
