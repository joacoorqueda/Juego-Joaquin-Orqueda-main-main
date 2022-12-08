using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Timerxd = 0 ;

    public Text Timerxdmodo;

    public GameObject UIprincipal;

    // Start is called before the first frame update
    void Start()
    {


        UIprincipal.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        Timerxd += Time.deltaTime ;
        Timerxdmodo.text = "Time= " + Timerxd.ToString("f2");


        if (Timerxd > 16 )
        {
            UnityEditor.EditorApplication.isPlaying = false;

        }

        if (Timerxd > 2.8)

        {
            UIprincipal.SetActive(false);
        } 


    }
}
