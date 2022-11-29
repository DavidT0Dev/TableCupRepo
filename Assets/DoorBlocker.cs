using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlocker : MonoBehaviour
{
    public List<GameObject> runeFragments;

    bool isDoorEnabled;

    // Start is called before the first frame update
    void Start()
    {
        isDoorEnabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = isDoorEnabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckAllFragments() && !isDoorEnabled)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }

    public bool CheckAllFragments()
    {

        bool _bool = true;
        foreach (GameObject go in runeFragments)
        {
            if (!go.activeInHierarchy)
            {
                _bool = false;
            }
        }

        return _bool;
    }
}
