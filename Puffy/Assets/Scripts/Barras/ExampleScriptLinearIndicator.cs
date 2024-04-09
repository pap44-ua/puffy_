using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScriptLinearIndicator : MonoBehaviour
{

    public LinearIndicator linearIndicator;
    public LinearIndicator linearIndicator2, linearIndicator3, linearIndicator4;

    public float minValue, maxValue;
    public float currentValue;

    void Start()
    {
        //Setup the linear indicator by code or do it in inspector
        linearIndicator.SetupIndicator(0,100);
        linearIndicator2.SetupIndicator(0, 100);
        linearIndicator3.SetupIndicator(0, 100);
        linearIndicator4.SetupIndicator(0, 100);


        //linearIndicator.SetOrientation(LinearIndicator.Orientation.Horizontal);
        //linearIndicator.reverse = false;
        linearIndicator.SetValue(currentValue);
        linearIndicator2.SetValue(currentValue);
        linearIndicator3.SetValue(currentValue);
        linearIndicator4.SetValue(currentValue);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
           //Aquí se pondrán los valores para ajustar las barras

    }
}
