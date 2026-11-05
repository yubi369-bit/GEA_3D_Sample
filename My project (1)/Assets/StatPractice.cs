using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string PlayerName;

    public int Level;

    public float Attack = 12.5f;

    public bool isBoss;

    public string itemName = "포션";

    public int price = 30;
    public float discount = 0.5f;
    public bool isSoldOut = false;

    [ContextMenu("가격")]
    void ShowPrice()
    {
        float finalPrice = price * discount;
        Debug.Log(itemName + "" + finalPrice);
    }


    [ContextMenu("스텟")]
    void ShowStat()
    {
        Debug.Log("레벨 :"+Level);
        Debug.Log("공격력 :" +Attack);
        Debug.Log("보스 생존 :"+isBoss);
        Debug.Log("이름 :"+PlayerName);
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
