using UnityEngine;
using TMPro;

public class Paper : MonoBehaviour
{
    public TextMeshPro childTextMeshPro;
    public GameObject stampComplete; // Дочерний объект для отображения печати
    private TextData currentTextData;

    public void SetTextData(TextData textData, int order)
    {
        currentTextData = textData;
        childTextMeshPro.text = currentTextData.latterText;

        
        childTextMeshPro.sortingOrder = order + 1;
    }

    public bool IsCensor()
    {
        return currentTextData.isCensor;
    }

    public void AttachStamp(Sprite stampSprite)
    {
        
        GameObject newStamp = new GameObject("stampComplete");
        newStamp.transform.parent = stampComplete.transform;
        newStamp.transform.localPosition = Vector3.zero;

        
        SpriteRenderer stampSpriteRenderer = newStamp.AddComponent<SpriteRenderer>();
        stampSpriteRenderer.sprite = stampSprite;
    }
}

