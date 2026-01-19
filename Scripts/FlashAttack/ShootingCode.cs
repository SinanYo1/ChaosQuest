using GLTFast.Schema;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class ShootingCode : MonoBehaviour
{
    public SoundCode soundCode;
    public bool player1Dead = false;
    public bool player2Dead = false;
    public bool player1Win = false;
    public bool player2Win = false;
    public int player1Health = 3;
    public int player2Health = 3;
    public Animator animator;
    public Animator animatorplayer1;
    public bool player1shot = false;
    public bool player2shot = false;
    public bool roundEnd = true;
    public bool roundRunning = true;
    public MusicStop musikCode;
    public Transform drehenPlayer1;
    public Transform drehenPlayer2;
    public GameObject Endscreen;
    public GameObject projectilePlayer1;
    public TextMeshProUGUI Text;
    public GameObject effectPrefab;
    public GameObject player2effectPrefab;
    public GameObject projectilePlayer2;

    void Update()
    {
        if (GameEnd() == false)
        {
            Shoot();
            RoundEnd();
        }
        
            GameEnd();
        if(GameEnd() == true)
        {
            StartCoroutine(EndScreen());
        }
    }

    void Shoot()
    {
        if(roundRunning == true) // nur wenn eine Runde läuft 
        { 
            if (soundCode.hasPlayed == false) // wenn vor dem sound geschossen wird
            {
                if (Input.GetKeyDown("d") == true && player2shot == false) // Player 1 war zu früh und verliert Leben
                {
                    Debug.Log("Player 1 Verliert Leben");
                    player1Health--;
                    player1shot = true; // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    player2shot = true; // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    animatorplayer1.SetTrigger("Hit1"); ;
                    PlayEffect(new Vector3(3.1f, 3, 15.96f));
                   // GameObject projectile = Instantiate(projectilePlayer1, new Vector3(2.1f, 8, 15.96f), new Quaternion(0, 90, 0, 0));
                   // Destroy(projectile, 1f);
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow) == true && player1shot == false) // Player 2 war zu früh und verliert Leben
                {
                    Debug.Log("Player 2 Verliert Leben");
                    player2Health--;
                    player1shot = true;  // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    player2shot = true;  // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    animator.SetTrigger("Hit"); ;
                    PlayEffect2(new Vector3(-22.45f, 3, 14.75f));
                   // GameObject projectile2 = Instantiate(projectilePlayer2, new Vector3(-22.45f, 8, 14.75f), new Quaternion(0, 90, 0, 0));
                   //  Destroy(projectile2, 1f);
                }
            }
            if (soundCode.hasPlayed == true) // wenn nach dem sound geschossen wird
            {
                if (Input.GetKeyDown("d") == true && player2shot == false) // Player 1 war schneller und Player 2 Verliert Leben
                {
                    player2Health--;
                    Debug.Log("Player 2 Verliert Leben");
                    player1shot = true; // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    player2shot = true; // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    animatorplayer1.SetTrigger("Attack1");
                    animator.SetTrigger("Hit");
                    PlayEffect(new Vector3(-22.45f, 3, 14.75f));
                    //GameObject projectile = Instantiate(projectilePlayer1, new Vector3(-22.45f, 8, 14.75f), new Quaternion(0,90,0, 0));
                    //Destroy(projectile, 1f);
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow) == true && player1shot == false) // Player 2 war schneller und Player 1 Verliert Leben
                {
                    player1Health--;
                    Debug.Log("Player 1 Verliert Leben");
                    player1shot = true; // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    player2shot = true; // wenn true könn beide Spieler nicht mehr schießen bis zur nächsten Runde
                    animator.SetTrigger("Attack");
                    animatorplayer1.SetTrigger("Hit1"); ;
                    PlayEffect2(new Vector3(3.1f, 3, 15.96f));
                    //GameObject projectile2 = Instantiate(projectilePlayer2, new Vector3(2.1f, 8, 15.96f), new Quaternion(0, 90, 0, 0));
                    //Destroy(projectile2, 1f);
                }
            }
        }
    }
    public void PlayEffect(Vector3 position)
    {
        Instantiate(effectPrefab, position, Quaternion.identity);
    }
    public void PlayEffect2(Vector3 position)
    {
        Instantiate(player2effectPrefab, position, Quaternion.identity);
    }
    bool GameEnd()
    {
        if(player1Health <= 0) // Player 2 gewinnt
        {
            player2Win = true; // Player 2 hat gewonnen
            animator.SetTrigger("Win"); // Winning Animation
            animatorplayer1.SetTrigger("Die1"); // Gegner Todes Animation
            drehenPlayer2.rotation = Quaternion.Euler(0, 350, 0); //Drehung richtung Kamera
            
            return true;
        }
        else if (player2Health <= 0) // Player 1 gewinnt
        {
            player1Win = true;
            drehenPlayer1.rotation = Quaternion.Euler(0, 350, 0); //Drehung richtung Kamera
            animatorplayer1.SetTrigger("Win1");  // Winning Animation
            animator.SetTrigger("Die"); // Gegner Todes Animation
            

            return true;
        }
        return false;
    }

    IEnumerator EndScreen()
    {
        yield return new WaitForSeconds(3f);
        if(player1Win == true)
        {
            Endscreen.SetActive(true);
            Text.text = "Plyer 1 Win";
            Text.color = Color.green;
        }
        else if(player2Win == true)
        {
            Endscreen.SetActive(true);
            Text.text = "Plyer 2 Win";
            Text.color = Color.blue;
        }
    }
    void RoundEnd()
    {
        if (player1shot == true || player2shot == true) // wenn einer der spieler gescossen hat
        { 
            musikCode.musik.Stop(); // die Musik stoppt
            player1shot = false; // es wird zurückgesetzt das Geschossen wurde
            player2shot = false;
            roundEnd = true; // Runden ende true
            roundRunning = false; // die runde läuft nicht mehr
        }
    }
    
}

//Dieses Skript steuert den Hauptspielablauf eines Duells zwischen zwei Spielern. Es verwaltet Schüsse, Treffer und Animationen, überprüft, welcher Spieler 
//vorzeitig oder nach dem Signal geschossen hat, zieht Lebenspunkte ab, prüft das Spielende und zeigt nach dem Sieg den Endscreen an.
//Außerdem wird die Musik passend zur Runde gestartet und gestoppt, und visuelle Effekte für Schüsse werden erzeugt.
