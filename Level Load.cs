using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    [SerializeField] float Aceleracao = 100f;
    [SerializeField] float Giro = 100f;

    Rigidbody rigidBody;
   

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
       }
	
	// Update is called once per frame
	void Update () {
        Acelerar();
        Girar();
	}

	 void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
				print("ok");
                
                break;
            case "Finish":
                print("Hit finish"); 
                SceneManager.LoadScene(1);
                break;
			
            default:
                print("Dead");
               
                break;
        }
    }

    private void Acelerar()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            rigidBody.AddRelativeForce(Vector3.up * Aceleracao);
           
        }
        
    }

    private void Girar()
    {
        rigidBody.freezeRotation = true;
       
        float rotationThisFrame = Giro * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }

        rigidBody.freezeRotation = false; 
    }
}