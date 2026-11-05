using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;


    public int gold = 1234;


    public int member = 4;

    public int kill = 7;

    public int expPerKill = 35;

    public int totalDamage = 250;

    public int hit = 20;

    public float expRate = 1.5f;

    public int maxTime = 60;

    public int minTime = 0;


    [ContextMenu("정산")]
    public void All()
    {
        /*int hour = playSeconds / 60;
        int min = (playSeconds - hour) / 60;
        int sec = min % 60;
        Debug.Log("플레이 타임" + hour + "." + min + "." + sec); */

        int min = playSeconds / 60;
        int sec = playSeconds % 60;
        int hour = min / 60;




        //플탐
        min = min - (60 * hour);

        Debug.Log("플레이 시간" + hour + "시간 " + min + "분 " + sec + "초");

        //골드
            int wantGold = gold / member;

        int leader = gold % member;

        Debug.Log("획득 금액: " + wantGold + ",리더 보너스: " + leader);
        


       





            
             //경험치
        int Difficultyexp = kill * expPerKill;

                int nowUp = (int)((float)Difficultyexp * expRate);

                Debug.Log("("+"기본 경험치" + Difficultyexp + ")" +  "현제 경험치" + nowUp);








        int Level = 1 + nowUp / 100;
        int namegeexp = 100 - (nowUp % 100);

            Debug.Log("현제 레벨: " + Level + "남은 경험치 : " + namegeexp);

        float differentDmg = ((float)totalDamage / hit);

            

        

        Debug.Log("기본뎀" + differentDmg);

       





    }
}