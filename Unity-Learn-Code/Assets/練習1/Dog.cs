using UnityEngine;   //引用 API

[System.Serializable] // 序列化的類別會連同欄位顯示在屬性面板上
public class Dog    //建立類別
{
    #region 欄位     //可以包括住程式碼 
    public string name;
    public float weight;
    public string type;
    public string color;

    private string _sex;
    private int _age;
    #endregion

    #region 建構函式
    //建構函式可以多載
    public Dog()
    {

    }

    public Dog(string vsex ,int vage)
    {
        this._sex = vsex;
        this._age = vage;
    }
    #endregion
    #region 方法
    /// <summary>
    /// 狗狗叫的方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ":汪汪");
    }

    /// <summary>
    /// 轉換狗狗年齡的方法
    /// </summary>
    /// <returns>狗狗年齡</returns>
    public int ConvertAge()
    {
        return _age * 7;
    }
    /// <summary>
    /// 狗狗吃東西的方法
    /// </summary>
    /// <param name="food"></param>
    /// <param name="speed"></param>
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + ":" + "food" + "，速度:" + speed);
    }
    /// <summary>
    /// 狗狗吃東西的方法
    /// </summary>
    /// <param name="food"></param>
    /// <param name="count"></param>
    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + "，份量" + count);
    }
    #endregion

}