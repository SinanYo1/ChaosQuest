using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZaehlMechanikl : MonoBehaviour
{
    [SerializeField] Timer timer;
    private bool functionCalled = false;
    public int anzahlnpc;
    public string targetTag = "NPC";
    public int player1Zaehler = 0;
    public int player2Zaehler = 0;
    public bool player1wins = false;
    public bool player2wins = false;
    private bool draw = false;
    [SerializeField] TextMeshProUGUI player1counter;
    [SerializeField] TextMeshProUGUI player2counter;
    [SerializeField] TextMeshProUGUI anzchar;
    [SerializeField] TextMeshProUGUI winnerIs;
    [SerializeField] TextMeshProUGUI player1score;
    [SerializeField] TextMeshProUGUI player2score;
    public GameObject winnerscreen;
   
    void Start()
    {
        AnzahlChar();
        Debug.Log(anzahlnpc);
    }

    void Update()
    {
        if(timer.timerend == false) //Man kann nur so lange Zählen bis der Timer endet
        { 
            Zaehlen();
        }
        if(!functionCalled && timer.timerend == true) //Ruft die Winner und Ergebnis Funktion nur einmal auf
        {
            functionCalled = true;
            Ergebnis();
            Winner();       
        }
    }
    public void Winner() // macht die ganzen Texte für den Winnner screen
    {
        winnerscreen.SetActive(true);
        anzchar.text = anzahlnpc.ToString();
        if (player1wins == true) // wenn Player 1 gewinnt
        {
            winnerIs.text = "Player 1 Wins";
        }
        else if (player2wins == true) // wenn Player 2 gewinnt
        {
            winnerIs.text = "Player 2 Wins";
        }
        else if (draw == true) // wenn es ein Unentschieden gibt
        {
            winnerIs.text = "\tDraw";
        }
        //Zeigt wie viele beide Player gezählt haben
        player1score.text = "Player 1: " + player1Zaehler.ToString(); 
        player2score.text = "Player 2: " + player2Zaehler.ToString();
    }
    void AnzahlChar() // gibt die Anzahl der Characktere an
    {
        anzahlnpc = GameObject.FindGameObjectsWithTag(targetTag).Length;
        Debug.Log("Anzahl Charaktere: " + anzahlnpc);
    }
    
    void Zaehlen()
    {
        // Hoch zähle für Player 1 und Player 2
        if (Input.GetKeyDown("w"))
        {
            player1Zaehler++;
            Debug.Log("Player 1 Zähler: " + player1Zaehler);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player2Zaehler++;
            Debug.Log("Player 2 Zähler: " + player2Zaehler);
        }

        //Runter Zählen für Player 1 und Player 2
        if(player1Zaehler > 0 || player2Zaehler > 0)
        { 
            if (Input.GetKeyDown("s"))
            {
                player1Zaehler--;
                Debug.Log("Player 1 Zähler: " + player1Zaehler);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                player2Zaehler--;
                Debug.Log("Player 2 Zähler: " + player2Zaehler);
            }
        }
        //Text Für beide Zähler
        player1counter.text = Convert.ToString(player1Zaehler);
        player2counter.text = Convert.ToString(player2Zaehler);
    }

    public void Ergebnis()
    {
        //Berechnet den Abstand  wer näher dran ist
        int player1Differnce = Math.Abs(player1Zaehler - anzahlnpc);
        int player2Differnce = Math.Abs(player2Zaehler - anzahlnpc);
        // Ergebnis wird ausgewertet wenn der timer endet
        if (timer.timerend == true)
        {
            if (player1Differnce < player2Differnce)
            {
                player1wins = true;
                Debug.Log("Player 1 Gewinnt");
            }

            else if (player1Differnce > player2Differnce)
            {
                player2wins = true;
                Debug.Log("Player 2 Gewinnt");
            }
            else
            {
                draw = true;
                Debug.Log("Unetnschieden");
            }

        }

    }
}

//Dieser Code ist der "GameManager" durch ihn wird die Spiel Mechanik des Zählens realisiert und es gibt auch zurück wer Gewonnen hat
