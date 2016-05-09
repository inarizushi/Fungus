using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Fungus
{

    public class ModalPanel : MonoBehaviour
    {

        public GameObject modalPanel;
        private float previousTimeScale;

        public void showPanel()
        {
            //TODO: add fade in
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0;
            modalPanel.SetActive(true);
        }

        public void HidePanel()
        {
            //TODO: add fade out
            modalPanel.SetActive(false);
            Time.timeScale = previousTimeScale;
        }
    }
}