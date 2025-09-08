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
    public GameObject[] uiButtonsdeactivate;


    public GameObject frontalLobe;
    public GameObject PeritalLobe;
    public GameObject OccipitalLobe;
    public GameObject PrefrontalLobe;
    public GameObject TemporalLobe;
    public GameObject BrainStem;
    public GameObject Cerebellum;
    public GameObject Thalamus;
    public GameObject start; 

    public GameObject[] highlightObject;
    public GameObject[] dehighlightObjects;


    public GameObject right_brain_highlight;
    public GameObject left_brain_highlight;
    public GameObject Left_side_body_highlight;
    public GameObject Right_side_body_highlight; // GameObjects to be activated or deactivated

    //public YarnCommands yarnCommands; // Reference to the YarnCommands script


    public void Start()
    {
        frontalLobe = GameObject.Find("Frontal Lobe");
        PeritalLobe = GameObject.Find("Parietal Lobe");
        OccipitalLobe = GameObject.Find("Occipital Lobe");
        PrefrontalLobe = GameObject.Find("Prefrontal Lobe");
        TemporalLobe = GameObject.Find("Temporal Lobe");
        BrainStem = GameObject.Find("Brain Stem");
        Cerebellum = GameObject.Find("Cerebellum");
        Thalamus = GameObject.Find("Thalamus");
        start = GameObject.Find("Start");
        right_brain_highlight = GameObject.Find("Right Brain Highlight");
        left_brain_highlight = GameObject.Find("Left Brain Highlight");
        Left_side_body_highlight = GameObject.Find("Left Side Body Highlight");
        Right_side_body_highlight = GameObject.Find("Right Side Body Highlight");
    }


    [YarnCommand("FrontalLobe")] // Activate the Frontal Lobe GameObject
    public void SetFrontallobe()
    {
        uiButtonsForBrain[0].SetActive(true);
    }

    [YarnCommand("FrontalLobe")]// Activate the Parietal Lobe GameObject
    public void deactiveFrontallobe()
    {
        uiButtonsdeactivate[0].SetActive(false);
    }

    [YarnCommand("PeritalLobe")]// Activate the Parietal Lobe GameObject
    public void SetPeritalLobe()
    {
        uiButtonsForBrain[1].SetActive(true);
    }

    [YarnCommand("dePeritalLobe")]// Activate the Parietal Lobe GameObject
    public void deactivePeritalLobe()
    {
        uiButtonsdeactivate[1].SetActive(false);
    }

    [YarnCommand("OccipitalLobe")]// Activate the Occipital Lobe GameObject
    public void SetOccipitalLobe()
    {
        uiButtonsForBrain[2].SetActive(true);
    }

    [YarnCommand("deOccipitalLobe")]// Activate the Occipital Lobe GameObject
    public void deactivateOccipitalLobe()
    {
        uiButtonsdeactivate[2].SetActive(false);
    }

    [YarnCommand("PrefrontalLobe")]//   Activate the Prefrontal Lobe GameObject
    public void SetPrefrontalLobe()
    {
        uiButtonsForBrain[3].SetActive(true);
    }

    [YarnCommand("dePrefrontalLobe")]//   Activate the Prefrontal Lobe GameObject
    public void deactivePrefrontalLobe()
    {
        uiButtonsdeactivate[3].SetActive(false);
    }

    [YarnCommand("TemporalLobe")]// Activate the Temporal Lobe GameObject
    public void SetTemporalLobe()
    {
        uiButtonsForBrain[4].SetActive(true);
    }

    [YarnCommand("deTemporalLobe")]// Activate the Temporal Lobe GameObject
    public void deactivateTemporalLobe()
    {
        uiButtonsdeactivate[4].SetActive(false);
    }


    [YarnCommand("BrainStem")]      // Activate the Brain Stem GameObject
    public void SetBrainStem()
    {
        uiButtonsForBrain[5].SetActive(true);
    }

    [YarnCommand("deBrainStem")]      // Activate the Brain Stem GameObject
    public void deactivateBrainStem()
    {
        uiButtonsdeactivate[5].SetActive(false);
    }

    [YarnCommand("Cerebellum")]     // Activate the Cerebellum GameObject
    public void SetCerebellum()
    {
        uiButtonsForBrain[6].SetActive(true);
    }

    [YarnCommand("deCerebellum")]     // Activate the Cerebellum GameObject
    public void deactivateCerebellum()
    {
        uiButtonsdeactivate[6].SetActive(false);
    }

    [YarnCommand("Thalamus")]    // Activate the Thalamus GameObject
    public void SetThalamus()
    {
        uiButtonsForBrain[7].SetActive(true);
    }

    [YarnCommand("deThalamus")]    // Activate the Thalamus GameObject
    public void deactivateThalamus()
    {
        uiButtonsdeactivate[7].SetActive(false);
    }

    [YarnCommand("Start")]    // Activate the Start GameObject
    public void SetStart()
    {
        uiButtonsForBrain[8].SetActive(true);
    }

    [YarnCommand("RightBrainHighlight")]
    public void HighlightRightBrain()
    {
    highlightObject[0].SetActive(true);
    }

    [YarnCommand("deRightBrainHighlight")]
    public void deHighlightRightBrain()
    {
        dehighlightObjects[0].SetActive(false);
    }

    [YarnCommand("LeftBrainHighlight")]    // Activate the Left Brain Highlight GameObject
    public void SetLeftBrainHighlight()
    {
        highlightObject[1].SetActive(true);
    }

    [YarnCommand("deLeftBrainHighlight")]    // Activate the Left Brain Highlight GameObject
    public void SetdeLeftBrainHighlight()
    {
        dehighlightObjects[1].SetActive(false);
    }

    [YarnCommand("LeftSideBodyHighlight")]    // Activate the Left Side Body Highlight GameObject
    public void SetLeftSideBodyHighlight()
    {
        highlightObject[2].SetActive(true);
    }

    [YarnCommand("deLeftSideBodyHighlight")]    // Activate the Left Side Body Highlight GameObject
    public void SetdeLeftSideBodyHighlight()
    {
        dehighlightObjects[2].SetActive(false);
    }

    [YarnCommand("RightSideBodyHighlight")]    // Activate the Right Side Body Highlight GameObject
    public void SetRightSideBodyHighlight()
    {
        highlightObject[3].SetActive(true);
    }

    [YarnCommand("deRightSideBodyHighlight")]    // Activate the Right Side Body Highlight GameObject
    public void SetdeRightSideBodyHighlight()
    {
        dehighlightObjects[3].SetActive(false);
    }

}
