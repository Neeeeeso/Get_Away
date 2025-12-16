using UnityEngine;


public class Escaleras : MonoBehaviour
{

    public Movement mover;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            mover.escaleras=true;

        }
    }
   

    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player")){
            mover.escaleras=false;
        }
    } 

}
