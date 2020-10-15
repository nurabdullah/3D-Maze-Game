using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    public GameObject btn;
    public Text zaman,durum;
    private Rigidbody rg;
    public float Hiz = 1.5f;
    public  float zamanSayaci ;
   
    bool Oyundurumu = true;
    bool oyuntamam = false;
    void Start()
    {
        rg = GetComponent<Rigidbody> () ;
    }

    void Update()
    {
        if (Oyundurumu && !oyuntamam) {
            if (zamanSayaci > 0) { 
        zamanSayaci -= Time.deltaTime;
        zaman.text=(int)zamanSayaci+"";
        }

        }
        if (zaman.text=="0"){
            durum.text = "Maalesef Başaramadınız";
            btn.SetActive(true);
        }

        if (zamanSayaci < 0)
           
            Oyundurumu = false;

    }

     void FixedUpdate()
    {
        if (Oyundurumu&& !oyuntamam) { 
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3 (dikey,0,-yatay);
            rg.AddForce(kuvvet*Hiz);
        }
        else 
        {
           
            rg.angularVelocity = Vector3.zero;
            rg.velocity = Vector3.zero;
        }
    }

     void OnCollisionEnter(Collision cls)
    {
        string objismi = cls.gameObject.name;
        if (objismi.Equals("Bitis"))
        {
            
            oyuntamam = true;
            durum.text = "Tebrikler Kazandınızz";
            btn.SetActive(true);

        }

    }


}
