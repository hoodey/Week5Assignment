using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    //Variables to init on program start
    [SerializeField] TMP_Text greeting;
    TMP_Text score;

    // Start is called before the first frame update
    void Start()
    {
        //Set current score text on screen
        score.text = "The correct answer was: " + Model.currentAnswer + "\nYou guessed " + (Model.numGuesses+1).ToString() + " times!";
        //Output based on how many guesses
        if (Model.numGuesses <= 5 )
        {
            greeting.text = "Congratulations! You did it!";//Winning Guess
        }
        else
        {
            greeting.text = "Better luck next time!";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Create a function to transition scenes on mouse click and reset the round score
    public void restart()
    {
        SceneManager.LoadScene("WordleScreen");
    }

    //Create a function to end the game
    public void quit()
    {
        Application.Quit();
    }
}
