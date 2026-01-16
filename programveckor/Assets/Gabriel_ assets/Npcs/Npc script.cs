using UnityEditor.Rendering;
using UnityEngine;

public class Npcscript : MonoBehaviour
{
    bool isPlayerNearby = false;
    public GameObject dialogText;
    public GameObject PromptText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNearby == true)
        {
            
            dialogText.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PromptText.SetActive(true);
        print("Prata med npc");
        isPlayerNearby = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            isPlayerNearby = false;
            dialogText.SetActive(false);
            PromptText.SetActive(false);
        }
    }
}
