using UnityEngine;
using UnityEngine.UI;

public class DangerSliderHandler : MonoBehaviour
{
    public GameObject audioManager;
    Slider slider;
    MusicHandler musicHandlerScript;

    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        musicHandlerScript = audioManager.GetComponent<MusicHandler>();
        slider.value = musicHandlerScript.dangerValue;
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void Update()
    {
        if (musicHandlerScript.dangerValue != slider.value) slider.value = musicHandlerScript.dangerValue;
    }

    void OnSliderValueChanged(float newValue)
    {
        slider.value = newValue;
        musicHandlerScript.ChangeEnergy(newValue);
    }
}
