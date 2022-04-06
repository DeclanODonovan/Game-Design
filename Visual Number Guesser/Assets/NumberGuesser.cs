using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberGuesser : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int count = 1; // Number of guesses made, will be updated
    int guess = 0; // The current guess (placeholder)
    int maxGuesses = 10;
    public Text guessText;
    


    

    // Start is called before the first frame update
    void Start()
    {
        

        new_guess();
    }

    void new_guess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        maxGuesses--;
        if (maxGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }


    }
    public void GuessHigher()
    {
        min = guess + 1;
        count++;
        new_guess();
    }
    public void GuessLower()
    {
        max = guess - 1;
        count++;
        new_guess();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess + 1;
            count++; //Increases count by 1
            new_guess();
        }

    }
}
