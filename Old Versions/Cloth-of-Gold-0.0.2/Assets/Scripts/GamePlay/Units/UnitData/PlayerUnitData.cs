// FIX ME

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnitData : MonoBehaviour
{
    [SerializeField] private Sprite _test, _blue, _red;

    public void SetPlayerColor(string playerColor)
    {

    }
    /*
    //[SerializeField] private GameObject _unit;

    public string whichPlayer = "TestPlayer";
    public int numNeighbors = 0;

    private GameObject _unit;

    private Sprite _neutralUnit, _blueUnit, _redUnit;
    private SpriteRenderer _unitRenderer;


   public void IsAlive(int PlayerAreaType)
    {
        if (_unit.activeSelf == true)
        {
            _unit.SetActive(false);
        }

        else
        {
            switch (PlayerAreaType)
            {
                case 0:
                    _unitRenderer.sprite = _neutralUnit;
                    break;

                case 1:
                    _unitRenderer.sprite = _blueUnit;
                    break;

                case 2:
                    _unitRenderer.sprite = _redUnit;
                    break;

                default:
                    _unitRenderer.sprite = _neutralUnit;
                    break;
            }

            _unit.SetActive(true);
        }
    }
    */
}
