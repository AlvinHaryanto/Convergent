using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class Cd_LevelInputInterfaceTemplate : MonoBehaviour {
    private bool hasLoaded = false;
    BulletSpawn BSPAWN;
    public int level=0;
    public int difficulty=0;
    public GameObject FirstBoss;
    GetReady GR;
    public BulletSpawnV2 bulletSpawn;
    [System.Serializable]
    public class bulletList
    {
        public bool leftLane;
        public bool offLeft;
        public bool midLane;
        public bool offRight;
        public bool rightLane;
        public bool deflectable;
        public bool undeflectable;
        public bool offlaneLeft;
        public bool offlaneRight;
        public bool offLaneUndeflectable;
        public bool split;
        public bool lob;
        public bool ghost;
    }
    [System.Serializable]
    public class entryList
    {
        public bulletList[] entry;
    }

    public entryList[] InspectorArray;
    // Use this for initialization
    void Start()
    {
        //BSPAWN = GameObject.Find ("BulletSpawn").GetComponent<BulletSpawn> ();
        BSPAWN = FindObjectOfType<BulletSpawn>();
        GR = FindObjectOfType<GetReady>();
        LoadBullets();

        //BSPAWN.addBullet (1, 2);

    }

    void LoadBullets()
    {
        for (int i = 0; i < InspectorArray.Length; i++)
        {
            int bulletID = 7;
            for(int j = 0; j < InspectorArray[i].entry.Length; j++)
            {

                //0: Normal - Undeflectable
                //1: Normal - Deflectable
                //2: Offlane- Deflectable - Left
                //3: Offlane- Deflectable - Right
                //4: Offlane- Undeflectable
                //5: Split (undeflectable only)
                //6: Missile (deflectable MUST)
                //7: Empty / Silent (ada bagian di pattern yang kosong)
                //8: Ghost - Undeflectable
                if (InspectorArray[i].entry[j].deflectable) { bulletID = 1; }
                else if (InspectorArray[i].entry[j].undeflectable) { bulletID = 0; }
                else if (InspectorArray[i].entry[j].offlaneLeft) { bulletID = 2; }
                else if (InspectorArray[i].entry[j].offlaneRight) { bulletID = 3; }
                else if (InspectorArray[i].entry[j].offLaneUndeflectable) { bulletID = 4; }
                else if (InspectorArray[i].entry[j].split) { bulletID = 5; }
                else if (InspectorArray[i].entry[j].lob) { bulletID = 6; }
                else if (InspectorArray[i].entry[j].ghost) { bulletID = 8; }
                int laneID = 0;
                if (InspectorArray[i].entry[j].leftLane) { laneID = 0; }
                else if (InspectorArray[i].entry[j].offLeft) { laneID = 1; }
                else if (InspectorArray[i].entry[j].midLane) { laneID = 2; }
                else if (InspectorArray[i].entry[j].offRight) { laneID = 3; }
                else if (InspectorArray[i].entry[j].rightLane) { laneID = 4; }
                bulletSpawn.AddBullet(bulletID, laneID,i);
            }
        }
    }

    public void GenerateLevel()
    {
        string targetFolder= Application.dataPath + "/LevelBulletEntries";
        try
        {
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
        }
        catch (IOException ex)
        {
            Debug.Log(ex.Message);
        }
        FileStream targetFile = File.Create(targetFolder+ "/Entry" + level + "-" + difficulty + ".txt");
        targetFile.Close();
        StreamWriter sw = new StreamWriter(targetFolder + "/Entry" + level + "-" + difficulty + ".txt");
        //write txt content here<====================================================================================================
        for(int i = 0; i < InspectorArray.Length; i++)
        {
            for(int j = 0; j < InspectorArray[i].entry.Length; j++)
            {
                if (j > 0) { sw.Write(" "); }
                int bulletID = 7;
                Debug.Log(i);
                if (InspectorArray[i].entry[j].deflectable) { bulletID = 1; }
                else if (InspectorArray[i].entry[j].undeflectable) { bulletID = 0; }
                else if (InspectorArray[i].entry[j].offlaneLeft) { bulletID = 2; }
                else if (InspectorArray[i].entry[j].offlaneRight) { bulletID = 3; }
                else if (InspectorArray[i].entry[j].offLaneUndeflectable) { bulletID = 4; }
                else if (InspectorArray[i].entry[j].split) { bulletID = 5; }
                else if (InspectorArray[i].entry[j].lob) { bulletID = 6; }
                else if (InspectorArray[i].entry[j].ghost) { bulletID = 8; }
                int laneID = 0;
                if (InspectorArray[i].entry[j].leftLane) { laneID = 0; }
                else if (InspectorArray[i].entry[j].offLeft) { laneID = 1; }
                else if (InspectorArray[i].entry[j].midLane) { laneID = 2; }
                else if (InspectorArray[i].entry[j].offRight) { laneID = 3; }
                else if (InspectorArray[i].entry[j].rightLane) { laneID = 4; }
                sw.Write(bulletID+"%"+laneID);
            }
            sw.WriteLine();
        }
        sw.Close();
        Debug.Log(targetFolder);
    }
    public void ReadLevel()
    {
        string targetFolder = Application.dataPath + "/LevelBulletEntries";
        try
        {
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
        }
        catch (IOException ex)
        {
            Debug.Log(ex.Message);
        }
        if(File.Exists(targetFolder + "/Entry" + level + "-" + difficulty + ".txt"))
        {
            StreamReader sr = new StreamReader(targetFolder + "/Entry" + level + "-" + difficulty + ".txt");
            int currSRIndex = 0;
            //Debug.Log(TotalLines(targetFolder + "/Entry" + level + "-" + difficulty + ".txt"));
            InspectorArray = new entryList[TotalLines(targetFolder + "/Entry" + level + "-" + difficulty + ".txt")];
            //testing the availability of inspector array
            //if (InspectorArray[0]!=null) { Debug.Log("yes"); }
            while (!sr.EndOfStream)
            {
                //read txt content here<====================================================================================================
                string temp = sr.ReadLine();
                string[] parsed = temp.Split(new[] {' '});
                InspectorArray[currSRIndex] = new entryList();
                InspectorArray[currSRIndex].entry = new bulletList[parsed.Length];
                //Debug.Log("parse length is "+parsed.Length);
                for(int i = 0; i < parsed.Length; i++)
                {
                    string[] entryString = parsed[i].Split(new[] {'%'});
                    //Debug.Log("String is "+parsed[i]);
                    //Debug.Log(currSRIndex + " on " + i+" with results "+entryString[0]+"%"+entryString[1]);
                    int tempBulletID = int.Parse(entryString[0]);
                    int tempLaneID = int.Parse(entryString[1]);
                    //if (InspectorArray[currSRIndex].entry[i] != null) { Debug.Log("yes"); } else { Debug.Log("NO"); }
                    InspectorArray[currSRIndex].entry[i] = new bulletList();
                    InspectorArray[currSRIndex].entry[i].undeflectable = false;
                    InspectorArray[currSRIndex].entry[i].deflectable = false;
                    InspectorArray[currSRIndex].entry[i].offlaneLeft = false;
                    InspectorArray[currSRIndex].entry[i].offlaneRight = false;
                    InspectorArray[currSRIndex].entry[i].offLaneUndeflectable = false;
                    InspectorArray[currSRIndex].entry[i].split = false;
                    InspectorArray[currSRIndex].entry[i].lob = false;
                    InspectorArray[currSRIndex].entry[i].ghost = false;
                    InspectorArray[currSRIndex].entry[i].leftLane = false;
                    InspectorArray[currSRIndex].entry[i].offLeft = false;
                    InspectorArray[currSRIndex].entry[i].midLane= false;
                    InspectorArray[currSRIndex].entry[i].offRight= false;
                    InspectorArray[currSRIndex].entry[i].rightLane = false;
                    switch (tempBulletID)
                    {
                        case 0:
                            InspectorArray[currSRIndex].entry[i].undeflectable = true;
                            break;
                        case 1:
                            InspectorArray[currSRIndex].entry[i].deflectable = true;
                            break;
                        case 2:
                            InspectorArray[currSRIndex].entry[i].offlaneLeft = true;
                            break;
                        case 3:
                            InspectorArray[currSRIndex].entry[i].offlaneRight = true;
                            break;
                        case 4:
                            InspectorArray[currSRIndex].entry[i].offLaneUndeflectable = true;
                            break;
                        case 5:
                            InspectorArray[currSRIndex].entry[i].split = true;
                            break;
                        case 6:
                            InspectorArray[currSRIndex].entry[i].lob = true;
                            break;
                        case 7:
                            break;
                        case 8:
                            InspectorArray[currSRIndex].entry[i].ghost = true;
                            break;
                    }
                    switch (tempLaneID)
                    {
                        case 0:
                            InspectorArray[currSRIndex].entry[i].leftLane = true;
                            break;
                        case 1:
                            InspectorArray[currSRIndex].entry[i].offLeft = true;
                            break;
                        case 2:
                            InspectorArray[currSRIndex].entry[i].midLane = true;
                            break;
                        case 3:
                            InspectorArray[currSRIndex].entry[i].offRight = true;
                            break;
                        case 4:
                            InspectorArray[currSRIndex].entry[i].rightLane = true;
                            break;
                    }
                }
                currSRIndex++;
            }
            sr.Close();
        }
        else
        {
            Debug.Log("File not found!");
        }
    }
    int TotalLines(string filePath)
    {
        using (StreamReader r = new StreamReader(filePath))
        {
            int i = 0;
            while (r.ReadLine() != null) { i++; }
            return i;
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
