using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Movement mover;
    Collider2D colider;
    
    void Start(){
        colider=GetComponent<Collider2D>();
    }

    void Update(){
        Atravesar();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Atravesar(){
        if(mover.suelo== true){
            colider.enabled= false;           
        }
        else{
            colider.enabled=true;
        }
    }
   

    
}
