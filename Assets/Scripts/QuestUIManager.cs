using UnityEngine;
using UnityEngine.UI;
using Naninovel;
using TMPro;

public class QuestUIManager : MonoBehaviour
{

    [SerializeField] private Text questText;


    private const string QuestVariableName = "Quest";

    private void Start()
    {
        UpdateQuestText();
    }

    private void Update()
    {
        UpdateQuestText();
    }

    private void UpdateQuestText()
    {
        var questValue = Engine.GetService<ICustomVariableManager>().GetVariableValue(QuestVariableName);

        if (questValue == "Quest1")
        {
            questText.text = "������� � ����� � ������� � Alex (���� � ������)";
        }
        else if (questValue == "Quest2")
        {
            questText.text = "����� � ��� � ������� (���� � ������)";
        }
        else if (questValue == "Quest3")
        {
            questText.text = "������� Alex, ��� ������ ��������";
        }
        else if (questValue == "Quest4")
        {
            questText.text = "������� (���� � ������) NoName";
        }
        else
        {
            questText.text = "��� �������� �������";
        }
    }
}