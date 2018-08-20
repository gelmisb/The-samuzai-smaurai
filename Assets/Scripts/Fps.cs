using UnityEngine;
using System.Collections;

public class Fps : MonoBehaviour {
	Rect fpsRect;
	GUIStyle style;

	void Start(){
		fpsRect = new Rect (1100, 50, 100, 100);
		style = new GUIStyle ();
		//style.alignment = TextAnchor.UpperRight;
		style.fontSize = 24;
	}
	void Update(){

	}
	
	void OnGUI()
	{
		float fps = 1 / Time.deltaTime;
		GUI.Label (fpsRect, "FPS: " + fps);
	}
}


