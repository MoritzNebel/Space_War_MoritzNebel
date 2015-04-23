using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float maxSpeed = 5f;
    public float rotSpeed = 180f;

    float shipBoundaryRadius = 0.5f;

	void Start () {
	
	}
	

	void Update () {
        
        Quaternion rot = transform.rotation;
	    float z = rot.eulerAngles.z;
		z -= Input.GetAxis("Horizontal") * rotSpeed;
        rot = Quaternion.Euler(0, 0, z);
		transform.rotation = rot;
		Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0); 
        pos += rot * velocity;

        if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }

        if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }

        float screenRation = (float)Screen.width / (float)Screen.height; 
        float widthOrtho = Camera.main.orthographicSize * screenRation;

        if (pos.x + shipBoundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }

        if (pos.x - shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }

        transform.position = pos;
        

       }
}
