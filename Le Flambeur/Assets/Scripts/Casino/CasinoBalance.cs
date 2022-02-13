using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CasinoBalance : MonoBehaviour
{
    public DoCasinoBet DoCasinoBet;
    public CasinoSpin Spin;
    public CasinoButtons Buttons;

    public Text Result;
    public Text DisplayBalance;
    public Text Continue;

    public bool _casinoDone = false;
    public int _casinoBalance;

    void Start()
    {
        StartCoroutine(CasinoDone());
        DisplayBalance.text = "1000000" /*PlayerData.instance._playerBalance.ToString()*/;
        _casinoBalance = 1000000 /*PlayerData.instance._playerBalance*/;
    }

    void Update()
    {
        if (Spin._stopSpin == true)
        {
            if (Buttons._isRedButtonPressed == true && DoCasinoBet._result == "red")
            {
                Result.text = "Gagne..";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance += System.Convert.ToInt32(Buttons._bet) * 2;
                _casinoDone = true;
            }
            if (Buttons._isRedButtonPressed == true && DoCasinoBet._result == "black")
            {
                Result.text = "Perdu !";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance -= System.Convert.ToInt32(Buttons._bet);
                _casinoDone = true;
            }

            if (Buttons._isBlackButtonPressed == true && DoCasinoBet._result == "black")
            {
                Result.text = "Gagne..";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance += System.Convert.ToInt32(Buttons._bet) * 2;
                _casinoDone = true;
            }
            if (Buttons._isBlackButtonPressed == true && DoCasinoBet._result == "red")
            {
                Result.text = "Perdu !";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance -= System.Convert.ToInt32(Buttons._bet);
                _casinoDone = true;
            }

            if (Buttons._is1to12ButtonPressed == true && DoCasinoBet._result == "first")
            {
                Result.text = "Gagne..";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance += System.Convert.ToInt32(Buttons._bet) * 3;
                _casinoDone = true;
            }
            if (Buttons._is1to12ButtonPressed == true && (DoCasinoBet._result == "second" || DoCasinoBet._result == "third"))
            {
                Result.text = "Perdu !";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance -= System.Convert.ToInt32(Buttons._bet);
                _casinoDone = true;
            }
            
            if (Buttons._is13to24ButtonPressed == true && DoCasinoBet._result == "second")
            {
                Result.text = "Gagne..";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance += System.Convert.ToInt32(Buttons._bet) * 3;
                _casinoDone = true;
            }
            if (Buttons._is13to24ButtonPressed == true && (DoCasinoBet._result == "first" || DoCasinoBet._result == "third"))
            {
                Result.text = "Perdu !";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance -= System.Convert.ToInt32(Buttons._bet);
                _casinoDone = true;
            }
            
            if (Buttons._is25to36ButtonPressed == true && DoCasinoBet._result == "third")
            {
                Result.text = "Gagne..";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance += System.Convert.ToInt32(Buttons._bet) * 3;
                _casinoDone = true;
            }
            if (Buttons._is25to36ButtonPressed == true && (DoCasinoBet._result == "first" || DoCasinoBet._result == "second"))
            {
                Result.text = "Perdu !";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance -= System.Convert.ToInt32(Buttons._bet);
                _casinoDone = true;
            }

            if (Buttons._isChooseNumberButtonPressed == true && DoCasinoBet._result == "win")
            {
                Result.text = "Gagne..";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance += System.Convert.ToInt32(Buttons._bet) * 8;
                _casinoDone = true;
            }
            if (Buttons._isChooseNumberButtonPressed == true && DoCasinoBet._result == "lose")
            {
                Result.text = "Perdu !";
                Continue.text = "ESPACE pour continuer !";
                if (_casinoDone == false)
                    _casinoBalance -= System.Convert.ToInt32(Buttons._bet);
                _casinoDone = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && _casinoDone == true)
        {
            SceneManager.LoadScene("Board");
        }
    }

    IEnumerator CasinoDone()
    {
        yield return new WaitForSeconds (6.0F);
    }
}
