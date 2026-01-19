using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MeteoritSpawner : MonoBehaviour
{
    public float spawntime = 3f;  //Zeit für den Timer der abläuft zum Meteoriten spawnen
    public float hardmode = 16f; //Zeit für anderen Timer, wenn der timer aus ist spawnen mehr Meteoriten
    public GameObject meteorit; 
    private bool TimerFinished()
    {
        spawntime -= Time.deltaTime;

        if (spawntime <= 0)
        {
            spawntime = 3f;
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private bool HardmodeTimer()  // wenn der Timer abläuft spawnen mehr Metoriten um die schwierigkeit zu erhöhen
    {
        hardmode -= Time.deltaTime;

        if (hardmode <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Update()
    {
        HardmodeTimer();
        if (TimerFinished()) //spawnt nach ablauf der zeit einen Meteorit
        {
            Vector3 spawnposition = new Vector3(Random.Range(-57, 52), 60,Random.Range(-21, 39));
            Instantiate(meteorit, spawnposition, meteorit.transform.rotation);

            if(HardmodeTimer())
            {
                Vector3 secondspawnposition = new Vector3(Random.Range(-57, 52), 60, Random.Range(-21, 39));
                Instantiate(meteorit, secondspawnposition, meteorit.transform.rotation);
            }
        }
        

    }
}
//Dieses Skript spawnt Meteoriten in Unity in regelmäßigen Abständen. 
//Nach Ablauf eines normalen Timers wird ein Meteorit erzeugt, und wenn der „Hardmode“-Timer abgelaufen ist, werden zusätzlich mehr Meteoriten gespawnt, um die Schwierigkeit zu erhöhen
