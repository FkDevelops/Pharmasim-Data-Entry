using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.UI;
using System;

public class DrugAutoFill : MonoBehaviour
{

    public TMP_InputField userInput;
    public TMP_Text recommendations;
    public Transform drugRecommendation;
    public GameObject drugButton;
    private Drug selectedDrug;
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
            recommendation.GetComponent<Button>().onClick.AddListener(() => OnButtonClicked(drug));
            TMP_Text recommendationText = recommendation.GetComponentInChildren<TMP_Text>();
            recommendationText.text = $"{drug.ChemicalName}: {drug.Strength}";

            /*Testing recommendation to console
            Debug.Log($"{drug.ChemicalName}: {drug.Strength} \n");
            */
        }

    void OnButtonClicked(Drug drug)
        {
            selectedDrug = drug;
            userInput.text = $"{drug.ChemicalName}: {drug.Strength}";
            //test by printing to log to see if din differs
            Debug.Log($"The din for {drug.ChemicalName} is {drug.Din}");
            //destroy all current reccomendations
            foreach (Transform button in drugRecommendation)
            {
                Destroy(button.gameObject);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
