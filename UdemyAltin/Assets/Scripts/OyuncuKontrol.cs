using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public OyunKontrol oyunK;
    private float hiz = 10f;
    public AudioClip altin, dusme;

    // Start is called before the first frame update
    void Start()
    {

      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunK.oyunAktif) { 

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        x *= Time.deltaTime * hiz;
        y *= Time.deltaTime * hiz;

        transform.Translate(x, 0, y);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        Debug.Log(c.gameObject.tag);
        if (c.gameObject.tag.Equals("Altin"))
        {
            GetComponent<AudioSource>().PlayOneShot(altin, 1f);
            oyunK.AltinArttir();
            Destroy(c.gameObject);
        }
        if (c.gameObject.tag.Equals("Dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
            oyunK.OyunPasif();


        }
    }
}
