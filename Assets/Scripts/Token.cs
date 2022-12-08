using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Token : MonoBehaviour
{
    // Start is called before the first frame update

    Inventario inventario;

    public GameObject UIfinal;


    void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventario>();
   
    }

    


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inventario.Cantidad = inventario.Cantidad + 1;
            Destroy(gameObject);
            

        }


       




    }
}