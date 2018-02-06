using UnityEngine;
using UnityEngine.UI;


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
			GameObject.Find ("Title").GetComponent<Text>().enabled = true;
            GameObject caption = GameObject.Find("Caption");
            caption.GetComponent<Text>().enabled = true;
            if (caption.GetComponent<ChangeText>() != null)
                caption.GetComponent<ChangeText>().enabled = false;
            if (caption.GetComponent<Toggle>() != null)
                caption.GetComponent<Toggle>().enabled = false;
            caption.GetComponent<Text>().text = "Correct. Well Done!";
            GameObject.Find("Button Next Puzzle").GetComponent<Text>().enabled = true;
            foreach (GameObject slot in Slots)
                if (slot.GetComponent<CheckCorrectPiece>().IsCorrectPiece)
                {
                    slot.GetComponent<CheckCorrectPiece>().enabled = false;
                    this.enabled = false;
                }
        } 
	}
}
