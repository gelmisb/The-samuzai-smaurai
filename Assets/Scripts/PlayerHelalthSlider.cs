using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHelalthSlider : MonoBehaviour {
	public Slider healthSlider;//making a slider for the health bar
//	private int currentHealth;//current health as in the health that is activer(being tken down or stopped)
	private int startingHealth = 100;//health bar starts at 100 as all games
	private int lives = 3;//initialising the lives so when the healthbar is 0 take away the lives
	private Player player;//calling out the player script
	private PlayerDisplay playerDisplay;//calling the display script

	void Start () {// Use this for initialization
		playerDisplay = GetComponent<PlayerDisplay>();//getting the component of the display
		player = GetComponent<Player> ();//calling the player component
		//playerDisplay.UpdateLivesImage(lives);//getting the update lives method from the display
	}//end of start
	void Update () {// Update is called once per frame
		checkIfDead ();//check for everyframe if the player has less thn 0 left
	}//end of update
	private void checkIfDead(){//checking if the player is dead or not
		if (healthSlider.value <= 0) {//asking if the healthbar is less pr equal to 0
			lives -= 1;//if yes take awat some lives
			playerDisplay.UpdateLivesImage (lives);//updating the display
			player.MoveToStartPosition ();//moving to start position
			healthSlider.value = startingHealth;//initialising that starting health is equal to the slider
		}//end of if for healthslider value
	}//end of check if dead method
	public void OnTriggerStay(Collider hit){//while colliders are together
		if (hit.gameObject.tag == "Enemy") {//comprae the tag t enemy
			healthSlider.value -= 0.2f;//take the health away
		}//end of if compare tag
	}//end of ontriggerstay
}//end of class
