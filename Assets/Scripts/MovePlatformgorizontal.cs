using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovePlatformgorizontal : MonoBehaviour
{
    private SliderJoint2D slider;
    void Start()
    {
        slider = GetComponent<SliderJoint2D>();
    }
    private void Update()
    {
        var t = slider.jointTranslation;
        var motor = slider.motor;

        if (t >= slider.limits.max && motor.motorSpeed > 0)
        {
            motor.motorSpeed *= -1;
            slider.motor = motor;
         }
        if (t <= slider.limits.min && motor.motorSpeed < 0)
        {
            motor.motorSpeed *= -1;
            slider.motor = motor;
        }
    }
}

