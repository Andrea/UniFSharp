﻿namespace UniFSharp
open UnityEngine

type BuildVoice =
  ///「これで終わりっ！」
  | [<AliasName("univ1239.wav")>] BuildComplete = 0
  ///「あちゃー…ダメかぁ…」
  | [<AliasName("univ1243.wav")>] BuildError = 1

type ProgressVoice =
  ///「進捗どうですか？」a
  | [<AliasName("univ1197a.wav")>] ShinchokuA = 0
  ///「進捗どうですか？」b
  | [<AliasName("univ1197b.wav")>] ShinchokuB = 1
  ///「進捗どうですか？」c
  | [<AliasName("univ1197c.wav")>] ShinchokuC = 2

type CheerVoice = 
  ///「頑張ってる姿って素敵だよ」
  | [<AliasName("univ1194.wav")>]Ganbatteru = 0
  ///「（可愛らしく）ファイトぉっ！」	
  | [<AliasName("univ1022.wav")>] Fight = 1
  ///「おーえす、おーえす！　ゴーッ！」
  | [<AliasName("univ1023.wav")>]OsOsGo = 2

type LicenseVoice = 
  ///「このコンテンツはユニティちゃんライセンスで提供されています」
  | [<AliasName("univ1081.wav")>] LicenseContents = 0

type StartingVoice = 
  /// 「そんじゃ、始めるとしますか！」
  | [<AliasName("univ1003.wav")>] Hajimeru = 0

type ChoiceVoice = 
  ///「どれを選ぶ？」
  | [<AliasName("univ1109.wav")>] Dore = 0

type TimeSignalVoice =
  ///「日付が変わったよ！」	０時
  | [<AliasName("Hour\univ1268.wav")>] AM00 = 0
  ///「１時！明日の準備は大丈夫？」	１時
  | [<AliasName("Hour\univ1269.wav")>] AM01 = 1
  ///「２時だよ〜…わたしもう寝るね〜…おやふみ…」	２時
  | [<AliasName("Hour\univ1270.wav")>] AM02 = 2
  ///「（寝息+）ふぁんじ…」	３時
  | [<AliasName("Hour\univ1271.wav")>] AM03 = 3
  ///「（寝息+）ひょじー…」	４時
  | [<AliasName("Hour\univ1272.wav")>] AM04 = 4
  ///「（寝息+）ほじ…」	５時
  | [<AliasName("Hour\univ1273.wav")>] AM05 = 5
  ///「（寝息+）ほふじ…」	６時
  | [<AliasName("Hour\univ1274.wav")>] AM06 = 6
  ///「７時かぁ…。ふわ〜ぁ…。おはよ〜」	７時
  | [<AliasName("Hour\univ1275.wav")>] AM07 = 7
  ///「８時だね。そろそろエンジンかけなきゃ」	８時
  | [<AliasName("Hour\univ1276.wav")>] AM08 = 8
  ///「９時だよ！遅刻してない？大丈夫？」	９時
  | [<AliasName("Hour\univ1277.wav")>] AM09 = 9
  ///「１０時〜」	１０時
  | [<AliasName("Hour\univ1278.wav")>] AM10 = 10
  ///「１１時！もうすぐお昼！」	１１時
  | [<AliasName("Hour\univ1279.wav")>] AM11 = 11
  ///「お昼だよ〜！」	１２時
  | [<AliasName("Hour\univ1280.wav")>] PM12 = 12
  ///「１３時をお知らせしまーす」	１３時
  | [<AliasName("Hour\univ1281.wav")>] PM13 = 13
  ///「１４時だね。一番マッタリしちゃう時間…」	１４時
  | [<AliasName("Hour\univ1282.wav")>] PM14 = 14
  ///「１５時…。油断すると眠気が…」	１５時
  | [<AliasName("Hour\univ1283.wav")>] PM15 = 15
  ///「じゅうろく…へへ、もう食べられない…よ…」	１６時
  | [<AliasName("Hour\univ1284.wav")>] PM16 = 16
  ///「はっ！ 何時の間に１７時に！？」	１７時
  | [<AliasName("Hour\univ1285.wav")>] PM17 = 17
  ///「もう１８時か〜。そろそろ暗くなってくるね」	１８時
  | [<AliasName("Hour\univ1286.wav")>] PM18 = 18
  ///「１９時だよ。みんなテレビ見てる時間かな？」	１９時
  | [<AliasName("Hour\univ1287.wav")>] PM19 = 19
  ///「２０時！ お仕事してる人はそろそろ一区切りかな？」	２０時
  | [<AliasName("Hour\univ1288.wav")>] PM20 = 20
  ///「２１時〜。何か面白いテレビやってるかなぁ」	２１時
  | [<AliasName("Hour\univ1289.wav")>] PM21 = 21
  ///「（風呂音+鼻歌交じり）ふんふ〜ん♪ ２２時だよーん♪」	２２時
  | [<AliasName("Hour\univ1290.wav")>] PM22 = 22
  ///「ふい〜… あと一時間で今日も終わりだね〜」	２３時 
  | [<AliasName("Hour\univ1291.wav")>] PM23 = 23


