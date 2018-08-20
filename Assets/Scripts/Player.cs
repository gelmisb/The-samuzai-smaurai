using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	//variables for all the audio files
	public AudioClip coinSound;//when coin is picked up
	//public AudioClip katanaSlash;//for smasdhing the katana
	public AudioClip dieSound;//when player health goes below 0
	public AnimationClip attack;//animation clips for the plyer to excecute for attacking
	private int lives = 3;//creating some ui objects
	private int score = 0;//initialisng the score property
	private PlayerDisplay playerDisplay;//references to script
	private float delayBetweenDeaths = 5;//int to delay the die time
	private float nextTimeAllowedToDie = 0;//int that is necessary for the delay
	public GameObject cube;
	//----------------------------------------------------------------
	void Start(){
		playerDisplay = GetComponent<PlayerDisplay>();//calling out the script
		playerDisplay.UpdateScoreImage(score);//calling the method for score
		playerDisplay.UpdateLivesImage(lives);//caling the method for lives
	}//end of void start
	void Update(){//on every frame
		if(Input.GetButton("Fire1")){//check if the user pressed mouse(1)		     
			GetComponent<Animation>().Play("Attack");//get the animation and play attack animation
			GetComponent<Animation>().wrapMode = WrapMode.Default;//by default it only plays it once
			//GetComponent<AudioSource> ().PlayOneShot (katanaSlash);//playing an audiowhen katana is hitting
		}//end of if mouse input
		LoseLife ();
	}//end of update	
	//---------------------------LoseLife-------------------------------------
	public void LoseLife(){//void if the player loses a life to load the game over screen
		if(lives < 0){//if the lives are less than 0 load game Over scscreen
			Application.LoadLevel("scene2_gameOver");
		}//end of if statement
		playerDisplay.UpdateLivesImage(lives);//updating the display for the lives 
		//GetComponent<AudioSource>().PlayOneShot(dieSound);//playing an adioclip only once when the protaginist dies
	}//end of LoseLife#
	//---------------------------MoveToStartPosition-------------------------------------
	public void MoveToStartPosition() {//a method made for the player to more to a certain position after he dies
		Vector3 startPosition = new Vector3 (35, 11, 56);//map coordinates
		transform.position = startPosition;//trasnforming the player back to its starting psition
	}//end of move to start position
	//---------------------------OnTriggerEnter-------------------------------------
	void OnTriggerEnter(Collider hit) {//when colliders hit each other
		if (hit.CompareTag ("Coin")) {//comparing the colider with its tag 
			score++;//adding one to score
			playerDisplay.UpdateScoreImage (score);//udating the image for the score
			Destroy (hit.gameObject);//destroyng the game object
			GetComponent<AudioSource> ().PlayOneShot (coinSound);//playing audioclip once when the coin is picked up
		}//endS if for audiosource
		if (hit.CompareTag ("Enemy")) {//when intreracting with enemies collider
			if (Time.time > nextTimeAllowedToDie){//check if what time has passed
				//lives--;//taking lives out
				nextTimeAllowedToDie = Time.time + delayBetweenDeaths;//not letting theplayer die after
			}//end of if time
		}//end of if enemy compare tag
		if (hit.CompareTag ("Trigger")) {
			Application.LoadLevel("scene4_GameWon");
			Destroy(cube.gameObject);
		}
		if (hit.CompareTag ("Death")) {
			lives--;
			playerDisplay.UpdateLivesImage(lives);
			GetComponent<AudioSource>().PlayOneShot(dieSound);
			MoveToStartPosition();
			Destroy(hit.gameObject);
		}
		if (hit.CompareTag ("NewLevel")) {//when hitting the new level sphere collider
			if (score != 3) {//if score is not = 3
				Application.LoadLevel("scene2_gameOver");//load level failed
			} else{
			Application.LoadLevel("scene1_Level1Passed");//if you do have 3 level was passed
			}//end of else if
		}//end of if compare tag
	}//end of ontriggerenter method
}//end of class



