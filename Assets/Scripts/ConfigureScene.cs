using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfigureScene : MonoBehaviour
{
    void Awake()
    {
        float height = Screen.currentResolution.height;
        float width = Screen.currentResolution.width;

        float aspectRatio = height / width;
        //aspectRatio = 1.77777777f;

        if (aspectRatio > 2.0f)
            return;

        string sceneName = SceneManager.GetActiveScene().name;

        switch(sceneName)
        {
            case "Start":
                StartSceneSetup();
                break;
            case "BlocksPuzzle2x2 WithHint":
                break;
            case "BlocksPuzzle3x3 WithHint":
                break;
            case "MatchTheShapesGame":
                MatchShapesSetup();
                break;
            case "JigsawGame2x2":
                JigsawPuzzle2x2Setup();
                break;
            case "JigsawGame3x3":
                JigsawPuzzle3x3Setup();
                break;
        }
    }

    void StartSceneSetup()
    {
        GameObject snow = GameObject.Find("Snow");
        snow.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-0.10535f, -3.38f, -41.00008f);
        snow.GetComponent<RectTransform>().sizeDelta = new Vector2(12944.8f, 1759.97f);
    }

    void JigsawPuzzle2x2Setup()
    {
        GameObject caption = GameObject.Find("Caption");
        caption.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0.013851f, 1185f, -150f);
        caption.GetComponent<RectTransform>().sizeDelta = new Vector2(1163.7f, 95f);

        GameObject next = GameObject.Find("Button Next Puzzle");
        next.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0f, 800f, -150f);
    }

    void JigsawPuzzle3x3Setup()
    {
        GameObject caption = GameObject.Find("Caption");
        caption.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0.013851f, 1200f, -150f);
        caption.GetComponent<RectTransform>().sizeDelta = new Vector2(1163.7f, 95f);

        GameObject next = GameObject.Find("Button Next Puzzle");
        next.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0f, 800f, -150f);
    }

    void MatchShapesSetup()
    {
        GameObject caption = GameObject.Find("Caption");
        caption.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0.013851f, 1225f, -150f);
        caption.GetComponent<RectTransform>().sizeDelta = new Vector2(1163.7f, 95f);

        GameObject next = GameObject.Find("Button Next Puzzle");
        next.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(0f, 725f, -150f);
    }


}
