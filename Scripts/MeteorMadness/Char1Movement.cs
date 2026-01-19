using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char2Movement : MonoBehaviour
{
    public float speed = 20f;
    public bool isdead2 = false;
    private Animator animator;
    

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(!isdead2)
        { 
        Movement();
        }
    }

    public void GameOver()
    {
        Debug.Log("Player 2 ist Gestorben"); 
        isdead2 = true;
    }

    public void Movement()
    {
        Vector3 moveDirection = Vector3.zero;

        // Bewegung in Abhängigkeit von den Tasten
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += new Vector3(-1, 0, 0); // Rechts
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += new Vector3(1, 0, 0); // Links
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += new Vector3(0, 0, -1); // Rüclwärts
        }
        if (Input.GetKey(KeyCode.UpArrow))
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

        // Bewegung und Drehung anwenden
        if (moveDirection != Vector3.zero)
        {
            // Normalisierung der Richtung für konsistente Geschwindigkeit
            moveDirection = moveDirection.normalized;

            // Bewegung ausführen
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

            // Rotation in Richtung der Bewegung
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }
        //Bereich eingrenzen
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -57, 52);
        pos.z = Mathf.Clamp(pos.z, -21, 39);
        transform.position = pos;
    }
}

//Diese Klasse sorgt für die Bewegung des Ersten Spielers, Grenzt seinen Bewegungs Radius ein und prüft ob er "gestorben" // Diese Klasse steuert die Bewegung des ersten Spielers,
// begrenzt seinen Bewegungsradius und prüft, ob er „gestorben“ ist.
