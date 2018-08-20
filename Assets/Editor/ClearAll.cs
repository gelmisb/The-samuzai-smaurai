using UnityEditor;
using UnityEngine;
using System.Collections;

// Shows the Assets menu when you right click on the contextRect Rectangle.
public class ClearAll : MonoBehaviour {
	[MenuItem("Tools/Clear All")]//creating new menu item 
	public static void ShowWindow(){//a method to show the editor window
		EditorWindow.GetWindow(typeof(ClearAll));//show the window instance
	}//end of method to show window
	void OnGUI(){//again action happens in the GUI
		if (GUI.Button (new Rect (100, 100, 50, 50), "Clear all?")) {//adding a button to clear the process
			PlayerPrefs.DeleteAll();//deleting all the player prefs
		}//end of if stement with a gui button
	}//endingon gui method
}//ending the main class
