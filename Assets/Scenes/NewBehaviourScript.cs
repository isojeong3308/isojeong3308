using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
        //1.����
        int level = 5;
        float strength = 15.5f;
        string playname = "�˻�";
        bool isFullLevel = false;


        Debug.Log("����� �̸���?");
        Debug.Log(playname );
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(isFullLevel);


        //2.�׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("�ʿ� �����ϴ� ������ ����");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("������");
        items.Add("��������");
        
        items.RemoveAt(0);

        Debug.Log("������ �ִ� ������");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        Debug.Log(items[2]);


        Debug.Log("�ʿ� �����ϴ� ����");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        //3.������
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("����� �̸���?");
        Debug.Log(playname);
        Debug.Log("����� ������?");
        Debug.Log(level);
        Debug.Log("����� ����?");
        Debug.Log(strength);
        Debug.Log("���� �����ΰ�?");
        Debug.Log(strength);

        int nextFxp = 300 - (exp & 300);
        Debug.Log("nextExp");

        Debug.Log(title + " ");
    }
}
