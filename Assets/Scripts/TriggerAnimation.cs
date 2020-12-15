using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public string AnimationTag;

    public void Animate()
    {
        GameObject[] clips = GameObject.FindGameObjectsWithTag(AnimationTag);

        foreach(GameObject clip in clips)
        {
            clip.GetComponent<Animator>().enabled = true;
            clip.GetComponent<Animator>().Play(0);
        }
    }
    public void Animate(string clipName)
    {
        GameObject[] clips = GameObject.FindGameObjectsWithTag(AnimationTag);

        foreach (GameObject clip in clips)
        {
            clip.GetComponent<Animator>().enabled = true;
            clip.GetComponent<Animator>().Play(clipName);
        }
    }
}
