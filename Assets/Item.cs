
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "item", order = 1)]
public class Item : ScriptableObject
{
    public string ItemName;

    public int ID;
    public  Sprite Image;
    public Color color;

    
}
