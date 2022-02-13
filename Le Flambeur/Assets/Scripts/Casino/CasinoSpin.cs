using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasinoSpin : MonoBehaviour
{
    private float _rotation = 0F;
    public bool _stopSpin = false;
    public bool _startSpin = false;

    public void StartSpin()
    {
        StartCoroutine(SpinTime());
        _startSpin = true;
    }

    void Update()
    {
        if (_stopSpin == false && _startSpin == true)
        {
            Transform rotation = GameObject.Find("Display/Sprites/Roll_Spinner").GetComponent<Transform>();
            _rotation += Time.deltaTime;
            rotation.Rotate(new Vector3(0, 0, _rotation));
        }
    }

    IEnumerator SpinTime()
    {
        yield return new WaitForSeconds (6.0F);
        _stopSpin = true;
    }
}
