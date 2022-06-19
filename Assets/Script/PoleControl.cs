using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleControl : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, speed * Time.deltaTime, 0f));
        
        // Transform özelliği nesnenin duruşu ve pozisyonu özelliklerini içinde tutar
        //Döndür, Ölçekle, pozisyon gibi detayları özellikleri vardır. ve 3 boyutlu uzayın bir vektörünü kullanır.
        // Vector 3 dediğiniz zaman siz aslında 3 boyutlu bir uzay vektörü diyorsunuz. Vektör(x ekseni,y ekseni, z ekseni)
    }
}
