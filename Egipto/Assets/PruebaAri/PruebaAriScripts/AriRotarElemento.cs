using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AriRotarElemento : MonoBehaviour
{
    bool rotando = false;
    float incY = 1.0f;
    float anguloAcumulado = 0;
    public float anguloObjetivo;
    public Light luz;
    public int n;
    public AudioSource sonido;
    public GameObject PruebaIsra; 
   
    private void FixedUpdate()
    {
        if (rotando)
        {
            gameObject.transform.Rotate(0, incY, 0);
            anguloAcumulado += incY;
            Debug.Log("AnguloAcumulado = " + anguloAcumulado);
            if ((anguloAcumulado%360) > anguloObjetivo-3 && (anguloAcumulado%360) < anguloObjetivo+3)
            {
                luz.intensity = 6;
                AriLogicaJuego.estadoElementos[n] = true;
                if (AriLogicaJuego.verificar() == true)
                {
                    sonido.Play();
                    PruebaIsra.SetActive(true);




                }
            }
            else {
                luz.intensity = 0;
                AriLogicaJuego.estadoElementos[n] = false;
            }
        }
    }

    private void OnMouseDown()
    {
        rotando = true;

    }

    private void OnMouseUp()
    {
        rotando = false;

    }


}