using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CheckCompleted : MonoBehaviour
{
	public GameObject[] Slots;

	// Update is called once per frame
	void Update()
	{
		int count = 0;
		foreach (GameObject slot in Slots)
			if (slot.GetComponent<CheckCorrectPiece>().IsCorrectPiece)
				count++;

		if (count == Slots.Length)
		{
			GameObject.FindGameObjectWithTag ("Board").GetComponent<Image>().enabled = true;
			GameObject.Find ("Animal Caption").GetComponent<Text>().enabled = true;
		} 
		else
		{
			GameObject.FindGameObjectWithTag ("Board").GetComponent<Image>().enabled = false;
			GameObject.Find ("Animal Caption").GetComponent<Text>().enabled = false;
		}


	}
}
