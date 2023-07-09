using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class square : MonoBehaviour
{
    public GameObject player;
    private CarGeneral cg;
    public GameObject prfab;
    public Transform[] spawnpoints;
    private Transform playerT;
    public int score;
    public TextMeshProUGUI scoreText;
    public AudioSource src;
    public AudioClip sfx1;
    
   

    private void Start()
    {
        cg = GetComponent<CarGeneral>();   
        playerT = player.GetComponent<Transform>();
        scoreText.text = "Score : " + score;
        
    }
    private void Update()
    {
        scoreText.text = "Score : " + score;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            player.SetActive(true);
            playerT.position = new Vector3(3f, 26f, 0f);
            Destroy(other.gameObject);
            score += 10;
            scoreText.text = "Score : " + score;
            src.clip = sfx1;
            src.Play();
           
            int spawnIndex = Random.Range(0, spawnpoints.Length);
            GameObject newPoint = Instantiate(prfab, spawnpoints[spawnIndex].position, Quaternion.identity);
        }
    }

    


}
