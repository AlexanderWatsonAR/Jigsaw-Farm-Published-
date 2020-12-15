using UnityEngine;
using TMPro;
using System.Collections;

public class ChangeText : MonoBehaviour 
{
	public void OnToggle(bool value)
	{
		if (value)
			GetComponent<TextMeshProUGUI>().text = "Close Hint";
		else
			GetComponent<TextMeshProUGUI>().text = "Show Hint";
	}
}
