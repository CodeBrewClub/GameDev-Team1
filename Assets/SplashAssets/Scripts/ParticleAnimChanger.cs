using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.SplashAssets.Scripts
{
    public class ParticleAnimChanger : AnimChanger
    {
        [SerializeField]
        private GameObject particle_container;
        private Animator[] particle_animators;

        void Awake()
        {
            particle_animators = particle_container.GetComponentsInChildren<Animator>();
        }

        public override void FadeToLevel()
        {
            foreach (var p in particle_animators)
            {
                p.SetTrigger("trig_anim");
            }
        }
    }
}
