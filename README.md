# Contra-1

Членови:
Трајче Клинчаров 163212 и Никола Станоев 163164

Идеата за апликацијата која ја направивме доаѓа од стара игра наречена Контра 1 или Contra 1 од 1987 година.     
https://www.youtube.com/watch?v=F6iXwz4XGNQ&t=958s


За разлика од старата игра оваа е поедноставна имплементација со одредени промени, како промени на 
непријателите кој доаѓаат начинот на кој се одвива играта и целта на самата игра.
Имавме мали проблеми со наоѓање на анимирани фигури или гифови при изгработка на па затоа изреживме повеќе слики од 
истите фигури со цел да изгледаат така наречено по реални.


Играта е создадена во 4 Windows Forms Форми.
Првата форма се состои од логото на играта како и избор или копче за започнување на играта


![alt text](https://github.com/klincarovt/Contra-1/tree/master/Contra1/Pictures/play.png)



Потоа доаѓа втората форма каде што играчот е информиран за контролите на оваа игра.

![alt text](https://github.com/klincarovt/Contra-1/tree/master/Contra1/Pictures/controls.png)


На третата форма играчот веќе почнува со игра.
Правила на оваа игра е преживување играчот контролира еден  војник којшто се брани од напаѓачки хеликоптер
со убивањето на своите противници играчот остварува одреден број поени.
Хеликоптерите се појавуваад на одредено време и напаѓаат.
Играта заврува кога играчот ке биде убиен.


![alt text](https://github.com/klincarovt/Contra-1/tree/master/Contra1/Pictures/gameplay.png)


![alt text](https://github.com/klincarovt/Contra-1/tree/master/Contra1/Pictures/gameplay 2.png)

Потоа доаѓа четвртата форма каде играчот ги има освоените поени и покрај тоа има опција за повторно да игра одностно го враќа кон форма 3.

![alt text](https://github.com/klincarovt/Contra-1/tree/master/Contra1/Pictures/over.png)


Во играта се користат стелките лево и десно за движење и стреката нагоре за погледнување на играчот нагоре односно негово свртување кон непријателите. Играчот има опција да скока со копчето space, со скокање може да се качи на еден од двата блока или ѕидови. Ѕидовите содржат код за колизија како на пример играчот може да се качи на нив да се заштити од непријателите и во исто време тој неможи да пука преку ѕидот. За пукање играчот мора да го претисне копчето Z или З со претискање на копчето играчот се свртува нагоре и пука 3 проектили. Проектилите се движат така што еден оди во средината а другите два е одалечуваат кон лево и десно. Непријатели на играчот се 3 хеликоптери кој се појавуваат на одредено време. Овие хеликоптери си имаат своја траекторија за движење по изминатиот пат тие се ресетираат на првобитната позиција и повторно се движат по истата траекторија. 
За појавувањето на хеликоптерите искористивме тајмер. Овој тајмер исто така служи за напаѓање на хеликоптерите, по одредено време секој од трите хеликоптери напаѓаат во различно време секој хеликоптер пука по 2 проектили. Овие проектили при контакт со блоковите исчезнуваат каде што играчот може да се заштити , но при контакт со играчот проектилите го убиваат играчот и завршува играта. На крајот се појавува екран кој вели играта заврши го покажува скорот или простигнатите поени и овозможува опција за играње пак.
