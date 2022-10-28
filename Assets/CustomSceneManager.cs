using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomSceneManager : MonoBehaviour
{

    public static CustomSceneManager Instance { get; private set; }

    private Animator Fader;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneName(string sceneName)
    {
        Fader = GameObject.Find("Fader").GetComponent<Animator>();
        Fader.SetTrigger("FadeIn");
        Fader.gameObject.SetActive(false);
        //StartCoroutine(Waiter());
        SceneManager.LoadScene(sceneName);
        Fader.gameObject.SetActive(true);
        Fader.SetTrigger("FadeOut");
    }

    //public IEnumerator Waiter()
    //{
    //    yield return new WaitForSecondsRealtime(10);
    //}
}
