using UnityEngine;
using UnityEditor;
using System.Collections;

public class EditorExtension  : EditorWindow  {
	private string myString = "";//initialising the string for the username
	private bool groupEnabled;//enbale section bool
	private bool myBool = true;//another bool fr sound
	private float myFloat = 1.23f;//float for the slider
	//public float secs = 10f;//this is for a bar that wasnt made
	//public float startVal = 0f;//this is for a bar that wasnt made
	//public float progress = 0f;//this is for a bar that wasnt made
	//public static AsyncOperation UnloadUnusedAssets(); //wanted to compress all the files while in game
	[MenuItem("Window/Example Window")]//addding menu item "Example Window" to the Window menu
	public static void ShowWindow(){//calling out the windown for it
		EditorWindow.GetWindow(typeof(EditorExtension));//Show existing window instance. If one doesn't exist, make one.
	}//ending the method for calling winow
	void OnGUI(){//all action happens onGui
		GUILayout.Label ("Basic Settings", EditorStyles.boldLabel);//creating a label and defining it
		myString = EditorGUILayout.TextField ("Username", myString);//a textfield fr the username input
		groupEnabled = EditorGUILayout.BeginToggleGroup ("Optional Settings", groupEnabled);//starting a group blocked off section , toggle to show it 
		myBool = EditorGUILayout.Toggle ("Sound", myBool);//toggle to adjust the sound on or off
		myFloat = EditorGUILayout.Slider ("Lightning", myFloat, -3, 3);//making the lightining slider 
		EditorGUILayout.EndToggleGroup ();//ending the group section
		//this creates a windw by in the menu as an item that an editor user can access it while in/out of the game
		//Tried making a progress bar, as a loading screen.. Cousdnt get my head around it..
		/*
		secs = EditorGUILayout.FloatField("Time to wait:", secs);
		if (GUILayout.Button ("Display bar")) {
			startVal = (float)EditorApplication.timeSinceStartup;
		} if (progress < secs) {
			EditorUtility.DisplayProgressBar ("Simple Progress Bar", "S", progress / secs);
		} else {
			EditorUtility.ClearProgressBar ();
		}
		progress = (float)(EditorApplication.timeSinceStartup - startVal);
		*/

		}	
			//made for the rogress bar, unused because the bar was unsuccesful
			/*
			void OnInspectorUpdate() {
				Repaint();
			}*/
}
