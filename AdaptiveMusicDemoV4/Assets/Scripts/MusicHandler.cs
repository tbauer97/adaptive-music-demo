//KOMMENTARSTRICHE ENTFERNEN
//using AK.Wwise;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    public float energyValue;
    public float dangerValue;
    public GameObject hero;
    public GameObject enemy;
    public float distanceModifier = 5.5f;
    //KOMMENTARSTRICHE ENTFERNEN
    //public RTPC energyGameParameter;
    //public RTPC dangerGameParameter;


    void Update()
    {
        AdjustMusicToDistance();
    }

    public void AdjustMusicToDistance() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0 && hero != null && enemy != null)
        {
            float distance = Vector3.Distance(hero.transform.position, enemy.transform.position);
            ChangeDanger(100 - (distance * distanceModifier));
        }
    }

    public void ChangeEnergy(float newValue)
    {
        if (newValue < 0 || newValue > 100) return;
        energyValue = newValue;
        //KOMMENTARSTRICHE ENTFERNEN
        //energyGameParameter.SetValue(gameObject, energyValue);
    }

    public void ChangeDanger(float newValue)
    {
        if (newValue < 0 || newValue > 100) return;
        dangerValue = newValue;
        //KOMMENTARSTRICHE ENTFERNEN
        //dangerGameParameter.SetValue(gameObject, dangerValue);
    }
}
