using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class DetectarLuz : MonoBehaviour
{
    

   public AudioSource sonido;


    public GameObject objetoEsperado;
    
    public GameObject luz;
    public VideoPlayer video;
    
   

    private void Start()
	{
        
        //luz = GameObject.Find("Point Light Ceci").GetComponent<GameObject>();
        Debug.Log("start");

       
        
    }


     
    private void OnTriggerEnter(Collider other)
	{
       
        Debug.Log("Entró:" + other.name);
        


        if(other.name == objetoEsperado.name)
        {
            Debug.Log("ES UN CUBO");
            other.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            luz.GetComponent<Renderer>().material.SetColor("_Color", Color.green);


            video.Play();
         
            sonido.Play();


        }

    }


    private void OnTriggerExit(Collider other)
    {
        sonido.Stop();
    }


}



