using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public void Play(string clipName)
    {
        GetComponent<Animator>().enabled = true;
        GetComponent<Animator>().Play(clipName);
    }
}
