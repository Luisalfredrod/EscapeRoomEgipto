using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ActivaLuz : MonoBehaviour
{
    public GameObject Luz1;
    public GameObject Luz2;
    public GameObject Luz3;
    public GameObject Luz4;
    public bool ActivaCaja;
    public bool ActivaPiramide;
    public bool ActivaTrono;
    public bool ActivaJarron;


    // Start is called before the first frame update
    void Start()
    {
        ActivaCaja = false;
        ActivaPiramide = false;
        ActivaTrono = false;
        ActivaJarron = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ActivaPiramide == true && ActivaCaja == true && ActivaTrono == true && ActivaJarron == true)
        {
            Debug.Log("LuzPrendida");
            StartCoroutine(IniciaPatron());
        }
    }

    IEnumerator IniciaPatron()
    {
        yield return new WaitForSeconds(1f);
        Luz1.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz1.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz1.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz1.SetActive(false);
        yield return new WaitForSeconds(3f);
        Luz2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz2.SetActive(false);
        yield return new WaitForSeconds(3f);
        Luz3.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz3.SetActive(false);
        yield return new WaitForSeconds(3f);
        Luz4.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(false);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(true);
        yield return new WaitForSeconds(1f);
        Luz4.SetActive(false);
        yield return new WaitForSeconds(3f);
    }
}
