using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadNextLevel : MonoBehaviour
{
    //public GameObject Music;
    public int currentLevel;
	public Text Level;

	void Update()
	{
		
		Level.text = "Level: " + currentLevel;
	}
    void OnTriggerEnter2D(Collider2D PlayerShip)
    {
               

				if (PlayerShip.tag == "FinalGoal") {
						
					if (GameObject.FindGameObjectsWithTag ("Goal").Length == 0) {
							
						if(TimeDamageHandler.live <= 0){

								Application.LoadLevel ("Menu");
                
						}
						else{
								Application.LoadLevel ("Game2." + (currentLevel + 1));

						}
			
			
					}

   


				}
	}
}