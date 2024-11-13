using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class negcounterscript : MonoBehaviour
{
    public static float negtotal = 0;
    public Text text;
    public bool textaan = false;
    public string sceneToLoad;
    public float fadeDuration = 2f;
    public GameObject[] images;

    public static void AddNegative(float amount)
    {
        negtotal += amount;
    }

    void Update()
    {
        if (negtotal >= 3 && !textaan)
        {
            StartCoroutine(LeaveSequence());
            textaan = true;
        }
    }

    private IEnumerator LeaveSequence()
    {
        yield return new WaitForSeconds(5);

        // Tekst weergeven
        text.text = "I don't think I am welcome here\nI should go home";
        text.enabled = true;
        Debug.Log("Bericht weergegeven");

        StartCoroutine(FadeImagesOutAndLoadScene());
    }

    private IEnumerator FadeImagesOutAndLoadScene()
    {
        foreach (GameObject imgObj in images)
        {
            Image img = imgObj.GetComponent<Image>();
            if (img != null)
            {
                yield return StartCoroutine(FadeToBlack(img));
            }
        }

        yield return new WaitForSeconds(2); // Wacht even na de fade
        SceneManager.LoadScene(sceneToLoad); // Laad de volgende scène
    }

    private IEnumerator FadeToBlack(Image image)
    {
        Color originalColor = image.color;
        float elapsedTime = 0f;
        
        while (elapsedTime < fadeDuration)
        {
            image.color = Color.Lerp(originalColor, new Color(0, 0, 0, 1), elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return new WaitForSeconds(5);
        
            SceneManager.LoadScene(28);
        }
        
        image.color = new Color(0, 0, 0, 1); // Zorg dat de kleur volledig zwart wordt aan het einde
          
    }

}