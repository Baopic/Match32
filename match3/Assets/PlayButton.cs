using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string Gameplay; // ��� �����, ������� ����� ���������

    public void LoadScene()
    {
        SceneManager.LoadScene(Gameplay); // ��������� ��������� �����
    }
}