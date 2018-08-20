using UnityEngine;
using System.Collections;

public class ButtonActions : MonoBehaviour {

	public void BUTTON_LOAD_SCENE_WELCOME(){
		Application.LoadLevel("scene0_Welcome");
	}
	
	public void BUTTON_LOAD_SCENE_MENU(){
		Application.LoadLevel("scene5_Menu");
	}
	
	public void BUTTON_LOAD_SCENE_LEVEL1_PLAYING(){
		Application.LoadLevel("scene1_Level1Playing");
	}
	
	public void BUTTON_LOAD_SCENE_LEVEL2_PLAYING(){
		Application.LoadLevel("scene3_Level2Playing");
	}

	public void BUTTON_LOAD_HIGH_SCORES(){
		Application.LoadLevel("scene10_HighScores");
	}

	public void BUTTON_LOAD_HELP(){
		Application.LoadLevel("scene6_Help");
	}

	public void BUTTON_LOAD_HELP_CONTROLS(){
		Application.LoadLevel("scene7_Controls");
	}

	public void BUTTON_LOAD_HELP_TIPS(){
		Application.LoadLevel("scene8_Tips");
	}

	public void BUTTON_LOAD_CREDITS(){
		Application.LoadLevel("scene9_Credits");
	}

	public void BUTTON_LOAD_GAME_OVER(){
		Application.LoadLevel("scene2_gameOver");
	}

	public void BUTTON_LOAD_SCENE_LEVEL1_PASSED(){
		Application.LoadLevel("scene1_Level1Passed");
	}

	public void BUTTON_LOAD_SCENE_LEVEL2_PASSED(){
		Application.LoadLevel("scene4_GameWon");
	}

	public void Button_ExitGame(){
		Application.Quit();
	}

	public void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)){
			Application.Quit();
		}
	}
}

