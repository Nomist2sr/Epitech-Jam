using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorseRaceButtons : MonoBehaviour
{
    public HorseRaceSpin Spin;
    public GameObject betInput;

    public Text Player1;
    public Text Player2;
    public Text Player3;
    public Text Player4;

    public int _betPlayerOrder = 0;
    public int _playerOnHorse1 = 0;
    public int _playerOnHorse2 = 0;
    public int _playerOnHorse3 = 0;
    public int _playerOnHorse4 = 0;

    public string _bet;
    public bool _isBetButtonPressed = false;

    public int _numberOfPlayer;

    public bool _isHorse1Pressed = false;
    public bool _isHorse2Pressed = false;
    public bool _isHorse3Pressed = false;
    public bool _isHorse4Pressed = false;

    public int _bet1 = 0;
    public int _bet2 = 0;
    public int _bet3 = 0;
    public int _bet4 = 0;

    void Start()
    {
        _numberOfPlayer = 4 /*SetPlayerNumber.instance._playerNumber*/;
        Button _horse1Button = GameObject.Find("Display/Canvas/Horse1").GetComponent<Button>();
        _horse1Button.onClick.AddListener(Horse1Pressed);
        Button _horse2Button = GameObject.Find("Display/Canvas/Horse2").GetComponent<Button>();
        _horse2Button.onClick.AddListener(Horse2Pressed);
        Button _horse3Button = GameObject.Find("Display/Canvas/Horse3").GetComponent<Button>();
        _horse3Button.onClick.AddListener(Horse3Pressed);
        Button _horse4Button = GameObject.Find("Display/Canvas/Horse4").GetComponent<Button>();
        _horse4Button.onClick.AddListener(Horse4Pressed);
    }

    void Horse1Pressed()
    {
        if (_isHorse1Pressed == false && _isBetButtonPressed == true)
        {
            _bet1 = System.Convert.ToInt32(_bet);
            _playerOnHorse1 = _betPlayerOrder;
            _numberOfPlayer -= 1;
            Player1.text = "Pris !";
            _isBetButtonPressed = false;
            _isHorse1Pressed = true;
        }
    }

    void Horse2Pressed()
    {
        if (_isHorse2Pressed == false && _isBetButtonPressed == true)
        {
            _bet2 = System.Convert.ToInt32(_bet);
            _playerOnHorse2 = _betPlayerOrder;
            _numberOfPlayer -= 1;
            Player2.text = "Pris !";
            _isBetButtonPressed = false;
            _isHorse2Pressed = true;
        }
    }

    void Horse3Pressed()
    {
        if (_isHorse3Pressed == false && _isBetButtonPressed == true)
        {
            _bet3 = System.Convert.ToInt32(_bet);
            _playerOnHorse3 = _betPlayerOrder;
            _numberOfPlayer -= 1;
            Player3.text = "Pris !";
            _isBetButtonPressed = false;
            _isHorse3Pressed = true;
        }
    }

    void Horse4Pressed()
    {
        if (_isHorse4Pressed == false && _isBetButtonPressed == true)
        {
            _bet4 = System.Convert.ToInt32(_bet);
            _playerOnHorse4 = _betPlayerOrder;
            _numberOfPlayer -= 1;
            Player4.text = "Pris !";
            _isBetButtonPressed = false;
            _isHorse4Pressed = true;
        }
    }

    void BetPressed()
    {
        if (_bet != "" && (_bet == "50000" || _bet == "30000" || _bet == "20000" || _bet == "10000"))
        {
            _isBetButtonPressed = true;
            _betPlayerOrder = _numberOfPlayer;
        }
    }

    void Update()
    {
        Button _betButton = GameObject.Find("Display/Canvas/BetButton").GetComponent<Button>();
        _bet = betInput.GetComponent<Text>().text;
        if (_bet != "" && (_bet == "50000" || _bet == "30000" || _bet == "20000" || _bet == "10000") && _isBetButtonPressed == false)
        {
            _betButton.onClick.AddListener(BetPressed);
        }
        if (_numberOfPlayer == 0)
        {
            _isBetButtonPressed = true;
            Spin.StartSpin();
        }
    }
}
