using UnityEngine;

public class GuiltyStamp : DragObject2D
{
    public Sprite stampSprite; // Спрайт печати

    void OnMouseDown()
    {
        AttachStampToPaper();
    }

    void AttachStampToPaper()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero);
        if (hit.collider != null && hit.collider.gameObject.GetComponent<Paper>() != null)
        {
            
            hit.collider.gameObject.GetComponent<Paper>().AttachStamp(stampSprite);
        }
    }
}
