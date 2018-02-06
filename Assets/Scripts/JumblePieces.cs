using UnityEngine;

public class JumblePieces : MonoBehaviour
{
	public GameObject[] Pieces;

	// Use this for initialization
	void Start() 
	{
		int random = Random.Range(0, 3);

		if (random == 2)
			return;
		Swap(random);
	}

	void Swap(int value)
	{
		// Check if the value is even.
		// If true, swap the positions of the pieces with even numbered index position in the array.
		// If false, do the same, but only for the odd numbers.
		if (value % 2 == 0)
		{
			Vector3 temp = Pieces[0].transform.position;
			Pieces[0].transform.position = Pieces[2].transform.position;
			Pieces[2].transform.position = temp;                         
		} 
		else
		{
			Vector3 temp = Pieces[1].transform.position;
			Pieces[1].transform.position = Pieces[3].transform.position;
			Pieces[3].transform.position = temp;
		}
	}
}
