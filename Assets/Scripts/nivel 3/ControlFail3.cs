using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFail3 : MonoBehaviour
{
    cambioEscenas Cambiador;
    TestSave input;
    public string escena;
    // Start is called before the first frame update
    void Start()
    {
        Cambiador = FindObjectOfType<cambioEscenas>();
        input = FindObjectOfType<TestSave>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
      
            Debug.Log("Submit");
            input.LevelFail3();
            Cambiador.LoadScene (escena);
            // Fire !!
        }
        
    }
}