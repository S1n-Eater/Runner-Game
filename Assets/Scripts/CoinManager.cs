using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _numberOfCoinInLevel;
    [SerializeField] private TextMeshProUGUI _textCoinCounter;

    public void AddOneCoin()
    {
        _numberOfCoinInLevel++;
        _textCoinCounter.text = _numberOfCoinInLevel.ToString();
    }
}
