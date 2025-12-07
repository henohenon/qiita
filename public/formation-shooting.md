---
title: 非現実動力
tags:
  - UnrealEngine
  - 一人アドベントカレンダー
private: false
updated_at: '2025-12-07T23:47:19+09:00'
id: 7caa39fc676f220f08eb
organization_url_name: null
slide: false
ignorePublish: false
---

さて、今回は久々のゲーム回。なんとUnrealEngine製のゲームです。実は今まで一番製作に時間をかけたゲームです。完成形として出せるものはほぼないですが、結構作り込んでるし、UE製ということもあり見栄えが割と良い。

# ゲームの概要
経緯としては、[前回](https://qiita.com/darknes_henohenon/items/1a707533e41e8b724461)のアニメーションモデル作成後、ゲームに魂を囚われて作り始めたという流れになります。
![ゲーム画面1](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/play.gif)
![ゲーム画面2](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/gagame.gif)

こんな感じで強制スクロールの3D自由ユニット配置シューティングです(情報量が多い)。
ベースは「エースコンバット的なフライトシューティング × タワーディフェンス」です。そこに「隊列」というスキル・形態変化の要素を取り入れ、
戦闘中に戦闘機を自由に並べ、隊列を組み替えて隊列ごとのスキルを活かして戦う！というゲームとしています。

強制スクロールにした理由は、単純に「広すぎると敵と出会わないなぁ」、でも「自由に動けると各個撃破で物量を圧倒できてしまうんだよな〜」というところから来ています。今になってみると手段と目的が逆転している気がします。
スクロールというか、一本道っぽいマップでゴールまで行くとか、ボスを倒すとかそんな感じが良かったかも。

# 開発記録
この頃頭がおかしかったらしく、無限に動画があります。いくつかご紹介します。
![キャプチャ集](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/images.png)

最初の頃。飛び方がふにゃふにゃ。
![01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/01.gif)
とてもunrealを感じるマップ。楽しそう。
![02](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/02.gif)
攻撃の実装。上手く行ってない。可愛い。
![03](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/04.gif)
攻撃の実装、それっぽくなったver。
![04](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/03.gif)
対空砲に晒されてる。
![05](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/05.gif)
攻撃できるように。毎回のように新しいモデリングの何かが出てて面白い。なんでやねん。
![06](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/06.gif)
ドックファイトもどき。
![07](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/07.gif)
隊列移動。なんかすごい爆発してる。
![08](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/08.gif)

# プログラム
フルBluePrintです。もういじれる気がしない。これ一番複雑なBP。
![bp](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/bp.gif)
ただ案外綺麗でしょう？ 何を隠そうこのプロジェクト、3回ぐらい0から作り直しているのです。だからUIが3種類ぐらいあるんですね〜。にしてもだいぶ進化を感じる。ビジュアルプログラミングは偉大なのかもしれない。

もう詳細は量もあって語れませんが、構成は大体こんな感じだった気がします。絶対どこかは間違えてる。
![クラス図。](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/classDiagram.png)


飛行機の挙動もマジでこだわってて、PitchとYawの値が来るので、それに合わせてアニメーションされるようになっています。
![レベル](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/zeroft-anim.png)

これが戦闘機のパラメーター。各種攻撃方法に場所、キャスト、リキャスト、エフェクト、ダメージ、アニメーションなど無限に詰まってる...恐ろしい。他にもTargetっていうプロパティとかとにかくまぁ色々ある。処理重そ〜どうやってたんだろ。
![何これ](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/nanikore.gif)
このゲーム、チームで開発していて、その中の一人から「ヤマト近代改修型」とかいうとんでもねぇものをお借りしていまして。なんか、もうほんとに、すごい。
![やまと図](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/yamamoto.gif)
これはアニメーションのBP。卒倒しそう。
![大和アニメーションbp](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/yamatobp.png)

レベルのデータもすごい。敵のSpawnerと各種敵があって、場所と角度とそれからの挙動とが定義できる...なんかプロジェクト更新してて今はまともに動いてない；；
![レベル](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/formation-shooting/leveldata.png)

# 今思うこと
記録があるからってのもあるんだろうけど、なんか、おかしいな。この頃が一番おかしいかもしれない。ここら辺で「ゲーム製作・ゲームプログラミング完全に理解した」気になっていたのだと思う。C++を触ろうとしたりして別のプロジェクトがどんどん始まり、また量産体制に入って満足してしまったため、開発をやめたっぽい。作り続けてた世界線も気になるような、結局中途半端に見切りつけてやめていそうな。

マップ外に出た時のエフェクトとかモデルとかパーティクルの話とかUIの話とかも、、暇があれば加筆するかも。
