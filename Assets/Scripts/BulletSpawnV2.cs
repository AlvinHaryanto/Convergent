using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class BulletSpawnV2 : MonoBehaviour
{
    //initialize bullet list here
    //bullet ID legend:
    //0: Normal - Undeflectable
    //1: Normal - Deflectable
    //2: Offlane- Deflectable - Left
    //3: Offlane- Deflectable - Right
    //4: Offlane- Undeflectable
    //5: Split (undeflectable only)
    //6: Missile (deflectable MUST)
    //7: Empty / Silent (ada bagian di pattern yang kosong)
    //8: Ghost - Undeflectable
    public GameObject bullet;
    public GameObject undeflectable;
    public GameObject offlane;
    public GameObject offlaneUndeflectable;
    public GameObject split;
    public GameObject missile;
    public GameObject ghostybullet;

    private GameObject tempBullet;
    private BulletMovement tempBulletMovement;
    //lane ID legend;
    //0: left
    //1: offlane left
    //2: mid
    //3: offlane right
    //4: right

    //level and difficulty is used to load the notes
    public int level;
    public int difficulty;
    public BulletMovement bm;
    private List<Entry> entryList = new List<Entry>();
    public class Entry
    {
        public List<int> EntryBulletID;
        public List<int> EntryLaneID;
    }
    private int finalIndex = 0;
    private int currIndex = 0;
    //make sure that the distance is in Unitee(s)
    //Unitee = time * speed
    //speed = value used to influence rb.velocity over time.deltatime
    public float distance = 4200;
    public float velocityMult = 1;
    public float noteSpeed = 5000;
    public float songBPM = 100;
    private float interval;
    private float currInterval = 3;
    private float travelTime = 0;
    private Vector3 location = new Vector3(0, 0, 70f);
    private float offValue = 3.48f;
    //offvalue: distance from center to any offlane. negative for left offlane
    // Use this for initialization
    void Start()
    {
        ReadEntryList();
        velocityMult = PlayerPrefs.GetFloat("VeloMult", 1f);
        setBulletSpeed();
        travelTime = distance / (noteSpeed * velocityMult);
        //Debug.Log("travel time is " + travelTime);
        interval = 60*2 / songBPM;
        currInterval -= travelTime;
        StartCoroutine(StartSpawning());
    }
    private void setBulletSpeed()
    {
        float newSpeed = noteSpeed * velocityMult;
        //Debug.Log("noteSpeed of "+noteSpeed+" with multi of "+velocityMult);
        //Debug.Log("New Speed is "+newSpeed.ToString());
        bullet.GetComponent<BulletMovement>().speed = newSpeed;
        undeflectable.GetComponent<BulletMovement>().speed = newSpeed;
        offlane.GetComponent<BulletMovement>().speed = newSpeed;
        offlaneUndeflectable.GetComponent<BulletMovement>().speed = newSpeed;
        split.GetComponent<Sc_BulletSplit>().speed = newSpeed;
        missile.GetComponent<BulletMovement>().speed = newSpeed;
        ghostybullet.GetComponent<BulletMovement>().speed = newSpeed;

        //Debug.Log("New Speed is " + bullet.GetComponent<BulletMovement>().speed.ToString());
    }
    IEnumerator StartSpawning()
    {
        while (true)
        {
            if (finalIndex > 0)
            {
                yield return new WaitForSeconds(currInterval);
                currInterval = interval;
                for (int i = 0; i < entryList[currIndex].EntryBulletID.Count; i++)
                {
                    SpawnBullet(entryList[currIndex].EntryBulletID[i], entryList[currIndex].EntryLaneID[i]);
                }
                currIndex++;
                if (currIndex >= finalIndex)
                {
                    currIndex = 0;
                }
            }
        }
    }

    private void ReadEntryList()
    {
        //fill entry using steamreader
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
        if (File.Exists(targetFolder + "/Entry" + level + "-" + difficulty + ".txt"))
        {
            StreamReader sr = new StreamReader(targetFolder + "/Entry" + level + "-" + difficulty + ".txt");
            int currSRIndex = 0;
            //Debug.Log(TotalLines(targetFolder + "/Entry" + level + "-" + difficulty + ".txt"));
            //testing the availability of inspector array
            //if (InspectorArray[0]!=null) { Debug.Log("yes"); }
            while (!sr.EndOfStream)
            {
                //read txt content here<====================================================================================================
                string temp = sr.ReadLine();
                string[] parsed = temp.Split(new[] { ' ' });
                for (int i = 0; i < parsed.Length; i++)
                {
                    string[] entryString = parsed[i].Split(new[] { '%' });
                    int tempBulletID = int.Parse(entryString[0]);
                    int tempLaneID = int.Parse(entryString[1]);
                    //if (InspectorArray[currSRIndex].entry[i] != null) { Debug.Log("yes"); } else { Debug.Log("NO"); }
                    entryList[currSRIndex].EntryBulletID[i] = tempBulletID;
                    entryList[currSRIndex].EntryLaneID[i] = tempLaneID;
                }
                currSRIndex++;
            }
            sr.Close();
        }
        else
        {
            Debug.Log("File "+ targetFolder + "/Entry" + level + "-" + difficulty + ".txt" + "not found!");
        }
    }
    private void SpawnBullet(int bulletID, int laneID)
    {
        //spawns bullet based on inputted ID and Lane Value
        //changes location value
        switch (laneID)
        {
            case 0:
                location.x = -7.27f;
                break;
            case 1:
                location.x = -offValue;
                break;
            case 2:
                location.x = 0f;
                break;
            case 3:
                location.x = offValue;
                break;
            case 4:
                location.x = 7.27f;
                break;
        }
        //spawns bullet basedon bulletID
        switch (bulletID)
        {
            case 0:
                tempBullet = Instantiate(undeflectable, location, bullet.transform.rotation);
                break;
            case 1:
                tempBullet = Instantiate(bullet, location, bullet.transform.rotation);
                break;
            case 2:
                tempBullet = Instantiate(offlane, location, bullet.transform.rotation);
                tempBulletMovement = tempBullet.GetComponent<BulletMovement>();
                tempBulletMovement.setLaneID(1);
                tempBulletMovement.setDeflectDir(0);
                //lane ID indicates offlane
                //deflect dir sets the correct deflection direction
                break;
            case 3:
                tempBullet = Instantiate(offlane, location, bullet.transform.rotation);
                tempBulletMovement = tempBullet.GetComponent<BulletMovement>();
                tempBulletMovement.setLaneID(1);
                tempBulletMovement.setDeflectDir(1);
                tempBulletMovement.Model.transform.localScale = new Vector3(-1 * tempBulletMovement.Model.transform.localScale.x, tempBulletMovement.Model.transform.localScale.y, tempBulletMovement.Model.transform.localScale.z);
                break;
            case 4:
                tempBullet = Instantiate(offlaneUndeflectable, location, bullet.transform.rotation);
                tempBullet.GetComponent<BulletMovement>().setLaneID(1);
                break;
            case 5:
                tempBullet = Instantiate(split, location, bullet.transform.rotation);
                break;
            case 6:
                tempBullet = Instantiate(missile, location, bullet.transform.rotation);
                tempBullet.GetComponent<ExplodeMissile>().rocketAnim.speed = velocityMult;
                break;
            case 7:
                //EMPTY BULLET
                break;
            case 8:
                tempBullet = Instantiate(ghostybullet, location, bullet.transform.rotation);
                break;

        }
    }
    public void AddBullet(int bulletID, int laneID, int entryIndex)
    {
        if (entryIndex>=finalIndex)
        {
            //first new entry
            entryList.Add(new Entry());
            entryList[entryIndex].EntryBulletID = new List<int>();
            entryList[entryIndex].EntryLaneID = new List<int>();
            //entryList[entryIndex].EntryBulletID.Add(1);
            entryList[entryIndex].EntryBulletID.Add(bulletID);
            entryList[entryIndex].EntryLaneID.Add(laneID);
            finalIndex++;
        }
        else
        {
            //additional bullets of the same entry
            entryList[entryIndex].EntryBulletID.Add(bulletID);
            entryList[entryIndex].EntryLaneID.Add(laneID);
        }
    }
}