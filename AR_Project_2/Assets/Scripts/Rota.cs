using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Importar libreria de Vuforia
using Vuforia;

//Heredar clase IVirtualButtonEventHandler
public class Rota : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject VBButtonObject;
    private GameObject zombie;

    // Use this for initialization
    void Start()
    {
        //Unir con el botón de vuforia
        VBButtonObject = GameObject.Find("RotateZombieButton");
        VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        zombie = GameObject.Find("zombie");
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        zombie.transform.Rotate(new Vector3(0, Time.deltaTime * 1000, 0));
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Epa");
    }
}