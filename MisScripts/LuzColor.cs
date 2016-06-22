using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LuzColor : MonoBehaviour {
    public Light miLuz;
    public Slider miSlider;
    public void LuzRoja()
    {
        miLuz.color = Color.red;
    }
    public void LuzVerde()
    {
        miLuz.color = Color.green;
    }
    public void LuzAmarilla()
    {
        miLuz.color = Color.yellow;
    }
    public void LuzAzul()
    {
        miLuz.color = Color.blue;
    }

    public void IntensidadLuz()
    {
        miLuz.intensity = miSlider.value * 8f;
    }
}
