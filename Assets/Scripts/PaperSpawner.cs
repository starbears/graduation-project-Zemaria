using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;

public class PaperSpawner : MonoBehaviour
{
    public TextDataList texts;
    public GameObject paperPrefab;
    private List<int> availableOrders;

    void Start()
    {
        
        availableOrders = Enumerable.Range(-80, 4).ToList();

        TextAsset jsonFile = Resources.Load<TextAsset>("paperText");
        string json = jsonFile.text;
        texts = JsonUtility.FromJson<TextDataList>(json);
        
        // foreach (var item in texts.items)
        // {
        //     Debug.Log("Text: " + item.latterText + ", IsCensor: " + item.isCensor);
        // }
        AdaptiveTimer.OnTimeExpired += SpawnPaper;
    }

    public void SpawnPaper()
    {
        if (texts.items.Count > 0)
        {
            var paperText = GetRandomTextData();

            // Создаем новый объект бумаги
            var paperObject = Instantiate(paperPrefab, transform.position, Quaternion.identity);
            var paper = paperObject.GetComponent<Paper>();

            // Получаем уникальное случайное значение для Order in Layer
            int order = GetUniqueRandomOrder();

            // Устанавливаем данные и Order in Layer для бумаги
            paper.SetTextData(paperText, order);

            // Изменяем Order in Layer для SpriteRenderer
            var spriteRenderer = paperObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = order;
        }
    }

    void OnDisable()
    {
        AdaptiveTimer.OnTimeExpired -= SpawnPaper;
    }

    TextData GetRandomTextData()
    {
        return texts.items.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
    }

    int GetUniqueRandomOrder()
    {
        if (availableOrders.Count == 0)
        {
            
            availableOrders = Enumerable.Range(-80, 4).ToList();
        }

        int index = Random.Range(0, availableOrders.Count);
        int order = availableOrders[index];
        availableOrders.RemoveAt(index);

        return order;
    }
}
