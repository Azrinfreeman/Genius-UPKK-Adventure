using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Watermelon
{
    public class QuestionController : MonoBehaviour
    {
        public static System.Random rnd = new();

        public static System.Random rnd1 = new();

        public int level;

        public int questionNumber;
        public int numCount;
        public TextMeshProUGUI textNumCount;
        public TextMeshProUGUI questionText;
        public List<Transform> buttonParents;

        public int buttonNum;
        public List<int> randomAnswer;
        private int answers;

        public Transform tick;
        public Transform cross;

        //hold answers in array
        public List<string> answerArray = new List<string>();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Invoke("showQuestion", 0.4f);
            numCount = 0;
            textNumCount.text = (numCount + 1).ToString();
        }

        // Update is called once per frame
        void Update()
        {
            if (numCount < 5)
            {
                textNumCount.text = (numCount + 1).ToString();
            }
        }

        public void showQuestion()
        {
            StartCoroutine(showQuest());
        }

        public void ResetButton()
        {
            if (level <= 12)
            {
                for (int a = 0; a < 3; a++)
                {
                    buttonParents[a].GetComponent<Button>().enabled = true;
                    buttonParents[a].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
            }
            else
            {
                for (int a = 0; a < 4; a++)
                {
                    buttonParents[a].GetComponent<Button>().enabled = true;
                    buttonParents[a].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                }
            }
        }

        public void CorrectButtonFunction(int buttonNum)
        {
            StartCoroutine(roundCollected(buttonNum));
        }

        IEnumerator roundCollected(int buttonNum)
        {
            DisableAllButtons();
            if (!GameObject.Find("rewarded").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("rewarded").GetComponent<AudioSource>().Play();
                GameObject.Find("yay").GetComponent<AudioSource>().Play();
            }
            buttonParents[buttonNum].GetComponent<Image>().color = new Color32(54, 217, 42, 255);
            //post question
            ScoreController.instance.AddScore(10);
            tick.gameObject.SetActive(true);
            yield return new WaitForSeconds(2f);
            tick.gameObject.SetActive(false);
            //EnableAllButtons();
            yield return new WaitForSeconds(0.3f);
            //repeat
            RepeatQuestion();
        }

        public void RepeatQuestion()
        {
            numCount++;
            if (numCount < 5)
            {
                showQuestion();
            }
            else
            {
                numCount = 0;
                transform.GetComponent<Animator>().Play("QuestionHide");
            }
        }

        void DisableAllButtons()
        {
            if (level <= 12)
            {
                for (int a = 0; a < 3; a++)
                {
                    buttonParents[a].GetComponent<Button>().enabled = false;
                    buttonParents[a].GetComponent<Image>().color = new Color32(77, 99, 243, 255);
                    Debug.Log("Clear button");
                }
            }
            else
            {
                for (int a = 0; a < 4; a++)
                {
                    buttonParents[a].GetComponent<Button>().enabled = false;
                    buttonParents[a].GetComponent<Image>().color = new Color32(77, 99, 243, 255);
                    Debug.Log("Clear button");
                }
            }
        }

        void EnableAllButtons()
        {
            if (level <= 12)
            {
                for (int a = 0; a < 3; a++)
                {
                    buttonParents[a].GetComponent<Button>().enabled = true;
                }
            }
            else
            {
                for (int a = 0; a < 4; a++)
                {
                    buttonParents[a].GetComponent<Button>().enabled = true;
                }
            }
        }

        IEnumerator showQuest()
        {
            //choose which index in the list to display the qeuestion
            questionNumber = rnd1.Next(
                0,
                QuestionClasses.instance.levels[level - 1].questions.Count
            );

            answers = questionNumber;
            //display question
            questionText.text = QuestionClasses
                .instance.levels[level - 1]
                .questions[questionNumber]
                .question.ToString();
            //apply answer to button

            //choose which button to put answer
            if (level <= 12)
            {
                buttonNum = rnd.Next(3);
            }
            else
            {
                buttonNum = rnd.Next(4);
            }

            answerArray.Clear();
            //assign to list temp

            if (level <= 12)
            {
                for (int b = 0; b < 3; b++)
                {
                    answerArray.Add(
                        QuestionClasses.instance.levels[level - 1].questions[answers].answerButton[
                            b
                        ]
                    );
                }
            }
            else
            {
                for (int b = 0; b < 4; b++)
                {
                    answerArray.Add(
                        QuestionClasses.instance.levels[level - 1].questions[answers].answerButton[
                            b
                        ]
                    );
                }
            }

            //add function to button
            //clear the button of any text and function

            if (level <= 12)
            {
                buttonParents[3].gameObject.SetActive(false);
                for (int a = 0; a < 3; a++)
                {
                    buttonParents[a].GetComponent<Button>().onClick.RemoveAllListeners();
                    buttonParents[a]
                        .GetComponent<Button>()
                        .transform.GetChild(0)
                        .GetComponent<TextMeshProUGUI>()
                        .text = "";
                    buttonParents[a].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                    Debug.Log("Clear button");
                }
            }
            else
            {
                Debug.Log("leve more than 4");
                for (int a = 0; a < 4; a++)
                {
                    Debug.Log("count: " + a);
                    buttonParents[a].GetComponent<Button>().onClick.RemoveAllListeners();
                    buttonParents[a]
                        .GetComponent<Button>()
                        .transform.GetChild(0)
                        .GetComponent<TextMeshProUGUI>()
                        .text = "";
                    buttonParents[a].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                    Debug.Log("Clear button");
                }
            }

            //apply the right button along with text
            buttonParents[buttonNum]
                .GetComponent<Button>()
                .onClick.AddListener(() => CorrectButtonFunction(buttonNum));
            buttonParents[buttonNum].GetChild(0).GetComponent<TextMeshProUGUI>().text = answerArray[
                QuestionClasses.instance.levels[level - 1].questions[answers].AnswerOnButton
            ];
            //remove from the array

            answerArray.RemoveAt(
                QuestionClasses.instance.levels[level - 1].questions[answers].AnswerOnButton
            );
            //apply wrong answer to any button

            if (level <= 12)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i != buttonNum)
                    {
                        //the list
                        int chooseRandom = rnd.Next(
                            0,
                            QuestionClasses.instance.levels[level - 1].questions.Count
                        );

                        //if list is empty (first time)
                        if (randomAnswer.Count == 0)
                        {
                            while (chooseRandom == questionNumber)
                            {
                                chooseRandom = rnd.Next(
                                    0,
                                    QuestionClasses.instance.levels[level - 1].questions.Count
                                );
                            }
                            randomAnswer.Add(chooseRandom);
                        }
                        else
                        {
                            // check if randomnumbers are duplicated in list
                            for (int l = 0; l < randomAnswer.Count; l++)
                            {
                                //                        Debug.Log("Check");
                                while (randomAnswer[l] == chooseRandom)
                                {
                                    //          Debug.Log("Duplicated");
                                    //generate new number if chooseRandom already in the list
                                    chooseRandom = rnd.Next(
                                        0,
                                        QuestionClasses.instance.levels[level - 1].questions.Count
                                    );
                                }
                            }
                            //check if answers is already selected from the list
                            while (chooseRandom == answers)
                            {
                                Debug.Log("Duplicated");
                                //generate new number if chooseRandom already in the list
                                chooseRandom = rnd.Next(
                                    0,
                                    QuestionClasses.instance.levels[level - 1].questions.Count
                                );
                            }

                            //

                            randomAnswer.Add(chooseRandom);
                        }
                        buttonParents[i].GetComponent<Button>().onClick.RemoveAllListeners();
                        buttonParents[i]
                            .GetComponent<Button>()
                            .onClick.AddListener(() => buttonFunction());

                        //button salah

                        Debug.Log("i = " + i);
                        Debug.Log(
                            QuestionClasses
                                .instance
                                .levels[level - 1]
                                .questions[answers]
                                .answerButton[0]
                        );
                        buttonParents[i]
                            .transform.GetChild(0)
                            .GetComponent<TextMeshProUGUI>()
                            .text = answerArray[0];

                        //remove from the array
                        answerArray.RemoveAt(0);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i != buttonNum)
                    {
                        //the list
                        int chooseRandom = rnd.Next(
                            0,
                            QuestionClasses.instance.levels[level - 1].questions.Count
                        );

                        //if list is empty (first time)
                        if (randomAnswer.Count == 0)
                        {
                            while (chooseRandom == questionNumber)
                            {
                                chooseRandom = rnd.Next(
                                    0,
                                    QuestionClasses.instance.levels[level - 1].questions.Count
                                );
                            }
                            randomAnswer.Add(chooseRandom);
                        }
                        else
                        {
                            // check if randomnumbers are duplicated in list
                            for (int l = 0; l < randomAnswer.Count; l++)
                            {
                                //                        Debug.Log("Check");
                                while (randomAnswer[l] == chooseRandom)
                                {
                                    //          Debug.Log("Duplicated");
                                    //generate new number if chooseRandom already in the list
                                    chooseRandom = rnd.Next(
                                        0,
                                        QuestionClasses.instance.levels[level - 1].questions.Count
                                    );
                                }
                            }
                            //check if answers is already selected from the list
                            while (chooseRandom == answers)
                            {
                                Debug.Log("Duplicated");
                                //generate new number if chooseRandom already in the list
                                chooseRandom = rnd.Next(
                                    0,
                                    QuestionClasses.instance.levels[level - 1].questions.Count
                                );
                            }

                            //

                            randomAnswer.Add(chooseRandom);
                        }
                        buttonParents[i].GetComponent<Button>().onClick.RemoveAllListeners();
                        buttonParents[i]
                            .GetComponent<Button>()
                            .onClick.AddListener(() => buttonFunction());

                        //button salah

                        Debug.Log("i = " + i);
                        Debug.Log(
                            QuestionClasses
                                .instance
                                .levels[level - 1]
                                .questions[answers]
                                .answerButton[0]
                        );
                        buttonParents[i]
                            .transform.GetChild(0)
                            .GetComponent<TextMeshProUGUI>()
                            .text = answerArray[0];

                        //remove from the array
                        answerArray.RemoveAt(0);
                    }
                }
            }
            //play notidication sound
            if (!GameObject.Find("Notification").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("Notification").GetComponent<AudioSource>().Play();
            }

            yield return new WaitForSeconds(1.2f);
            EnableAllButtons();
        }

        private void buttonFunction()
        {
            StartCoroutine(incorrectAnswer());
        }

        IEnumerator incorrectAnswer()
        {
            DisableAllButtons();

            if (!GameObject.Find("wrong").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("wrong").GetComponent<AudioSource>().Play();
                GameObject.Find("aww").GetComponent<AudioSource>().Play();
            }
            buttonParents[buttonNum].GetComponent<Image>().color = new Color32(54, 217, 42, 255);
            cross.gameObject.SetActive(true);
            yield return new WaitForSeconds(2f);
            cross.gameObject.SetActive(false);

            //repeat
            RepeatQuestion();
        }

        public void HideQuestion()
        {
            transform.gameObject.SetActive(false);
        }
    }
}
