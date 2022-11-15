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
            this.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        }
        else
        {
            this.transform.localScale = new Vector3(2.3f, 2.3f, 2.3f);
        }
    }

}
