# Contra-1

Членови:
Трајче Клинчаров 163212 и Никола Станоев 163164

Идеата за апликацијата која ја направивме доаѓа од стара игра наречена Контра 1 или Contra 1 од 1987 година.     

Оригиналната игра : https://en.wikipedia.org/wiki/Contra_(video_game)

Линк од нашата игра (Gameplay): https://youtu.be/aNsyYwDzuiI

За разлика од старата игра оваа е поедноставна имплементација со одредени промени, како промени на 
непријателите кој доаѓаат начинот на кој се одвива играта и целта на самата игра.
Имавме мали проблеми со наоѓање на анимирани фигури или гифови при изгработка на па затоа изреживме повеќе слики од 
истите фигури со цел да изгледаат така наречено по реални.


Играта е создадена во 4 Windows Forms Форми.
Првата форма се состои од логото на играта како и избор или копче за започнување на играта


![alt text](https://github.com/klincarovt/Contra-1/blob/master/Contra1/Pictures/play.png)



Потоа доаѓа втората форма каде што играчот е информиран за контролите на оваа игра.


![alt text](https://github.com/klincarovt/Contra-1/blob/master/Contra1/Pictures/controls.png)



На третата форма играчот веќе почнува со игра.
Правила на оваа игра е преживување играчот контролира еден  војник којшто се брани од напаѓачки хеликоптер
со убивањето на своите противници играчот остварува одреден број поени.
Хеликоптерите се појавуваад на одредено време и напаѓаат.
Играта завршува кога играчот ке биде убиен.


![alt text](https://github.com/klincarovt/Contra-1/blob/master/Contra1/Pictures/gameplay.png)

![alt text](https://github.com/klincarovt/Contra-1/blob/master/Contra1/Pictures/gameplay%202.png)


Потоа доаѓа четвртата форма каде играчот ги има освоените поени и покрај тоа има опција за повторно да игра одностно го враќа кон форма 3.

![alt text](https://github.com/klincarovt/Contra-1/blob/master/Contra1/Pictures/over.png)


Во играта се користат стелките лево и десно за движење и стреката нагоре за погледнување на играчот нагоре односно негово свртување кон непријателите. 

Играчот има опција да скока со копчето space, со скокање може да се качи на еден од двата блока или ѕидови. Ѕидовите содржат код за колизија како на пример играчот може да се качи на нив да се заштити од непријателите и во исто време тој неможи да пука преку ѕидот.

За пукање играчот мора да го претисне копчето Z или З со претискање на копчето играчот се свртува нагоре и пука 3 проектили.
Проектилите се движат така што еден оди во средината а другите два е одалечуваат кон лево и десно. 

Непријатели на играчот се 3 хеликоптери кој се појавуваат на одредено време. Овие хеликоптери си имаат своја траекторија за движење по изминатиот пат тие се ресетираат на првобитната позиција и повторно се движат по истата траекторија. 

За појавувањето на хеликоптерите искористивме тајмер. Овој тајмер исто така служи за напаѓање на хеликоптерите, по одредено време секој од трите хеликоптери напаѓаат во различно време секој хеликоптер пука по 2 проектили. Овие проектили при контакт со блоковите исчезнуваат каде што играчот може да се заштити , но при контакт со играчот проектилите го убиваат играчот и завршува играта.


```
private void ResetPicture(PictureBox pb)
        {
            if (pb.Left >= screen.Width - pb.Width)
            {
                pb.Left = 1;


            }
        }

private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            if (Enemy1.Visible)
            {
                if (timer == 1)//random.Next(1, 2))
                {
                    EnemyShoot1.Top = Enemy1.Top + 30;
                    EnemyShoot1.Left = Enemy1.Left + 50;
                    EnemyShoot1.Visible = true;
                    EnemyShoot4.Top = Enemy1.Top + 30;
                    EnemyShoot4.Left = Enemy1.Left + 60;
                    EnemyShoot4.Visible = true;


                }

                ResetPicture(Enemy1);
                Enemy1.Left += 1;



            }
            if (Enemy2.Visible)
            {
                if (timer == 2) //random.Next(3, 4))
                {
                    EnemyShoot2.Top = Enemy2.Top + 30;
                    EnemyShoot2.Left = Enemy2.Left + 50;
                    EnemyShoot2.Visible = true;
                    EnemyShoot5.Top = Enemy2.Top + 30;
                    EnemyShoot5.Left = Enemy2.Left + 60;
                    EnemyShoot5.Visible = true;

                }
                ResetPicture(Enemy2);
                Enemy2.Left += 1;


            }
            if (Enemy3.Visible)
            {
                if (timer == 3)// random.Next(5, 6))
                {
                    EnemyShoot3.Top = Enemy3.Top + 30;
                    EnemyShoot3.Left = Enemy3.Left + 50;
                    EnemyShoot3.Visible = true;
                    EnemyShoot6.Top = Enemy3.Top + 30;
                    EnemyShoot6.Left = Enemy3.Left + 60;
                    EnemyShoot6.Visible = true;

                }


                ResetPicture(Enemy3);
                Enemy3.Left += 1;

            }


        }

        int timer;

private void EnemyShoot_Tick(object sender, EventArgs e)
{



            timer++;
            if (timer == 3)
            {

                if (Enemy1.Visible == false)
                {
                    Enemy1.Visible = true;
                }
                if (Enemy2.Visible == false)
                {
                    Enemy2.Visible = true;
                }
                if (Enemy3.Visible == false)
                {
                    Enemy3.Visible = true;
                }
                timer = 1;
            }
}
       
       ```
