using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
  //  public Text LoadingPercentage;
  //  public Image LoadingProgressBar;
    public static SceneTransition _instance;
    public static bool shouldPlayOpeningAnimation = false;
    [SerializeField] 
    private GameObject LoadingFade;
    public Animator componentAnimator;
    [SerializeField]
    public Animator componentAnimatorText;
    public AsyncOperation loadingSceneOperation;

    public static void SwitchToScene(string NameScene)
    {
        _instance.LoadingFade.SetActive(true);
        _instance.componentAnimator.SetTrigger("SceneClosing");
        _instance.componentAnimatorText.SetTrigger("TextIn");        
        _instance.loadingSceneOperation = SceneManager.LoadSceneAsync(NameScene);

        // Чтобы сцена не начала переключаться пока играет анимация 
      //  _instance.loadingSceneOperation.allowSceneActivation = false;

       // instance.LoadingProgressBar.fillAmount = 0;
    }

    public void Start()
    {
        _instance = this;

        // componentAnimator = GetComponent<Animator>();
        // componentAnimatorText = GetComponent<Animator>();

       if (shouldPlayOpeningAnimation)
        {
            componentAnimator.SetTrigger("SceneOpening");
            componentAnimatorText.SetTrigger("TextOut");
         //   instance.LoadingProgressBar.fillAmount = 1;

            // если следующий переход будет обычным SceneManager.LoadScene, не проиграет анимацию opening
             shouldPlayOpeningAnimation = false;
       }
    }

    // private void Update()
    // {
    //     if (loadingSceneOperation != null)
    //     {
    //         LoadingPercentage.text = Mathf.RoundToInt(loadingSceneOperation.progress * 100) + "%";
    //
    //         // присвоить прогресс:
    //         LoadingProgressBar.fillAmount = loadingSceneOperation.progress; 
    //
    //        
    //         LoadingProgressBar.fillAmount = Mathf.Lerp(LoadingProgressBar.fillAmount, loadingSceneOperation.progress,
    //             Time.deltaTime * 5);
    //     }
    // }

    public void OnAnimationOver()
    {
        // Чтобы при открытии сцены, куда мы переключаемся, проигралась анимация opening
        shouldPlayOpeningAnimation = true;

        loadingSceneOperation.allowSceneActivation = true;
    }
}
