using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Watermelon
{
    public class VolumeText : MonoBehaviour
    {
        public float value;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() { }

        // Update is called once per frame
        void Update()
        {
            value = transform.parent.transform.parent.GetComponent<Slider>().value * 100;
            GetComponent<TextMeshProUGUI>().text = value.ToString("00") + "%";
        }
    }
}
