using System.Collections;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private Text timerText;
    [SerializeField]
    private UnityEvent onTimerEnded;
    [SerializeField]
    private UnityEvent onSecondPassed;
    [SerializeField]
    private string showAnimationName;
    private float seconds;
    private Coroutine timerCoroutine;
    public void cancelTimer()
    {
        if (timerCoroutine != null)
        {
            StopCoroutine(timerCoroutine);
            timerCoroutine = null;
        }
    }
    public void StarTimer(float duraction)
    {
        seconds = duraction;
        timerCoroutine = StartCoroutine(RunTimer());
    }
    private IEnumerator RunTimer()
    {
        
        timerText.GetComponent<Animator>().Play(showAnimationName, 0, 0f);
        timerText.text =seconds.ToString();
        onSecondPassed.Invoke();
        timerText.text = seconds.ToString();
        yield return new WaitForSeconds(1);
        seconds--;
        if (seconds <=0)
        {
            onTimerEnded.Invoke();
        }
        else
        {
            timerCoroutine = StartCoroutine(RunTimer());
        }
    }
}
