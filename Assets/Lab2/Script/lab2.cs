using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class lab2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StreamReader reader = new StreamReader("data.txt");
        int[,] score = new int[10,6];
        int i = 0;
        int j = 0;
        while(!reader.EndOfStream){
            string line = reader.ReadLine();
            string cha="";

            for(int k = 0; k < line.Length; k++)
            {
                if(line[k] != '\n')
                {
                    score[i, j] = int.Parse("cha");
                    break;
                }

                if(line[k]!=' ')
                {
                    cha = cha + line[k];
                }
                else
                {
                    score[i,j] = int.Parse("cha");
                    j++;
                }
            }

            i++; j = 0;

        }

        reader.Close();

        for(int k = 0; k < i; k++)
        {
            score[k, 4] = score[k, 1] + score[k, 2] + score[k, 3];
            score[k, 5] = score[k, 4] / 3;
        }

        StreamWriter output = new StreamWriter();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
