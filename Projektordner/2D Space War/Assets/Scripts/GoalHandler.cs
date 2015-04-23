using UnityEngine;
using System.Collections;


public class GoalHandler : MonoBehaviour {

    public GameObject soundi;
	public GameObject Hindernis;

	void OnTriggerEnter2D(Collider2D Goal)
    {
        

        if (Goal.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(Hindernis);

            GameObject soundy = (GameObject)Instantiate(soundi, transform.position, transform.rotation);
            soundy.layer = gameObject.layer;
        }


    }


}
