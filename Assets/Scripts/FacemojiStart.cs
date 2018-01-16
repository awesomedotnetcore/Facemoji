﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace HuiHut.Facemoji
{
    [AddComponentMenu("FacemojiStart")]
    public class FacemojiStart : MonoBehaviour
    {
        bool isPress = false;
        float pressTimes = 0;

        // Use this for initialization
        void Start ()
        {

        }

        // Update is called once per frame
        void Update ()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // Press the first time
                if (!isPress)
                {
                    pressTimes = Time.time;
                    isPress = true;
                }
                // Press the second time
                else
                {
                    // Press twice in two seconds
                    if (Time.time - pressTimes < 2.0)
                    {
                        Application.Quit();
                    }
                    else
                    {
                        isPress = false;
                    }
                }
            }
        }

        public void OnFaceTracking()
        {
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene("FaceTracking");
#else
            Application.LoadLevel ("FaceTracking");
#endif
        }

        public void OnFacemojiAI()
        {
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene("FacemojiAI");
#else
            Application.LoadLevel("FacemojiAI");
#endif
        }

        public void OnTTS()
        {
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene("TTS");
#else
            Application.LoadLevel("TTS");
#endif
        }

        public void OnIAT()
        {
#if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene("IAT");
#else
            Application.LoadLevel("IAT");
#endif
        }

        public void OnExitButton()
        {
            Application.Quit();
        }

        public void OnMenuButton()
        {
            // Menu
        }
    }
}
