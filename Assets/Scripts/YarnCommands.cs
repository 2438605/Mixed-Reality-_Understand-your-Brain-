using Meta.WitAi.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public GameObject[] uiButtonsForBrain;


    public GameObject frontalLobe;
    public GameObject PeritalLobe;
    public GameObject OccipitalLobe;
    public GameObject PrefrontalLobe;
    public GameObject TemporalLobe;
    public GameObject BrainStem;
    public GameObject Cerebellum;
    public GameObject Thalamus;


    public GameObject right_brain_highlight;
    public GameObject left_brain_highlight;
    public GameObject Left_side_body_highlight;
    public GameObject Right_side_body_highlight; // GameObjects to be activated or deactivated

    //public YarnCommands yarnCommands; // Reference to the YarnCommands script


    public void Start()
    {
        frontalLobe = GameObject.Find("Frontal Lobe");
    }


    [YarnCommand("FrontalLobe")] // Activate the Frontal Lobe GameObject
    public void SetFrontallobe()
    {
        uiButtonsForBrain[0].SetActive(true);
    }

    [YarnCommand("PeritalLobe")]// Activate the Parietal Lobe GameObject
    public void SetPeritalLobe()
    {
        PeritalLobe.SetActive(true);
    }

    [YarnCommand("OccipitalLobe")]// Activate the Occipital Lobe GameObject
    public void SetOccipitalLobe()
    {
        OccipitalLobe.SetActive(true);
    }

    [YarnCommand("PrefrontalLobe")]//   Activate the Prefrontal Lobe GameObject
    public void SetPrefrontalLobe()
    {
        PrefrontalLobe.SetActive(true);
    }

    [YarnCommand("TemporalLobe")]// Activate the Temporal Lobe GameObject
    public void SetTemporalLobe()
    {
        TemporalLobe.SetActive(true);
    }

    [YarnCommand("BrainStem")]      // Activate the Brain Stem GameObject
    public void SetBrainStem()
    {
        BrainStem.SetActive(true);
    }

    [YarnCommand("Cerebellum")]     // Activate the Cerebellum GameObject
    public void SetCerebellum()
    {
        Cerebellum.SetActive(true);
    }

    [YarnCommand("Thalamus")]    // Activate the Thalamus GameObject
    public void SetThalamus()
    {
        Thalamus.SetActive(true);
    }

    [YarnCommand("RightBrainHighlight")]
    public void HighlightRightBrain()
    {
        Debug.Log("Right Brain Highlight Activated!");
        right_brain_highlight.SetActive(true);
    }

    [YarnCommand("LeftBrainHighlight")]    // Activate the Left Brain Highlight GameObject
    public void SetLeftBrainHighlight()
    {
        left_brain_highlight.SetActive(true);
    }

    [YarnCommand("LeftSideBodyHighlight")]    // Activate the Left Side Body Highlight GameObject
    public void SetLeftSideBodyHighlight()
    {
        Left_side_body_highlight.SetActive(true);
    }

    [YarnCommand("RightSideBodyHighlight")]    // Activate the Right Side Body Highlight GameObject
    public void SetRightSideBodyHighlight()
    {
        Right_side_body_highlight.SetActive(true);
    }

}
