using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.UI;

public class MaterialWebCam : MonoBehaviour
{
    private Renderer rd;
    Texture texturaOriginal;
    Color colorOriginal;
    private WebCamTexture texturaTv;
    private float contadorCapturas;
    private string rutaGuardado = "C:\\Users\\PC\\Desktop\\Mis cosas\\Unity\\examen\\Assets\\Scenes\\Micro y Cam\\Capturas\\";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Renderer>();
        texturaTv = new WebCamTexture();
        texturaOriginal = rd.material.mainTexture;
        Debug.Log("El nombre de la cámara es " + texturaTv.deviceName);
        colorOriginal = rd.material.color;
        contadorCapturas = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rd.material.color = new Color(1, 1, 1);
            rd.material.mainTexture = texturaTv;
            texturaTv.Play();
        }
        if (Input.GetKey(KeyCode.P))
        {
            texturaTv.Stop();
            rd.material.color = colorOriginal;
            rd.material.mainTexture = texturaOriginal;
        }
        if (Input.GetKey(KeyCode.X))
        {
            Texture2D captura = new Texture2D(texturaTv.width, texturaTv.height);
            captura.SetPixels(texturaTv.GetPixels());
            captura.Apply();
            System.IO.File.WriteAllBytes(rutaGuardado + contadorCapturas.ToString() + ".png", captura.EncodeToPNG());
            ++contadorCapturas;
        }
    }
}
