using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneFragmentBehaviour : MonoBehaviour
{
    RuneManager runeManager;

    int whichLevelLocated;
    Sprite fragmentSprite;

    // Start is called before the first frame update
    void Start()
    {
        runeManager = GameObject.Find("RuneManager").GetComponent<RuneManager>();
        fragmentSprite = GetComponentInChildren<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Rune fragment collected");

        runeManager.RuneCaptured(fragmentSprite);
        Destroy(this.gameObject);
        Destroy(this);
    }
}
