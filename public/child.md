---
title: こどものころ
tags:
  - 一人アドベントカレンダー
private: true
updated_at: '2025-12-01T23:16:09+09:00'
id: 989dd555af1e7a9c699c
organization_url_name: null
slide: false
ignorePublish: false
---

いちばん最初に作っていたゲームの話をします。あの頃は、帰って宿題をしてゲームを作って、フィニアスとファーブを見る生活を送っていました。

ちなみに今は、XR Kaigiに行く飛行機の中で「すずめの戸締まり」を見ながら書いています。これ以上ヘンな状況で書くことはない気がします。
# Scratch
最初にゲームを作ったやつです。家族で外食しているときに暇つぶしにとiPadを渡されたのが最初だった気がします。声を録音したり、不協和音すぎる音楽を作ったりしていました。
例の猫のアクションシューティング的なやつとか、RPGのマップ移動みたいなのを作っていた気がします。

アカウントへのアクセス方法を失い、ずっと非公開で作っていたのでもう見られるものはないのですが……ここが間違いなくゲーム制作・プログラミングの始まりではあるので記載させていただきました。
（構成はミスった気もする。これ、前回の最後に付ければよかったかも）
# Unityのすゝめ
ある時、Unityの教科書を与えられました。

https://www.sbcr.jp/product/4815621360/

こういうやつ。現物は軽く探したのですが、奥深くに仕舞い込まれてしまった模様……捨ててはないと思うんだけどな〜。見つかったら上げておきます。

この本は、最後のレベルデザインとかの章を除き一通りやって、そのあとは自分でアクションゲームとかを作っていました。

# 3Dアクション引き継ごくん
今残っている中で最初のゲーム。この頃はgitも使ってなかったし、Unityプロジェクト名も日本語のまま。

## タイトル
タイトル画面。タイトルは「ステージ5の難易度が異常なくそアクションゲー。」ほんまかな。

![タイトル画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/title.png)

矢印キー移動で操作説明。わりとちゃんと作ってあってえらい。

![操作説明画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/how_to_play.png)

## 複数フォーム
フォームはクウガオマージュ。マイティ、ドラゴン、ペガサス、タイタン。装飾の向きとかが地味に違ったりする。

![マイティgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/maity.gif)
![ドラゴンgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/dragon.gif)
![ペガサスgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/pegasus.gif)
![タイタンgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/titan.gif)

## ステージ1
純粋にジャンプ。

![ステージ1gif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage01.gif)

## ステージ2
動く足場。このゲーム、ジャンプの効きが悪くて辛い；； FixedUpdateで判定取ったりしちゃってるのかなぁ。

![ステージ2gif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage02.gif)

## ステージ3
この時点でなんか難易度おかしい。

落ちる足場がある。
![ステージ3落ちる足場gif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage03-break-ground-wall.gif)

スイッチを押してから戻るというギミックっぽい。難しすぎるだろ。
![ステージ3全体画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage03.png)
[ステージ3クリアgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage03-asretick-clear.gif)

## ステージ4
謎解き面。ペガサスがあんま意味ないなぁと思い、急遽増設した記憶。

![ステージ4全体画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage04.png)
![ステージ4クリアgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage04.gif)

ワンチャン、アクションでもいけるのだろうか。
![ステージ4アクションgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage04-fight.gif)

## ステージ5
出たな、迷宮面。これ作るの楽しかったな〜。作るのにゲーム本体と他のレベルより絶対時間かかった。レベルデザインとかは全くないので、私もクリアできたことはないです。

![ステージ5画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage05.png)

えーで詳細と行きたいんですがね、もうそんな時間がない！！！！
- ざっくり、ステージのサイズが5倍
- 想定クリアまでの時間は今までのステージの30倍。20分とか。
- 即死あり、初見殺しあり、遅延あり、運ゲーあり、理不尽な謎解きあり。
![ステージ5空画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/stage05-sky.png)
どこかで攻略記事とかを別で出すかも？

