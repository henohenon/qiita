---
title: Hexamagia ~音ゲーを作ろう~
tags:
  - 一人アドベントカレンダー
private: false
updated_at: '2025-12-24T00:31:21+09:00'
id: 898296d1abd3031ec543
organization_url_name: null
slide: false
ignorePublish: false
---

今回は、初めて作った音ゲーについて語ります。  最近の自分は、なんちゃって楽曲制作＆サウンドプログラマー的な立ち位置を開拓しようと動いています。

なぜ今さら音ゲーを？ もう開拓されきったジャンルでは？  
と言われると図星ですが、まあ、作りたかったので……
一応打算としては、
- 自分の文脈として一度ボカロを回収しておきたい
- 音楽が作れたらなんちゃってゲーム制作系全網羅人間になれるかも
- サウンドプログラマーの立ち位置は結構ニッチで良さそう
というのがあったりはします。

# 概要

https://henohenon.itch.io/hexamagia

こんな感じ。かっこいい〜。  
Kyosuニキと話していて「やっぱ音ゲー作りてぇよな！！！」となり、制作が始まりました。

メンバー構成は、プログラマー2、デザイン・エフェクト1、サウンド2、アドバイザー1といった座組です。
自分の担当は、メインがプログラム、次点でデザイン、おまけで企画と進行でした。

## プログラム
もう一人のメンバーと一緒に実装していて、かなり渾然一体となっていたため、明確な役割分担を説明するのはちょっと難しいのですが、BMSの解釈から判定処理、表示の作成まで、一通りメインで関わっています。

BMS解釈が本当に辛くてぇ……音ズレが……どうしても……修正できなくてぇ……。

最終的にはバグまみれですが、ギリギリ動くものにはなりました。えらい。が、完全に力不足です。反省。

https://github.com/henohenon/RhythmGameTemplate

プログラムとしては簡略化したものをこちらに置いているので、よければ見てみてください。

## デザイン

このプロダクト、実は地味に自分もデザインを担当しています。  
元々デザイン担当の方からもらっていたのがこちら。

![元](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/first.png)

それを、いい感じに素材化しました。

![プレイ画面](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/play-tmp.png)

アイコン・ロゴデザインは完全に自分です。顔だし、気合と6時間ぐらいを込めて作りました。
ノーツや画面全体、切り替えのイメージをベースに作成しました。最終ではこじつけもいいところですが、過程ではHやXにも見えるといいかもな〜、とかも思いながら作ってました。
![ロゴ](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/logo-tmp.png)

細かく作り込んでいてえらいですね。
![ロゴ詳細](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/logo-detail.png)

スタート画面やリザルト画面も自分が考えていました。
![理想の結果画面](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/result-ideal.png)

※実装は追いついていません。  
UI周りは本当に全然間に合わなかったです。色々考えてはいたのですが……スケジューリングが致命的に下手。

![現実の結果画面](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/result-real.png)

## 企画・進行
企画に関しては、ほぼKyosuさんの持ち込みです。  
ゲーム名を相談しながら決める、といったことはしましたが、どちらかというと進行寄りの役割でした。

これは初回MTGで使ったスライドの一部です。  
8枚ほどですが、それなりにちゃんと用意しました。

![初回MTG](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/hexamagia/ice-break.png)

座組と初回だけは気合を入れ、その後はひたすらアウトプットを出すイメージでコミット。
締め切り直前まで自分がノリきれなかったこと、メンバーを十分に見きれなかったことなど反省はいっぱいある。。

進行としてはイマイチだったかもしれませんが、個々人のアウトプットが非常に高く、なんとか完成まで漕ぎ着けました。本当に感謝。
# 今思うこと
よく走りきったな、という気持ちです。マジで感謝。

グラフィック担当のPCが壊れてほぼ動けなかったり、効果音の調整時間がなく、最後の3時間くらいで効果音をつけてってて、想定選択音が判定音になったりと、なかなかハッカソンらしいカオスでした。楽しかった。

素材自体はかなりかっこよく用意できていただけに、企画面・プレイヤー体験の両方でまとめきれなかったのがとても悔しいです。

音ゲーは今後も継続して開発していきたい気持ちはありますが、こうした王道形式を落とし込むかはなんとも。やりたくはあるのだが、まだ模索中。。
