using UnityEngine;
using UnityEngine.SceneManagement;

namespace Watermelon
{
    public class SceneController : WorldChangeSpecialBehavior
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start() { }

        // Update is called once per frame
        void Update() { }

        public void LoadScene(string scenename)
        {
            SceneManager.LoadScene(scenename);
        }

        public override void OnGroundTileOpened(bool immediately)
        {
            throw new System.NotImplementedException();
        }

        public override void OnWorldChanged(SimpleCallback worldChangeCallback)
        {
            throw new System.NotImplementedException();
        }
    }
}
