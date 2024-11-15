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
            questText.text = "Сходить в город и забрать у Alex (Очки и Указку)";
        }
        else if (questValue == "Quest2")
        {
            questText.text = "Зайти в дом и забрать (Очки и Указку)";
        }
        else if (questValue == "Quest3")
        {
            questText.text = "Сказать Alex, что забрал предметы";
        }
        else if (questValue == "Quest4")
        {
            questText.text = "Отнести (Очки и указку) NoName";
        }
        else
        {
            questText.text = "Нет активных квестов";
        }
    }
}