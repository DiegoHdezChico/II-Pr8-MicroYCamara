using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Grabadora : MonoBehaviour
{
    private AudioSource reproductor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reproductor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire2") != 0)
        {
            reproductor.clip = Microphone.Start("", false, 5, 44100);
            Debug.Log("Grabando!");
        }
        if (Input.GetAxis("Fire1") != 0)
        {
            reproductor.Play();
            Debug.Log("Reproduciendo!");
        }
    }
}
