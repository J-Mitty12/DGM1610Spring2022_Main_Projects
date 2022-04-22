using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : MonoBehaviour
{
    public UnityEvent OnZeroEvent;

    public float value;

    public void UpdateValue(float number)
    {
        value += number;
    }

    public void ReplaceValue(float number)
    {
        value = number;
    }

    public void DisplayImage(Image img)
    {
        if (value <= 0)
        {
            OnZeroEvent.Invoke();
        } else if (value >= 1)
        {
            value = 1;
        }

        img.fillAmount = value;

    }

    public void DisplayNumber(Text txt)
    {
        txt.Text = value.ToString();
    }
    void Update()
    {
        
    }
}
