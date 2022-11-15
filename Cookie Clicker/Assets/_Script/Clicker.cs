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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            cookies = cookies + (1 * manualClickUpgrade);
            holder.text = cookies.ToString();
            this.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        }
        else
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);
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
