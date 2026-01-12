using UnityEditor.Rendering;
using UnityEngine;

public class Npcscript : MonoBehaviour
{
    bool isPlayerNearby = false;
    public GameObject dialogText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNearby == true)
        {
            print("Prata med Npc");
            dialogText.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Något är i närheten");
        isPlayerNearby = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        dialogText.SetActive(false);
    }
}
