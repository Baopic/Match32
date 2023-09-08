using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string Gameplay; // Имя сцены, которую нужно загрузить

    public void LoadScene()
    {
        SceneManager.LoadScene(Gameplay); // Загружаем указанную сцену
    }
}