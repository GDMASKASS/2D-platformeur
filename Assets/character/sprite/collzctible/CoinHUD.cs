using UnityEngine;
using TMPro;

public class CoinHUD : MonoBehaviour
{
    private TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        Collectible.total = 0;
    }

    private void Update()
    {
        text.text = Collectible.total.ToString();
    }
}