using System.Collections;
using TMPro;
using UnityEngine;

namespace MenuScripts
{
    public class Diyalog : MonoBehaviour
    {
        public TextMeshProUGUI textComponent;
        public string[] lines;
        public float textSpeed;
        public GameObject point;
        public float endDialogueDelay = 2.0f;

        private int index;

        void Start()
        {
            textComponent.text = string.Empty;
            StartDialogue();
        }

        void Update()
        {
            if (gameObject.activeSelf)
            {
                point.SetActive(false);
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }

        void StartDialogue()
        {
            index = 0;
            StartCoroutine(TypeLine());
        }

        IEnumerator TypeLine()
        {
            foreach (char c in lines[index].ToCharArray())
            {
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }

            if (index == lines.Length - 1)
            {
                yield return new WaitForSeconds(endDialogueDelay);
                gameObject.SetActive(false);
                point.SetActive(true);
            }
        }

        void NextLine()
        {
            if (index < lines.Length - 1)
            {
                index++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());
            }
        }
    }
}