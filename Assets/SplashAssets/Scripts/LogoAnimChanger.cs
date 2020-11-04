using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.SplashAssets.Scripts
{
    public class LogoAnimChanger : AnimChanger
    {
        [SerializeField]
        private Animator logo_animator;
        [SerializeField]
        private Animator mug_animator;

        public override void FadeToLevel()
        {
            logo_animator.SetTrigger("trig_anim");
            mug_animator.SetTrigger("trig_anim");
        }
    }
}
