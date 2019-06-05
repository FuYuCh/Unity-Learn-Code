using UnityEngine;

public class GameManager : MonoBehaviour  //檔案名稱跟類別名稱需相同
{
    public Soldier SoldierA = new Soldier();
    public Warrior WarriorA = new Warrior();

    private void Start()
    {
        SoldierA.lv = 30;
        Debug.Log("士兵經驗值 - 取得:" + SoldierA.GetExp());
        
        SoldierA.SetExp(100);
        Debug.Log("士兵經驗值 - 設定" + SoldierA.exp);

        
        WarriorA.lv = 50;
        Debug.Log("戰士經驗值 - 取得" + WarriorA.Exp);
        WarriorA.Exp = 777;
        Debug.Log("戰士經驗值 - 取得" + WarriorA.Exp);

    }
}
