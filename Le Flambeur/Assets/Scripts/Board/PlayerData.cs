using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance;
    public int _playerBalance;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        _playerBalance = 1000000;
        SceneManager.LoadScene("Casino");
    }

    public void Update()
    {
        // _playerBalance = CasinoBalance.instance._casinoBalance;
    }
}
