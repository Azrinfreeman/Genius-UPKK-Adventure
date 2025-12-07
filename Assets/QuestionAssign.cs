using UnityEngine;

namespace Watermelon
{
    public class QuestionAssign : MonoBehaviour
    {
        public Transform questionController;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Invoke("assigningQuestion", 0.1f);
        }

        public void assigningQuestion()
        {
            questionController = GameObject.Find("QuestionController").transform;
            questionController.GetComponent<QuestionController>().level = QuestionClasses
                .instance
                .level;
            questionController.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update() { }

        public void Active()
        {
            questionController.gameObject.SetActive(true);
        }

        public void GivePlayerQuestion()
        {
            Active();
            questionController.GetComponent<QuestionController>().showQuestion();
        }
    }
}
