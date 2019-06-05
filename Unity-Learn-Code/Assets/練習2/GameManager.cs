using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Soldier SoldierA = new Soldier();

    private void start()
    {
        SoldierA.lv = 30;
        Debug.Log("士兵經驗值 - 取得:" + SoldierA.GetExp());

        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值 - 設定" + SoldierA.exp);
    }



}
