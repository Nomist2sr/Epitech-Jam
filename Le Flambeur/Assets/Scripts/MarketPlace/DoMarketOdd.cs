using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoMarketOdd : MonoBehaviour
{
    public SwitchMarketSprite Switch;

    public string _result = "";
    public bool _resultGet = false;

    public bool _isLaunchPressed = false;

    public void StartMarket()
    {
        StartCoroutine(GetResult());
    }

    void Launch()
    {
        Switch.StartSwitch();
    }

    string MarketOdd()
    {
        int x = Random.Range(0, 2);
        _resultGet = true;

        if (x == 0 && Switch._imageView == false)
            return "cryptoUp";
        else if (x == 0 && Switch._imageView == true)
            return "cryptoDown";
        else if (x == 1 && Switch._imageView == false)
            return "petrolUp";
        else if (x == 1 && Switch._imageView == true)
            return "petrolDown";
        return null;
    }

    void Update()
    {
        Button _launch = GameObject.Find("Display/Canvas/LaunchButton").GetComponent<Button>();
        _launch.onClick.AddListener(Launch);
        if (Switch._stopSwitch == true)
            _isLaunchPressed = true;
        if (_resultGet == false && _isLaunchPressed == true)
        {
            _result = MarketOdd();
        }
    }

    IEnumerator GetResult()
    {
        yield return new WaitForSeconds (6.0F);
    }
}
