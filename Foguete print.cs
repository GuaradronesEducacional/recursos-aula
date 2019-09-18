using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foguete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        ControleTeclado();
    }
    private void ControleTeclado()
    {
        if (Input.GetKey(KeyCode.Space)) // Comando utilizado para identificar uma tecla pressionada
        {
            print("acelerando");  // Ação Realizada pelo comando
        }
        if (Input.GetKey(KeyCode.A)) // Comando utilizado para identificar uma tecla pressionada
        {
            print("giro esquerda"); // Ação Realizada pelo comando
        }
        else if (Input.GetKey(KeyCode.D)) // Comando utilizado para identificar uma tecla pressionada
        { 
            print("giro direita"); // Ação Realizada pelo comando
        }
    }
}
