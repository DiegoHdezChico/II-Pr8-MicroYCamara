using UnityEngine;

public class ReproduceAudio : MonoBehaviour
{
    public NotificadorColisionHumanoide notificador;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        notificador.AlertaColision += Reproducir;
    }

    void Reproducir()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
