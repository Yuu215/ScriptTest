using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int[] array = { 1, 2, 3, 4, 5};

        //arrayの値を順番に表示する
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        
        //arrayの値を順番に表示する
        for(int i = array.Length -1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        

        //発展課題
        Boss boss = new Boss();

        for(int i = 0; i < 10; i++)
        {
            boss.Magic();
        }

        boss.Magic();
    }

    //発展課題
    public class Boss
    {
        int mp = 53;

        public void Magic()
        {
            if(mp >= 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }
            else
            {
                Debug.Log("MPが足りないため、魔法が使えない");
            }
        }
    }
}
