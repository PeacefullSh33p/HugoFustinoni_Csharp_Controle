
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Slots : MonoBehaviour, IDropHandler
{

    public Item itemInfos;
    public Transform SpawnLocation;
    public Fabric fabrique;
    public int SlotID;
   [SerializeField] private bool Spawned;  
    [SerializeField] private GameObject ItemToSpawn;


    public void Start()
    {
       
        SlotID = Random.Range(0, 3);
        Debug.Log(SlotID);
    }
    private void Update()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            if(eventData.pointerDrag.GetComponent<ItemBehavior>() != null)
            {

                fabrique.Check();
                Destroy(eventData.pointerDrag.gameObject);
                Destroy(this.gameObject);
               
             
            }
            Debug.Log("J'ai Drop");

        }
    }



    public void Spawn(Item iteminfos)
    {
        GameObject CurrentObject = Instantiate(ItemToSpawn, SpawnLocation);
        CurrentObject.name = itemInfos.name;        
        CurrentObject.AddComponent<Image>();
        CurrentObject.GetComponent<Image>().sprite = itemInfos.Image;
        CurrentObject.GetComponent<Image>().color = itemInfos.color;


        Debug.Log("l'objet a spawn");
    }

 
}
