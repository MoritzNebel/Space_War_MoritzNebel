using UnityEngine;
using System.Collections;

public class SelfDestruct2 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D Bullet2)
    {
        if (Bullet2.tag == "Hind")
            Destroy(gameObject);

        if (Bullet2.tag == "Goal")
            Destroy(gameObject);

        if(Bullet2.tag == "Enemy")
            Destroy(gameObject);


    }
}
