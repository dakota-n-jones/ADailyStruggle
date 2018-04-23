using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;


public class Greyscale : MonoBehaviour {

    [SerializeField] PostProcessingProfile m_profile = null;
    [SerializeField] Clicker m_motivation = null;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        float ratio = m_motivation.Total / 100.0f;
        ColorGradingModel.Settings colorSettings = m_profile.colorGrading.settings;
        colorSettings.basic.saturation = ratio * 2.0f;
        m_profile.colorGrading.settings = colorSettings;
        GrainModel.Settings grainSettings = m_profile.grain.settings;
        grainSettings.intensity = (1 - ratio) / 2.0f;
        m_profile.grain.settings = grainSettings;
    }
}
