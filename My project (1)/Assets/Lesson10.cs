using UnityEngine;

public class Lesson10 : MonoBehaviour
{

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }



    void WeaponType()
    {
        int weaponId = 2;

        switch (weaponId)
        {
            case 1:
                Debug.Log("근접무기");
            break;
            case 2:
                Debug.Log("검");
                    break;
            case 3:
                    Debug.Log("도끼");
                    break;

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
