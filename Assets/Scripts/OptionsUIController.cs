using System;
using UnityEngine;
using UnityEngine.UI;

public class OptionsUIController : MonoBehaviour
{
    [SerializeField] private Toggle myToggle;
    [SerializeField] private Slider Slider;
    void Start()
    {
        myToggle.onValueChanged.AddListener(OnMyToggleClick);
        Slider.onValueChanged.AddListener(OnSliderChange);
        Slider.minValue = 1;
        Slider.maxValue = 100;
    }

    private void OnMyToggleClick(bool value)
    {
        Debug.Log(value);
    }

    private void OnSliderChange(float value)
    {
        Debug.Log(value);
    }
}
