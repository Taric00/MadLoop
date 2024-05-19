using UnityEngine;
using TMPro;

public class GetMouseSensivity : MonoBehaviour
{
    public TMP_InputField inputField; // Input Field'i atamak için Inspector üzerinden sürükleyip bırakın
    public string ABC; // ABC değişkeni

    public void GetInputFieldValue()
    {
        ABC = inputField.text; // Input Field'in değerini ABC değişkenine atama
    }
}