type EventVoice = 
  ///「明けましておめでとうございます。今年も精一杯がんばりますので、よろしくお願い致します。 …えへへ、たまにはね♪(イラスト出す)」	１月１日用
  | [<AliasName("Event\univ1316.wav")>] ``元日`` = 0
  ///「今日は成人の日だって！ 成人式とはまた違うのよね。成人の日とか成人式って、いざ迎えると何かが変わるものなのかなぁ…？」	１月１５日用
  | [<AliasName("Event\univ1317.wav")>] ``成人の日`` = 1
  ///「ついに開戦の火蓋が斬って落とされた…。今日は節分ウォー。鬼という鬼を滅多斬りするデー…。あれ？ あ、そっか。滅多切りじゃなくて蜂の巣…ん？」	２月３日用
  | [<AliasName("Event\univ1318.wav")>] ``節分`` = 2
  ///「建国記念日だってさ！ この記念日って世界中何処に行ってもあるんだろうなぁ…。はっ！ ということは、建国が早い順に各国をめぐっていけばずっとお休み…。あ、今バカにしたでしょ！」	２月１１日用
  | [<AliasName("Event\univ1319.wav")>] ``建国記念の日`` = 3
  ///「バレンタインデーだね！ ふっふっふ。今のわたしにかかればチョコの自作くらい造作も無い。というわけで、はいっ！ どうぞ！(イラスト出す)」	２月１４日用
  | [<AliasName("Event\univ1320.wav")>] ``バレンタインデー`` = 4
  ///「今日は雛祭りだよー。雛祭り…あまり良い思い出が無い…。パパってばわたしに重たい服着せたと思ったらかわいいかわいいしか言わなくなるし…。あ、でも雛壇にある菱形のお餅みたいなのは大好き！」	３月３日用
  | [<AliasName("Event\univ1321.wav")>] ``ひな祭り`` = 5
  /// 「そわそわ。そわそわ。え？ な、何も？ 何でもないよ？」	３月１４日用
  | [<AliasName("Event\univ1322.wav")>] ``ホワイトデー`` = 6
  ///「ハールーっ！ 今日は春分の日だよ！ 」	３月１９日用
  | [<AliasName("Event\univ1323.wav")>] ``春分の日`` = 7
  ///「今日はトーコちゃんの誕生日だよ。あとでミサキチ達とパーティするんだ！」	４月１日用
  | [<AliasName("Event\univ1324.wav")>] ``トーコちゃんの誕生日`` = 8
  ///「今日はミサキチの誕生日！ こないだトーコちゃんをお祝いしたばかりだけど、パーティは何度やってもオッケーだもんね♪」	４月２１日用
  | [<AliasName("Event\univ1325.wav")>] ``ミサキチの誕生日`` = 9
  ///「なんと、今日は今月三回目の誕生パーティ。主役は茅野さんだよ。あんまり話す機会がないんだけど、あの人ってクールでかっこいいよね」	４月２２日用
  | [<AliasName("Event\univ1326.wav")>] ``茅野茉莉恵の誕生日`` = 10
  ///「今日は憲法記念日…。これって記念日なの？」	５月３日用
  | [<AliasName("Event\univ1327.wav")>] ``憲法記念日`` = 11
  ///ユニティちゃん「今日はみどりの日だって。改めて思うけど、コーゲンシティにはあんまり緑が無いんだよね。その分青が多いんだ。あおの日とか作っちゃえばいいのにね」	５月４日用
  | [<AliasName("Event\univ1328.wav")>] みどりの日 = 12
  ///「今日はこどもの日！ 昔からわくわくする日だったな〜！ え？ ううん、そわそわなんてしてないよ？ ちょっと、子供っぽいって何ー！？」	５月５日用
  | [<AliasName("Event\univ1329.wav")>] ``こどもの日`` = 13
  ///「今日はわたしのママの誕生日！ 学校から帰ったら家族みんなで一緒にご飯を作って、お祝いするんだ！」	６月２日用
  | [<AliasName("Event\univ1330.wav")>] ``大鳥こはくのママの誕生日`` = 14
  ///「今日は織姫と彦星の日だね。この街も川を挟んで三つの島に分かれてるから、川を挟んで恋愛してる人とかはきっと今日という日に想いを馳せ…え？ ううん、トーコちゃんが目をキラキラさせながら言ってたのを真似してみただけ。似てた？」	７月７日用
  | [<AliasName("Event\univ1331.wav")>] ``七夕`` = 15
  ///「海の日っ！ 海…。あれ、何か忘れてるような…。あーっ！ ミサキチと水着買いに行く約束してたんだった！！(イラスト出す)」	７月２０日用
  | [<AliasName("Event\univ1332.wav")>] ``海の日`` = 16
  ///「ハッピーバースデーわたしー！ 今日はわたしの誕生日！ ふははは。わたしだってちゃんと成長しているのだよ〜？ 日々のご褒美も含めて何かプレゼントくれちゃってもいいのだよ〜？」	８月１３日用
  | [<AliasName("Event\univ1333.wav")>] ``大鳥こはくの誕生日`` = 17
  ///「今日は敬老の日。この日になると急にパパがそわそわしだすのよね。まぁ、腰を踏んで肩を叩くくらいはしてあげるけど…」	９月１５日用
  | [<AliasName("Event\univ1334.wav")>] ``敬老の日`` = 18
  ///「味覚の秋！ 秋分の日だよ。 わたしの秋は味覚の秋なの！ でもこの街は本当に海しかないから、山に行こうものなら一大旅行なのよね。今年もスーパーで我慢するかぁ…」	９月２２日用
  | [<AliasName("Event\univ1335.wav")>] ``秋分の日`` = 19
  ///「今日はパパの誕生日。 なんだかんだで普段から拘りがあるから、お店で買えるプレゼントは喜んでくれないのよね…。え？ この紙？ 肩たたきけ…ううん、なんでもない！」	１０月８日用
  | [<AliasName("Event\univ1336.wav")>] 大鳥こはくのパパの誕生日 = 20
  ///「ついにきた、わたしの日！ 平たく言うと体育の日！ ふふふ、今日ははりきっちゃうぞー！(イラスト出す)」	１０月１０日用
  | [<AliasName("Event\univ1337.wav")>] ``体育の日`` = 21
  ///「ハァ…。文化の日のようです…。え？ テンション？ 低くない低くない。ハァ…。メイド喫茶とか…そんな安直な…ぶつぶつ。(イラスト出す)」	１１月３日用
  | [<AliasName("Event\univ1338.wav")>] ``文化の日`` = 22
  ///ユニティちゃん「今日は勤労感謝デー。敬老の日と同じくパパのそわそわっぷりが鼻につくデーです。よくよく考えたらまだおじいちゃん生きてるし、何で敬老の日にパパを労ってたのかしらわたし…！！ 振り替え休日で今日は何もしないって言ったら…しばらく寝込みそうね…。しかたないなぁ」	１１月２３日用
  | [<AliasName("Event\univ1339.wav")>] ``勤労感謝の日`` = 23
  ///「クリスマス・イブ！ いやぁ…世の中デコデコですなぁ…。 そっちは雪降ってる？ こっちは今は止んでるけど、先月からすこーしずつ降り始めてるから、シーズン中は期待できるかもね！ あ〜スノボ行きたいな〜！」	１２月２４日用
  | [<AliasName("Event\univ1340.wav")>] ``クリスマス・イブ`` = 24
  ///「メリークリスマース！ サンタこはくちゃんだぞー！ 良い子に開発を続けるみんなにプレゼントだ〜！ (イラスト出す)…うう、恥ずかしい。 いや違うんだよ〜！ これ、ミサキチが作ったんだけど、着ないと、えーと、大変なことするぞっていうから…。に、似合ってなくていいの！ ほらほら、サンタこはくちゃんはおしまい！ 七面鳥食べよ！ ね！」	１２月２５日用
  | [<AliasName("Event\univ1341.wav")>] ``クリスマス`` = 25
  ///「ほへぇ…(炬燵の中で気抜け) あ、年の瀬だね…。 やっほー。 みかん食べる？ ふは〜… ふぇっ 寝てない、寝てないよ。 今日はちゃんと起きてないと勿体無いもんね〜。 あ〜お年玉楽しみだな〜。 あ、おせんべい食べる？」	１２月３１日用
  | [<AliasName("Event\univ1342.wav")>] ``大晦日`` = 26
  ///「お誕生日おめでとう！！ こはくちゃんから素敵なプレゼントをあげちゃうぞ！(イラスト出す) えへへ、また一歩成長しちゃったね！ 今年も一緒にがんばろー！」	お誕生日用 
  | [<AliasName("Event\univ1343.wav")>] ``誕生日`` = 27