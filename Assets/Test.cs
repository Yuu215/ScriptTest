using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        int[] array = { 1, 2, 3, 4, 5};

        //array�̒l�����Ԃɕ\������
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        
        //array�̒l�����Ԃɕ\������
        for(int i = array.Length -1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        

        //���W�ۑ�
        Boss boss = new Boss();

        for(int i = 0; i < 10; i++)
        {
            boss.Magic();
        }

        boss.Magic();
    }

    //���W�ۑ�
    public class Boss
    {
        int mp = 53;

        public void Magic()
        {
            if(mp >= 5)
            {
                mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + mp);
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
            }
        }
    }
}
