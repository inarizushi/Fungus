using UnityEngine;
using System.Collections;

namespace Fungus
{ 
    public class BringToFront : MonoBehaviour
    {

        void OnEnable()
        {
            transform.SetAsLastSibling();
        }
    }
}