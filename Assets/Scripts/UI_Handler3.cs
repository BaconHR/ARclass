using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler3 : MonoBehaviour
{

    #region //UI Setting Config (Name)
    private const string TITLE_NAME = "Title";
    #endregion

    private Text textTitle { get; set; }
    private Text textMessage { get; set; }

    private Button btnYes { get; set; }
    private Text textYes { get; set; }

    private Button btnNo { get; set; }
    private Text textNo { get; set; }


    private void Awake()
    {
        ScanObject();

        InitObject();
    }

    private void ScanObject()
    {
        try
        {
            #region   //Scan
            int childCount = this.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject go = this.transform.GetChild(i).gameObject;
                Debug.Log("Child Index = " + i + " Name = " + go.name);
                if (go.name.Equals(TITLE_NAME))
                {
                    textTitle = go.GetComponent<Text>();
                }
                if (go.name.Equals("Message"))
                {
                    textMessage = go.GetComponent<Text>();
                }
                if (go.name.Equals("BtnYes"))
                {
                    btnYes = go.GetComponent<Button>();
                    textYes = go.GetComponentInChildren<Text>(); //最短模式      
                }
                if (go.name.Equals("BtnNo"))
                {
                    btnNo = go.GetComponent<Button>();
                    textNo = go.GetComponentInChildren<Text>(); //最短模式      
                }
            }
            #endregion
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    private void InitObject()
    {
        try
        {
            //init
            if (textTitle != null)
            {
                textTitle.text = "I M Right!";
            }
            if (textMessage != null)
            {
                textMessage.text = "這個是測試的文字\n換行測試\n換行測試2";
            }
            if (textYes != null)
            {
                textYes.text = "OK";
            }
            if (textNo != null)
            {
                textNo.text = "否";
            }

        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    public void SetTitle(string title)
    {
        try
        {
            textTitle.text = title;
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

}
