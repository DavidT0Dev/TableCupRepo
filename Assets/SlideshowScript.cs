using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideshowScript : MonoBehaviour
{

    public List<GameObject> slides;

    public CustomSceneManager sm;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject slide in slides)
        {
            slide.SetActive(false);
        }
        slides[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Next()
    {
        if (slides.Count >= 2)
        {
            slides.RemoveAt(0);
            slides[0].SetActive(true);
        }
        else
        {
            sm.LoadSceneName(sceneName);
        }
    }
}
