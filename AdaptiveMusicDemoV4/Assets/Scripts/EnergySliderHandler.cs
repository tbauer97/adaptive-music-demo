using UnityEngine;
using UnityEngine.UI;

public class EnergySliderHandler : MonoBehaviour
{
    public GameObject audioManager;
    Slider slider;
    MusicHandler musicHandlerScript;

    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        musicHandlerScript = audioManager.GetComponent<MusicHandler>();
        slider.value = musicHandlerScript.energyValue;
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    void OnSliderValueChanged(float newValue)
    {
        slider.value = newValue;
        musicHandlerScript.ChangeEnergy(newValue);
    }
}
