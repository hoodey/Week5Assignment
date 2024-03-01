using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    //GameController Variables
    [SerializeField] TMP_InputField input;          //The input field for answers
    [SerializeField] TMP_Text output;
    [SerializeField] static float clearOutputTimer = 3f;
    public string playerAnswer = "";                //Variable to hold answers
    bool guessed = false;
    [SerializeField] GameObject model;
    

    // Start is called before the first frame update
    void Start()
    {
        input.characterLimit = 5;                   //Only allow 5 letter answers
        input.onValidateInput += delegate (string input, int charIndex, char addedChar) { return ValidateAnswer(addedChar); };
        
    }

    // Update is called once per frame
    void Update()
    {
        //Clear the output every 3 seconds for wrong guesses
        if (guessed)
        {
            clearOutputTimer -= Time.deltaTime;
            if (clearOutputTimer <= 0f)
            {
                output.text = "";
                clearOutputTimer = 3f;
                guessed = false;
            }
        }

    }

    private char ValidateAnswer(char charToValidate)
    {
        //check if alpha
        if (Char.IsLetter(charToValidate))
        {
            return charToValidate;
        }
        else
            return '\0';
    }
    //Function to control submitting answers
    public void submit()
    {
        guessed = true;
        playerAnswer = input.text;
        if (Model.IsValidGuess(playerAnswer))
        {
            Model.userGuess = playerAnswer;
            input.text = "";
            Model m = model.GetComponent<Model>();
            m.UpdateCells();
        }
        else
        {
            output.text = "Invalid Word!";
        }

    }
    //Function to control winning the game
    public void WinGame()
    {

    }
    //Function to control what happens when you lose the game
    public void LoseGame()
    {

    }

    //Function to reset game state
    public void reset()
    {
        SceneManager.LoadScene("WordleScreen");
    }
}
