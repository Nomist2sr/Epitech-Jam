using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HorceRaceBalance : MonoBehaviour
{
    public DoHorseRaceBet DoHorseRaceBet;
    public HorseRaceButtons Buttons;
    public HorseRaceSpin Spin;

    public Text Result;
    public Text DisplayBalance;
    public Text Continue;

    public bool _horseRaceDone = false;

    public int _horseRaceBalance = 0;

    void Start()
    {
        StartCoroutine(HorseRaceDone());
        DisplayBalance.text = "1000000" /*PlayerData.instance._playerBalance.ToString()*/;
        _horseRaceBalance = 1000000 /*PlayerData.instance._playerBalance*/;
    }

    void Update()
    {
        if (Spin._stopSpin == true)
        {
            if (DoHorseRaceBet._result == "horse1")
            {
                Result.text = "Cheval 1 !";
                Continue.text = "ESPACE pour continuer !";
                if (_horseRaceDone == false)
                    _horseRaceBalance += System.Convert.ToInt32(Buttons._bet) * 2;
                _horseRaceDone = true;
            }
            if (DoHorseRaceBet._result == "horse2")
            {
                Result.text = "Cheval 2 !";
                Continue.text = "ESPACE pour continuer !";
                if (_horseRaceDone == false)
                    _horseRaceBalance += System.Convert.ToInt32(Buttons._bet) * 3;
                _horseRaceDone = true;
            }
            if (DoHorseRaceBet._result == "horse3")
            {
                Result.text = "Cheval 3 !";
                Continue.text = "ESPACE pour continuer !";
                if (_horseRaceDone == false)
                    _horseRaceBalance += System.Convert.ToInt32(Buttons._bet) * 4;
                _horseRaceDone = true;
            }
            if (DoHorseRaceBet._result == "horse4")
            {
                Result.text = "Cheval 4 !";
                Continue.text = "ESPACE pour continuer !";
                if (_horseRaceDone == false)
                    _horseRaceBalance += System.Convert.ToInt32(Buttons._bet) * 5;
                _horseRaceDone = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Board");
        }
    }

    IEnumerator HorseRaceDone()
    {
        yield return new WaitForSeconds (6.0F);
    }
}
