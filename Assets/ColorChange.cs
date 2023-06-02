using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class is for the change of Color and contains _renderer
 * newColorGreen/Red for the change
 */

public class ColorChange : MonoBehaviour
{
    public Renderer _renderer;
   
    public Color newColorGreen = Color.green;
    public Color newColorRed = Color.red;

    public ColorChange()
    {
        this.newColorGreen = newColorGreen;
        this.newColorRed = newColorRed;
    }

    public void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ColorChangeGreen()
    {
        _renderer.material.color = newColorGreen;
    }

    public void ColorChangeRed()
    {
        _renderer.material.color = newColorRed;
    }
}
