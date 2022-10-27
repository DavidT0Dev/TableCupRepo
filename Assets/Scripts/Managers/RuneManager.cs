using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public List<Sprite> collectedRuneSpritesL1;

    public List<GameObject> RuneFragmentPrefabsLevel1;

    public List<Vector2> RuneScreenPositions;

    public Canvas PlayerCanvas;

    public List<ENUM_RuneType> collectedRunes;

    public float runeSpriteSpacing;

    // Start is called before the first frame update
    void Start()
    {
        //collectedRunes = new List<ENUM_RuneType>();
        //collectedGrimoires = new List<ENUM_GrimoireType>();

        //playerScreen = GameObject.Find("Canvas").GetComponent<>;

        RuneFragmentPrefabsLevel1 = new List<GameObject>();

        collectedRuneSpritesL1 = new List<Sprite>();
            
        RuneScreenPositions = new List<Vector2>();
        RuneScreenPositions.Add(new Vector2(0f - 200f, 0f + 400f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RuneCaptured(Sprite runeSprite)
    {
        Debug.Log("RuneManager got rune");
        collectedRuneSpritesL1.Add(runeSprite);
        AddRuneToCanvas(runeSprite);

    }

    public void AddRuneToCanvas(Sprite runeSprite)
    {
        GameObject imgObject = new GameObject("Rune" + collectedRuneSpritesL1.Count);

        RectTransform trans = imgObject.AddComponent<RectTransform>();
        trans.transform.SetParent(PlayerCanvas.transform); // setting parent
        trans.localScale = Vector3.one;

        trans.anchoredPosition = RuneScreenPositions[RuneScreenPositions.Count - 1]; // setting position, will be on center
        RuneScreenPositions.Add(RuneScreenPositions[RuneScreenPositions.Count - 1] + new Vector2(runeSpriteSpacing, 0f));
        trans.sizeDelta = new Vector2(150, 200); // custom size

        

        Image image = imgObject.AddComponent<Image>();
        Texture2D tex = Resources.Load<Texture2D>("red");
        image.sprite = runeSprite;
        imgObject.transform.SetParent(PlayerCanvas.transform);
    }
}
