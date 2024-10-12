using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cooldown
{
    public float duration;
    private float m_CooldownCompleteTime;
    public bool IsReady
    {
        get
        {
            return Time.time >= m_CooldownCompleteTime;
        }
    }

    public Cooldown(float cooldown)
    {
        this.duration = cooldown;
    }

    public void StartCooldown()
    {
        m_CooldownCompleteTime = Time.time + duration;
    }
    public void StartCooldown(float duration)
    {
        this.duration = duration;
        StartCooldown();
    }
}
