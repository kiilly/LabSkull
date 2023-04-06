using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin_Script : MonoBehaviour
{
    public int coins;
    public TMPro.TextMeshProUGUI coinsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collected!");
            coins = coins + 1;
            Col.gameObject.SetActive(false);
            //Destroy(Col.gameObject);
            coinsText.text = "Coins : " + coins + " / 3";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
