using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeText : MonoBehaviour 
{
	public void OnToggle(bool value)
	{
		if (value)
			GetComponent<Text>().text = "Close Hint";
		else
			GetComponent<Text>().text = "Show Hint";
	}
}
