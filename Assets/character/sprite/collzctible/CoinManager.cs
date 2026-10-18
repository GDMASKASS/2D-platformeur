using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    [SerializeField] private TextMeshProUGUI coinText;

    private void Update()
    {
        coinText.text = coinCount.ToString();
    }
}