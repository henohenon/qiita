---
title: ゲーム制作への回帰 ~MultiSweeper~
tags:
  - 一人アドベントカレンダー
  - Unity
private: false
updated_at: ''
id: null
organization_url_name: null
slide: false
ignorePublish: false
---
学校卒業以来、ゆるゆると何かを作ったり、ふわふわと仕事をしたり、のんびりとした生活をしていました。
今回はそんな生活・感覚を明確に変えたとあるゲーム制作の話。

https://unityroom.com/games/multi-sweeper

# 経緯
始まりは、作るっちゃん内部のゲーム制作をしてみようというイベントからでした。
このイベントは今思うとなかなか特殊で、3週間とかの期間で、週1でメンタリングがある。毎週課題が振られる。という感じでした。

メンツはプログラマー2人、デザイナー2人、自分の系5人。自分が一番ゲーム制作の経験値がありそうで、これキャリー枠か、なるほどとなりました。また、その時の自分はのほほんと生きていて、結構時間がありました。

自分が戦う環境があったわけなんですね。リーダーとして手を上げました
# 企画
二人でマインスイーパーをするゲームで、一人はヒントなしでFPS視点でマインスイーパーを解く人、もう一人は謎解きをしながら指示を出す。というゲームになってます。

企画書をチラ見せ。最初のオフラインのキックオフで、アイテムがあるマインスイーパーみたいなところまでは決まってましたが、それ以降はだいたい自分で詰めていった気がします。
![kikaku01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/kikaku01.png)
![kikaku02](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/kikaku02.png)

# 実装
## 謎解き
爆弾の記載されている3枚のマップがあり、いずれか1つが本物。安全で繋がってるマスは自動で開く、アイテムのマス・爆弾のマスは自動では開かない。
全マップ共通の安全な箇所とかを開けてって、正解のマップを当てて、あとは指示していくゲーム。
![maptest](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/maptest.gif)

## ゲームオーバー
ここの演出、めっちゃこだわっている。ポストエフェクト、物理、細かくちゃんと作ってる。半日ぐらいかけた。
![dead](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/dead.gif)

## アイテム
一定確率でアイテムが出現します。記号を指示側に伝えると効果がわかるというもの。

これはランダムに動き回っちゃうアイテム
![item](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/item.gif)

これは足が速くなるアイテム。一定以上取ると爆弾を避けられるように(調子に乗ってよく死ぬ)
![item2](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/item2.gif)

他にも前方一列空けるアイテムとか、周囲の爆弾の数字を出すアイテムとか。6種類前後は実装してあるはず。
(なお、同じアイコンの別アイテムがあるバグはあります)
## 旗
デフォルトで🚩のアイテムを持ってます。本家リスペクト。
![flag](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/multisweeper/flag.gif)
# 今思うこと
結構作り込みや完成度があると思うのです。自分がやった中では、比較的成功と言っていいのではないだろうか。
でもって、これを作っていた時、楽しかったのですよね。とても楽しかった。プレイヤーの反応を想像し思うがままにゲームを作る。終わる気のしない苦行を私は楽しんでいました。その時、俺はつくづくゲーム制作が好きなのだなぁと思い知らされました。

そして私は打って変わって、無限ゲームジャム男として半年ほどを過ごすこととなります。