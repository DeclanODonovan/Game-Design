using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuesser : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int count = 1; // Number of guesses made, will be updated
    int guess = 0; // The current guess (placeholder)


    // Start is called before the first frame update
    void Start()
    {
        print("Welcome to Number Guesser!");
        print("Think of a number, any number...");
        print("As long as its between " + min + " and " + max + " ;)");

        new_guess();
    }

    void new_guess()
    {
        guess = Random.Range(min, max + 1);
        print("Is the number higher (up arrow) or lower (down arrow) than " + guess + "? If I got it right press Enter.");


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
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess - 1;
            count++; //Increases count by 1
            new_guess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Mwahahaha I have gotten your number! And it only took me " + count + " guesses! Computers rule supreme!");

        }
    }
}