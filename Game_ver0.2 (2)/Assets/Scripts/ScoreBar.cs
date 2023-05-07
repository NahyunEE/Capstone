using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBar : MonoBehaviour
{
    public Slider TotalBar;
    public Text text;
    public Text message;

    public void ChangeScene()
    {
        SceneManager.LoadScene("Finish_Game");
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("Failed_Game");
    }

    // Start is called before the first frame update
    void Start()
    {
        TotalBar.value = 0;
        message.text = "�����մϴ�!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            TotalBar.value += 5;
            float t = TotalBar.value;
            text.text = t+"/100";
            message.text = "���ϰ� �־��!";

        }
        else if (Input.GetKey(KeyCode.H)){
            message.text = "������ �� ��Ȯ�� �ϼ���!";
        }
      
        if(TotalBar.value == 100)
        {
            message.text = "�����߾��!";
            ChangeScene();

        }

        /*if(TotalBar.value != 100)
        {                                                     ������ ���� ������ 100��ä��� failed ������ ����
            message.text = "�����߾��..";
            ChangeScene2();
        }*/
    }

    
}
