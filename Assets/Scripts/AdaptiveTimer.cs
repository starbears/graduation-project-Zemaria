using UnityEngine;
using System;

public class AdaptiveTimer : MonoBehaviour
{
    public float initialTime = 10f;
    public float minTime = 1f;
    public float maxTime = 20f;
    public float timeChange = 1f;

    private float currentTime;

    public static event Action OnTimeExpired;

    void Start()
    {
        currentTime = initialTime;
    }

    public void CorrectAnswer()
    {
        // Если печать верна
        currentTime = Mathf.Max(currentTime - timeChange, minTime);
    }

    public void IncorrectAnswer()
    {
        // Если печать неверна
        currentTime = Mathf.Min(currentTime + timeChange, maxTime);
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            OnTimeExpired?.Invoke();
            
            currentTime = initialTime;
        }
    }
}

