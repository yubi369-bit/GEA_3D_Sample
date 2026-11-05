using UnityEngine;

public class Hp : MonoBehaviour
{
    int currentHP = 10;
    int maxHp = 20;

    [ContextMenu("HP")]

    void PrintHp()
    {
        int a = (int)((float)currentHP / maxHp * 100);
        Debug.Log("HP " + a + "%");
        
        int b = (int)((float)currentHP / (float)maxHp * 100);
        Debug.Log("HP " + b + "%");
    }
}
