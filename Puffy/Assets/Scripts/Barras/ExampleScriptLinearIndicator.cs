using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScriptLinearIndicator : MonoBehaviour
{

    public LinearIndicator comida, energia, salud, diversion;

    public float minValue, maxValue;
    public float currentValue;

    void Start()
    {
        //Setup the linear indicator by code or do it in inspector
        comida.SetupIndicator(0,100);
        energia.SetupIndicator(0, 100);
        salud.SetupIndicator(0, 100);
        diversion.SetupIndicator(0, 100);


        //linearIndicator.SetOrientation(LinearIndicator.Orientation.Horizontal);
        //linearIndicator.reverse = false;
        comida.SetValue(50);
        diversion.SetValue(75);
        energia.SetValue(25);
        salud.SetValue(100);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
           //Aquí se pondrán los valores para ajustar las barras

    }
}
