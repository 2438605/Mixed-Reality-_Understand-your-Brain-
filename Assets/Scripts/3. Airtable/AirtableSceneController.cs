using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AirtableSceneController : MonoBehaviour
{
    [Header("Scripts")]
    public AirtableManager airtableManager;

    //[Header("Record ID")]
    //public TMP_Text recordIDTMP;

    //[Header("Player Name")]
    ////public TMP_InputField playerNameInputField;
    //public TMP_Text playerNameFeedback;
    //private string playerName;

    [Header("Experience Sliders")]
    public Slider experienceSlider1;
    public Slider experienceSlider2;
    public Slider experienceSlider3;
    //public Slider experienceSlider4;
    //public Slider experienceSlider5;

    private string experience1;
    private string experience2;
    private string experience3;
    //private string experience4;
    //private string experience5;

    //public void UpdatePlayerName()
    //{
    //    playerName = playerNameInputField.text;
    //}

    public void SavePlayerName()
    {
        //airtableManager.playerName = playerName;
        airtableManager.CreateRecord();
    }

    public void UpdateExperienceValues()
    {
        experience1 = experienceSlider1.value.ToString();
        experience2 = experienceSlider2.value.ToString();
        experience3 = experienceSlider3.value.ToString();
        //experience4 = experienceSlider4.value.ToString();
        //experience5 = experienceSlider5.value.ToString();
    }

    public void SaveExperienceData()
    {
        airtableManager.experience1 = experience1;
        airtableManager.experience2 = experience2;
        airtableManager.experience3 = experience3;
        //airtableManager.experience4 = experience4;
        //airtableManager.experience5 = experience5;
        airtableManager.CreateRecord();
    }

    public void SaveAllData()
    {
        //UpdatePlayerName();
        UpdateExperienceValues();
        //airtableManager.playerName = playerName;
        airtableManager.experience1 = experience1;
        airtableManager.experience2 = experience2;
        airtableManager.experience3 = experience3;
        //airtableManager.experience4 = experience4;
        //airtableManager.experience5 = experience5;
        airtableManager.CreateRecord();
    }

    void Update()
    {
        // Optional: Continuously update slider values (if needed)
    }
}
