using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public int cointCount = 0;
    public Text coinText;

    private void Start()
    {
        coinText.text = "Coins: " + cointCount;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            cointCount++;
            coinText.text = "Coins: " + cointCount;
            Destroy(collision.gameObject);
        }
    }
}
