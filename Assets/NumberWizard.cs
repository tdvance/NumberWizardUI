using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	
	int max;
	int min;
	int guess;
    int maxGuessesAllowed;

    public Text text;

    void Start () {
		min = 1;
		max = 1000;
		guess = 500;
        maxGuessesAllowed = 10;
        text.text = guess.ToString() + "?";
    }

    public void GuessLower()
    {
        max = guess - 1;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    void NextGuess(){
		guess = (min + max) / 2;
        text.text = guess.ToString() + "?";
        maxGuessesAllowed -= 1;
        if(maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
	
}
