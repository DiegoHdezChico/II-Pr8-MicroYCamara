using UnityEngine;

public class MovimientoSoldados : MonoBehaviour
{
    public GameObject objetivo;
    private Rigidbody rb;
    private float umbral;
    private float velocidad = 8;
    private Quaternion rotacionObjetivo;
    private bool corregirRotacion;
    void OnCollisionExit(Collision collision)
    {
        corregirRotacion = true;
        rotacionObjetivo = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        umbral = 0.01f;
        corregirRotacion = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direccion = (objetivo.transform.position - rb.position).normalized;
        if (direccion.magnitude > umbral)
        {
            rb.MovePosition(rb.position + direccion * velocidad * Time.fixedDeltaTime);
        }
        if (corregirRotacion)
        {
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, rotacionObjetivo, Time.fixedDeltaTime * 2f));
            if (Quaternion.Angle(rb.rotation, rotacionObjetivo) < 1f)
            {
                corregirRotacion = false;   
            }
        }
    }
}
