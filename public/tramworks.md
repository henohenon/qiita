---
title: 株式会社トラムワークス
tags:
  - 一人アドベントカレンダー
private: true
updated_at: '2025-12-11T19:07:11+09:00'
id: 05c68ee34238bd9f6f08
organization_url_name: null
slide: false
ignorePublish: false
---

今日はお仕事紹介シリーズその2です。

https://tramworks-inc.com/

https://tramcity.net/

函館の路面電車のシミュレーションゲームの一部開発を行わせてもらってます。超ニッチ〜〜〜。でも代表のサクラダさんを中心として、めちゃめちゃ熱量高く作られており、これまた非常に面白いプロダクトです。
# モデリング
## 建物
作中のマップに配置されている建物です。自分はこれのコミットが一番多いと思います。ポリゴン数は300~1800ほど。だいたい窓わくが多いとポリゴン数が爆発的に増えます。テクスチャで描ければ削減できるのですが、時間との兼ね合いでなかなか難しいところです。
![01](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/building01.png)
![02](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/building02.png)
![03](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/building03.png)
![05](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/building05.png)
![08](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/building08.png)
![09](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/building09.png)

## 3000形
最近追加された3000形のモデリングも自分が担当しました。うおーーーーかっちょよく実装してくださり感謝...
![main](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/main.png)
運転席は半分ぐらいは写真をお借りしていますが、もう半分、例えばこの辺のテクスチャは手書きです...！ウェザリングも手でやってます。
![handmade](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/handmade.png)
![handmade](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/handmade02.png)
あとは下の方も簡単にだけど書き込んでいたり...！実写のようなクオリティ、、とはいきませんが、可能な範囲で作り込みしてあります。
![under](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/under.png)
せっかくなので今ゲーム内で見れない、外装を剥がした姿や横からなど。車内も解像度高くテクスチャ貼ってあります。ちなみに納品時データのポリゴン数は7386でした。
※次の3枚は、納品時のデータのため一部実装とは異なる可能性があります。
![open-door](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/open-door.png)
![side](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/side.png)
![nakanuki](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/nakanuki.png)

# プログラミング
一部だけですが、お手伝いさせてもらっております。今回は現行の車の制御システムについて触れたいと思います。元々あったものを改修する形で、独自のNodePathを構築しました。
![nodes](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/tramcity/nodes.png)
停止要因の判定のためunityの物理を使用していますが、最低限負荷を下げられるようにターゲット計算を数フレーム毎に行うようにしたり、ObjectPoolを使用したりしています。いつかDOTS移行とかしてみたい。
# 今思うこと
締め切りに遅れたりしたときや、今回の記事の件でも優しく対応してくださり、本当にお世話になりっぱなしです。
> 本当に申し訳ないことに最近コミットがおろそかになりがちだったのですが、気を引き締めてまたコミットしていきたい〜

---

最後にTRAM CITYはSteamで好評発売中ですので、ぜひ興味のある方がいましたら、手に取っていただければ幸いです〜

https://store.steampowered.com/app/2614000/TRAMCITY_HAKODATE/

