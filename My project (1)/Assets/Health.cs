using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int maxHp = 3;
    public int currentHp;
    public Slider hpSlider;     //플레이어만 연결
    public static int killCount;     // 모든 Health 가 같이 쓰는 값 하나

    public float invincibleTime = 0f;  //플레이어는 0.5초
    float lastHitTime = -999f;

    public  GameObject dropPrefab;

    public float dropChance = 0.3f;

    public GameObject hitEffect;

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        UpdateBar();
    }


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
        if(Time.time < lastHitTime + invincibleTime) return;
        lastHitTime = Time.time;

        currentHp -= damage;
        Debug.Log(name + "Hp: " + currentHp);
        UpdateBar();
        Vector3 hitPos = transform.position + Vector3.up;
        if (hitEffect != null)
        Instantiate(hitEffect, hitPos, Quaternion.identity);

        if (currentHp <= 0) Die();
        else Blink();
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
            GameManager.Instance.GameOver();
        }

        else
        {
            killCount++;
            if (dropPrefab != null && Random.value < dropChance)
            {
                Vector3 pos = transform.position + Vector3.up * 0.5f;
                Instantiate(dropPrefab, pos, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }

    void Blink()
    {
        Setvisible(false);
        Invoke(nameof(SceneAgain), 0.1f);
    }

    void SceneAgain()
    {
        Setvisible(true);
    }

    void Setvisible(bool on)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = on;
    }
}
