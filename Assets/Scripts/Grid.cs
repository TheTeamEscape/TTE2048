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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            for (int i = 0; i < 4; ++i) {
                int headNullY = -1;
                for (int j = 0; j < 4; ++j)
                {
                    if (headNullY == -1)
                    {
                        if (blocks[i, j] is null)
                        {

                            headNullY = j;

                        }
                    }
                    else if (blocks is not null)
                    {

                        blocks[i, headNullY] = blocks[i, j];
                        blocks[i, j] = null;

                    }       
                    float x = blocks[i, j].transform.position.x;
                    float y = blocks[i, j].transform.position.y;
                    float z = blocks[i, j].transform.position.z;
                }
            }
        }
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
