
using UnityEngine;

public class Fabric : MonoBehaviour
{
   public Item itemInfos;

   public ItemBehavior Item;

  public  Slots Slot;
    int ResultId;
 

 public  void  Check() // on fait un switch pour checker l'Id de l'item et en fonction de son ID et de celle du "Slot" on fais spawn un item différent                         // en fonction de la somme des IDs
    {
       ResultId = Item.ItemId + Slot.SlotID;

        Debug.Log(ResultId);
        switch (ResultId)
        {
            case 0:
                if(ResultId == 0)
                {
                    itemInfos.name = "Belouga";
                    itemInfos.color = Color.cyan;
                    Slot.Spawn(itemInfos);
                }
                    break;

            case 1:
                if(ResultId == 1)
                {
                itemInfos.name = "Coquelicot";
                itemInfos.color = Color.red;
                Slot.Spawn(itemInfos);

                }
              
                break;
                case 2:
                if(ResultId == 2)
                {
                itemInfos.name = "oiseau";
                itemInfos.color = Color.gray;
                Slot.Spawn(itemInfos);

                }
                break;
                case 3:
                if(ResultId == 3)
                {
                    itemInfos.name = "Crocodile";
                    itemInfos.color = Color.yellow;
                    Slot.Spawn(itemInfos);

                }
                break;
                case 4:
                if (ResultId == 4)
                {
                    itemInfos.name = "Dragibus";
                    itemInfos.color = Color.magenta; 
                    Slot.Spawn(itemInfos);
                }
                break;
                case 5:
                if(ResultId == 5)
                {
                    itemInfos.name = "Chargeur USB-C";
                    itemInfos.color = Color.white;
                    Slot.Spawn(itemInfos);
                }
                break;


        }

       
    }
}
