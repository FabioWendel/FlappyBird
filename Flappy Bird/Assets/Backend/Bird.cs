using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private new Rigidbody2D rigidbody;
    public GameObject GameOver;
    public AudioClip FlyAudioClip, DeathAudioClip, ScoredAudioClip;
    private AudioSource audioSource;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
           rigidbody = GetComponent<Rigidbody2D>();  // reference of an object
           audioSource = GetComponent<AudioSource>(); // reference of an object
           animator = GetComponent<Animator>(); // reference of an object
           Screen.orientation = ScreenOrientation.Portrait; // force portrait screen
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Cliclouu");
            rigidbody.velocity = Vector2.up * speed;
            audioSource.PlayOneShot(FlyAudioClip);
        }
    }
    // checks if game object collides with something
    void OnCollisionEnter2D(Collision2D colisor)
    {

        print("Colidiuuu");
        audioSource.PlayOneShot(DeathAudioClip);
        GameOver.SetActive(true);
        animator.runtimeAnimatorController = Resources.Load("BirdCollider") as RuntimeAnimatorController;
        print("set BirdCollider");
        Time.timeScale = 0;
    }
    // checks if game object collides with something
    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "ScoreSound")
        {
            audioSource.PlayOneShot(ScoredAudioClip);
            Destroy(colisor.gameObject);
        }
    }
}
