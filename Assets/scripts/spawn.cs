using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject road;
    Vector3 nextSpawnPoint;
    Vector3 obstaclespawn;
    float xstart;
    float xend;
    bool spawnobs = false;
    public GameObject obs1;
    public GameObject obs2;
    public GameObject obs3;
    public GameObject health;
    public GameObject ability;
    float z;
    float z2;
    float z3;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 7; i++)
        {
            spawnroad();
        }
        spawnobs = true;
        

    }

    // Update is called once per frame
    void Update()
    {

        
    }

  public  void spawnroad()
    {

      GameObject temp =  Instantiate(road, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(2).transform.position;
        if (spawnobs == true)
        {
            obstaclespawn = nextSpawnPoint - new Vector3(5, 0, 0);
        xend = obstaclespawn.x ;
        xstart = obstaclespawn.x - 5;
       
       int determine = Random.Range(1, 6);
            //Debug.Log("" + determine);
            //if(determine == 5 || determine == 4)
            //{
            //    int luckyspin = Random.Range(1, 4);
            //    {
            //        if (luckyspin == 1 || luckyspin==2)
            //            determine = Random.Range(1, 4);
            //    }
            //}

            if(determine ==1)
            {
                float range = Random.Range(1, 4);
                if (range == 1)
                    z = (float)3.4;
                else if (range == 2)
                    z = (float)-3.4;
                else
                    z = 0;


                obstaclespawn = new Vector3(Random.Range(xstart, xend), (float)0.5, z);
                Instantiate(obs1, obstaclespawn, Quaternion.identity);
            }
            if (determine == 2)
            {
                float range = Random.Range(1, 3);
                if (range == 1)
                    z = (float)-1.85;
                else
                    z = (float)1.85;


                obstaclespawn = new Vector3(Random.Range(xstart, xend), (float)0.5, z);
                Instantiate(obs2, obstaclespawn, Quaternion.identity);

            }
            if (determine == 3)
            {

                obstaclespawn = new Vector3(Random.Range(xstart, xend), (float)0.5, 0);

                Instantiate(obs3, obstaclespawn, Quaternion.identity);
            }
            if (determine == 4|| determine==5)  
            {
                int randoming = Random.Range(1, 10);
                //determining Z for all
                float range = Random.Range(1, 7);
                if (range == 1)
                {
                    z = (float)2.5;
                    z2 = (float)0;
                    z3 = (float)-2.5;

                }
                   
                else if (range == 2)
                {
                    z = (float)2.5;
                    z2 = (float)-2.5;
                    z3 = (float)0;
                }
                else if (range == 3)
                {
                    z = (float)-2.5;
                    z2 = (float)2.5;
                    z3 = (float)0;
                }
                else if (range == 4)
                {
                    z = (float)-2.5;
                    z2 = (float)2.5;
                    z3 = (float)0;
                }
                else if (range == 5)
                {
                    z = (float)0;
                    z2 = (float)-2.5;
                    z3 = (float)2.5;
                }
                else if (range == 6)
                {
                    z = (float)0;
                    z2 = (float)2.5;
                    z3 = (float)-2.5;
                }




                if (randoming == 1)
                {
                   


                    obstaclespawn = new Vector3(Random.Range(xstart, xend), (float)0.5, z);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));
                }else

                if (randoming == 2)
                {

                   

                    obstaclespawn = new Vector3(Random.Range(xstart, xend),(float) 0.5, z);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));
                }
                else
                if (randoming == 3)
                {
                    

                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5, z);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                }
                else
                if (randoming == 4)
                {


                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5, z);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                }
                else
                if (randoming == 5)
                {


                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5, z);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                }
                else
                if (randoming == 6)
                {
                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5, z);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5,z3);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));
                }
                else
                if (randoming == 7)
                {
                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5,z);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5,z3);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));
                }
                else
                if (randoming == 8)
                {
                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5, z);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z3);
                    Instantiate(health, obstaclespawn, Quaternion.Euler(90, 0, 90));
                }
                else
                if (randoming == 9)
                {
                    float randoming2 = Random.Range(xstart, xend);
                    obstaclespawn = new Vector3(randoming2, (float)0.5, z);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z2);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));

                    obstaclespawn = new Vector3(randoming2, (float)0.5, z3);
                    Instantiate(ability, obstaclespawn, Quaternion.Euler(90, 0, 90));
                }
                

            }


           

        }
      

    }

 
  
}
