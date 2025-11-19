using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class NotificadorColisionHumanoide : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje AlertaColision;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "humanoide_tipo1")
        {
            AlertaColision();        
        }
    }   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
