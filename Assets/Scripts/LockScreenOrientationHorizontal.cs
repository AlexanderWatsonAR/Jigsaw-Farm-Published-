using UnityEngine;
using System.Collections;

public class LockScreenOrientationHorizontal : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{
		Screen.orientation = ScreenOrientation.Portrait;
	}
}
