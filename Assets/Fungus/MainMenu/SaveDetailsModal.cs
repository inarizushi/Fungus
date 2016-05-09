using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fungus
{
    public class SaveDetailsModal : SaveMenuPanel
    {
        public Text dateTimeText;
        public Text chapterText;
        public InputField nameInputField;

        void AddMenuListeners()
        {
            nameInputField.onEndEdit.AddListener(HandleNameInput);
        }

        void LoadMenu()
        {
            dateTimeText.text = System.DateTime.Now.ToShortDateString();

            //TODO: Actually add chapter or some indicator here
            chapterText.text = "Chapter 1";
        }

        private void HandleNameInput(string arg0)
        {
            //Get name and save it to playerprefs
        }
                
    }
}
