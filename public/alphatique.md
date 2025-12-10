---
title: 株式会社Alphatique
tags:
  - 一人アドベントカレンダー
private: true
updated_at: '2025-12-10T23:38:06+09:00'
id: f7c6cc7e09fdd7811b90
organization_url_name: null
slide: false
ignorePublish: false
---
今回から、お世話になってる会社などシリーズが始まります。

その初回、株式会社Alphatique回です。今現在の私のWeb開発の知識・経験はほぼこの会社のおかげで成り立っています。また、ゲーム開発でないことを除けば、フルベットしたくなるような非常に魅惑の会社です。
# 概要
https://alphatique.co.jp/

この会社では現在、セラー管理くんというAmazon小売事業者向けのアプリを開発しています。
<iframe width="560" height="315" src="https://www.youtube.com/embed/ok-hxHhT7Fo?si=BiM558tNWyV7ck_3" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>

https://alphatique.co.jp/products/seller-kanrikun/

私が主にやっているのはapi調査、フロントの作成などです。バックエンドも一時期やってたのですが、ゲームにうつつを抜かしてたのと純粋に実力がなくて自然と最近フロントに追いやられてきました。数年以内にはAIに代替されそうである。
これは私のコミット数。春との落差がすごい。
![コミット数](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/alphatique/contribute.png)


# 具体的な働きエピソード
## SP-API
まずはapiから。AmazonってAPIの提供やってるんですね〜。なんとOpenApiもあります。

https://github.com/glue-systems/sp-api-open-api/blob/main/models/reports_2021-06-30.json

![ポストマン](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/alphatique/postman.png)

こんな感じで、めっちゃ模索をしていました。本当にね〜Amazonくんは癖が強くて。
必要なデータを日時で取得したいのですが、その一部のタイムアウトが15回でバーストの1分ごととかのapiを730(2年分)回叩く必要があり、、一通りのデータを取得するのに3時間とかかったり...OAuthの仕様に反していたり、reportTypeの一覧がなかったり。

前提としてこれだけ巨大なデータを提供していただけているのは本当にありがたい限りで足を向けて寝れません。が、まぁとんでもないカオスです。
今後とも仲良くしてください。
## フロントエンド
大きく作成したのはこの損益計算書のページです。計算周りは色々みてもらいながら作成したし、細かくレイアウトやバグフィックスは複数人の手が加わっていて、自分一人で作成したわけではないですが、全体の構造は大体自分が書きました（ちょっともう触れないぐらい巨大化してて今問題になってますが）。
https://help-center.seller-kanrikun.app/guides/finance/pl/
![イメージ](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/alphatique/image.png)

他にも細々とurlパラメータでのフィルターの保存を部分的に実装したり、表に特殊なスクロールを実装したり。今のアプリの基礎実装は全く私ではないのですが、なんだかんだ自分の息はかかってると思います。

# 今思うこと
全然年下の同僚の強強プログラマーにボコられ続ける日々なのですが、githubの使い方やプログラミングのより深い概念など、本当に勉強になる日々です。コミュニケーションも取りやすく、意思決定も納得でき、リファクタリングにも適切に取り組んでいます。すごすごプロダクト。

悪い点で言うと現在お金が発生しているわけではないこと、急にメール返信をお願いされたりすることですね。

まぁ要するにスタートアップ。

と言うことでAlphatiqueでは一緒に働いてくれるメンバーを！！募集しているわけではないのですが、
興味ある方などがいましたら[お問い合わせ](https://alphatique.co.jp/contact/)など送っていただければ喜びます。

そして、セラー管理くんを何卒よろしくお願いします。
