using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int gold = 100;

    [ContextMenu("Hello 기능 테스트")]
    void Hello()
    {
        Debug.Log("Hello");
    }

    [ContextMenu("gold Text")]
    void Gold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("테스트 1")]
    void Test1()
    {
        int hp = 1;

        Debug.Log(hp);
    }

    [ContextMenu("테스트 2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }


    
    public int Attack = 10;

    public int killCount = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Attack);
    }

    void Hit()
    {
        killCount = killCount + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("예측 1")]
    void PreDict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);

    }

    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;     // 지역 변수
        killCount = killCount + 1;
        Debug.Log(Attack - defense);
        Debug.Log(killCount);
    }

    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(d == 0.3);

        float half = 1 / 2;
        Debug.Log(half);
    }

    [ContextMenu("자료형")]
    void Types()
    {
        int level = 30;

        byte red = 255;

        char grade = 'S';

        float speed = 5.5f;
        bool isHigh = level >= 10;
        Debug.Log(level + " " + red + " " + grade);
        Debug.Log(speed + " " + isHigh);

    }
    [ContextMenu("에측 2")]
    void predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }

    [ContextMenu("나머지")]
    void Remainder()
    {
        int shotCount = 6;
        int totalSeconds = 135;

        bool isEven = shotCount % 2== 0;
        bool strongShot = shotCount %3 == 0;
        int min = totalSeconds / 60;
        int sec = totalSeconds % 60;
        Debug.Log(min + "." + sec);
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합:" + a + b);
        Debug.Log("합:" + (a + b));
        Debug.Log(a + b+"점");
        Debug.Log("HP" + 7 / 2);
    }
}
