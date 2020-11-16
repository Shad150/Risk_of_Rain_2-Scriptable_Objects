using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card _card;

    public Text nameText;
    public Text rarityText; 
    public Text descriptonText;

    public Image artworkText;

    public Text _priorityText;
    public Text _maxRecommendedText;


    void Start()
    {
        nameText.text = _card.name;
        rarityText.text = _card._rarity;
        descriptonText.text = _card._description;
        _priorityText.text = _card._tier;

        artworkText.sprite = _card._itemIcon;

        _maxRecommendedText.text = _card._recommendedMaxAmount.ToString();
    }

}
