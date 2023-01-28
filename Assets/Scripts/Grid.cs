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
        bool Movement = false;

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            for (int i = 0; i < 4; ++i) {
                int headNullY = -1;
                for (int j = 0; j < 4; ++j)
                {
                    int finalY = j;
                    if (blocks[i, j] is null)
                    {
                        finalY = -1;
                    }
                    if (headNullY == -1)
                    {
                        if (blocks[i, j] is null)
                        {

                            headNullY = j;

                        }
                    }
                    else if (blocks[i, j] is not null)
                    {

                        blocks[i, headNullY] = blocks[i, j];
                        blocks[i, j] = null;

                        finalY = headNullY;
                        float x = blocks[i, headNullY ].transform.position.x;
                        float y = blocks[i, headNullY ].transform.position.y;
                        float z = blocks[i, headNullY ].transform.position.z;

                        y = headNullY - 1.5f;
                        blocks[i, headNullY].transform.position = new Vector3(x, y, z);
                        headNullY = headNullY + 1;

                        Movement = true;
                    }
                    if (finalY > 0)
                    {
                        if (blocks[i, finalY].number.value == blocks[i, finalY - 1].number.value)
                        {
                            Destroy(blocks[i, finalY].gameObject);
                            blocks[i, finalY] = null;
                            headNullY = finalY;
                            blocks[i, finalY - 1].number.value *= 2;
                        }
                    }


                }
            }
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            for (int i = 3; i > -1; --i)
            {
                int headNullY = 4;
                for (int j = 3; j > -1; --j)
                {
                    int finalY = j;
                    if (blocks[i, j] is null)
                    {
                        finalY = 4;
                    }

                    if (headNullY == 4)
                    {
                        if (blocks[i, j] is null)
                        {
                            headNullY = j;

                        }
                    }
                    else if (blocks[i, j] is not null)
                    {

                        blocks[i, headNullY] = blocks[i, j];
                        blocks[i, j] = null;

                        finalY = headNullY;
                        float x = blocks[i, headNullY].transform.position.x;
                        float y = blocks[i, headNullY].transform.position.y;
                        float z = blocks[i, headNullY].transform.position.z;

                        y = headNullY - 1.5f;
                        blocks[i, headNullY].transform.position = new Vector3(x, y, z);
                        headNullY = headNullY - 1;

                        Movement = true;
                    }
                    if (finalY < 3)
                    {
                        if (blocks[i, finalY].number.value == blocks[i, finalY + 1].number.value)
                        {
                            Destroy(blocks[i, finalY].gameObject);
                            blocks[i, finalY] = null;
                            headNullY = finalY;
                            blocks[i, finalY + 1].number.value *= 2;
                        }
                    }


                }
            }
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            for (int j = 3; j > -1; --j)
            {
                int headNullX = 4;
                for (int i = 3; i > -1; --i)
                {
                    int finalX = i;
                    if (blocks[i, j] is null)
                    {
                        finalX = 4;
                    }


                    if (headNullX == 4)
                    {
                        if (blocks[i, j] is null)
                        {
                            headNullX = i;
                        }
                    }
                    else if (blocks[i, j] is not null)
                    {

                        blocks[headNullX, j] = blocks[i, j];
                        blocks[i, j] = null;

                        finalX = headNullX;
                        float x = blocks[headNullX, j].transform.position.x;
                        float y = blocks[headNullX, j].transform.position.y;
                        float z = blocks[headNullX, j].transform.position.z;

                        x = headNullX - 1.5f;
                        blocks[headNullX, j].transform.position = new Vector3(x, y, z);
                        headNullX = headNullX - 1;
                        Movement = true;
                       
                        
                    }
                    if (finalX < 3)
                    {
                        if (blocks[finalX, j].number.value == blocks[finalX + 1, j].number.value)
                        {
                            Destroy(blocks[finalX, j].gameObject);
                            blocks[finalX, j] = null;
                            headNullX = finalX;
                            blocks[finalX + 1, j].number.value *= 2;
                        }
                    }



                }
            }
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            for (int j = 0; j < 4; ++j)
            {
                int headNullX = -1;
                for (int i = 0; i < 4; ++i)
                {
                    int finalX = i;
                    if (blocks[i, j] is null) {
                        finalX = -1;
                    }

                    
                    if (headNullX == -1)
                    {
                        if (blocks[i, j] is null)
                        {
                            headNullX = i;
                        }
                    }
                    else if (blocks[i, j] is not null)
                    {

                        blocks[headNullX, j] = blocks[i, j];
                        blocks[i, j] = null;

                        finalX = headNullX;
                        float x = blocks[headNullX, j].transform.position.x;
                        float y = blocks[headNullX, j].transform.position.y;
                        float z = blocks[headNullX, j].transform.position.z;

                        x = headNullX - 1.5f;
                        blocks[headNullX, j].transform.position = new Vector3(x, y, z);
                        headNullX = headNullX + 1;
                        Movement = true;
                        
                        

                    }
                    if (finalX > 0)
                    {
                        if(blocks[finalX, j].number.value == blocks[finalX - 1, j].number.value)
                        {
                            Destroy(blocks[finalX, j].gameObject);
                            blocks[finalX, j] = null;
                            headNullX = finalX;
                            blocks[finalX - 1, j].number.value *= 2;
                        }
                    }



                }
            }
        }
        if (Movement == true)
        {
            CreateBlock();
        }
    }

    public void CreateBlock() {
        int LocationX;
        int LocationY;
        do
        {
            LocationX = Random.Range(0, 4);
            LocationY = Random.Range(0, 4);

        } while (blocks[LocationX, LocationY] is not null);

        GameObject newBlock = Instantiate(BlockPrefab, new Vector3(LocationX - 1.5f, LocationY - 1.5f, 0f), Quaternion.identity);
        blocks[LocationX, LocationY] = newBlock.GetComponent<Block>();
    }
}
