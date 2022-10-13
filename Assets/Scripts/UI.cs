using UnityEngine;
using TMPro;
using System;

public class UI : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _inputSpeed;

    [SerializeField]
    private TMP_InputField _inputDirection;

    [SerializeField]
    private TMP_InputField _repiteRate;

    [SerializeField]
    GameHelper _gameHelper;

    private void Start() => 
        AddListener();

    private void AddListener()
    {
        _inputSpeed.onValueChanged.AddListener(_gameHelper.SpeedChangeHandler);
        _inputDirection.onValueChanged.AddListener(_gameHelper.DirectionChangeHandler);
        _repiteRate.onValueChanged.AddListener(_gameHelper.TimerChangeHandler);
    }

}