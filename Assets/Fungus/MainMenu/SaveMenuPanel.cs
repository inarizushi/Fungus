using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

namespace Fungus
{
    public class SaveMenuPanel : MonoBehaviour
    {
        public Button[] saveButtons;
        public Button doneButton;

        private static SaveMenuPanel saveMenuPanel;

        public static SaveMenuPanel Instance()
        {
            if (!saveMenuPanel)
            {
                saveMenuPanel = FindObjectOfType(typeof(SaveMenuPanel)) as SaveMenuPanel;
                if (!saveMenuPanel)
                    Debug.LogError("There needs to be one active SaveMenuPanel script on a GameObject in your scene.");
            }

            return saveMenuPanel;
        }

        void Awake()
        {
            LoadMenu();
            AddMenuListeners();
            doneButton.onClick.RemoveAllListeners();
            doneButton.onClick.AddListener(CloseDialog);
        }

        void LoadMenu()
        {
            //TODO: load saves
        }

        void AddMenuListeners()
        {
            foreach (Button saveButton in saveButtons)
            {
                saveButton.onClick.RemoveAllListeners();
                saveButton.onClick.AddListener(ShowSaveDialog);
            }
        }

        public virtual void ShowSaveDialog ()
        {
            Debug.Log("show save dialog");
        }

        public virtual void CloseDialog ()
        {
            ModalPanel modalPanel = this.GetComponentInParent<ModalPanel>();
            modalPanel.HidePanel();
        }
        
    }

}

