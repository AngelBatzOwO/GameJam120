using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBarBehaviour : MonoBehaviour
{

    [SerializeField]
    public float oxygenTimer = 5f;

    [SerializeField]
    Image oxygenBarUI;

    [SerializeField]
    Gradient oxygenBarGradient;

    private void Update()
    {
        UpdateOxygenBarGradient();
    }

    void UpdateOxygenBarGradient()
    {
        oxygenTimer -= Time.deltaTime;

        if (oxygenBarGradient != null)
        {
            oxygenBarUI.fillAmount = oxygenTimer/ 10;
            oxygenBarUI.color = oxygenBarGradient.Evaluate(oxygenBarUI.fillAmount);
        }

        if (oxygenTimer > 10f)
        {
            oxygenTimer = 10f;
        }
    }
}
