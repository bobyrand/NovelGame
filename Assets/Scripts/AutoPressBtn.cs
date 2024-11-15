using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoPressBtn : MonoBehaviour
{
    public string buttonName = "Level-1"; // ��� ������, ������� ������ ���� ������������� ������

    void Start()
    {
        // ������� ������ �� �����
        Button button = GameObject.Find(buttonName)?.GetComponent<Button>();

        if (button != null)
        {
            // �������� �� ������
            button.onClick.Invoke();
        }
        else
        {
            Debug.LogWarning($"������ � ������ {buttonName} �� �������!");
        }
    }
}
