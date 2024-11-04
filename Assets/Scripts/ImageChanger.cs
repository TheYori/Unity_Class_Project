// AUTHOUR: Ricki G. Matwijkiw
// Assited by ChatGPT-4 Turbo model
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Image imageComponent;    //image component
    public Sprite orignalSprite;    // OG asset
    public Sprite tempSprite;       // temp asset
    public int waitTime = 3;

    //Function to attach to button
    public void ChangeSprite()
    {
        StartCoroutine(ChangeSpriteRoutine());
    }

    //Coroutine to change assets
    private IEnumerator ChangeSpriteRoutine()
    {
        imageComponent.sprite = tempSprite;

        yield return new WaitForSeconds(waitTime);

        imageComponent.sprite = orignalSprite;
    }
}
