---
title: 株式会社Ozora
tags:
  - 一人アドベントカレンダー
private: true
updated_at: ''
id: ''
organization_url_name: null
slide: false
ignorePublish: false
---

今回は、2021年〜2025年春にかけて携わらせていただいた **Ozora** という会社での経験について語ろうと思います。  
この会社ではドローン撮影やシミュレーター開発などを行っており、私は主にドローンシミュレーターの開発を担当していました。

## 概要
### GlobeXplore
一言で言うと、ドローンシミュレーターです。  
[Cesium for Unity](https://cesium.com/learn/unity/) を利用し、世界中を自由に飛び回れます。

https://x.com/henohenon_8282/status/1669315641223045120

### GlobeXplore Pro
企業向けの Pro 版。  
気象設定やレンズ設定などが追加され、より本格的でかっこいい。

https://gxpro.app/

## こだわった点
このプロダクトは一見シンプルですが、設定項目が非常に多く、UIを舐めてはいけないと痛感しました（n敗）。

![無印](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/ozora-drone/muji.png)
![pro](https://raw.githubusercontent.com/henohenon/qiita/refs/heads/main/images/ozora-drone/pro.png)

また、ドローン用の特殊なコントローラーに対応するため、**hidapi** というライブラリを使用するなど、ギミック面もかなり作り込まれています。

https://zenn.dev/henohenon/articles/5e53f268e89f06

## 今思うこと
R3、UniTask、DI Container などの Unity 設計技術を、この開発を通して学びました。  
必死に試行錯誤しながら作っていた記憶がありますが、今の自分の Unity エンジニアリング力の半分以上は、この経験で培われたものだと思います。

本当にお世話になりました。

---

ということで **GlobeXplore** は Steam にて販売中です。  
Switch の Pro コントローラーでも動作します（実際にデバッグしていました）。  
もし興味がありましたら、ぜひ気軽にお試しください。

https://store.steampowered.com/app/2635620/GlobeXplore/
