using UnityEngine;

public class Puerta : MonoBehaviour
{
    public Palanca palanca;
    public Sprite sprito;
    SpriteRenderer sp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sp= GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(palanca.puerta==true){
            sp.sprite = sprito;
        }
    }
}
