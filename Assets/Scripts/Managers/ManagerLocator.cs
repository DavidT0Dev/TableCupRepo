using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerLocator : MonoBehaviour
{

    public static ManagerLocator Instance {get; private set;}

    public RuneManager runeManager;

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
}
