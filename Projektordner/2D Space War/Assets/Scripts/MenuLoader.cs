using UnityEngine;
using System.Collections;

public class MenuLoader : MonoBehaviour {

	void Update () {
		if (Input.GetButton("Submit"))
		{
			TimeDamageHandler.live = 0;
			Application.LoadLevel("Menu");
		}
		
		
	}
}
