using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor.Animations;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;
    private int colorIndex = 0;

    private void Update()
    {
        SetGroundMaterialSmoothColorChange();
        SetColorChangeTime();
    }

    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            ChecckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
    private void ChecckColorIndexValue()
    {
        colorIndex++;

        if(colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void SetGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[colorIndex],lerpValue*Time.deltaTime);
    }

    private void OnDestroy()
    {
        groundMaterial.color = colors[1];
    }
}
