using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetPlayerNumber : MonoBehaviour
{
    public static SetPlayerNumber instance;
    public int _playerNumber;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        _playerNumber = 4;
        // SceneManager.LoadScene("Board");
    }

    public void Update()
    {
        // _playerBalance = CasinoBalance.instance._casinoBalance;
    }
}
