using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    // переменая для получения доступа к слайдеру 
    public Slider hangerSlider;
    // количество необходимой еды 
    public int amountToBeFed;
    // текущие количество еды 
    private int currentFedAmount = 0;

    private GameManager gameManager;

    private void Start()
    {
        // максимальный размер ползунка 
        hangerSlider.maxValue = amountToBeFed;
        // текущий размер ползунка 
        hangerSlider.value = 0;
        // принудительно деактивируем обект 
        hangerSlider.fillRect.gameObject.SetActive(false);
        // ссылка на обект GameObject
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // новый метод кормления животного 
    public void FeedAnimal (int amount)
    {

        currentFedAmount += amount;
        //принудительно активирует слайдер fillRect
        hangerSlider.fillRect.gameObject.SetActive(true);
        // размер слайдера равен текущему кол. еды 
        hangerSlider.value = currentFedAmount;

        // если текущие кол. еды равно необходимой 
        if (currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }


    }
}
