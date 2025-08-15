using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnCommands : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public GameObject FrontalLobe, PeritalLobe, OccipitalLobe, PrefrontalLobe, TemporalLobe, BrainStem, Cerebellum, Thalamus; // GameObjects to be activated or deactivated
    public YarnCommands yarnCommands; // Reference to the YarnCommands script



    [YarnCommand("SetFrontalLobe")] // Activate the Frontal Lobe GameObject
    public void setFrontallobe()
    {
        FrontalLobe.SetActive(true);
    }

    [YarnCommand("PeritalLobe")]// Activate the Parietal Lobe GameObject
    public void setPeritalLobe()
    {
        PeritalLobe.SetActive(true);
    }

    [YarnCommand("OccipitalLobe")]// Activate the Occipital Lobe GameObject
    public void setOccipitalLobe()
    {
        OccipitalLobe.SetActive(true);
    }

    [YarnCommand("PrefrontalLobe")]//   Activate the Prefrontal Lobe GameObject
    public void setPrefrontalLobe()
    {
        PrefrontalLobe.SetActive(true);
    }

    [YarnCommand("TemporalLobe")]// Activate the Temporal Lobe GameObject
    public void setTemporalLobe()
    {
        TemporalLobe.SetActive(true);
    }

    [YarnCommand("BrainStem")]      // Activate the Brain Stem GameObject
    public void setBrainStem()
    {
        BrainStem.SetActive(true);
    }

    [YarnCommand("Cerebellum")]     // Activate the Cerebellum GameObject
    public void setCerebellum()
    {
        Cerebellum.SetActive(true);
    }

    [YarnCommand("Thalamus")]    // Activate the Thalamus GameObject
    public void setThalamus()
    {
        Thalamus.SetActive(true);
    }

}
