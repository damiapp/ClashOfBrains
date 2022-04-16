using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardView : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text descriptionText;

    private AbstractCard card;

    public AbstractCard GetCard() {
        return card;
    }

    public void SetCard (AbstractCard newCard) {
        card = newCard;

        UpdateTexts();
    }

    private void UpdateTexts() {
        if (nameText != null) {
            nameText.text = card.Name;
        }
        if (descriptionText != null) {
            descriptionText.text = card.Description;
        }
    }
}
