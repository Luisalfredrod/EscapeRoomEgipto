using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ActivaLuz : MonoBehaviour
{
    bool ObjetosColocados = false;
    public GameObject Luz1Obj;
    public GameObject Luz2Obj;
    public GameObject Luz3Obj;
    public GameObject Luz4Obj;
    Light Luz1;
    Light Luz2;
    Light Luz3;
    Light Luz4;
    public bool ActivaCaja;
    public bool ActivaPiramide;
    public bool ActivaTrono;
    public bool ActivaJarron;
    AudioSource AudioLuz;


    // Start is called before the first frame update
    void Start()
    {
        Luz1 = Luz1Obj.GetComponent<Light>();
        Luz2 = Luz2Obj.GetComponent<Light>();
        Luz3 = Luz3Obj.GetComponent<Light>();
        Luz4 = Luz4Obj.GetComponent<Light>();
        ActivaCaja = false;
        ActivaPiramide = false;
        ActivaTrono = false;
        ActivaJarron = false;
        AudioLuz = GameObject.Find("AudioLuz").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!ObjetosColocados)
        {
            if (ActivaPiramide == true && ActivaCaja == true && ActivaTrono == true && ActivaJarron == true)
            {
                Debug.Log("LuzPrendida");
                StartCoroutine(IniciaPatron());
                ObjetosColocados = true;
            }
        }
    }

    IEnumerator IniciaPatron()
    {

        yield return new WaitForSeconds(0.5f);
        AudioLuz.Play();
        Luz1.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz1.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz1.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz1.intensity = 0;
        yield return new WaitForSeconds(2f);
        AudioLuz.Play();
        Luz2.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz2.intensity = 0;
        yield return new WaitForSeconds(2f);
        AudioLuz.Play();
        Luz3.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz3.intensity = 0;
        yield return new WaitForSeconds(2f);
        AudioLuz.Play();
        Luz4.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 10;
        yield return new WaitForSeconds(0.5f);
        Luz4.intensity = 0;
        yield return new WaitForSeconds(2f);
        ObjetosColocados = false;
    }
}