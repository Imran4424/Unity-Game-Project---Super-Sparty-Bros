using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

 //this is needed since this script references the unity Editor

//this is a script that enhances unity editor(aka, Editor Script)
public class DeleteAllPlayerPrefs : ScriptableObject
{


	//Delete All PlayerPrefs after the confirmation dialog
	[MenuItem ("Editor/Delete Player Prefs")]
	static void DeletePrefs ()
	{
		if (EditorUtility.DisplayDialog ("Delete all player preferences?",
			    "Are you sure you want to delete all the player preferences,this can not be undone?",
			    "Yes", "No")) {


			PlayerPrefs.DeleteAll ();
		}

	}



}
