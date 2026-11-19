using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };

    public int criticalLine = 3000;


    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        List<int> critical = new List<int>();
        critical.Add(3500);
        critical.Add(12000);
        critical.Add(3500);

        foreach(int critical in critical)
        {
            Debug.Log(critical);
        }
        Debug.Log(critical.Count + "회");

        foreach (int i in damages)
        {
                
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