## その他
ちょっと気になったのでスクリプト見てみる。命名は本当にひどいけど、驚くことにそこまで神クラスはない。突っ込みたい箇所は多々ありつつも、まぁギリ読めるな。（長い？ごめん）
```pleyercont.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pleyercont : MonoBehaviour
{
    int change = 0;
    float time = 0;
    GameObject who(int w, int h)
    {
        GameObject[] a = VB[w];
        GameObject v = a[h];
        return v;
    }


    public Material[] _material;  //正しいジャンプ
    Rigidbody rigid;
    int oldecoler = 1;
    GameObject mawaka;
    public static int stagew = 1;
    int coler = 1;
    float[,] status = { { 0, 0, 0, 0, 0, 0, 0 }, { -0.05f, -1, 410, 100, 30, 2, 90 }, { -0.065f, -1.4f, 420, 200, 60, 0.7f, 110 }, { -0.049f, -0.8f, 370, 100, 0, 0, 250 }, { -0.045f, -0.78f, 366, 200, 400, 0, 90 } };
    float workspeed = -0.05f;
    float jump = 410;
    float rotespeed = -1;
    int ja = 0;
    float kadougennkai;
    GameObject V;
    GameObject chan; 
    GameObject B;
    public List<GameObject[]> VB = new List<GameObject[]>();
    Color[] co = { new Color(255f, 255f, 255f, 255f), new Color(255f, 0f, 0f, 255f), new Color(0f, 255f, 255f, 255f), new Color(0f, 255f, 0f, 255f), new Color(255f, 0f, 255f, 255f) };
    public static int getstage()
    {
        return stagew;
    }
    Start is called before the first frame update
    void Start()
    {
        chan = GameObject.Find("change");
        chan.SetActive(false);
        for (int a = 0; a < 4; a++)
        {
            int b = a + 1;
            GameObject vv = GameObject.Find("vkey-" + b);
            vv.SetActive(false);
            GameObject bb = GameObject.Find("bkey-" + b);
            bb.SetActive(false);
            GameObject[] vbvb = { vv, bb };
            VB.Add(vbvb);
        }
        V = who(0, 0);
        mawaka = GameObject.Find("mawaka");
        B = who(0, 1);
        this.rigid = this.GetComponent<Rigidbody>();
        this.GetComponent<Renderer>().material = _material[coler];
    }
    int jump2 = 0;
    Update is called once per frame
    void Update()
    {
        if (change == 0)
        {
            float rorf = 0;
            float uord = 0;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rorf = 1;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rorf = -1;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                uord = 1;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                uord = -1;
            }
            if (Input.GetKeyDown(KeyCode.Space) && jump2 == 1)
            {
                jump2 = 0;
                rigid.AddForce(transform.up * jump);//400/900
            }
            if (Input.GetKey(KeyCode.K))
            {
                coler = 1;
            }
            if (Input.GetKey(KeyCode.L))
            {
                coler = 4;
            }
            if (Input.GetKey(KeyCode.I))
            {
                coler = 2;
            }
            if (Input.GetKey(KeyCode.J))
            {
                coler = 3;
            }
            if (oldecoler != coler)
            {
                V.gameObject.SetActive(false);
                B.gameObject.SetActive(false);
                V = who(coler - 1, 0);
                B = who(coler - 1, 1);
                change = 1;
                chan.SetActive(true);
                chan.GetComponent<ParticleSystem>().Play();
                this.rigid.angularVelocity = new Vector3(0, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                if (coler == 2)
                {
                    workspeed = -0.08f;
                    rotespeed = -1.6f;
                }
                else if (coler == 1)
                {
                    workspeed = -0.07f;
                    rotespeed = -1.3f;
                }
                V.gameObject.SetActive(true);
                V.GetComponent<Renderer>().material = _material[coler];
            }
            if (Input.GetKeyUp(KeyCode.V))
            {
                if (coler == 2)
                {
                    workspeed = -0.07f;
                    rotespeed = -1.4f;
                }
                else if (coler == 1)
                {
                    workspeed = -0.05f;
                    rotespeed = -1f;
                }
                V.gameObject.SetActive(false);
            }
            if (Input.GetKey(KeyCode.V))
            {
                if (coler == 3)
                {

                }
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                if (coler == 2)
                {
                    jump = 430f;
                }
                B.gameObject.SetActive(true);
                B.GetComponent<Renderer>().material = _material[coler];
            }
            if (Input.GetKeyUp(KeyCode.B))
            {
                if (coler == 2)
                {
                    jump = 420f;
                }
                B.gameObject.SetActive(false);
            }
            if (Input.GetKey(KeyCode.B))
            {
                if (coler == 3)
                {

                }
            }
            //Vector3 go = new Vector3;
            this.transform.Translate(0, 0, uord * workspeed*1.2f);
            this.rigid.angularVelocity = new Vector3(0, rorf * rotespeed, 0);

            float down = this.rigid.velocity.y;
            if (0.3f < down)
            {
                ja = 1;
            }
            else
            {
                ja = 0;
            }
            jump2 = 0;

        }
        else
        {
            if (time > 1.5f)
            {
                ParticleSystem.MainModule me = this.GetComponent<ParticleSystem>().main;
                me.startColor = co[coler];
                this.GetComponent<Renderer>().material = _material[coler];
                workspeed = status[coler, 0];
                jump = status[coler, 2];
                rotespeed = status[coler, 1];
                oldecoler = coler;
                change = 0;
                time = 0;
            }
            else
            {
                time += Time.deltaTime;
            }
        }
        if (oldecoler != coler)
        {
            V.gameObject.SetActive(false);
            B.gameObject.SetActive(false);
            V = who(coler - 1, 0);
            B = who(coler - 1, 1);
            change = 1;
            chan.SetActive(true);
            chan.GetComponent<ParticleSystem>().Play();
            this.rigid.angularVelocity = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            string stage = SceneManager.GetActiveScene().name;
            int sta = stage[5] - 47;
            SceneManager.LoadScene("stage" + sta);
        }
        if (collision.gameObject.tag == "gimenn")
        {
            jump2 = 1;
        }
        if (collision.gameObject.tag == "GameOber")
        {

            //transform.position = new Vector3(0, 3f, -9f);
            //transform.forward = new Vector3(0, 0, 0);
            stagew = SceneManager.GetActiveScene().name[5] - 48;
            SceneManager.LoadScene("gameOver");
        }

    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "gimenn" && ja == 0)
        {
            jump2 = 1;
            //Debug.Log("0");
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "gimenn")
        {
            jump2 = 0;
            //Debug.Log("1");
        }
    }
}
```

