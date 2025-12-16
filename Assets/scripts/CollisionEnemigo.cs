using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionEnemigo : MonoBehaviour
{
    public Movement player;
    AudioSource sonido;

    public GameObject imagen1;
    public GameObject imagen2;
    public Button boton;
    bool ejecucion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sonido= GetComponent<AudioSource>();
        boton.onClick.AddListener(TaskOnClick);

        ejecucion=false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            sonido.Play();
            player.muerte=true;
            imagen1.SetActive(true);
            imagen2.SetActive(true);
            boton.gameObject.SetActive(true);

        }
    }

    void TaskOnClick()
    {

    if (!ejecucion)
    {

        ejecucion = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
         
                 
    }
}
