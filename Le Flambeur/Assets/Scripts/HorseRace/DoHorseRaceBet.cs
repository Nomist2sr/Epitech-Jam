using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoHorseRaceBet : MonoBehaviour
{
    public HorseRaceButtons Buttons;

    public bool _resultGet = false;
    public string _result = "";

    void Start()
    {
        StartCoroutine(GetResult());
    }

    string BetOdd()
    {
        int x = Random.Range(0, 101);
        _resultGet = true;

        if (x >= 50)
            return "horse1";
        else if (x >= 25 && x < 50)
            return "horse2";
        else if (x >= 10 && x < 25)
            return "horse3";
        else if (x >= 0 && x < 10)
            return "horse4";
        return null;
    }


    void Update()
    {
        if (_resultGet == false)
        {
            if (Buttons._numberOfPlayer == 0)
                _result = BetOdd();
        }
    }

    IEnumerator GetResult()
    {
        yield return new WaitForSeconds (6.0F);
    }
}
