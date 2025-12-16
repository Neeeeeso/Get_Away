using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioParaVariasescenas : MonoBehaviour
{
   
    AudioSource musica;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private static AudioParaVariasescenas _instance; 
    void Awake(){
        if(_instance == null){
            //DontDestroyOnLoad(this.gameObject);
            //created=true;
            musica = GetComponent<AudioSource>();
            _instance=this;
            DontDestroyOnLoad(this.gameObject);
            musica.Play();
            
        }
        else{
            Destroy(this);
        }
    }      
    
}
