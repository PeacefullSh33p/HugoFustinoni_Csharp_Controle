
using UnityEngine;
using UnityEngine.EventSystems;


public class ItemBehavior : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public GameObject Item;
    public Item ItemInfos;
    public int ItemId;
    public void Start()
    {

        ItemId = Random.Range(0, 3);

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if(eventData.pointerDrag!= null )
        {
            
           
            if (eventData.pointerDrag == Item)
            {
                Item.transform.position = eventData.position;
                 Debug.Log("Drag Start");
            }

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag == Item)
            {
                Item.transform.position = eventData.position;
                Debug.Log("Dragggggg");
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null )
        {

        }
    }

   
}
