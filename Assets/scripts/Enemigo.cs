using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed;

    public Transform posToGo1;
    public Transform posToGo2;
    Transform posToGo;

    int index;

    SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        posToGo = posToGo2;
    }
    
    void FixedUpdate()
    {
    
        transform.position = Vector3.MoveTowards(transform.position, posToGo.position, speed * Time.deltaTime);
        
        
        if(transform.position == posToGo2.position){
            transform.position = Vector3.MoveTowards(transform.position, posToGo1.position, speed * Time.deltaTime);
            posToGo=posToGo1;
        }
        if(transform.position == posToGo1.position){
            transform.position = Vector3.MoveTowards(transform.position, posToGo2.position, speed * Time.deltaTime);
            posToGo=posToGo2;
        }
        
        Flip(posToGo);
        
    }

    // Update is called once per frame



    private void Flip(Transform posToGo)
    {
        if(posToGo.position.x > transform.position.x){
            sr.flipX=true;
        }
        else if(posToGo.position.x < transform.position.x)
        {
            sr.flipX=false;
        }
    }
}
