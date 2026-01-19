using UnityEngine;

public class MusicStop : MonoBehaviour
{
    public SoundCode soundcode;
    public AudioSource musik;

    void Start()
    {
        musik = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
}
//Dieses Skript hält eine Referenz auf die Hintergrundmusik und den SoundCode, lädt den AudioSource-Component beim Start, führt aber keine weiteren Aktionen im Update aus.
