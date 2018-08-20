using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	
	public Text timerText;
	public Slider timerSlider;
	public int timeForLevel = 80; 
	private CountdownTimer countdownTimer;
	private int secondsLeft = 80;

	void Start() 
	{
		countdownTimer = GetComponent<CountdownTimer>();
		countdownTimer.ResetTimer(timeForLevel); 
		countdownTimer.GetSecondsRemaining ();
	}
	
	
	void Update() 
	{
		CheckGameOver(secondsLeft);
		UpdateTimerDisplay(secondsLeft);
		UpdateTimerSlider();
	}
	
	public void UpdateTimerSlider()
	{
		float proportionLeft = countdownTimer.GetSecondsRemaining ();
		timerSlider.value = proportionLeft;
	}
	
	private void CheckGameOver(int secondsLeft)
	{

		if(timerSlider.value <= 0)
		{
			Application.LoadLevel("scene8_GameOver"); 
		}
	}
	
	
	public void UpdateTimerDisplay(int secondsLeft)
	{
		string timerMessage = "Time left = " + timerSlider.value;
		timerText.text = timerMessage;
	}
	
}
