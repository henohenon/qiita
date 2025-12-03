---
title: 動物タワー・ウォーズ ~Blenderの目覚め~
tags:
  - Blender
  - 一人アドベントカレンダー
private: false
updated_at: '2025-12-03T23:59:57+09:00'
id: 1b80528e5a5d66eb4d2d
organization_url_name: null
slide: false
ignorePublish: false
---

タータラッタータータラー
テンションが高いです。幸せな日々を送っております。謝謝。

今回は昔作っていた犬猫魚のタワーディフェンスゲームの話をします。ゲーム自体としては形になる前のプロト版ぐらいの完成度です。当初は熱量としてはアクションゲームと同じかなんなら勝てんやろと思って[前回の記事](//リンク)にまとめてしまうつもりでした。
しかし、フォルダを漁っていたら信じられないぐらいBlenderファイルが出てきて、非常に濃い内容だったので単体での記事化に至りました。やったね。
# towerdiffence3D(構造体、クラスでremake!)のコピー
もうしばらくはこのひどい名称が続きます。よろしくお願いします。

こんな感じのゆるい世界観で、猫と犬が魚を食べまくるという内容です。もうちょっと動いてたタイミングもあったはずなんだけどもう手元にない...gitが渇望されている。
![ゲーム画面](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/game.gif)

経緯としては、ダンジョンウォーフェアというゲームが好きすぎて作り始めました。

https://store.steampowered.com/app/355980/Dungeon_Warfare/

## (ダンジョンウォーフェア)
ほんとにこのゲーム好きでぇ。ダートでノックバックしながらグシャって潰すのが好きでぇ。うあーーーっていう悲鳴が好きでぇ。きるしーっていうコンボ音が好きでぇ、あの重厚なUI効果音が好きでぇ。デーモンの生まれるぱちって音が好きでぇ、soul harvesterっていう名前が天才でぇ、山がトラウマでぇ

これ以来タワーディフェンスが大好きになりました。

## その他
![フォルダの画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/files.png)

なんと、フォルダがすごくいい感じに分けられています！！！圧倒的進化！
そして、スクリプトが分割されている...!今までも分割されてはいたのですが、ほとんど1機能（ワープや消失など）だけを持つか、あるいは1つのクラスでほぼ全てを管理する形式でした。それが今回は、タワーや敵ユニットにクラスらしい役割を持たせた実装になっています。進化だな〜。

それはそうと、神クラスはちょこちょこあったり。あとそろそろ名前せめて全小文字はやめてほしい。
確か最適経路(車輪の再発明)とかマップのデータからの生成とかcdによる自動攻撃とかやってて、すごくゲームプログラミングっぽくなっている気がします。
# キャラクター紹介
こっからが本番です。前回将棋などでなんとなくBlenderで見た目をアップすることを覚えたへのへのんは、ここで個性を出し始めます。守破離でいう「破」が始まります。
## 猫
壁で連打してくれるタイプのやつです、2D絵に厚みをつけただけ感がありますね。手を振って、爪を飛ばします(今考えるとなぜ爪を飛ばせるのか)。

![🐈のgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat.gif)

![爪](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/tume.png)

これでもくっそ頑張っていた記憶があります。ここの縁のテクスチャとかね。将棋なんて10頂点だけどこれは1128頂点ですからね。桁が違います。
![猫のblender画像](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat-poly.png)


## 犬
次に、犬です。ほぼ同じ、と見せかけておもろ攻撃をします。
![犬のgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/dog.gif)

これを久々に見たとき天才かと思いました。これはアニメーション側はunityでつけてます。モデリング自体はほぼ変わってないはずですが、すごい好きです。

## ライオン
地面設置型です。立体感が増していますが、攻撃が雑で犬猫より努力度はおそらく低いです。地面設置型のために生まれた子。好きだけどね。
![ライオンのgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/lion.gif)

## 猫lv2
騎士になります。
![🐈lv2のgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat02.gif)

兜制作の思考過程が残っており面白いです。スクリプトも実はそうなんですが、バックアップポツポツ残してあるんですよね。この頃の俺にgitを教えてやってほしい。

![🐈lv2の途中01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat02-tmp01.png)
![🐈lv2の途中02](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat02-tmp02.png)
![🐈lv2の途中03](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat02-tmp03.png)
![🐈lv2の途中04](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat-tmp04.png)

ちなみに兜のヒンジというか付け根の部分の動きもエロいと思うのですがわかる人はいますか
![r18](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/hinge.gif)

ここら辺から歯車が何かおかしくなっているのですが、なんか招き猫がついています。
![招き猫](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/maneki.png)

こうです。こういうビックリドッキリメカ好きなんだよな〜
![招き猫発射](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/maneki-fire.png)
足の裏に肉球があったり、
![裏](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/maneki-low.png)
展開部分が理論上動くようになってたりします。
![ヒンジ](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/hinge.png)


剣も結構拘ってて、かなりいい感じです。この辺からマテリアルをたまに使っていますね。

![猫剣01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat-sword.png)
![猫剣02](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat-sword02.png)
![猫剣03](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat-sword03.png)
![猫剣04](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/cat-sword04.png)

ただしこの縮尺なので、タワーの方に使ってくれとは思います。

## 犬lv2
武士です。やっぱ猫よりこっちの方がぱっと見は可愛いなぁ。猫が実験体となり、犬が製品版って感じがします。
モーションもめっちゃいい。というかやはり犬が良すぎる。
![犬lv2のgif](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/dog02.gif)


## 刀
問題はこれです。これ。綺麗だな〜なんと犬よりもポリゴン数が多いです(なんで)
確か、当時、日本男児たるもの刀に手を抜くなどあってはならないみたいなことを思っていた気がします。その割には細かい構造にはなっておらず、調べが甘かった気もしますが。

![katana-split](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katnaa-split.png)


ただし魂を込めて打った刀です。美しいです。かっこいいです。

![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana01.png)
![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana02.png)
![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana03.png)


各所の装飾もちゃんと凝ってて
![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana-back.png)
![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana-front.png)
![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana-tuka.png)

銘も入れてあります。名は隠していくスタイル。
![katana01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/animal-tower-defence/katana-mei.png)

猫と同様に縮尺はおかしいですが、いい刀だと思います。

# 今思うこと
久々に色々みれて嬉しい。なんかだんだんちゃんと上達している感がありおもろいです。刀とかは拵えを変えたりもっとしっかりして、またどこかで日の目を浴びせたいですね〜。
完全に今回は間に合っておらず、あともうちょっと載せたいモデルがあるのですが...!一旦ここで公開です。これは素材自体はもうあるので、後日追記していきたいと思ってます。
