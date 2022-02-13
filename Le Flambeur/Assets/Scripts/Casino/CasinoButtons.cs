using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CasinoButtons : MonoBehaviour
{
    public CasinoSpin Spin;
    public GameObject betInput;
    public GameObject chooseNumberInput;

    public string _bet;
    public string _chooseNumber;

    public bool _numberChoosed = false;
    public bool _isRedButtonPressed = false;
    public bool _isBlackButtonPressed = false;
    public bool _is1to12ButtonPressed = false;
    public bool _is13to24ButtonPressed = false;
    public bool _is25to36ButtonPressed = false;
    public bool _isChooseNumberButtonPressed = false;
    public bool _isBetButtonPressed = false;

    void Start()
    {
        Button _redButton = GameObject.Find("Display/Canvas/RedButton").GetComponent<Button>();
        _redButton.onClick.AddListener(RedPressed);
        Button _blackButton = GameObject.Find("Display/Canvas/BlackButton").GetComponent<Button>();
        _blackButton.onClick.AddListener(BlackPressed);
        Button _1to12Button = GameObject.Find("Display/Canvas/1to12Button").GetComponent<Button>();
        _1to12Button.onClick.AddListener(FirstSlicePressed);
        Button _13to24Button = GameObject.Find("Display/Canvas/13to24Button").GetComponent<Button>();
        _13to24Button.onClick.AddListener(SecondSlicePressed);
        Button _25to36Button = GameObject.Find("Display/Canvas/25to36Button").GetComponent<Button>();
        _25to36Button.onClick.AddListener(ThirdSlicePressed);
    }

    void RedPressed()
    {
        if (_isBetButtonPressed == true)
        {
            _isRedButtonPressed = true;
            _isBetButtonPressed = false;
            Spin.StartSpin();
        }
    }

    void BlackPressed()
    {
        if (_isBetButtonPressed == true)
        {
            _isBlackButtonPressed = true;
            _isBetButtonPressed = false;
            Spin.StartSpin();
        }
    }

    void FirstSlicePressed()
    {
        if (_isBetButtonPressed == true)
        {
            _is1to12ButtonPressed = true;
            _isBetButtonPressed = false;
            Spin.StartSpin();
        }
    }

    void SecondSlicePressed()
    {
        if (_isBetButtonPressed == true)
        {
            _is13to24ButtonPressed = true;
            _isBetButtonPressed = false;
            Spin.StartSpin();
        }
    }

    void ThirdSlicePressed()
    {
        if (_isBetButtonPressed == true)
        {
            _is25to36ButtonPressed = true;
            _isBetButtonPressed = false;
            Spin.StartSpin();
        }
    }

    void ChooseNumberPressed()
    {
        _isChooseNumberButtonPressed = true;
        _isBetButtonPressed = false;
        Spin.StartSpin();
    }

    void BetPressed()
    {
        _isBetButtonPressed = true;
    }

    bool CheckNumberChoosed(string num)
    {
        int number = System.Convert.ToInt32(num);
        if (number >= 1 || number <= 36)
            return true;
        return false;
    }

    void Update()
    {
        Button _betButton = GameObject.Find("Display/Canvas/BetButton").GetComponent<Button>();
        _bet = betInput.GetComponent<Text>().text;
        if (_bet != "" && (_bet == "50000" || _bet == "30000" || _bet == "20000" || _bet == "10000"))
        {
            _betButton.onClick.AddListener(BetPressed);
        }

        Button _chooseNumberButton = GameObject.Find("Display/Canvas/ChooseNumberButton").GetComponent<Button>();
        _chooseNumber = chooseNumberInput.GetComponent<Text>().text;
        if (_chooseNumber != "" && CheckNumberChoosed(_chooseNumber) == true)
        {
            if (_isBetButtonPressed == true)
            {
                _numberChoosed = true;
                _chooseNumberButton.onClick.AddListener(ChooseNumberPressed);
            }
        }
    }
}
