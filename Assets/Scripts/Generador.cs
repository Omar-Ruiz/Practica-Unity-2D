using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    [SerializeField] GameObject[] nuevosPisos;
    // Start is called before the first frame update
    void OnTriggerEnter2D()
    {
        int randomIndex = Random.Range(0, nuevosPisos.Length);
        
        //genera un nuevo piso

        Instantiate(nuevosPisos[randomIndex], new Vector3(transform.position.x+20f, -2.5f,transform.position.z), Quaternion.identity);
        transform.position = new Vector3(transform.position.x+20f, -2.5f,transform.position.z); 
    }

}
