using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] float timeLeft = 30f;
    public bool timerend = false;


    void Update()
    {
        if (timeLeft > 0 && timerend == false)
        {
            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft < 0) //Countdown geht nicht weiter runter als 0
        {
            timeLeft = 0;
            timerend = true;
        }
        if (timeLeft < 6) //Timer Farbe kurz vor ende Rot färben
        {
            timertext.color = Color.red;
        }
        timertext.text = timeLeft.ToString("0");

        
    }

}
// Diese Klasse zählt während das Spiel läuft einen Timer runter und endet ab 5 Sekunden die Farbe vom Timer auf Rot
