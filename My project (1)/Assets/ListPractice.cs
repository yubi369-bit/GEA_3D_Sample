using UnityEngine;
using System.Collections.Generic;

public class ListPractice : MonoBehaviour
{

    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> Items = new List<string>();
        Items.Add("화살");
        Items.Add("포션");
        Items.Add("열쇠");
        Items.Remove("포션");
        Debug.Log("아이템"+Items.Count+"개");
        Debug.Log("열쇠 있음" + Items.Contains("열쇠"));
        for(int i = 0; i < Items.Count; i++)
        {
            Debug.Log(i + "번: " + Items[i]);
        }

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
