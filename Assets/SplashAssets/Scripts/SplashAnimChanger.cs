using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.SplashAssets.Scripts
{
    public class SplashAnimChanger : AnimChanger
    {
        [SerializeField]
        private Animator animator;

        public override void FadeToLevel()
        {
            animator.SetTrigger("FadeOut");
        }

        public void OnFadeComplete()
        {
            SceneManager.LoadScene(++LEVEL.LEVEL_TO_LOAD);
        }

        public Animator GetAnimator()
        {
            return this.animator;
        }
    }
}
