using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class LlegoCaja : MonoBehaviour
{
    AudioSource bien;
    public GameObject objetoEsperado;

    // Start is called before the first frame update
    private void Start()
    {
        bien = GameObject.Find("SonidoBien").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {



        if (other.name == objetoEsperado.name)
        {
            bien.Play();
            Debug.Log("Se activo: " + other.name);
            ActivaLuz activeC = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ActivaLuz>();
            activeC.ActivaCaja = true;
        }
    }
}