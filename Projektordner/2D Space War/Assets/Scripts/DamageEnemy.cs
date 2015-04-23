using UnityEngine;
using System.Collections;

public class DamageEnemy : MonoBehaviour {

    public float health = 1;

    void OnTriggerEnter2D(Collider2D Enemy)
    {

        if (Enemy.tag == "Bullet")
        {
            health--;
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }


}
