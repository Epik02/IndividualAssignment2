using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Clicker : MonoBehaviour
{ 
    public int cookies = 0;
    public int manualClickUpgrade = 1;
    public TMP_Text holder;
    public TMP_Text upgradeCost;
    public TMP_Text currentUpgrade;

    // Update is called once per frame
    void Update()
    {
        upgradeCost.text = (manualClickUpgrade * 100).ToString();
        currentUpgrade.text = manualClickUpgrade.ToString();


        if (Input.GetKeyDown("space"))
        {
            cookies = cookies + (1 * manualClickUpgrade);
            holder.text = cookies.ToString();
            this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else
        {
            this.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        }

        if (Input.GetKeyDown("w"))
        {
            if(cookies >= 100 * manualClickUpgrade)
            {
                cookies -= 100 * manualClickUpgrade;
                holder.text = cookies.ToString();
                manualClickUpgrade++;
            }
        }
    }

}
