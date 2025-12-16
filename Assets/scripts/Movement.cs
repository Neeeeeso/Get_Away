using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed =4;
        public LayerMask layerGround;//la capa donde va a estar el suelo

        Rigidbody2D rb;
        SpriteRenderer sp;
        Animator anim;
        public float SmoothTime;
        Vector2 targetVelocity;
        Vector2 dampVelocity; 

       // Animator anim;
        Vector3 movement;
        float horizontal;
        float vertical;
        public bool escaleras;
        public bool suelo;

        public bool muerte;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
        escaleras = false;
        muerte = false;
        Time.timeScale=1f;

        Manager.InitLevelScore();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v =Input.GetAxis("Vertical");
         // Crear un vector de movimiento basado en el input
        
        // Mover el jugador en función de la dirección y la velocidad
        Animar(h,v,speed);
        
        Flip(h);
        
        v = Gravedad(v,h);
        Vector3 movement = new Vector3(h,v, 0.0f);
        transform.Translate(movement * speed *Time.deltaTime, Space.World);
        

    }

    float Gravedad(float vertical, float horizontal){
        if(vertical!=0 && escaleras ==true)
        {
            rb.gravityScale=0;
            suelo = true;
            
        }
        else{
            rb.gravityScale=2;
            vertical = 0;
            suelo =false; 
        }
        return vertical;
    }
   
    void Animar(float h, float v, float speed){
        if(h!=0)
        {
            anim.SetBool("Correr", true);
            if(muerte ==true){

            anim.SetBool("Muerte", true);
            pausar();
            }

            else{
            anim.SetBool("Muerte",false);
            }
        }
        else
        {
            anim.SetBool("Correr", false);
        }
        if(v!=0 && escaleras==true){
            anim.SetBool("Trepar", true);
            if(muerte ==true){

            anim.SetBool("Muerte", true); 
            
            pausar();

            }

        else{
            anim.SetBool("Muerte",false);
        }
        }
        else{
            anim.SetBool("Trepar", false);
        }
        if(muerte ==true){

            anim.SetBool("Muerte", true);
            
            pausar();
            }

        else{
            anim.SetBool("Muerte",false);
        }
    }


  void pausar(){
        Manager.SetScore();
        float time1=0f;
        float time2=2f;
        
        while (time1<time2)
        {
            time1 += Time.deltaTime;

        } 
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >2f && !anim.IsInTransition(0)){
            Time.timeScale=0f;
            
        }
    }

    void Flip(float horizontal)
    {
        if (horizontal > 0)
        {
            sp.flipX = false;
        }
        else if(horizontal<0){
            sp.flipX =true;
        }
    }
}
