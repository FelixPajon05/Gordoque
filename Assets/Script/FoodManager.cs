using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FoodManager : MonoBehaviour
{
    public Text levelCleared;

    public GameObject transition;

    public Text totalFood;

    public Text foodCollected;

    private int totalFoodInLevel;

    private void Start()
    {
        totalFoodInLevel = transform.childCount;
    }

    private void Update()
    {
        AllFoodCollected();
        totalFood.text=totalFoodInLevel.ToString();
    }

    public void AllFoodCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("Ganaste");
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
