using TMPro;
using UnityEngine;

namespace Watermelon
{
    public class VersionControl : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            GetComponent<TextMeshProUGUI>().text = "v" + Application.version;
        }

        // Update is called once per frame
        void Update() { }
    }
}
