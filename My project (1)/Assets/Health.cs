using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int maxHp = 3;
    public int currentHp;
    public Slider hpSlider;     //플레이어만 연결


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;     //이미 죽었으면 무시

        currentHp -= damage;
        Debug.Log(name + "Hp: " + currentHp);
        UpdateBar();

        if (currentHp <= 0) Die();
    }

    void UpdateBar()
    {
        if (hpSlider != null)
            hpSlider.value = (float)currentHp / maxHp;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            Debug.Log("게임오버");
            Time.timeScale = 0f;        //게임 정지
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
