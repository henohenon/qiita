using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class yamoveb : MonoBehaviour
{
    public void turnchange()
    {
        ya.turn = 0;
        turn = 0;
    }
    void zutougo(int xxxxx, int yyyyy)
    {
        int xxxx = x;
        int yyyy = y;
        while (xxxx < 100)
        {
            xxxx += xxxxx;
            yyyy += yyyyy;
            if (xxxx != 9 && yyyy != 9 && xxxx != -1 && yyyy != -1)
            {
                if (bannmenn[xxxx, yyyy] != 0)
                {
                    Debug.Log("S1");
                    break;
                }
                else if (ya.bannmenn[xxxx, yyyy] != 0)
                {
                    int[] wentt = { xxxx, yyyy };
                    canmove.Add(wentt);
                    GameObject goo = Instantiate(koma) as GameObject;
                    Renderer rr = goo.GetComponent<Renderer>();
                    rr.sharedMaterial = mate;
                    goo.transform.localScale = new Vector3(45f, 45f, 45f);
                    goo.transform.position = new Vector3(xxxx - 4, goo.transform.position.y, yyyy - 4);
                    break;
                }
                Debug.Log("S2");
                int[] went = { xxxx, yyyy };
                canmove.Add(went);
                GameObject go = Instantiate(koma) as GameObject;
                Renderer r = go.GetComponent<Renderer>();
                r.sharedMaterial = mate;
                go.transform.localScale = new Vector3(45f, 45f, 45f);
                go.transform.position = new Vector3(xxxx - 4, go.transform.position.y, yyyy - 4);
            }
            else
            {
                break;
            }
        }
    }
    public void uugoki(int xxx, int yyy)
    {
        if (bannmenn[xxx, yyy] == ban[namas[xxx, yyy] - 1])
        {
            koma.transform.position = new Vector3(xxx - 4, koma.transform.position.y, yyy - 4);
        }
        else
        {
            koma.transform.position = new Vector3(xxx - 4, koma.transform.position.y, yyy - 4);
        }
    }
    public int torareta(int xx, int yy)
    {
        int moxtuteikareta = 0;
        if (namas[xx, yy] != 0)
        {
            koma = null;
            moxtuteikareta = namas[xx, yy];
            GameObject m = GameObject.Find(this.gameObject.name + names[moxtuteikareta - 1]);
            if (bannmenn[xx, yy] != ban[namas[xx, yy] - 1])
            {
                m.transform.Rotate(-180, 0, 0);
            }
            m.transform.position = new Vector3(0, 15, 0);
            mykoma[namas[xx, yy] - 2] = 0;
            int[,] nama = namas;
            nama[xx, yy] = 0;
            namas = nama;
            bannmenn[xx, yy] = 0;
        }
        return moxtuteikareta;
    }
    GameObject red;
    public Material mate;
    yamover ya;
    int mode = 0;
    public int turn = 0;
    public int x = 5;
    public int y = 4;
    public int sotox = 0;
    public int sotoy = 0;
    int oko = 0;
    GameObject koma;
    List<GameObject> motigo = new List<GameObject>();
    List<string> zerofive = new List<string>();
    List<int[]> canmove = new List<int[]>();
    public int[,] ugoki = { { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
    { 0, 1, 0, 1, 1, 1, 1, 1, 2 }, { 1, 0, 1, 0, 0, 1, 1, 1, 2 },
    { 0, 0, 0, 0, 0, 3, 0, 3, 2 }, { 0, 0, 0, 0, 0, 0, 2, 0, 2 },
    { 0, 2, 0, 2, 2, 0, 2, 0, 9 }, { 2, 0, 2, 0, 0, 2, 0, 2, 10 },
    { 0, 0, 0, 0, 0, 0, 1, 0, 2 }, { 1, 2, 1, 2, 2, 1, 2, 1, 9 }, 
    { 2, 1, 2, 1, 1, 2, 1, 2, 10 } };
    public int[,] bannmenn =  { { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 8, 8, 8, 8, 8, 8, 8, 8, 8 },
    { 0, 7, 0, 0, 0, 0, 0, 6, 0 }, { 5, 4, 3, 2, 1, 2, 3, 4, 5 } };
    public int[,] namas =  { { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 30, 29, 28, 27, 26, 25, 24, 23
    , 22 },{ 0, 20, 0, 0, 0, 0, 0, 18, 0 }, { 15, 11, 7, 3, 1, 2, 6
    , 10, 14 } };
    string[] names = { "King", "Gold1", "Gold2", "Gold3", "Gold4",
    "Silver1", "Silver2", "Silver3", "Silver4","ScentedCar1",
    "ScentedCar2","ScentedCar3","ScentedCar4","Guima1","Guima2",
    "Guima3","Guima4","Coaster1","Coaster2","CornerRow1",
    "CornerRow2","Infantry1","Infantry2","Infantry3","Infantry4",
    "Infantry5","Infantry6","Infantry7","Infantry8","Infantry9",
    "Infantry10","Infantry11","Infantry12","Infantry13",
    "Infantry14","Infantry15","Infantry16","Infantry17","Infantry18"
     };
    string[] tags = { "0", "1", "2", "3", "4", "5", "6", "7", "8",
    "9","10", "11", "12", "13", "14", "15", "16", "17", "18","19",
    "20","21","22" ,"23","24","25","26","27","28","29","30","31",
    "32","33","34","35","36","37","38" };
    int[] ban = { 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5
    , 6, 6, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8
    , 8 };
    int[] mykoma = { 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0
    , 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1,1, 0, 0, 0, 0, 0, 0, 0, 0
    ,0 };
    public int[,] sotobann = { { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 
    0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, } };
    List<int> utekoma = new List<int>();
    Vector2 nari = new Vector3();
    int lr = 0;
    // Start is called before the first frame update
    void Start()
    {
        red = GameObject.Find("teemred");
        ya = red.GetComponent<yamover>();
        turn = ya.turn;
        zerofive.Add("1");
        zerofive.Add("2");
        zerofive.Add("3");
        zerofive.Add("4");
        zerofive.Add("5");
        zerofive.Add("6");
        zerofive.Add("7");
        zerofive.Add("8");
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(1, 0, 0);
                x++;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3(-1, 0, 0);
                x--;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, 1);
                y++;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, -1);
                y--;
            }
            if (Input.GetKeyDown(KeyCode.E) && (utekoma.Count != 0 || koma == this.gameObject))
            {
                transform.position = new Vector3(6, 1, -5);
                mode = 1;
                sotox = 0;
                sotoy = 0;
                if (koma != this.gameObject && koma != null)
                {
                    var clones = GameObject.FindGameObjectsWithTag(koma.gameObject.tag);
                    foreach (var clone in clones)
                    {
                        if (clone.name.Contains("Clone"))
                        {
                            Destroy(clone);
                        }
                    }
                    canmove.Clear();
                }
                else
                {
                    var clones = GameObject.FindGameObjectsWithTag(tags[sotobann[sotox, sotoy] - 1]);
                    foreach (var clone in clones)
                    {
                        if (clone.name.Contains("Clone"))
                        {
                            Destroy(clone);
                        }
                    }
                    canmove.Clear();
                }
            }
            if (Input.GetKeyDown(KeyCode.Q) && turn == 0)
            {
                if (koma == this.gameObject)
                {
                    int mn = 0;
                    for (int i = 0; i < canmove.Count; i++)
                    {
                        int[] mend = canmove[i];
                        if (mend[0] == x && mend[1] == y)
                        {
                            mn = 1;
                            break;
                        }
                    }
                    if (mn == 1)
                    {
                        Vector3 kopo = koma.transform.position;
                        GameObject[] clones = GameObject.FindGameObjectsWithTag(tags[sotobann[sotox, sotoy] - 1]);
                        int[,] n = bannmenn;
                        bannmenn[x, y] = ban[sotobann[sotox, sotoy] - 1];
                        namas[x, y] = sotobann[sotox, sotoy];
                        koma = GameObject.Find(this.gameObject.name + names[sotobann[sotox, sotoy] - 1]);
                        if (zerofive.Contains(koma.gameObject.tag))
                        {
                            koma.transform.position = new Vector3(x - 4, 0.85f, y - 4);
                        }
                        else
                        {
                            koma.transform.position = new Vector3(x - 4, 0.5f, y - 4);
                        }
                        foreach (GameObject clone in clones)
                        {
                            if (clone.name.Contains("Clone"))
                            {
                                Destroy(clone);
                            }
                        }
                        sotobann[sotox, sotoy] = 0;
                        canmove.Clear();
                        ya.turnchange();
                        koma = null;
                        for(int i= sotox * 9 + sotoy+1; i < utekoma.Count; i++)
                        {
                            motigo[i].transform.position = motigo[i].transform.position+new Vector3(0,0,-1);
                        }
                        for(int i = sotoy; i < 3; i++)
                        {
                            for (int ii = sotox; ii < 9; ii++)
                            {
                                if (ii == 8)
                                {
                                    if (i == 2)
                                    {
                                        sotobann[i, 8] = 0;
                                    }
                                    else
                                    {
                                        sotobann[i, 8] = sotobann[i + 1, 8];
                                    }
                                }
                                else
                                {
                                    sotobann[i, ii] = sotobann[i, ii + 1];
                                }
                            }
                        }
                        utekoma.RemoveAt(sotox * 9 + sotoy);
                        motigo.RemoveAt(sotox * 9 + sotoy);
                    }
                }
                else
                {
                    int[] mypo = { x, y };
                    int m = 0;
                    List<int> e = new List<int>();
                    for (int i = 0; i < canmove.Count; i++)
                    {
                        int[] mend = canmove[i];
                        if (mend[0] == mypo[0] && mend[1] == mypo[1])
                        {
                            m = 1;
                            e.Add(mend[0]);
                            e.Add(mend[1]);
                        }
                    }
                    if (m == 1)
                    {
                        if (ya.bannmenn[x, y] != 1)
                        {
                            int me = ya.torareta(x, y);
                            if (me != 0)
                            {
                                GameObject men = GameObject.Find(this.gameObject.name + names[me - 1]);
                                men.transform.position = new Vector3(6, 0.4f, -5 + utekoma.Count);
                                sotobann[(int)Mathf.Floor(utekoma.Count / 9), utekoma.Count % 9] = me;
                                utekoma.Add(me);
                                motigo.Add(men);
                                mykoma[me - 2] = 1;
                            }
                        }
                        else
                        {
                            GameObject time = GameObject.Find("timeObserver");
                            timeObserve t = time.GetComponent<timeObserve>();
                            t.finish(1);
                        }
                        Vector3 kopo = koma.transform.position;
                        var clones = GameObject.FindGameObjectsWithTag(tags[namas[(int)kopo.x + 4, (int)kopo.z + 4] - 1]);
                        int[,] n = bannmenn;
                        if ((x < 3 || kopo.x + 4 < 3) && bannmenn[(int)kopo.x + 4, (int)kopo.z + 4] != ugoki[ban[namas[(int)kopo.x + 4, (int)kopo.z + 4] - 1] - 1, 8])
                        {
                            clones = GameObject.FindGameObjectsWithTag(koma.gameObject.tag);
                            foreach (var clone in clones)
                            {
                                if (clone.name.Contains("Clone"))
                                {
                                    Destroy(clone);
                                }
                            }
                            Vector2 a = new Vector2(x, y);
                            nari = a;
                            if (zerofive.Contains(koma.gameObject.tag))
                            {
                                koma.transform.position = new Vector3(x - 4, 0.85f, y - 4);
                            }
                            else
                            {
                                koma.transform.position = new Vector3(x - 4, 0.5f, y - 4);
                            }
                            Debug.Log("S3");
                            GameObject go = Instantiate(koma) as GameObject;
                            go.transform.Rotate(180, 0, 0);
                            go.transform.position += new Vector3(0, 0.7f, 0.5f);
                            GameObject goo = Instantiate(koma) as GameObject;
                            goo.transform.position += new Vector3(0, 0.7f, -0.5f);
                            mode = 2;
                            transform.position += new Vector3(0, 0, 0.5f);
                            bannmenn[x, y] = n[(int)kopo.x + 4, (int)kopo.z + 4];
                            bannmenn[(int)kopo.x + 4, (int)kopo.z + 4] = 0;
                            int[,] d = namas;
                            namas[x, y] = d[(int)kopo.x + 4, (int)kopo.z + 4];
                            namas[(int)kopo.x + 4, (int)kopo.z + 4] = 0;
                            canmove.Clear();
                            ya.turnchange();
                        }
                        else
                        {
                            bannmenn[x, y] = n[(int)kopo.x + 4, (int)kopo.z + 4];
                            bannmenn[(int)kopo.x + 4, (int)kopo.z + 4] = 0;
                            int[,] d = namas;
                            namas[x, y] = d[(int)kopo.x + 4, (int)kopo.z + 4];
                            namas[(int)kopo.x + 4, (int)kopo.z + 4] = 0;
                            uugoki(x, y);
                            foreach (var clone in clones)
                            {
                                if (clone.name.Contains("Clone"))
                                {
                                    Destroy(clone);
                                }
                            }
                            canmove.Clear();
                            ya.turnchange();
                        }
                    }
                    else if (bannmenn[x, y] != 0)
                    {
                        if (canmove.Count != 0)
                        {
                            Vector3 kopo = koma.transform.position;
                            var clones = GameObject.FindGameObjectsWithTag(tags[namas[(int)kopo.x + 4, (int)kopo.z + 4] - 1]);
                            foreach (var clone in clones)
                            {
                                if (clone.name.Contains("Clone"))
                                {
                                    Destroy(clone);
                                }
                            }
                        }
                        koma = GameObject.Find(this.gameObject.name + names[namas[x, y] - 1]);
                        canmove.Clear();
                        string[] b = { "9", "10", "11", "12" };
                        if (bannmenn[x,y]==4)
                        {
                            for (int I = 0; I < 2; I++)
                            {
                                for (int i = 0; i < 2; i++)
                                {
                                    if (ugoki[ban[namas[x, y] - 1] - 1, I * 5 + ((i + 1) * 2 - 2)] == 3 && x + (I * -4 + 2) < 9 && x + (I * -4 + 2) > -1 && y + (i * 2 - 1) < 9 && y + (i * 2 - 1) > -1)
                                    {
                                        Debug.Log("S4");
                                        int[] went = { x + (I * -4 + 2), y + (i * 2 - 1) };
                                        canmove.Add(went);
                                        GameObject go = Instantiate(koma) as GameObject;
                                        Renderer r = go.GetComponent<Renderer>();
                                        Material[] _material = r.materials;
                                        r.sharedMaterial = mate;
                                        go.transform.localScale = new Vector3(45f, 45f, 45f);
                                        go.transform.position += new Vector3(I * -4 + 2, 0, i * 2 - 1);
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                if (ugoki[bannmenn[x, y] - 1, i] == 1)
                                {
                                    GameObject go = Instantiate(koma) as GameObject;
                                    Renderer r = go.GetComponent<Renderer>();
                                    Material[] _material = r.materials;
                                    r.sharedMaterial = mate;
                                    go.transform.localScale = new Vector3(45f, 45f, 45f);
                                    if (i == 0 && x + 1 < 9 && x + 1 > -1 && y - 1 < 9 && y - 1 > -1 && bannmenn[x + 1, y - 1] == 0)
                                    {
                                        go.transform.position += new Vector3(1, 0, -1);
                                        int[] went = { x + 1, y - 1 };
                                        canmove.Add(went);
                                    }
                                    else if (i == 1 && x + 1 < 9 && x + 1 > 0 && bannmenn[x + 1, y] == 0)
                                    {
                                        go.transform.position += new Vector3(1, 0, 0);
                                        int[] went = { x + 1, y };
                                        canmove.Add(went);
                                    }
                                    else if (i == 2 && x + 1 < 9 && x + 1 > -1 && y + 1 < 9 && y + 1 > -1 && bannmenn[x + 1, y + 1] == 0)
                                    {
                                        go.transform.position += new Vector3(1, 0, 1);
                                        int[] went = { x + 1, y + 1 };
                                        canmove.Add(went);
                                    }
                                    else if (i == 3 && y - 1 < 9 && y - 1 > -1 && bannmenn[x, y - 1] == 0)
                                    {
                                        go.transform.position += new Vector3(0, 0, -1);
                                        int[] went = { x, y - 1 };
                                        canmove.Add(went);
                                    }
                                    else if (i == 4 && y + 1 < 9 && y + 1 > -1 && bannmenn[x, y + 1] == 0)
                                    {
                                        go.transform.position += new Vector3(0, 0, 1);
                                        int[] went = { x, y + 1 };
                                        canmove.Add(went);
                                    }
                                    else if (i == 5 && x - 1 < 9 && x - 1 > -1 && y - 1 < 9 && y - 1 > -1 && bannmenn[x - 1, y - 1] == 0)
                                    {
                                        go.transform.position += new Vector3(-1, 0, -1);
                                        int[] went = { x - 1, y - 1 };
                                        canmove.Add(went);
                                    }
                                    else if (i == 6 && x - 1 < 9 && x - 1 > -1 && bannmenn[x - 1, y] == 0)
                                    {
                                        Debug.Log("a");
                                        go.transform.position += new Vector3(-1, 0, 0);
                                        int[] went = { x - 1, y };
                                        canmove.Add(went);
                                    }
                                    else if (i == 7 && x - 1 < 9 && x - 1 > -1 && y + 1 < 9 && y + 1 > -1 && bannmenn[x - 1, y + 1] == 0)
                                    {
                                        go.transform.position += new Vector3(-1, 0, 1);
                                        int[] went = { x - 1, y + 1 };
                                        canmove.Add(went);
                                    }
                                    else
                                    {
                                        Destroy(go);
                                    }
                                }
                                if (ugoki[bannmenn[x, y] - 1, i] == 2)
                                {
                                    //敵、味方の盤面で止まるまでクローン、敵だったら+1とかでよろしく。
                                    if (i == 0 && x + 1 < 9 && x + 1 > -1 && y - 1 < 9 && y - 1 > -1 && bannmenn[x + 1, y - 1] == 0)
                                    {
                                        zutougo(+1, -1);
                                    }
                                    else if (i == 1 && x + 1 < 9 && x + 1 > 0 && bannmenn[x + 1, y] == 0)
                                    {
                                        zutougo(+1, 0);
                                    }
                                    else if (i == 2 && x + 1 < 9 && x + 1 > -1 && y + 1 < 9 && y + 1 > -1 && bannmenn[x + 1, y + 1] == 0)
                                    {
                                        zutougo(1, 1);
                                    }
                                    else if (i == 3 && y - 1 < 9 && y - 1 > -1 && bannmenn[x, y - 1] == 0)
                                    {
                                        zutougo(0, -1);
                                    }
                                    else if (i == 4 && y + 1 < 9 && y + 1 > -1 && bannmenn[x, y + 1] == 0)
                                    {
                                        zutougo(0, 1);
                                    }
                                    else if (i == 5 && x - 1 < 9 && x - 1 > -1 && y - 1 < 9 && y - 1 > -1 && bannmenn[x - 1, y - 1] == 0)
                                    {
                                        zutougo(-1, -1);
                                    }
                                    else if (i == 6 && x - 1 < 9 && x - 1 > -1 && bannmenn[x - 1, y] == 0)
                                    {
                                        zutougo(-1, 0);
                                    }
                                    else if (i == 7 && x - 1 < 9 && x - 1 > -1 && y + 1 < 9 && y + 1 > -1 && bannmenn[x - 1, y + 1] == 0)
                                    {
                                        zutougo(-1, 1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (mode == 1)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(1, 0, 0);
                sotox++;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3(-1, 0, 0);
                sotox--;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, 1);
                sotoy++;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, -1);
                sotoy--;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                transform.position = new Vector3(0, 2, 0);
                mode = 0;
                x = 4;
                y = 4;
                koma = null;
            }
            if (Input.GetKeyDown(KeyCode.Q) && turn == 0)
            {
                koma = GameObject.Find(this.gameObject.name + names[sotobann[sotox, sotoy] - 1]);
                int[,] yaa = ya.bannmenn;
                for (int i = 0; i < 81; i++)
                {
                    if (bannmenn[(int)Mathf.Floor(i / 9), i % 9] == 0 && yaa[(int)Mathf.Floor(i / 9), i % 9] == 0)
                    {
                        Debug.Log("S6");
                        GameObject go = Instantiate(koma) as GameObject;
                        Renderer r = go.GetComponent<Renderer>();
                        Material[] _material = r.materials;
                        r.sharedMaterial = mate;
                        go.transform.localScale = new Vector3(45f, 45f, 45f);
                        go.transform.position = new Vector3(((int)Mathf.Floor(i / 9)) - 4, 0.8f, (i % 9) - 4);
                        int[] went = { (int)Mathf.Floor(i / 9), i % 9 };
                        canmove.Add(went);
                    }
                }
                koma = this.gameObject;
                transform.position = new Vector3(0, 2, 0);
                mode = 0;
                x = 4;
                y = 4;
            }
        }
        else if (mode == 2)
        {

            if (Input.GetKeyDown(KeyCode.W) && lr == 0)
            {
                transform.position += new Vector3(0, 0, -1);
                lr = 1;
            }
            if (Input.GetKeyDown(KeyCode.S) && lr == 1)
            {
                transform.position += new Vector3(0, 0, 1);
                lr = 0;
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                if (lr == 0)
                {
                    bannmenn[x, y] = ugoki[ban[namas[x, y] - 1] - 1, 8];
                    koma.transform.Rotate(180, 0, 0);
                    if (zerofive.Contains(koma.gameObject.tag))
                    {
                        koma.transform.position = new Vector3(x - 4, 0.4f, y - 4);
                    }
                    else
                    {
                        koma.transform.position = new Vector3(x - 4, 0.75f, y - 4);
                    }
                    lr = 0;
                }
                transform.position = new Vector3(x - 4, 2, y - 4);
                var clones = GameObject.FindGameObjectsWithTag(koma.gameObject.tag);
                foreach (var clone in clones)
                {
                    if (clone.name.Contains("Clone"))
                    {
                        Destroy(clone);
                    }
                }
                mode = 0;
                canmove.Clear();
                ya.turnchange();
            }
        }
    }
}
