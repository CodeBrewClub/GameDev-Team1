using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash_levelChanger : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private int levelToLoad;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            FadeToLevel(1);
        }
    }

    public void FadeToLevel(int levelIndex)
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
