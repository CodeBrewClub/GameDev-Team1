using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.SplashAssets.Scripts
{
    class LevelAndTransitionHandler : MonoBehaviour
    {
        [SerializeField]
        AnimChanger[] ListOfChangers;
        [SerializeField]
        private float time;

        void Start()
        {
            StartCoroutine(LoadMainScreen());
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                this.FadeToLevel();
            }
        }

        void FadeToLevel()
        {
            foreach (AnimChanger a in ListOfChangers)
                a.FadeToLevel();
        }

        IEnumerator LoadMainScreen()
        {
            yield return new WaitForSeconds(time);
            yield return TransitionTime();
            SceneManager.LoadScene(++LEVEL.LEVEL_TO_LOAD);
        }

        IEnumerator TransitionTime()
        {
            foreach (AnimChanger a in ListOfChangers)
            {
                a.FadeToLevel();
                if(a.GetType() == typeof(SplashAnimChanger))
                {
                    yield return new WaitForSeconds(((SplashAnimChanger)a).GetAnimator().GetCurrentAnimatorStateInfo(0).length + ((SplashAnimChanger)a).GetAnimator().GetCurrentAnimatorStateInfo(0).normalizedTime);
                }
            }
                
        }
    }
}
