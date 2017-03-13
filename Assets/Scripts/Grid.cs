using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

    public int GridX = 10;
    public int GridY = 10;

    private GridItem[,] grid;

	// Use this for initialization
	void Start () {
        initGrid();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void buildGrid()
    {

    }

    private void initGrid()
    {
        GameObject[] rows = gameObject.GetComponentsInChildren<GameObject>();

		GridX = rows.Length;

        for(int x = 0; x > GridX; x++)
        {
            GridItem[] items = rows[x].GetComponentsInChildren<GridItem>();

			GridY = items.Length;

			for(int y = 0; y < GridY; y++)
            {
				GridItem gridItem = items [y];
                grid.SetValue(gridItem, x, y);
            }
        }
    }

	GridItem FindGridItem(int x, int y) {
		return grid[x, y];
	}
}
