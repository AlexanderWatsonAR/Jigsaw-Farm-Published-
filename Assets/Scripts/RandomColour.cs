using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColour : MonoBehaviour
{
    private Color[] colours = { new Color(0.7333333f, 0.02352941f, 0.02352941f), new Color(0.2214533f, 0.3455435f, 0.9411765f), Color.cyan, Color.green, new Color(0.5735294f, 0.3249824f, 0.05482265f), new Color(0.9686275f, 0.9607844f, 0.0f), Color.red, Color.white, new Color(0.6901961f, 0.6901961f, 0.6901961f), new Color(0.4745098f, 0.6862745f, 0.2352941f), new Color(0.5215687f, 0.3686275f, 0.2588235f) };

    // Start is called before the first frame update
    void Start()
    {
        Color randomColour = colours[Random.Range(0, colours.Length - 1)];

        if (GetComponent<Image>() != null)
            GetComponent<Image>().color = randomColour;
        else
            GetComponent<Renderer>().materials[0].color = randomColour;
    }
}
