using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource shootSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shootSound.Play();
        }
    }
}
