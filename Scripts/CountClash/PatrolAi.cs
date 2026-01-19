using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // AI Libary für die automatischen bewegungen

public class PatrollAI : MonoBehaviour
{
    GameObject player;
    public float speed = 10f;
    NavMeshAgent agent;
    [SerializeField] Timer timer;

    [SerializeField] LayerMask groundLayer, playerLayer;

    //Laufen
    Vector3 zielPunkt;
    bool walkpointSet;
    [SerializeField] float range;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }
    void Update()
    {
        
       if(timer.timerend == false)
        { 
            Patrol();
        }

    }
        void Patrol()
    {
        if (!walkpointSet) SucheZiel();
        if (walkpointSet) agent.SetDestination(zielPunkt);
        if(Vector3.Distance(transform.position, zielPunkt)< 10) walkpointSet = false;
    }
    void SucheZiel()
    {
        float z = Random.Range(-range, range);
        float x = Random.Range(-range, range);

        zielPunkt = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);
        if (Physics.Raycast(zielPunkt, Vector3.down, groundLayer))
        {
            walkpointSet = true;
        }
    }
}

//Diese Klasse ist für die zufällige Bewegung der Npc's verantwortlich 
