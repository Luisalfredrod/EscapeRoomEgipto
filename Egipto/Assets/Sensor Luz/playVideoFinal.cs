using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class playVideoFinal : MonoBehaviour
{
    public GameObject objetoEsperado;

    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video.Pause();
    }

    private void OnMouseDown()
    {
        video.Play();
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Entró:" + other.name);



        if (other.name == objetoEsperado.name)
        {
           video.Play();


        }

    }


}
