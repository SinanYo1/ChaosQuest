using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metoritescript : MonoBehaviour
{
    public float speed = 1f;
    public float rotationspeed = 1f;
    public Rigidbody rb;
    private bool hasLanded = false; // Variable, um zu pr�fen, ob der Meteorit gelandet ist

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        if (!hasLanded) // Nur rotieren, wenn nicht gelandet
        {
            transform.Rotate(rotationspeed * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Pr�ft, ob der Boden getroffen wird
        {
            rb.linearVelocity = Vector3.zero; // Geschwindigkeit auf 0 setzen
            rb.angularVelocity = Vector3.zero; // Rotation stoppen
            rb.isKinematic = true; // Physikbewegung deaktivieren

            hasLanded = true; // Markiert, dass der Meteorit gelandet ist
        }
            
        if (collision.gameObject.CompareTag("Player"))
        {
          // Pr�fen, ob Char1 getroffen wurde
           if (collision.gameObject.GetComponent<Char1Movement>() != null)
           {
                 collision.gameObject.GetComponent<Char1Movement>().GameOver();
           }
                // Pr�fen, ob Char2 getroffen wurde
           else if (collision.gameObject.GetComponent<Char2Movement>() != null)
           {
                    collision.gameObject.GetComponent<Char2Movement>().GameOver();
           }
        }
        
    }
}
//Dieses Skript steuert einen Meteoriten in Unity: Er rotiert während des Falls, stoppt beim Aufprall auf den Boden und deaktiviert die Physik. 
//Trifft der Meteorit einen Spieler, löst er die GameOver()-Methode des entsprechenden Charakters aus.
