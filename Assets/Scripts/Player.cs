using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int numeroEntero = 1;
    float numeroDecimal = 1.5f;
    [SerializeField] float velocidad = 1;

    [SerializeField] float aceleracion = 1;

    [SerializeField] GameObject camara;

    [SerializeField] float jumpforce =1;

    bool inGround = false;

    bool dead = false;

    Animator animator;

    [SerializeField] GM gameManager;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update(){

        if (dead)
        {
            return;
        }
        velocidad += aceleracion;
        transform.position += new Vector3(1,0,0)*Time.deltaTime*velocidad;
        camara.transform.position += new Vector3(1,0,0)*Time.deltaTime*velocidad;

        if(Input.GetKeyDown(KeyCode.Space) && inGround)
        {
            
            inGround = false;
            animator.SetBool("jump", false);
            rb.AddForce(Vector2.up*jumpforce, ForceMode2D.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow) == true && isCrouching == false){
            
            isCrouching = true;


            animator.SetBool("crouch", false);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) == true && isCrouching == true){
            
            isCrouching = true;


            animator.SetBool("crouch", true);
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Obstaculos")
        {
            dead = true;

            gameManager.gameOver = true;
        }
        inGround = true;
    }
    public void Pausa()
        {
            
        }

}
