using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new characterStat", menuName =  "characterStat", order = 0)]
public class StatContainer_SO : ScriptableObject {

    // Use this for initialization


    [SerializeField] int jumpPresses;
    [SerializeField] float charHealth;
    [SerializeField] float maxHealth;

    private void Awake()
    {
        maxHealth = 100;
        charHealth = maxHealth;

    }


    public void jumped()
    {
        jumpPresses += 1;
    }

    public float getCharHealth()
    {
        return charHealth;
    }

    public void updateCharHealth(float healthAmt)
    {
        charHealth += healthAmt;
    }




}
