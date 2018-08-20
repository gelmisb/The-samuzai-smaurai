using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public string restart;//initiating a restart string
	public string mainMenu;//main menu string 
	public bool isPaused;//and a bool to see when its paused
	public GameObject pausedMenuCanvas;//referencing the paused menu canvas go
	// Update is called once per frame
	void Update () {//checking this for every frame since its in the game already
		if (isPaused) {//if the pause meu is activated
			pausedMenuCanvas.SetActive (true);//show the canvas pause menu
			Time.timeScale = 0f;//slow down the game to 0movement
		} else {//if its not true
			pausedMenuCanvas.SetActive(false);//set the paused menu canvas to invisible 
			Time.timeScale = 1f;//returning the game to its normal speed
		}//end of if else statemnts
		if (Input.GetKeyDown (KeyCode.P)) {//when user presses letter p
			isPaused = !isPaused;//true is equal to not true.. it makes sense
		}//end of if input key statement
	}//ending the update method
	public void Resume(){//calling the resume method
		isPaused = false;//whe pressed saying that its not paused anymore
	}//ending the pause method
	public void Restart(){//on restart we load the same level but different for each level
		Application.LoadLevel (restart);//restarting
	}//end of restart method
	public void MainMenu(){//calling the main menu
		Application.LoadLevel (mainMenu);//when button pressed load mai menu
	}//end of main menu method
}//end of main class
