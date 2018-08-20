using UnityEngine;
using System.Collections;

public class PopUpMenu : MonoBehaviour {
	public GameObject yes;
	public GameObject no;
	public GameObject popUpWindow;
	public GameObject cancel;

	void Start(){
		popUpWindow.SetActive (false);
	}

	void Update(){
		ClickedButtonCancel ();
	}

	public void CheckButtonKey(){
		if (no==true) {
			popUpWindow.SetActive (true);
		}
	}

	public void ClickedButtonCancel(){
		if (cancel==true) {
			popUpWindow.SetActive (false);
		}
	}

	public void ClickedButtonMenu(){
		Application.LoadLevel ("scene2_Menu");
	}

	public void ClickedButtonQuit(){
		Application.Quit ();
	}
}
