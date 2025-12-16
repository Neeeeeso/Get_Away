using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    public Button boton;
    bool ejecucion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boton.onClick.AddListener(TaskOnClick); 
        Manager.InitGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
    if (!ejecucion)
    {
        ejecucion = true;
        SceneManager.LoadScene("SampleScene");
    }
         
                 
    }
}
