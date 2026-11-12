using UnityEngine;

public class DamagePractice : MonoBehaviour
{

    public int attack;
    public int defense;
    public bool isCritical;
    public bool targetIsBoss;


    [ContextMenu("데미지")]

    void damage()
    {

        int damage = attack - defense;

        
       if(attack < defense)
        {
            damage = 1;
        }
        
        if(isCritical)
        {
            damage = damage * 2;
        }
        
        if (targetIsBoss)
        {
            damage = damage / 2;
        }

        Debug.Log(damage);

    }


    [ContextMenu("별")]
    public void star()
    {
        int height = 3;

        string text = "";



        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                text += "*";
            }
            text += "\n";

        }

        Debug.Log(text);
    }

    [ContextMenu("별2")]
    public void star2()
    {
        int height = 5;

        string text = "";



        for (int i = height; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                text += "*";
            }
            text += "\n";

        }

        Debug.Log(text);
    }

    [ContextMenu("상태")]
    void State()
    {
        int hp = 40;
        string state = "정상";
        if (hp <= 0) state = "사망";
        else if (hp < 50) state = "위험";
        Debug.Log(state);
    }

    [ContextMenu("반복")]
    void Loop()
    {
        int sum = 0;
        for (int i =2; i <= 10; i+=2)
        {
            sum += i;
        }
        Debug.Log(sum);
        for (int i = 1; i <= 9; i++)
        {
            Debug.Log("3 x " + i + " = " + 3*i);
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
