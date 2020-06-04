using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaGemas : MonoBehaviour
{


    static string[] respuesta = { "gemaRoja", "gemaRoja", "gemaVerde", "gemaVerde", "gemaVerde", "gemaVerde", "gemaVerde", "gemaAzul", "gemaAmarilla", "gemaAmarilla", "gemaAmarilla", "gemaAmarilla" };
    static int n = 0;
    static AudioSource openCofre;
    static AudioSource bien;

    
    

    // Start is called before the first frame update
    void Start()
    {
        openCofre = GameObject.Find("AudioCofreGemas").GetComponent<AudioSource>();
        bien = GameObject.Find("AudioGemaBien").GetComponent <AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void agregarGemas(string nombre)
    {
        if(nombre == respuesta[n])
        {

            Debug.Log("Correcto: " + nombre);
            bien.Play();
            n++;
            if (n == 11)
            {
                Debug.Log("CodigoCorrecto");
                openCofre.Play();
                AbrirCofre.triggerCode();


            }
        }
        else
        {
            Debug.Log("Incorrecto: " + nombre);
            n = 0;
        }
    }
}
