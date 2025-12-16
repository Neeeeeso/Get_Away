using UnityEngine;

public class PalancaSuelo : MonoBehaviour
{
    public SpriteRenderer sp;
    public GameObject suelo;

    AudioSource sonido;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sonido= GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
       if(other.CompareTag("Player")){
         sp.flipX=true;
         sonido.Play();
        suelo.SetActive(true);
        
       }
    }
}
