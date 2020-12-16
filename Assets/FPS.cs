using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float fps = 1.0f / Time.deltaTime;
        GetComponent<TMPro.TextMeshProUGUI>().text = fps.ToString();
    }
}
