using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchMarketSprite : MonoBehaviour
{
    public bool _stopSwitch = false;
    public bool _startSwitch = false;
    public bool _imageView = false;

    public Renderer Market;

    public void StartSwitch()
    {
        StartCoroutine(SwitchTime());
        Market = GameObject.Find("Display/Sprites/MarketDown").GetComponent<Renderer>();
        Market.enabled = true;
        _imageView = true;
        _startSwitch = true;
    }

    void Update()
    {
        if (_stopSwitch == false && _startSwitch == true && _imageView == true)
        {
            Market.enabled = false;
            _imageView = false;
        }
        else if (_stopSwitch == false && _startSwitch == true && _imageView == false)
        {
            Market.enabled = true;
            _imageView = true;
        }
    }

    IEnumerator SwitchTime()
    {
        yield return new WaitForSeconds (6.0F);
        _stopSwitch = true;
    }
}
