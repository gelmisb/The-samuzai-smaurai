using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour 
{
	private float countdownTimerStartTime;
	private int countdownTimerDuration;

	public int GetTotalSeconds()
	{
		return countdownTimerDuration;
	}

	public void ResetTimer(int seconds)
	{
		countdownTimerStartTime = Time.time;
		countdownTimerDuration = seconds;
	}
	
	public int GetSecondsRemaining()
	{
		int elapsedSeconds = GetElapsedSeconds();
		int secondsLeft = (countdownTimerDuration - elapsedSeconds);
		return secondsLeft;
	}

	public int GetElapsedSeconds()
	{
		int elapsedSeconds = (int)(Time.time - countdownTimerStartTime);
		return elapsedSeconds;
	}

	public float GetProportionTimeRemaining()
	{
		float proportionLeft = (float)GetSecondsRemaining() / (float)GetTotalSeconds();
		return proportionLeft;
	}
}
