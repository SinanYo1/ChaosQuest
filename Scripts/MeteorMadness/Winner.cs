using System;
using TMPro;
using UnityEngine;

public class Winner : MonoBehaviour
{

    private Char1Movement char1;
    private Char2Movement char2;
    private bool functioncalled = false;
    public GameObject winnerscreen;
    [SerializeField] TextMeshProUGUI winnerIs;


    public void WinnerScreen()
    {
        winnerscreen.SetActive(true);
        if(char1.isdead == true)
        {
            winnerIs.text = "Winner is Player 2";
            winnerIs.color = Color.blue;
        }
        else if (char2.isdead2 == true)
        {
            winnerIs.text = "Winner is Player 1";
            winnerIs.color = Color.green;
        }

    }

    void Start()
    {
        char1 = FindFirstObjectByType<Char1Movement>();
        char2 = FindFirstObjectByType<Char2Movement>();

        if (char1 == null) Debug.LogError("Char1Movement nicht gefunden!");
        if (char2 == null) Debug.LogError("Char2Movement nicht gefunden!");
    }

    void Update()
    {
        if (!functioncalled && char1 != null && char1.isdead)
        {
            Debug.Log("Player 2 wins");
            functioncalled = true;
        }
        else if (!functioncalled && char2 != null && char2.isdead2)
        {
            Debug.Log("Player 1 wins");
            functioncalled = true;
        }

        if(functioncalled == true)
        {
            WinnerScreen();
        }
    }
}

//Diese Klasse überprüft den Spielzustand beider Spieler und ermittelt den Gewinner, sobald einer der Spieler stirbt. 
//Anschließend wird ein Gewinnerbildschirm angezeigt, der den siegreichen Spieler inklusive passender Textfarbe darstellt.
