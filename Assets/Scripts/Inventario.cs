using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventario : MonoBehaviour
{
public int Cantidad = 0;


    public GameObject UIfinal;
    public TextMeshProUGUI Cantidadpelotitas;

  
    Inventario texto;

    // Start is called before the first frame update
    void Start()
    {

        UIfinal.SetActive(false);



    }

    // Update is called once per frame
    void Update()
    {
        Cantidadpelotitas.text = "Score= " + Cantidad.ToString();
    
      if (Cantidad >=  4 )
        {
            UIfinal.SetActive(true);
        }
    }





}
