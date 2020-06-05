using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarPiedras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("se dio clic sobre..." + gameObject.name);
        GameLogic.agregarPiedra(gameObject.name);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