フォルダ分けする気がなさすぎるけど、プレハブはちゃんと使ってたり、Inspectorやコンポーネント構成もわりと健全。ゲームがシンプルでUnityに適しているってのもあるんだろうが、今でも触れそうな気がする。教科書に感謝。

![フォルダの画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/action-assets.png)
これ（Playerプレハブ）好き。
![Playerプレハブの画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/player-prefab.png)

# 致命的なバグを抱える将棋君
将棋です。将棋の駒を並べるのがめんどくさくて作り始めました。ちなみに「致命的なバグ」がどれかは覚えていないし、将棋は別に強くない。

## できること
オフライン二人対戦でターンの概念があり、移動予測が出る。普通に動かせるし、成れる（何気にすごくない？）。王を取ったらエラーが出ました。二歩も対応できてない。あとは、取った駒を打つときとかにもバグがあった気がする。

![将棋プレイ動画](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/syogi.gif)

## モデリング
このあたりからBlenderを触り始める。モデルもテクスチャも全部自作の記憶（木目の模様はどこかから引っ張ってきたような気もするし、木目ブラシみたいなので描いた気もする）。ちょっと浮いてる感があったりライティングだったり、ツッコミどころはあるが、ぱっと見のクオリティはめちゃいい。

![モデル画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/shogi.png)

## その他
ちなみにこっちは結構神クラスだった。神クラスからしか得られない養分がある。でもほぼ1クラスで完結してる。なんかすごいシンプル。
![コードの画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/syogi-code.png)
ちょっとうっとうしいかと思い、全コードは[GitHub](https://github.com/henohenon/qiita/blob/main/codes/child/yamoveb.cs)へ。

相変わらず命名とフォルダ整理はひどい。今もそこまで綺麗じゃないが。
![フォルダの画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/child/shogi-assets.png)

# 今思うこと
懐かしいね……当時はゲーム・テレビの時間が制限されてて、友達と放課後遊ぶこともなく、ネットも検索以外で使っていなかったため、本当に純粋に物を作っていた。ゲームとして完成しているとは言い難いけれども、AIのない時代に初心者がここまでやってるって考えたら、なんかすごいねとはなる。あれが幸せだったのかもしれない。

Assetsを見てもらったらわかると思うけど、すごいシンプルでいいなともなる。コードも意味わからん箇所はあるけど、愚直にやってる＆ちゃんと書いているため（か、俺が昔見すぎて調教されているため）全然目に入ってくる。やっぱSimple is Bestなのかも。まぁ、あんま触りたくはないけれども。

Scratchの内容が見せられないのが残念でならない。また、Unityのプロジェクトももうちょっと中途半端に放置して忘れてるものがいくつかあるに違いないのだ……南無三。安らかに眠れ……私も寝ます。