using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public Button clearBtn;
    public Button tournamentBtn;
    public Button duelBtn;
    public Button questBtn; 
    public Button growthBtn; 
    public Button bestBtn; 
    public Button homeBtn; 
    
    public VisualElement infoPanel;

    public Label massageText;
    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        clearBtn = root.Q<Button>("clearBtn");
        tournamentBtn = root.Q<Button>("tournamentBtn");
        duelBtn = root.Q<Button>("questBtn");
        questBtn = root.Q<Button>("questBtn");
        growthBtn = root.Q<Button>("growthBtn");
        bestBtn = root.Q<Button>("bestBtn");
        homeBtn = root.Q<Button>("homeBtn");

        infoPanel = root.Q<VisualElement>("infopanel");

        massageText = root.Q<Label>("infoText");

        clearBtn.clicked += ClearMasege;

        tournamentBtn.clicked += TournamentMasege;

        duelBtn.clicked += DuelMasege;

        questBtn.clicked += QuestMasege;

        growthBtn.clicked += GrowthMasege;

        bestBtn.clicked += BestMasege;

        homeBtn.clicked += HomeMasege;

    }

    private void ClearMasege()
    {
        Debug.Log("Clear");
        infoPanel.style.display = DisplayStyle.None;
    }

    private void TournamentMasege()
    {
        Debug.Log("Tournament");
        massageText.text = "Your level is too low, you lack resources";
        infoPanel.style.display = DisplayStyle.Flex;
    }

    private void QuestMasege()
    {
        Debug.Log("Quest");
        SceneManager.LoadScene("quest");
    }

    private void DuelMasege()
    {
        Debug.Log("Duel");
        massageText.text = "Your level is too low, you lack resources";
        infoPanel.style.display = DisplayStyle.Flex;
    }

    private void GrowthMasege()
    {
        SceneManager.LoadScene("growth");
    }

    private void BestMasege()
    {
        SceneManager.LoadScene("bestRethalt");
    }

    private void HomeMasege()
    {
        SceneManager.LoadScene("home");
    }
}
