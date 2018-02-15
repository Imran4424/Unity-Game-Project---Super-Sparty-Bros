using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; //this is needed since this script references the unity Editor

[CustomEditor(typeof(GameManager))]
public class GameManagerEditor : Editor { //extends the editor class


	//called when Unity Editor Inspector is updated
	public override void OnInspectorGUI()
	{
		//show the default inspector stuff for this component
		DrawDefaultInspector();

		//get a reference to the GameManager script on this target game Object
		GameManager myGM = (GameManager) target;

		//add a custom button to the Inspector component
		if (GUILayout.Button ("Reset Player State")) 
		{
			//if this button pressed, then call function on script
			PlayerPrefManager.ResetPlayerState(myGM.startLives,false);
		}

		//add a custom button to the inspector component
		if (GUILayout.Button ("Reset Highscore"))
		{
			//if this button pressed , then call function on script
			PlayerPrefManager.SetHighscore(0);
		}

		//add a custom button to inspector component
		if (GUILayout.Button ("Output Player State")) 
		{

			//if this button pressed , then call the function on script
			PlayerPrefManager.ShowPlayerPrefs();
		}

	}
		
}
