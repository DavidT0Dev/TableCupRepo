using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneFragmentBehaviour : MonoBehaviour
{
    RuneManager runeManager;

    [SerializeField] public GameObject relatedSprite;

   

    // Start is called before the first frame update
    void Start()
    {
        runeManager = GameObject.Find("RuneManager").GetComponent<RuneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Runastic!");
        relatedSprite.SetActive(true);
        Destroy(this.gameObject);
    }
}
