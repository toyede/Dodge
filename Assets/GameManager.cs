using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI ���� ���̺귯��
using UnityEngine.SceneManagement;  //�� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;

    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
