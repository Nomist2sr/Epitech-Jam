using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetPlayerNumber : MonoBehaviour
{
    public static SetPlayerNumber instance;
    public int _playerNumber;
    public string _setPlayer;
    public int x = 0;

    public bool _playerNumberOk = false;
    public bool _islaunchPressed = false;

    public Button Launch;
    public GameObject NumberofPlayer;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void LaunchPress()
    {
        _playerNumber = x;
        _islaunchPressed = true;
        SceneManager.LoadScene("Board");
    }

    void NumberPlayerCheck(string check)
    {
        x = System.Convert.ToInt32(_setPlayer);

        if (x >= 2 && x <= 4)
        {
            _playerNumberOk = true;
            return;
        }
        _playerNumberOk = false;
        return;
    }

    void Start()
    {
    }

    public void Update()
    {
        if (_islaunchPressed == false)
        {
            Button _launchButton = GameObject.Find("Display/Canvas/LaunchButton").GetComponent<Button>();
            _setPlayer = NumberofPlayer.GetComponent<Text>().text;
            if (_setPlayer != "")
                NumberPlayerCheck(_setPlayer);
            if (_playerNumberOk == true)
                GameObject.Find("Display/Canvas/LaunchButton").GetComponent<Image>().color = Color.green;
            if (_playerNumberOk == false || _setPlayer == "")
                GameObject.Find("Display/Canvas/LaunchButton").GetComponent<Image>().color = Color.white;
            if (_islaunchPressed == false && _playerNumberOk == true)
                _launchButton.onClick.AddListener(LaunchPress);
        }
    }
}
