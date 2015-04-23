using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D Bullet)
    {
        if (Bullet.tag == "Hind")
            Destroy(gameObject);

        if (Bullet.tag == "Goal")
            Destroy(gameObject);

        if (Bullet.tag == "Enemy")
            Destroy(gameObject);


    }


}
