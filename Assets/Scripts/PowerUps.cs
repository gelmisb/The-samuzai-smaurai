using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PowerUps : MonoBehaviour {
	public GameObject shield;//power ups for the player
	public GameObject moreHealth;//power ups for the player
	public AudioClip laugh;//playing an audioclip when clllecting the health power up
	public Slider healthSlider; //initialising the slider to stop health when shield is active
	public Text timeShieldText;//creating a text to show how much seconds is left
	private bool shieldVisible = false;//nitialising the shield
	private int timeForShield = 1; //enable for the time limit on the shield
	private CountdownTimer countdownTimer;//callng out other classes for this script
	// Use this for initialization
	void Start () {
		moreHealth.SetActive(false);//setting the shield to be deactivated to remain neutral
		countdownTimer = GetComponent<CountdownTimer>();//getting the components from  different scrpts
		countdownTimer.ResetTimer(timeForShield);//getting the timing method
		countdownTimer.GetSecondsRemaining ();//getting sedonds remaining from the timer
	}//END OF START
	// Update is called once per frame
	void Update () {//starting update method
		float proportionLeft = countdownTimer.GetSecondsRemaining ();//calculating how much time there's left
		UpdateDisplay(timeForShield);//updating the visuals
		if(proportionLeft <= 0){//if time is 0
			moreHealth.SetActive(false);//turn the shield of helth off
			string msg = "";//print out a message saying
			timeShieldText.text = msg;//making the string to be that text
		}//end of if proportionleft
	}//end of update method
	//private because its only used in here
	private void UpdateDisplay(int timeForLevel){//how much time is needed
		if (shieldVisible == true) {//if you pick up the shiel
			float proportionLeft = countdownTimer.GetSecondsRemaining ();//getting how much time is left till it will expire
			string timerMessage = "Time left = " + proportionLeft;//shoing how much timme is left
			timeShieldText.text = timerMessage;//making the text to show the string
		}//end of shield visible if
	}//end of updating the disply
	//when hitting the health GO collider
	void OnTriggerEnter(Collider hit){//starting the n  trigger method
		if (hit.CompareTag ("Shield")) {//comparing the tags
			shieldVisible = true;//if the shield is visible
			string msg = "Health increased";//show that your healt has increased
			timeShieldText.text = msg;//making the text to display the string
			countdownTimer.ResetTimer(timeForShield); //resetting the timer
			moreHealth.SetActive(true);//making the shield active for that amount of time
			UpdateDisplay(timeForShield);//updating the visuals
			healthSlider.value = 100f;//restoring the health after the shield is shown
			Destroy(hit.gameObject);//destroyng thhe shield health gO
			GetComponent<AudioSource> ().PlayOneShot (laugh);//playing a shot for laughing
		}//end of comprae tag sound
	}//end of on trigger method
	
}
