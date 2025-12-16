using UnityEngine;

public class Monedas : MonoBehaviour
{

    public AudioSource sonido;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            sonido.Play();
            
            
            Destroy(gameObject);
            Manager.AddScore(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
