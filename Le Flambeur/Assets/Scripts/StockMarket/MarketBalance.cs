using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MarketBalance : MonoBehaviour
{
    public DoMarketOdd DoMarketOdd;
    public SwitchMarketSprite Switch;

    public Text Result;
    public Text Continue;

    public bool _marketDone = false;

    void Start()
    {
        StartCoroutine(MarketDone());
        DoMarketOdd.StartMarket();
        // _horseRaceBalance = 1000000 /*PlayerData.instance._playerBalance*/;
    }

    void Update()
    {
        if (DoMarketOdd._result == "cryptoUp")
        {
            Result.text = "Crypto Monte..";
            Continue.text = "ESPACE pour continuer !";
        }
        if (DoMarketOdd._result == "cryptoDown")
        {
            Result.text = "Crypto Descend !";
            Continue.text = "ESPACE pour continuer !";
        }
        if (DoMarketOdd._result == "petrolUp")
        {
            Result.text = "Petrole Monte..";
            Continue.text = "ESPACE pour continuer !";
        }
        if (DoMarketOdd._result == "petrolDown")
        {
            Result.text = "Petrole Descend !";
            Continue.text = "ESPACE pour continuer !";
        }
        if (Input.GetKeyDown(KeyCode.Space) && _marketDone == true)
        {
            SceneManager.LoadScene("Board");
        }
    }

    IEnumerator MarketDone()
    {
        yield return new WaitForSeconds (6.0F);
    }
}
