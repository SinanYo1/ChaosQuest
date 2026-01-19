using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public GameObject npcPrefab;
    

    void Start()
    {
        NpcSpawn();   
    }

    void NpcSpawn()
    {
        int randomNumber = Random.Range(23, 40); //erzeugt eine zufallszahl
        
        for (int i = 0; i < randomNumber; i++) // Wird im Wert der Zufalls zahl wiederholt
        {
            Vector3 randomSpawn = new Vector3(Random.Range(-140, 70), 1, Random.Range(-40, -4)); // bestimmmt die Zufallspostion wo die NPC Spawnen
            Instantiate(npcPrefab, randomSpawn, Quaternion.identity); // Spawnt die Npc
        }
    }
    
}
// Diese Klasse generiert für das Spiel prinzip eine zufällige Anzahl an Npc's und plaziert diese zufällig in einem eingegrenzten Bereich
