using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoPressBtn : MonoBehaviour
{
    public string buttonName = "Level-1"; // Имя кнопки, которая должна быть автоматически нажата

    void Start()
    {
        // Находим кнопку по имени
        Button button = GameObject.Find(buttonName)?.GetComponent<Button>();

        if (button != null)
        {
            // Нажимаем на кнопку
            button.onClick.Invoke();
        }
        else
        {
            Debug.LogWarning($"Кнопка с именем {buttonName} не найдена!");
        }
    }
}
