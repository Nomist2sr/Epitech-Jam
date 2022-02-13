using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoCasinoBet : MonoBehaviour
{
    public CasinoButtons Buttons;
    public string _result = "";
    public bool _resultGet = false;

    void Start()
    {
        StartCoroutine(GetResult());
    }

    string ColorBet()
    {
        int x = Random.Range(0, 2);
        _resultGet = true;

        if (x == 0)
            return "red";
        else if (x == 1)
            return "black";
        return null;
    }

    string SliceBet()
    {
        int x = Random.Range(0, 3);
        _resultGet = true;

        if (x == 0)
            return "first";
        else if (x == 1)
            return "second";
        else if (x == 2)
            return "third";
        return null;
    }

    string OneNumberBet()
    {
        InputField _chooseNumber = GameObject.Find("Display/Canvas/ChooseNumber").GetComponent<InputField>();
        bool isAllDigit = IsAllDigits(_chooseNumber.text);
        int x = Random.Range(1, 37);
        _resultGet = true;

        if (isAllDigit == true)
        {
            int bet = System.Convert.ToInt32(_chooseNumber.text);
            if (bet < 1 || bet > 36)
                return null;
            if (x == bet)
                return "win";
            else if (x != bet)
                return "lose";
            return null;
        }
        return null;
    }

    bool IsAllDigits(string s)
    {
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
                return false;
        }
        return true;
    }

    void Update()
    {
        if (Buttons._numberChoosed == false && _resultGet == false)
        {
            if (Buttons._isRedButtonPressed == true)
                _result = ColorBet();
            if (Buttons._isBlackButtonPressed == true)
                _result = ColorBet();
            if (Buttons._is1to12ButtonPressed == true)
                _result = SliceBet();
            if (Buttons._is13to24ButtonPressed == true)
                _result = SliceBet();
            if (Buttons._is25to36ButtonPressed == true)
                _result = SliceBet();
        }
        else if (Buttons._isBetButtonPressed == true && Buttons._numberChoosed == true && _resultGet == false)
        {
            _result = OneNumberBet();
        }
    }

    IEnumerator GetResult()
    {
        yield return new WaitForSeconds (6.0F);
    }
}
