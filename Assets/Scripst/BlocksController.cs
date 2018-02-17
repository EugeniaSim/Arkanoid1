using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksController : MonoBehaviour {

    public GameObject oneRow, blocks;
    
    public int row;

	

	public void CreateBlocks () {
        Debug.Log("Create");
        for (float x = -1; x < row/row; x += 0.5f)
        {
            GameObject temp = Instantiate(oneRow, transform.position = new Vector2(-0.4f, x), Quaternion.identity);
            temp.transform.SetParent(blocks.transform);
        }
    }

    public void DestroyBlocks() {
        Debug.Log("Destroy");
        for (int i = 0; i < blocks.transform.childCount; i++)
        {
            Destroy(blocks.gameObject.transform.GetChild(i).gameObject);
        }
           
       
    }
}
