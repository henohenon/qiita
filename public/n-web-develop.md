---
title: はじめてのおつかい ~ウェブの世界を大冒険スペシャル~
tags:
  - 一人アドベントカレンダー
private: false
updated_at: '2025-12-05T23:41:38+09:00'
id: 5acadec0a5d99c9ec860
organization_url_name: null
slide: false
ignorePublish: false
---

時間ができたこと、身近にコンテストや教材が増えたこと、幅を広げたかったことからWeb開発を開始しました。今回はその初めの頃に作っていたものの紹介です！

ちなみに今東京タワーの600段の階段に座りながら書いています。これを書きたいがためにパソコンを開きました。前々々回の状況を更新できたんじゃないでしょうか。アドカレ中に後一回は更新していきたいところ。
![タワー](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/tower.jpeg)

# 文字顔メーカー

https://henohenon.github.io/mojigao-maker/scripts/mojigao-maker.html

文字列をへのへのもへじ的に並べて素材組み合わせてアイコンを生成するサイト。文脈もしっかりしてるし作り込みもしてある。めっちゃええやん。

![イメージがぞう](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/mojigao-title.png)

デザインはGoogleのパクリ、規約は[こちら](https://kiyaku.jp/hinagata/)から引っ張ってて、素材はちゃんとオリジナル。
![サンプル](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/mojigao-images.png)
構成はガチガチの生html。この頃からようやくフォルダ分けやまともなファイルの名前付けを覚え始め、githubも使ってる。ファイル名日本語だけど...
![サンプル](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/mojigao-files.png)
あと確かこの召喚の背景が確かドラグスレイブの詠唱の英語版だった記憶(なんの話)。
![サンプル](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/summon.png)

# 人狼ボット
Slackで人狼のGMをしてくれるbot。アイコンがお気に入り。

![アイコン](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/jinro-icon.png)

テスト、バグが出まくったけど楽しかったな〜。テスト以外でまともに遊んだことはないが、まともに遊べるまでにはなったはず。
![サンプル01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/jinro-sample01.png)
![サンプル02](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/jinro-sample02.png)
開始コマンドは元々jsだったが犯罪臭がしてstに修正した記憶。

async awaitなどを初めていっぱい使った。でも中身はほんとに泥臭いプログラミングで、気合いのヘニャヘニャ初めての本格JavaScriptプログラミング。

# エモいチャット
アイコンに感情を持たせてチャットできるSNS。

ステージの場合はリアルタイムにアイコンが変化し、チャットすると漫画の吹き出しのように喋る。
ログの場合は時間順で記録されていて、チャットごとのアイコンに表情がある。
![エモいチャット](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/emoichat.gif)
発想としては任天堂のMiiとかが近いかも？

当時の自分には技術力が全くと言っていいほどなく、作り込みも機能もバグフィックスも全く追いついていない。サービスと呼べるクオリティでは断じてないが、主要機能としては動いてて、よーやっ
とる。


ちなみにまたしてもアイコンの画像は全部自作。こんな感じで配置できる。締切が厳しく、あんまり作り込めなかったな〜
![アイコン配置](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/emocha-icon.gif)


この制作で得た一番の経験値はCSSだと思ってます。こういう観覧車的なステージを作ろうとして、闘い、闘い、敗北しました。今なら割と実装できるかも？と見せかけてアイコンの実装がかなりやばく、ユーザーごとに5パーツくらいの自由配置のデータ+表情+一定期間でランダムに動くというなかなかな仕様。生きてる感を出したかったのだ...
![観覧車](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/kanransya.gif)
今ならログはCSSだとしても、ステージは一部もしくは全部Canvasで、とかにする気がする。

ちなみに2021年にデプロイされて2022年にポートフォリオ用に久々に起動され今また久々に起動されたわけだが、流石に色々怖かったのでこれを機に閉じた。南無三。
![部屋達](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/n-web-develop/emoichat-rooms.png)
今更ながら発想結構いい感じな気がするので、機会があったらなんかいい感じに拾い上げたい。
# 今思うこと
少ない技術、慣れないフィールドで足掻いているのが伝わる。作品としてしっかり自我が出ており、非常に好ましい。何なら作品の目的意識や思想という点ではゲームより全然レベル高いことしてる気がする！

この頃から多少締め切りという概念が出来始めた。制作期間としては他とあんまり変わってなかったと思うのだが、「飽きたからやめる。」みたいなのはなかった記憶。ネットにも触れ始め、良くも悪くもステージの変化を感じる。
(この頃他にも初めてのポートフォリオサイトを作ったりもしているのだが、それはまた別の記事で...)
