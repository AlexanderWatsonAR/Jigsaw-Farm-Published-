using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeControl : MonoBehaviour
{
    public bool isBlocksScene = true;

    // Start is called before the first frame update
    void Start()
    {
        if(isBlocksScene)
            GetComponent<Animator>().enabled = BlocksSceneLoadData.IsFadeInEnabled;
        else
            GetComponent<Animator>().enabled = ShapesLoadData.IsFadeInEnabled;
    }

    public void DisableFade()
    {
        if (isBlocksScene)
        {
            GetComponent<Animator>().enabled = false;
            BlocksSceneLoadData.IsFadeInEnabled = false;
        }
        else
        {
            GetComponent<Animator>().enabled = false;
            ShapesLoadData.IsFadeInEnabled = false;
        }
    }

    public void EnableFade()
    {
        if (isBlocksScene)
        {
            GetComponent<Animator>().enabled = true;
            BlocksSceneLoadData.IsFadeInEnabled = true;
        }
        else
        {
            GetComponent<Animator>().enabled = true;
            ShapesLoadData.IsFadeInEnabled = true;
        }
    }
}
