using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    Block[,] blocks;
    [SerializeField]
    private GameObject BlockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        blocks = new Block[4, 4];
        CreateBlock();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBlock() {
        int LocationX;
        int LocationY;

        LocationX = Random.Range(0, 4);
        LocationY = Random.Range(0, 4);

        GameObject newBlock = Instantiate(BlockPrefab, new Vector3(LocationX - 1.5f, LocationY - 1.5f, 0f), Quaternion.identity);

        blocks[LocationX, LocationY] = newBlock.GetComponent<Block>();
    }
}
