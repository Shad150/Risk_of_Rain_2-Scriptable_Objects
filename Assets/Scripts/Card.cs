using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "NewCard", menuName = "Card")]
public class Card : ScriptableObject
{
    public string _name;
    public string _rarity;
    public string _description;
    public string _tier;

    public Sprite _itemIcon;


    public int _recommendedMaxAmount;
}
