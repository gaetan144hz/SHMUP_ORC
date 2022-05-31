using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthCounter : MonoBehaviour
{
    public Gradient gradient;
    public TextMeshProUGUI healthBar;

    public PlayerData datap;

    public void SetMaxHealth(float health)
    {
        var toInt = Mathf.RoundToInt(health);
        healthBar.text = toInt.ToString("0");

        healthBar.color = gradient.Evaluate(1f);
    }
    public void SetHealth(float health)
    {
        var toInt = Mathf.RoundToInt(health);
        healthBar.text = toInt.ToString("0");

        healthBar.color = gradient.Evaluate(toInt / (datap.startHealth * 1));
    }
}
