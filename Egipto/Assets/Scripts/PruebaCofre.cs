using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaCofre : MonoBehaviour
{
    bool tapaAbriendose;
    bool tapaCerrada;

    public GameObject tapa;
    public AudioSource sonido;

    float inc;
    float anguloActual;

    // Start is called before the first frame update
    void Start()
    {
        tapaAbriendose = false;
        tapaCerrada = true;
        inc = -0.6f;

        anguloActual = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (tapaAbriendose)
        {
            tapa.transform.Rotate(inc, 0, 0);
            anguloActual += inc;

            if (tapaCerrada)
            {
                inc = -0.6f;
                if (anguloActual <= -100)
                {
                    tapaAbriendose = false;
                    tapaCerrada = false;
                }
            }
            else
            {
                inc = 0.6f;
                if (anguloActual >= 0)
                {
                    tapaAbriendose = false;
                    tapaCerrada = true;
                }
            }



        }

    }
    private void OnMouseDown()
    {
        tapaAbriendose = true;
        sonido.Play();
    }
}
