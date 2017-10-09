using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App2
{

    class PhraseList
    {
        public ObservableCollection<DiaryItemField> WeatherLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> WhenLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> WhereLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> WhoLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> HowLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> WhatLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> DoLists { get; } = new ObservableCollection<DiaryItemField>();
        public ObservableCollection<DiaryItemField> FeelingLists { get; } = new ObservableCollection<DiaryItemField>();


        public PhraseList()
        {
            WeatherLists.Add(new DiaryItemField { ItmString = "晴れ", InitialIndex = 0 });
            WeatherLists.Add(new DiaryItemField { ItmString = "曇り", InitialIndex = 1 });
            WeatherLists.Add(new DiaryItemField { ItmString = "雨", InitialIndex = 2 });
            WeatherLists.Add(new DiaryItemField { ItmString = "かいせい", InitialIndex = 3 });
            WeatherLists.Add(new DiaryItemField { ItmString = "ゆき", InitialIndex = 4 });
            WeatherLists.Add(new DiaryItemField { ItmString = "もうふぶき", InitialIndex = 5 });
            WeatherLists.Add(new DiaryItemField { ItmString = "かみなり", InitialIndex = 6 });
            WeatherLists.Add(new DiaryItemField { ItmString = "晴れのち雨", InitialIndex = 7 });
            WeatherLists.Add(new DiaryItemField { ItmString = "ゲリラ豪雨", InitialIndex = 8 });
            WeatherLists.Add(new DiaryItemField { ItmString = "無し", InitialIndex = 9 });
            WeatherLists.Add(new DiaryItemField { ItmString = "晴れ時々曇り所により雨一時吹雪", InitialIndex = 10 });


            WhenLists.Add(new DiaryItemField { ItmString = "あさ、", InitialIndex = 0 });
            WhenLists.Add(new DiaryItemField { ItmString = "ひづけがかわるしゅんかん、", InitialIndex = 1 });
            WhenLists.Add(new DiaryItemField { ItmString = "ある日、", InitialIndex = 2 });
            WhenLists.Add(new DiaryItemField { ItmString = "まよなかに、", InitialIndex = 3 });
            WhenLists.Add(new DiaryItemField { ItmString = "きのう、", InitialIndex = 4 });
            WhenLists.Add(new DiaryItemField { ItmString = "ごぜん、", InitialIndex = 5 });
            WhenLists.Add(new DiaryItemField { ItmString = "１３～１６時に", InitialIndex = 6 });
            WhenLists.Add(new DiaryItemField { ItmString = "ゴールデンタイムに", InitialIndex = 7 });
            WhenLists.Add(new DiaryItemField { ItmString = "ゆうがた、", InitialIndex = 8 });
            WhenLists.Add(new DiaryItemField { ItmString = "へんなじかんに、", InitialIndex = 9 });
            WhenLists.Add(new DiaryItemField { ItmString = "本日未明、", InitialIndex = 10 });
            WhenLists.Add(new DiaryItemField { ItmString = "よる、", InitialIndex = 11 });

            WhoLists.Add(new DiaryItemField { ItmString = "じゃがいもみたいな人と", InitialIndex = 0 });
            WhoLists.Add(new DiaryItemField { ItmString = "ややこしい立場の人と", InitialIndex = 1 });
            WhoLists.Add(new DiaryItemField { ItmString = "先生と", InitialIndex = 2 });
            WhoLists.Add(new DiaryItemField { ItmString = "豆マニアと", InitialIndex = 3 });
            WhoLists.Add(new DiaryItemField { ItmString = "カウボーイのたいぐんが", InitialIndex = 4 });
            WhoLists.Add(new DiaryItemField { ItmString = "おとうさんと", InitialIndex = 5 });
            WhoLists.Add(new DiaryItemField { ItmString = "かせいじんと", InitialIndex = 6 });
            WhoLists.Add(new DiaryItemField { ItmString = "だれということもなく", InitialIndex = 7 });
            WhoLists.Add(new DiaryItemField { ItmString = "シャガールと", InitialIndex = 8 });
            WhoLists.Add(new DiaryItemField { ItmString = "きょにゅうあいどると", InitialIndex = 9 });
            WhoLists.Add(new DiaryItemField { ItmString = "しんはんにんと", InitialIndex = 10 });
            WhoLists.Add(new DiaryItemField { ItmString = "ひとりで", InitialIndex = 11 });
            WhoLists.Add(new DiaryItemField { ItmString = "バイトリーダーと", InitialIndex = 12 });
            WhoLists.Add(new DiaryItemField { ItmString = "ごにんたいほのプロと", InitialIndex = 13 });
            WhoLists.Add(new DiaryItemField { ItmString = "カレーのおうじさまと", InitialIndex = 14 });
            WhoLists.Add(new DiaryItemField { ItmString = "シチューの国のトマトボーイと", InitialIndex = 15 });
            WhoLists.Add(new DiaryItemField { ItmString = "にんじゃと", InitialIndex = 16 });
            WhoLists.Add(new DiaryItemField { ItmString = "ゆうしゃっぽいかっこうのおじさんと", InitialIndex = 17 });
            WhoLists.Add(new DiaryItemField { ItmString = "がんめんそうはくなおにいちゃんと", InitialIndex = 18 });
            WhoLists.Add(new DiaryItemField { ItmString = "「もうだめだ」がくちぐせのおじさんと", InitialIndex = 19 });
            WhoLists.Add(new DiaryItemField { ItmString = "道具にばかり頼る愚民達と", InitialIndex = 20 });

            WhereLists.Add(new DiaryItemField { ItmString = "リビングで", InitialIndex = 0 });
            WhereLists.Add(new DiaryItemField { ItmString = "屋根裏で", InitialIndex = 1 });
            WhereLists.Add(new DiaryItemField { ItmString = "ゴーストタウンで", InitialIndex = 2 });
            WhereLists.Add(new DiaryItemField { ItmString = "えきまえで", InitialIndex = 3 });
            WhereLists.Add(new DiaryItemField { ItmString = "アトリエで", InitialIndex = 4 });
            WhereLists.Add(new DiaryItemField { ItmString = "だがしやポポロで", InitialIndex = 5 });
            WhereLists.Add(new DiaryItemField { ItmString = "竹林で", InitialIndex = 6 });
            WhereLists.Add(new DiaryItemField { ItmString = "ブルジュハリファで", InitialIndex = 7 });
            WhereLists.Add(new DiaryItemField { ItmString = "かそうくうかんで", InitialIndex = 8 });
            WhereLists.Add(new DiaryItemField { ItmString = "ひみつきちで", InitialIndex = 9 });
            WhereLists.Add(new DiaryItemField { ItmString = "けんもんじょで", InitialIndex = 10 });
            WhereLists.Add(new DiaryItemField { ItmString = "プールで", InitialIndex = 11 });
            WhereLists.Add(new DiaryItemField { ItmString = "けんこうランドで", InitialIndex = 12 });
            WhereLists.Add(new DiaryItemField { ItmString = "WindowsXPかべがみのあのそうげんで", InitialIndex = 13 });
            WhereLists.Add(new DiaryItemField { ItmString = "おんせんで", InitialIndex = 14 });
            WhereLists.Add(new DiaryItemField { ItmString = "やきにくやで", InitialIndex = 15 });
            WhereLists.Add(new DiaryItemField { ItmString = "むじんとうで", InitialIndex = 16 });
            WhereLists.Add(new DiaryItemField { ItmString = "こうえんで", InitialIndex = 17 });
            WhereLists.Add(new DiaryItemField { ItmString = "さつがいげんばで", InitialIndex = 18 });
            WhereLists.Add(new DiaryItemField { ItmString = "でぱーとで", InitialIndex = 19 });
            WhereLists.Add(new DiaryItemField { ItmString = "かぶぬしそうかいで", InitialIndex = 20 });
            WhereLists.Add(new DiaryItemField { ItmString = "上野で", InitialIndex = 21 });
            WhereLists.Add(new DiaryItemField { ItmString = "けいむしょで", InitialIndex = 22 });
            WhereLists.Add(new DiaryItemField { ItmString = "がっこうで", InitialIndex = 23 });
            WhereLists.Add(new DiaryItemField { ItmString = "ボブ邸で", InitialIndex = 24 });

            HowLists.Add(new DiaryItemField { ItmString = "鉄の", InitialIndex = 0 });
            HowLists.Add(new DiaryItemField { ItmString = "ぐんじょう色の", InitialIndex = 1 });
            HowLists.Add(new DiaryItemField { ItmString = "たいりょうの", InitialIndex = 2 });
            HowLists.Add(new DiaryItemField { ItmString = "あいしゅうただよう", InitialIndex = 3 });
            HowLists.Add(new DiaryItemField { ItmString = "本格派の", InitialIndex = 4 });
            HowLists.Add(new DiaryItemField { ItmString = "つねにかいてんしている", InitialIndex = 5 });
            HowLists.Add(new DiaryItemField { ItmString = "甘いにおいの", InitialIndex = 6 });
            HowLists.Add(new DiaryItemField { ItmString = "せんぞだいだいの", InitialIndex = 7 });
            HowLists.Add(new DiaryItemField { ItmString = "おとうさんの", InitialIndex = 8 });
            HowLists.Add(new DiaryItemField { ItmString = "Ｔシャツみたいな", InitialIndex = 9 });
            HowLists.Add(new DiaryItemField { ItmString = "けむりがでている", InitialIndex = 10 });
            HowLists.Add(new DiaryItemField { ItmString = "ぺらぺらの", InitialIndex = 11 });
            HowLists.Add(new DiaryItemField { ItmString = "こおった", InitialIndex = 12 });
            HowLists.Add(new DiaryItemField { ItmString = "あつあつの", InitialIndex = 13 });
            HowLists.Add(new DiaryItemField { ItmString = "みたことのない", InitialIndex = 14 });
            HowLists.Add(new DiaryItemField { ItmString = "べとべとした", InitialIndex = 15 });
            HowLists.Add(new DiaryItemField { ItmString = "まっきいろの", InitialIndex = 16 });
            HowLists.Add(new DiaryItemField { ItmString = "ひかりかがやく", InitialIndex = 17 });
            HowLists.Add(new DiaryItemField { ItmString = "なまぐさい", InitialIndex = 18 });
            HowLists.Add(new DiaryItemField { ItmString = "けいしきじょうの", InitialIndex = 19 });
            HowLists.Add(new DiaryItemField { ItmString = "ブタみたいな", InitialIndex = 20 });
            HowLists.Add(new DiaryItemField { ItmString = "めざわりな", InitialIndex = 21 });
            HowLists.Add(new DiaryItemField { ItmString = "のびたりちぢんだりする", InitialIndex = 22 });
            HowLists.Add(new DiaryItemField { ItmString = "隙だらけの", InitialIndex = 23 });
            HowLists.Add(new DiaryItemField { ItmString = "はんぶんになった", InitialIndex = 24 });
            HowLists.Add(new DiaryItemField { ItmString = "こどもむけの", InitialIndex = 25 });

            WhatLists.Add(new DiaryItemField { ItmString = "じゃがいもを", InitialIndex = 0 });
            WhatLists.Add(new DiaryItemField { ItmString = "船を", InitialIndex = 1 });
            WhatLists.Add(new DiaryItemField { ItmString = "にほんにんぎょうを", InitialIndex = 2 });
            WhatLists.Add(new DiaryItemField { ItmString = "アーティファクトを", InitialIndex = 3 });
            WhatLists.Add(new DiaryItemField { ItmString = "ばくだんを", InitialIndex = 4 });
            WhatLists.Add(new DiaryItemField { ItmString = "おかあさんのへそくりを", InitialIndex = 5 });
            WhatLists.Add(new DiaryItemField { ItmString = "チョコレートを", InitialIndex = 6 });
            WhatLists.Add(new DiaryItemField { ItmString = "はんばーがーを", InitialIndex = 7 });
            WhatLists.Add(new DiaryItemField { ItmString = "えんぴつを", InitialIndex = 8 });
            WhatLists.Add(new DiaryItemField { ItmString = "てれびを", InitialIndex = 9 });
            WhatLists.Add(new DiaryItemField { ItmString = "りゅうせいぐんを", InitialIndex = 10 });
            WhatLists.Add(new DiaryItemField { ItmString = "ロボットを", InitialIndex = 11 });
            WhatLists.Add(new DiaryItemField { ItmString = "えほんを", InitialIndex = 12 });
            WhatLists.Add(new DiaryItemField { ItmString = "概念上の友人を", InitialIndex = 13 });
            WhatLists.Add(new DiaryItemField { ItmString = "けがにんを", InitialIndex = 14 });
            WhatLists.Add(new DiaryItemField { ItmString = "ふうぜんのともしびを", InitialIndex = 15 });
            WhatLists.Add(new DiaryItemField { ItmString = "あかいいろをしたきつねを", InitialIndex = 16 });
            WhatLists.Add(new DiaryItemField { ItmString = "みどりいろのたぬきを", InitialIndex = 17 });
            WhatLists.Add(new DiaryItemField { ItmString = "ブタを", InitialIndex = 18 });
            WhatLists.Add(new DiaryItemField { ItmString = "よごれを", InitialIndex = 19 });
            WhatLists.Add(new DiaryItemField { ItmString = "やくたたずを", InitialIndex = 20 });
            WhatLists.Add(new DiaryItemField { ItmString = "ぼうを", InitialIndex = 21 });
            WhatLists.Add(new DiaryItemField { ItmString = "なにかを", InitialIndex = 22 });
            WhatLists.Add(new DiaryItemField { ItmString = "きおくを", InitialIndex = 23 });
            WhatLists.Add(new DiaryItemField { ItmString = "ゾウを", InitialIndex = 24 });
            WhatLists.Add(new DiaryItemField { ItmString = "ちゃんぽんめんを", InitialIndex = 25 });
            WhatLists.Add(new DiaryItemField { ItmString = "ビーフカレーを", InitialIndex = 26 });
            WhatLists.Add(new DiaryItemField { ItmString = "しゃっきんを", InitialIndex = 27 });
            WhatLists.Add(new DiaryItemField { ItmString = "おたがいを", InitialIndex = 28 });
            WhatLists.Add(new DiaryItemField { ItmString = "勇気を", InitialIndex = 29 });
            WhatLists.Add(new DiaryItemField { ItmString = "ふやけた肉まんを", InitialIndex = 30 });
            WhatLists.Add(new DiaryItemField { ItmString = "それを", InitialIndex = 31 });

            DoLists.Add(new DiaryItemField { ItmString = "絞めました。", InitialIndex = 0 });
            DoLists.Add(new DiaryItemField { ItmString = "あぶら絵にしました", InitialIndex = 1 });
            DoLists.Add(new DiaryItemField { ItmString = "わさびじょうゆに漬けました", InitialIndex = 2 });
            DoLists.Add(new DiaryItemField { ItmString = "となりにおきました", InitialIndex = 3 });
            DoLists.Add(new DiaryItemField { ItmString = "絞りました。", InitialIndex = 4 });
            DoLists.Add(new DiaryItemField { ItmString = "とばしました。", InitialIndex = 5 });
            DoLists.Add(new DiaryItemField { ItmString = "瞬時に消しました。", InitialIndex = 6 });
            DoLists.Add(new DiaryItemField { ItmString = "見ました。", InitialIndex = 7 });
            DoLists.Add(new DiaryItemField { ItmString = "あらいました。", InitialIndex = 8 });
            DoLists.Add(new DiaryItemField { ItmString = "たべました。", InitialIndex = 9 });
            DoLists.Add(new DiaryItemField { ItmString = "とびこえました。", InitialIndex = 10 });
            DoLists.Add(new DiaryItemField { ItmString = "しらべました。", InitialIndex = 11 });
            DoLists.Add(new DiaryItemField { ItmString = "ふういんしました。", InitialIndex = 12 });
            DoLists.Add(new DiaryItemField { ItmString = "クレープ状にしました。", InitialIndex = 13 });
            DoLists.Add(new DiaryItemField { ItmString = "つくりました。", InitialIndex = 14 });
            DoLists.Add(new DiaryItemField { ItmString = "うめました。", InitialIndex = 15 });
            DoLists.Add(new DiaryItemField { ItmString = "わりました。", InitialIndex = 16 });
            DoLists.Add(new DiaryItemField { ItmString = "右にいどうしました。", InitialIndex = 17 });
            DoLists.Add(new DiaryItemField { ItmString = "粉末状にしました。", InitialIndex = 18 });
            DoLists.Add(new DiaryItemField { ItmString = "とおくから見ました。", InitialIndex = 19 });
            DoLists.Add(new DiaryItemField { ItmString = "にこみました。", InitialIndex = 20 });
            DoLists.Add(new DiaryItemField { ItmString = "ひっぱりました。", InitialIndex = 21 });
            DoLists.Add(new DiaryItemField { ItmString = "箱につめました。", InitialIndex = 22 });
            DoLists.Add(new DiaryItemField { ItmString = "ゆっくりねかせました。", InitialIndex = 23 });
            DoLists.Add(new DiaryItemField { ItmString = "無視しました。", InitialIndex = 24 });

            FeelingLists.Add(new DiaryItemField { ItmString = "じごくでした", InitialIndex = 0 });
            FeelingLists.Add(new DiaryItemField { ItmString = "さんぽういちりょうぞんでござる", InitialIndex = 1 });
            FeelingLists.Add(new DiaryItemField { ItmString = "まさにうぃんうぃんのかんけいです", InitialIndex = 2 });
            FeelingLists.Add(new DiaryItemField { ItmString = "ふにおちない", InitialIndex = 3 });
            FeelingLists.Add(new DiaryItemField { ItmString = "ただただ、時が解決するのを待つばかりです", InitialIndex = 4 });
            FeelingLists.Add(new DiaryItemField { ItmString = "たのしかったです", InitialIndex = 5 });
            FeelingLists.Add(new DiaryItemField { ItmString = "もうにどとやりたくないです", InitialIndex = 6 });
            FeelingLists.Add(new DiaryItemField { ItmString = "しゅぎょうがたりぬ", InitialIndex = 7 });
            FeelingLists.Add(new DiaryItemField { ItmString = "こういうのはやめたほうがいいとおもいました", InitialIndex = 8 });
            FeelingLists.Add(new DiaryItemField { ItmString = "あしたがたのしみです", InitialIndex = 9 });
            FeelingLists.Add(new DiaryItemField { ItmString = "さっぱりしました", InitialIndex = 10 });
            FeelingLists.Add(new DiaryItemField { ItmString = "おかあさんにおこられました", InitialIndex = 11 });
            FeelingLists.Add(new DiaryItemField { ItmString = "これがじんせいだなとおもいました", InitialIndex = 12 });
            FeelingLists.Add(new DiaryItemField { ItmString = "もっとつづけばいいのになあとおもいました", InitialIndex = 13 });
            FeelingLists.Add(new DiaryItemField { ItmString = "ずるいぞふとし君", InitialIndex = 14 });
            FeelingLists.Add(new DiaryItemField { ItmString = "あれはなんだったんだろう", InitialIndex = 15 });
            FeelingLists.Add(new DiaryItemField { ItmString = "ゆめかとおもいました", InitialIndex = 16 });
            FeelingLists.Add(new DiaryItemField { ItmString = "うそです", InitialIndex = 17 });
            FeelingLists.Add(new DiaryItemField { ItmString = "はやると思います", InitialIndex = 18 });
            FeelingLists.Add(new DiaryItemField { ItmString = "すごくつかれました", InitialIndex = 19 });
            FeelingLists.Add(new DiaryItemField { ItmString = "まわりがざわめいてました", InitialIndex = 20 });
            FeelingLists.Add(new DiaryItemField { ItmString = "大豆があれば大丈夫！", InitialIndex = 21 });
            FeelingLists.Add(new DiaryItemField { ItmString = "にがにがしい", InitialIndex = 22 });
            FeelingLists.Add(new DiaryItemField { ItmString = "ぜつぼうだ", InitialIndex = 23 });
            FeelingLists.Add(new DiaryItemField { ItmString = "これでワシの役目は終わりじゃ", InitialIndex = 24 });

        }

        public class DiaryItemField
        {
            public string ItmString { get; set; }
            public int InitialIndex { get; set; }
        }

        enum DiaryElementIndex
        {
            Weather = 1,
            When = 2,
            Where = 3,
            Who =4,
            How =5,
            What = 6,
            Do = 7,
            Feeling = 8

        }
    }
}
