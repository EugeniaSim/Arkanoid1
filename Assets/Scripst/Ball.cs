using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;


public class Ball : MonoBehaviour {

    public Rigidbody2D rbBoll;
    public float ballSpeed;
    private int[] mass = new int[] {-4, -2, -1, 2, 4 };
    private int speedControll, blockCount = 40;
    public GameObject yellowBlock, greenBlock, player;
   

    void Start ()
    {
        NewGame();
    }

    void Update()
    {
        rbBoll.gravityScale = (rbBoll.velocity.y < 4 && rbBoll.velocity.y > -2) ? 3 : 0;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlueBlock")
        {
            GameObject temp = Instantiate(yellowBlock, collision.gameObject.transform.position, Quaternion.identity);
            temp.transform.SetParent(Manager.BlockControll.blocks.transform);
            WhenCollision(collision,5);
        }

        if (collision.gameObject.tag == "YellowBlock") 
        {

            Instantiate(greenBlock, collision.gameObject.transform.position, Quaternion.identity);
                      transform.SetParent(Manager.BlockControll.blocks.transform);
            WhenCollision(collision,10);
        }

        if (collision.gameObject.tag == "GreenBlock") {
            
                blockCount--;
                if (blockCount <= 0)
                {
                     Manager.Over.WhenVictory();
                }
                else
                {
                WhenCollision(collision,20);
            }
        }
           

        if (collision.gameObject.tag == "LowerBound")
        {
            Manager.Over.WhenDefeat();
            Manager.BlockControll.DestroyBlocks();
            StartCoroutine(NewGameCoroutine());
        }
    }

   
    public void SpeedUpdate() {
        speedControll++;

        if (speedControll >= 5) {
            speedControll = 0;
            ballSpeed += 1;
        }
        
    }

    public void WhenCollision(Collision2D collision, int step)
    {
        SpeedUpdate();
        Destroy(collision.gameObject);
        Manager.TextControll.UpdateScore(step);
    }

    public IEnumerator NewGameCoroutine() {
        
        yield return new WaitForSeconds(2.0f);
        Manager.Over.losePanel.SetActive(false);
        Debug.Log("new");
        yield return new WaitForSeconds(2.0f);
        NewGame();
       

    }


    // не работает((
    public void NewGame() {
        Manager.BlockControll.CreateBlocks();
        rbBoll.velocity = new Vector2(mass[Random.Range(0, mass.Length)], ballSpeed);
        this.transform.position = new Vector2(0, -1.5f);
        player.transform.position = new Vector2(0, -3f);
        Manager.BlockControll.DestroyBlocks();
        Manager.BlockControll.CreateBlocks();
        
        Time.timeScale = 1;
        speedControll = 0;
        rbBoll.velocity = new Vector2(mass[Random.Range(0, mass.Length)], ballSpeed);
        blockCount = 40;
    }


}
