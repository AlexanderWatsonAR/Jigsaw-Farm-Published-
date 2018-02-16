using System.Collections;
using UnityEngine;

public class LoopAnimation : MonoBehaviour
{
    public string AnimationName;
    public int NumberOfLoops;
    public float Interval;

    private Animator a;

    void Start()
    {
        a = GetComponent<Animator>();
        StartCoroutine(PlayAnimationWithInterval(NumberOfLoops, Interval));
    }
    private IEnumerator PlayAnimationWithInterval(int n, float time)
    {
        while (n > 0)
        {
            a.Play(AnimationName, -1, 0.0f);
            --n;
            yield return new WaitForSeconds(time);
        }
    }
}
