using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSubscription2 : MonoBehaviour
{
    private Button button2;
    private void Start()
    {
        button2 = GetComponent<Button>();
        button2.onClick.AddListener(Button2Click);
    }
    private void Button2Click()
    {
        Application.Quit();
        Debug.Log("Кнопка нажата!");
    }
}