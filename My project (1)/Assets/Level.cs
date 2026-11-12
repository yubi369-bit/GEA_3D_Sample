using UnityEngine;

public class Level : MonoBehaviour
{

    public int expPerKill = 35000;
    public int killCount = 3;

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;
        int currentkillCount = 0;

        for(int i=0; i<= killCount; i++)
        {
            exp += expPerKill;
            currentkillCount += 1;

            while (exp >= level * 10000)
            { 
                exp -= level * 10000;
                level+=1;
                

                Debug.Log("레벨업! " + "LV: " + level + "(잡은 마리수 : " + currentkillCount + ")");
            }

            Debug.Log("최종 " + "LV: " + level + "(경험치 : " + exp + "/" + level * 10000);
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
