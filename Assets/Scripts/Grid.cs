using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    List<List<Block>> blocks;
    [SerializeField]
    private GameObject BlockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Resources.Load<GameObject>("Prefabs/block");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
