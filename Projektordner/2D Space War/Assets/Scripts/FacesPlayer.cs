using UnityEngine;
using System.Collections;

public class FacesPlayer : MonoBehaviour {

    public float rotSpeed = 90f;
    Transform player;
	void Update () {
        if (player == null)
        {
            GameObject go = GameObject.Find("PlayerShip");

            if (go != null)
            {
                player = go.transform;
            }
        }
            Vector3 dir = player.position - transform.position; // Position Spieler - Position Gegner
            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg -90;
			
            Quaternion desiredRot = Quaternion.Euler(0,0, zAngle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed);
	}
}
