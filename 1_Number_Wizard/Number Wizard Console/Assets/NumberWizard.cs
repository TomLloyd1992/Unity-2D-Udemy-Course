using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int highest;
    int lowest;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //Starting Values
        highest = 1000;
        lowest = 0;
        guess = 500;

        //Intro
        Debug.Log("Welcome to number Wizard");
        Debug.Log("We would like you to pick a number");
        Debug.Log("The highest number is " + highest);
        Debug.Log("The lowest number you can choose is " + lowest);

        //Higher or Lower
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push up for Higher and push Down for lower. If I am correct press Enter");

        highest = highest + 1;
        lowest = lowest - 1;
    }

    // Update is called once per frame
    void Update()
    {
        //User Input
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lowest = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            highest = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I GOT IT!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (highest + lowest) / 2;
        Debug.Log("Higher or Lower than " + guess);
    }
}
