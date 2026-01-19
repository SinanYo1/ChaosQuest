using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using static UnityEditor.PlayerSettings;

public class Char1Movement : MonoBehaviour
{
    public float speed = 20f;
    public bool isdead = false;
    private Animator animator;
    public TextMeshPro text;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(!isdead)
        {
            Movement();
        }
    }

    


    public void GameOver()
    {
        Debug.Log("Player 1 ist gestorben!"); // Hier kannst du eine Szene neu laden oder ein Game-Over-Menü aktivieren
        isdead = true;
    }

    public void Movement()
    {
        Vector3 moveDirection = Vector3.zero;

        // Bewegung in Abhängigkeit von den Tasten
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += new Vector3(-1, 0, 0); // Links
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += new Vector3(1, 0, 0); // Rechts
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += new Vector3(0, 0, -1); // Rückwärts
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += new Vector3(0, 0, 1); // Vorwärts
        }

        // Setze die Animationsvariable basierend auf der Bewegungsgeschwindigkeit
        if (moveDirection.magnitude > 0)
        {
            animator.SetFloat("Input Magnitude", speed);
        }
        else
        {
            animator.SetFloat("Input Magnitude", 0); // Animation stoppen
        }

        // Normalisierung der Richtung für gleichmäßige Geschwindigkeit bei diagonaler Bewegung
        if (moveDirection != Vector3.zero)
        {
            moveDirection = moveDirection.normalized;

            // Bewegung ausführen
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

            // Rotation in Richtung der Bewegung
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }


        // Bereich eingrenzen
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -57, 52);
        pos.z = Mathf.Clamp(pos.z, -21, 39);
        transform.position = pos;

        
    }
}

//Diese Klasse steuert die Bewegung und Animation des ersten Spielers anhand der WASD-Tasten, begrenzt seinen Bewegungsbereich im Spiel und deaktiviert die Steuerung, sobald der Spieler gestorben ist.
