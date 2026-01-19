using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundCode : MonoBehaviour
{
    public AudioSource src; // Audio Player
    public AudioClip gunshot; // Sound Effect
    private float randomTime;
    public bool hasPlayed = false; // Verhindert mehrfaches Abspielen
    public ShootingCode shootingcode;
    public MusicStop musikCode;
    private float i = 0;
    void Update()
    {

        randomTime -= Time.deltaTime;
        
        if (shootingcode.player1Dead == false && shootingcode.player2Dead == false && shootingcode.roundEnd == true) // wenn beide Spieler noch leben und die runde vorbei ist
        {
            i -= Time.deltaTime;
            if(i<=0) // immer nach 3 sekunden startet die nächste runde
            {
                NextRound();
            }
        }

        if (randomTime <= 0) // wenn der Timer abläuft spielt der sound ab
        {
            if (!hasPlayed)  // wenn der Sound noch nicht abgespielt wurde
            {
                src.PlayOneShot(gunshot); // Sound wird abgespielt
                Debug.Log("Sound abgespielt");
                hasPlayed = true; // gibt an das der sound schon abgespielt wurde
                musikCode.musik.Stop(); // musik Stoppt 
            }
        }
    }

    void GenerateTime()
    {
        randomTime = Random.Range(6, 12f); //erstellt den timer wann Start Signal beginnt
        Debug.Log("Timer startet mit " + randomTime + " Sekunden");
    }

    void NextRound()
    {
        i = 3; // Zeit für den nächsten Runden Start
        shootingcode.roundEnd = false; // runde setzt sich zurück
        shootingcode.roundRunning = true; // gibt an das die runde läuft
        Debug.Log("Nächste Runde!");
        GenerateTime(); // neue Zeit wird generiert
        musikCode.musik.Play(); // Die Musik startet
        hasPlayed = false; // das der Sound Abgespielt wurder setzt sichj zurück
        //shootingcode.roundRunning = true;
    }
}
//Dieses Skript steuert den Ablauf zwischen Spielrunden und Soundeffekten: Es spielt zufällig ein Schussgeräusch ab, stoppt die Musik und startet nach einem Timer 
//die nächste Runde, solange beide Spieler noch leben. Es sorgt außerdem dafür, dass Sounds nicht mehrfach abgespielt werden und die Rundenlogik korrekt zurückgesetzt wird.
