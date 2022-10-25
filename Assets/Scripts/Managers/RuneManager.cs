using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneManager : MonoBehaviour
{

    /// <summary>
    /// In charge of all rune and grimoire related
    /// </summary>

    public enum ENUM_RuneType
    {
        ENERGY,
        STRENGHT,
        HEALTH,
        LOVE,
        PROTECTION,
        COURAGE,
        //ENDLESS_LOVE,
        //SAFE_TRAVELS,
        //GRACE,
        GOOD_LUCK
    }

    public List<GameObject> RuneFragmentPrefabsLevel1;

    public enum ENUM_GrimoireType
    {
    }

    public Canvas PlayerCanvas;

    public List<ENUM_RuneType> collectedRunes;

    public List<ENUM_GrimoireType> collectedGrimoires;

    // Start is called before the first frame update
    void Start()
    {
        //collectedRunes = new List<ENUM_RuneType>();
        //collectedGrimoires = new List<ENUM_GrimoireType>();

        RuneFragmentPrefabsLevel1 = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RuneCaptured(RuneFragmentBehaviour rune)
    {
        Debug.Log("RuneManager got rune");

    }
}
