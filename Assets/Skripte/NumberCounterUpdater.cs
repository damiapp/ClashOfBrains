using TMPro;
using UnityEngine;

public class NumberCounterUpdater : MonoBehaviour
{
    public NumberCounter numberCounter;
    public TMP_InputField InputField;

    public void SetValue()
    {
        int value;

        if (int.TryParse(InputField.text, out value))
        {
            numberCounter.Value = value;
        }
    }
}