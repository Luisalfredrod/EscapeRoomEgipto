﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    static string[] respuesta = { "p_Canasto", "p_V", "p_Mano", "p_5" };
    static int n = 0;
    static AudioSource correct;
    static AudioSource incorrect;
    static AudioSource open;
    static GameObject gate;
    static bool opening = false;
    static float increment = 0.1f;
    static int veces = 0;
    // Start is called before the first frame update
    void Start()
    {
        correct = GameObject.Find("right_sound_mel").GetComponent<AudioSource>();
        incorrect = GameObject.Find("wrong_sound_mel").GetComponent<AudioSource>();
        open = GameObject.Find("open_sound_mel").GetComponent<AudioSource>();
        gate = GameObject.Find("gate");
    }

    // Update is called once per frame
    void Update()
    {
        if (opening && veces < 30)
        {

            gate.transform.Translate(0f, increment, 0f);
            veces++;
        }
    }


    public static void agregarPiedra(string nombre)

    {
        if (nombre == respuesta[n])
        {
            Debug.Log("-----correcto----");
            correct.Play();
            n++;


            if (n == 4)
            {
                open.Play();
                opening = true;
                Debug.Log("----has despertado a Akenatón-----");

            }
        }
        else
        {

            Debug.Log("-----mal-------");
            incorrect.Play();
            n = 0;


        }

    }
}
