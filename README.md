# これは何？
ゆとシートからココフォリア用のコマデータを作成するツールです

#  使い方
SW2.5YutoKomaBuilder.exeを起動して、テキストボックスにゆとシートのキャラシURLを入れてボタンを押すとクリップボードにコマ情報がコピーされます（デフォルトの値はギハードのURL）

#  ゆとシートの標準出力と何が違う？
* チャットパレットで定義している"//xxx=yyy"のような変数が、数値の場合はステータス項目に、文字列の場合はパラメータ項目に出力されるようになっています。
* セッション中にチャット欄から補正とかいじれて便利…かも。
* 移動力＝イニシアティブをやってくれます。
* キャラクターメモには種族・種族特徴・PL名が出力されます
* アプリケーションを閉じたときのURLをファイルに保存するので、2回目以降はボタンを押すだけでコマを作成できます。

#  フリー枠について
剣の恩寵など、卓によってあったりなかったりするが画面上で参照したい値を設定できるように空欄の枠をつけています。
ココフォリアでは8個まで画面上で確認できるため、初期設定だとHP/MP/防護点の3つにフリー枠を5つ加えています。お好みで調整してください
