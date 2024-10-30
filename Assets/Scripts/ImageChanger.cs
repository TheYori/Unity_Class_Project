using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Image imageComponent;    //image component
    public Sprite orignalSprite;    // OG asset
    public Sprite tempSprite;       // temp asset

    //Function to attach to button
    public void ChangeSprite()
    {
        StartCoroutine(ChangeSpriteRoutine());
    }

    //Coroutine to change assets
    private IEnumerator ChangeSpriteRoutine()
    {
        imageComponent.sprite = tempSprite;

        yield return new WaitForSeconds(3);

        imageComponent.sprite = orignalSprite;
    }
}
