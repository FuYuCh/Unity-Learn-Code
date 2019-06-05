using UnityEngine;

[System.Serializable]
public class Warrior
{
    
    public int lv;
    private int _exp;
    /// <summary>
    /// 取得與設定戰士的經驗值
    /// </summary>
    public int Exp
    {
        get
        {
            _exp = lv * 10;
            return _exp;
        }
        set
        {
            
            _exp = value;
        }
    }
    public void ShowExp()
    {
        Debug.Log("戰士經驗-取得:" + _exp);
    }
}