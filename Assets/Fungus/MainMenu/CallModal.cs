using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

namespace Fungus
{
    public class CallModal: MonoBehaviour
    {
        public ModalPanel modalPanel;
        public float fadeTime;
        
        public void SaveGame()
        {
            modalPanel.showPanel();
            Debug.Log("Game Saved!");
        }
    }
}

