using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoreGame : MonoBehaviour
{
    public GameObject ChangingText;
    private Text text;
    

    public static int computerTrials;
    public int guess;
    private int maxGuess;
    int min;
    int max;

    private void Start()
    {
        maxGuess = Random.Range(12,15);
        text = ChangingText.GetComponent<Text>();

        guess = Random.Range(1, 1000);
        min = 1;
        max = 1000;
        computerTrials = 1;
        text.text = "Is your number equals " + guess + " ?";
    }

    public void ProcessGuess()
    {
        guess = Random.Range(min, max);
        computerTrials += 1;
        if (computerTrials == maxGuess)
        {
            Application.LoadLevel("Win");
        }
        text.text = "Is your number equals " + guess + " ?";
    }

    public void Higher()
    {
        min = guess;
        ProcessGuess();
    }

    public void Lower()
    {
        max = guess;
        ProcessGuess();
    }


}