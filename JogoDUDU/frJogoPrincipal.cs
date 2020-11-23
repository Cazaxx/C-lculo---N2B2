using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace JogoDUDU
{

    public partial class frJogoPrincipal : Form
    {
        public Skin imagensJogador, imagensBala, imagensInimigo;
        public PictureBox picBala = new PictureBox();
        Boolean glitchOk;
        object alinhaProcesso = new object();
        Thread jogo;
        Boolean fechaJogo;
        List<PictureBox> adicionaMapa = new List<PictureBox>();
        public static string tempoTotal; //Salva o tempo total da fase

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        Stopwatch tempoDecorrido = new Stopwatch();
        

        Boolean jogoPausado = false, gameOver;
        public frJogoPrincipal()
        {
            InitializeComponent();
            EscolheMapa();
            GlobalConfig.EscolheDificuldade();
            fechaJogo = false;
            glitchOk = false;
            GlobalConfig.score = 0;
            CapturaSkinsSelecionadas();
            tempoDecorrido.Start();
            timerTempoTotal.Start();           

            foreach (Control x in Controls)
            {
                if ((string)x.Tag == "inimigoCima" || (string)x.Tag == "inimigoDireita" || (string)x.Tag == "inimigoBaixo" || (string)x.Tag == "inimigoEsquerda" || (string)x.Tag == "key")
                {
                    adicionaMapa.Add((PictureBox)x);
                    IniciaInimigo((PictureBox)x);
                }

            }
            foreach (PictureBox aux in adicionaMapa)
            {

                aux.Parent = picMapa;
                aux.SizeMode = PictureBoxSizeMode.StretchImage;
                aux.BackColor = Color.Transparent;

            }


            PadraoDesligado();
            AtualizaPosicaoJogador();
            PadraoLigado();


            picJogador.Parent = picMapa;
            picJogador.Image = imagensJogador.imgDireita;
        }



        public void EscolheMapa()
        {
            if (GlobalConfig.mapa == "deserto")
                MapaDeserto();
            else if (GlobalConfig.mapa == "floresta")
                MapaFloresta();
            else if (GlobalConfig.mapa == "cidade")
                MapaCidade();
        }

        public void MapaFloresta()
        {

            // Padrões do mapa
            GlobalConfig.qntChavesAtuais = 0;
            GlobalConfig.qntChaves = 3;



            Jogador.Reset(new Point(22, 261), new Point(-64, 178));
            picJogador.Location = new Point(22, 261);
            picArea.Location = new Point(-64, 178);
            picMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            picMapa.Image = Properties.Resources.MapaFloresta;
            picPorta.Location = new Point(774, 453);
            if (!GlobalConfig.muteLigado)
            {
                player.URL = "WelcomeToTheJungle.mp3";
                player.controls.play();
            }

            #region Mapa Floresta --> NÃO MEXA AQUI
            // Mapa
            PictureBox pictureBox1 = new PictureBox();
            PictureBox pictureBox2 = new PictureBox();
            PictureBox pictureBox3 = new PictureBox();
            PictureBox pictureBox4 = new PictureBox();
            PictureBox pictureBox5 = new PictureBox();
            PictureBox pictureBox6 = new PictureBox();
            PictureBox pictureBox7 = new PictureBox();
            PictureBox pictureBox8 = new PictureBox();
            PictureBox pictureBox9 = new PictureBox();
            PictureBox pictureBox10 = new PictureBox();
            PictureBox pictureBox11 = new PictureBox();
            PictureBox pictureBox12 = new PictureBox();
            PictureBox pictureBox13 = new PictureBox();
            PictureBox pictureBox14 = new PictureBox();
            PictureBox pictureBox15 = new PictureBox();
            PictureBox pictureBox16 = new PictureBox();
            PictureBox pictureBox17 = new PictureBox();
            PictureBox pictureBox18 = new PictureBox();
            PictureBox pictureBox19 = new PictureBox();
            PictureBox pictureBox20 = new PictureBox();
            PictureBox pictureBox21 = new PictureBox();
            PictureBox pictureBox22 = new PictureBox();
            PictureBox pictureBox23 = new PictureBox();
            PictureBox pictureBox24 = new PictureBox();
            PictureBox pictureBox25 = new PictureBox();
            PictureBox pictureBox26 = new PictureBox();
            PictureBox pictureBox27 = new PictureBox();
            PictureBox pictureBox28 = new PictureBox();
            PictureBox pictureBox29 = new PictureBox();
            PictureBox pictureBox30 = new PictureBox();
            PictureBox pictureBox31 = new PictureBox();
            PictureBox pictureBox32 = new PictureBox();
            PictureBox pictureBox33 = new PictureBox();
            PictureBox pictureBox34 = new PictureBox();
            PictureBox pictureBox35 = new PictureBox();
            PictureBox pictureBox36 = new PictureBox();
            PictureBox pictureBox37 = new PictureBox();
            PictureBox pictureBox38 = new PictureBox();
            PictureBox pictureBox39 = new PictureBox();
            PictureBox pictureBox40 = new PictureBox();
            PictureBox pictureBox41 = new PictureBox();
            PictureBox pictureBox42 = new PictureBox();
            PictureBox pictureBox43 = new PictureBox();
            PictureBox pictureBox44 = new PictureBox();
            PictureBox pictureBox45 = new PictureBox();
            PictureBox pictureBox46 = new PictureBox();
            PictureBox pictureBox47 = new PictureBox();
            PictureBox pictureBox48 = new PictureBox();
            PictureBox pictureBox49 = new PictureBox();
            PictureBox pictureBox50 = new PictureBox();
            PictureBox pictureBox51 = new PictureBox();
            PictureBox pictureBox52 = new PictureBox();
            PictureBox pictureBox53 = new PictureBox();
            PictureBox pictureBox54 = new PictureBox();
            PictureBox pictureBox55 = new PictureBox();
            PictureBox pictureBox56 = new PictureBox();
            PictureBox pictureBox57 = new PictureBox();
            PictureBox pictureBox58 = new PictureBox();
            PictureBox pictureBox59 = new PictureBox();
            PictureBox pictureBox60 = new PictureBox();
            PictureBox pictureBox61 = new PictureBox();
            PictureBox pictureBox62 = new PictureBox();
            PictureBox pictureBox63 = new PictureBox();
            PictureBox pictureBox64 = new PictureBox();
            PictureBox pictureBox65 = new PictureBox();
            PictureBox pictureBox66 = new PictureBox();
            PictureBox pictureBox67 = new PictureBox();
            PictureBox pictureBox68 = new PictureBox();
            PictureBox pictureBox69 = new PictureBox();
            PictureBox pictureBox70 = new PictureBox();
            PictureBox pictureBox71 = new PictureBox();
            PictureBox pictureBox72 = new PictureBox();
            PictureBox pictureBox73 = new PictureBox();
            PictureBox pictureBox74 = new PictureBox();
            PictureBox pictureBox75 = new PictureBox();
            PictureBox pictureBox76 = new PictureBox();
            PictureBox pictureBox77 = new PictureBox();
            PictureBox pictureBox78 = new PictureBox();
            PictureBox pictureBox79 = new PictureBox();
            PictureBox pictureBox80 = new PictureBox();
            PictureBox pictureBox82 = new PictureBox();
            PictureBox pictureBox83 = new PictureBox();
            PictureBox pictureBox84 = new PictureBox();
            PictureBox pictureBox81 = new PictureBox();
            PictureBox pictureBox85 = new PictureBox();
            PictureBox pictureBox86 = new PictureBox();
            PictureBox pictureBox87 = new PictureBox();
            PictureBox pictureBox88 = new PictureBox();


            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 52);
            pictureBox1.TabIndex = 135;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "wall";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(51, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 52);
            pictureBox2.TabIndex = 136;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(102, 191);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 52);
            pictureBox3.TabIndex = 137;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(0, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 52);
            pictureBox4.TabIndex = 138;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(0, 54);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 52);
            pictureBox5.TabIndex = 139;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wall";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 52);
            pictureBox6.TabIndex = 140;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "wall";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(51, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 52);
            pictureBox7.TabIndex = 141;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "wall";
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(102, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 52);
            pictureBox8.TabIndex = 142;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "wall";
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(203, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(51, 52);
            pictureBox9.TabIndex = 143;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "wall";
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(155, 96);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(51, 52);
            pictureBox10.TabIndex = 144;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "wall";
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(206, 96);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(51, 52);
            pictureBox11.TabIndex = 145;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "wall";
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(256, 96);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(51, 52);
            pictureBox12.TabIndex = 146;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "wall";
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(206, 145);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(51, 52);
            pictureBox13.TabIndex = 147;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "wall";
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(256, 145);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(51, 52);
            pictureBox14.TabIndex = 148;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "wall";
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(256, 197);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(51, 52);
            pictureBox15.TabIndex = 149;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "wall";
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(206, 197);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(51, 52);
            pictureBox16.TabIndex = 150;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "wall";
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(206, 249);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(51, 52);
            pictureBox17.TabIndex = 151;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "wall";
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(206, 301);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(51, 52);
            pictureBox18.TabIndex = 152;
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "wall";
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(206, 353);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(51, 52);
            pictureBox19.TabIndex = 153;
            pictureBox19.TabStop = false;
            pictureBox19.Tag = "wall";
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(206, 405);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(51, 52);
            pictureBox20.TabIndex = 154;
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "wall";
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(155, 353);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(51, 52);
            pictureBox21.TabIndex = 155;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "wall";
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(104, 353);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(51, 52);
            pictureBox22.TabIndex = 156;
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "wall";
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(104, 301);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(51, 52);
            pictureBox23.TabIndex = 157;
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "wall";
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(53, 301);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(51, 52);
            pictureBox24.TabIndex = 158;
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "wall";
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(1, 301);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(51, 52);
            pictureBox25.TabIndex = 159;
            pictureBox25.TabStop = false;
            pictureBox25.Tag = "wall";
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(1, 449);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(51, 52);
            pictureBox26.TabIndex = 160;
            pictureBox26.TabStop = false;
            pictureBox26.Tag = "wall";
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(48, 449);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(51, 52);
            pictureBox27.TabIndex = 161;
            pictureBox27.TabStop = false;
            pictureBox27.Tag = "wall";
            // 
            // pictureBox28
            // 
            pictureBox28.Location = new Point(309, 389);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(51, 52);
            pictureBox28.TabIndex = 162;
            pictureBox28.TabStop = false;
            pictureBox28.Tag = "wall";
            // 
            // pictureBox29
            // 
            pictureBox29.Location = new Point(309, 342);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(51, 52);
            pictureBox29.TabIndex = 163;
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "wall";
            // 
            // pictureBox30
            // 
            pictureBox30.Location = new Point(309, 284);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(51, 64);
            pictureBox30.TabIndex = 164;
            pictureBox30.TabStop = false;
            pictureBox30.Tag = "wall";
            // 
            // pictureBox31
            // 
            pictureBox31.Location = new Point(360, 336);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(51, 52);
            pictureBox31.TabIndex = 165;
            pictureBox31.TabStop = false;
            pictureBox31.Tag = "wall";
            // 
            // pictureBox32
            // 
            pictureBox32.Location = new Point(360, 284);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(51, 52);
            pictureBox32.TabIndex = 166;
            pictureBox32.TabStop = false;
            pictureBox32.Tag = "wall";
            // 
            // pictureBox33
            // 
            pictureBox33.Location = new Point(360, 233);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(51, 52);
            pictureBox33.TabIndex = 167;
            pictureBox33.TabStop = false;
            pictureBox33.Tag = "wall";
            // 
            // pictureBox34
            // 
            pictureBox34.Location = new Point(360, 181);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(51, 52);
            pictureBox34.TabIndex = 168;
            pictureBox34.TabStop = false;
            pictureBox34.Tag = "wall";
            // 
            // pictureBox35
            // 
            pictureBox35.Location = new Point(360, 134);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(51, 52);
            pictureBox35.TabIndex = 169;
            pictureBox35.TabStop = false;
            pictureBox35.Tag = "wall";
            // 
            // pictureBox36
            // 
            pictureBox36.Location = new Point(360, 102);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(51, 35);
            pictureBox36.TabIndex = 170;
            pictureBox36.TabStop = false;
            pictureBox36.Tag = "wall";
            // 
            // pictureBox37
            // 
            pictureBox37.Location = new Point(360, 52);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(51, 52);
            pictureBox37.TabIndex = 171;
            pictureBox37.TabStop = false;
            pictureBox37.Tag = "wall";
            // 
            // pictureBox38
            // 
            pictureBox38.Location = new Point(308, 0);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(51, 52);
            pictureBox38.TabIndex = 172;
            pictureBox38.TabStop = false;
            pictureBox38.Tag = "wall";
            // 
            // pictureBox39
            // 
            pictureBox39.Location = new Point(359, 0);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(51, 52);
            pictureBox39.TabIndex = 173;
            pictureBox39.TabStop = false;
            pictureBox39.Tag = "wall";
            // 
            // pictureBox40
            // 
            pictureBox40.Location = new Point(410, 0);
            pictureBox40.Name = "pictureBox40";
            pictureBox40.Size = new Size(51, 52);
            pictureBox40.TabIndex = 174;
            pictureBox40.TabStop = false;
            pictureBox40.Tag = "wall";
            // 
            // pictureBox41
            // 
            pictureBox41.Location = new Point(461, 0);
            pictureBox41.Name = "pictureBox41";
            pictureBox41.Size = new Size(51, 52);
            pictureBox41.TabIndex = 175;
            pictureBox41.TabStop = false;
            pictureBox41.Tag = "wall";
            // 
            // pictureBox42
            // 
            pictureBox42.Location = new Point(512, 0);
            pictureBox42.Name = "pictureBox42";
            pictureBox42.Size = new Size(51, 52);
            pictureBox42.TabIndex = 176;
            pictureBox42.TabStop = false;
            pictureBox42.Tag = "wall";
            // 
            // pictureBox43
            // 
            pictureBox43.Location = new Point(563, 0);
            pictureBox43.Name = "pictureBox43";
            pictureBox43.Size = new Size(51, 52);
            pictureBox43.TabIndex = 177;
            pictureBox43.TabStop = false;
            pictureBox43.Tag = "wall";
            // 
            // pictureBox44
            // 
            pictureBox44.Location = new Point(614, 0);
            pictureBox44.Name = "pictureBox44";
            pictureBox44.Size = new Size(51, 52);
            pictureBox44.TabIndex = 178;
            pictureBox44.TabStop = false;
            pictureBox44.Tag = "wall";
            // 
            // pictureBox45
            // 
            pictureBox45.Location = new Point(665, 0);
            pictureBox45.Name = "pictureBox45";
            pictureBox45.Size = new Size(68, 52);
            pictureBox45.TabIndex = 179;
            pictureBox45.TabStop = false;
            pictureBox45.Tag = "wall";
            // 
            // pictureBox46
            // 
            pictureBox46.Location = new Point(732, 0);
            pictureBox46.Name = "pictureBox46";
            pictureBox46.Size = new Size(51, 52);
            pictureBox46.TabIndex = 180;
            pictureBox46.TabStop = false;
            pictureBox46.Tag = "wall";
            // 
            // pictureBox47
            // 
            pictureBox47.Location = new Point(733, 52);
            pictureBox47.Name = "pictureBox47";
            pictureBox47.Size = new Size(51, 52);
            pictureBox47.TabIndex = 181;
            pictureBox47.TabStop = false;
            pictureBox47.Tag = "wall";
            // 
            // pictureBox48
            // 
            pictureBox48.Location = new Point(733, 104);
            pictureBox48.Name = "pictureBox48";
            pictureBox48.Size = new Size(51, 52);
            pictureBox48.TabIndex = 182;
            pictureBox48.TabStop = false;
            pictureBox48.Tag = "wall";
            // 
            // pictureBox49
            // 
            pictureBox49.Location = new Point(733, 156);
            pictureBox49.Name = "pictureBox49";
            pictureBox49.Size = new Size(51, 52);
            pictureBox49.TabIndex = 183;
            pictureBox49.TabStop = false;
            pictureBox49.Tag = "wall";
            // 
            // pictureBox50
            // 
            pictureBox50.Location = new Point(733, 208);
            pictureBox50.Name = "pictureBox50";
            pictureBox50.Size = new Size(51, 52);
            pictureBox50.TabIndex = 184;
            pictureBox50.TabStop = false;
            pictureBox50.Tag = "wall";
            // 
            // pictureBox51
            // 
            pictureBox51.Location = new Point(733, 260);
            pictureBox51.Name = "pictureBox51";
            pictureBox51.Size = new Size(51, 52);
            pictureBox51.TabIndex = 185;
            pictureBox51.TabStop = false;
            pictureBox51.Tag = "wall";
            // 
            // pictureBox52
            // 
            pictureBox52.Location = new Point(733, 312);
            pictureBox52.Name = "pictureBox52";
            pictureBox52.Size = new Size(51, 52);
            pictureBox52.TabIndex = 186;
            pictureBox52.TabStop = false;
            pictureBox52.Tag = "wall";
            // 
            // pictureBox53
            // 
            pictureBox53.Location = new Point(733, 401);
            pictureBox53.Name = "pictureBox53";
            pictureBox53.Size = new Size(51, 52);
            pictureBox53.TabIndex = 187;
            pictureBox53.TabStop = false;
            pictureBox53.Tag = "wall";
            // 
            // pictureBox54
            // 
            pictureBox54.Location = new Point(585, 301);
            pictureBox54.Name = "pictureBox54";
            pictureBox54.Size = new Size(51, 52);
            pictureBox54.TabIndex = 188;
            pictureBox54.TabStop = false;
            pictureBox54.Tag = "wall";
            // 
            // pictureBox55
            // 
            pictureBox55.Location = new Point(682, 401);
            pictureBox55.Name = "pictureBox55";
            pictureBox55.Size = new Size(51, 52);
            pictureBox55.TabIndex = 189;
            pictureBox55.TabStop = false;
            pictureBox55.Tag = "wall";
            // 
            // pictureBox56
            // 
            pictureBox56.Location = new Point(631, 401);
            pictureBox56.Name = "pictureBox56";
            pictureBox56.Size = new Size(51, 52);
            pictureBox56.TabIndex = 190;
            pictureBox56.TabStop = false;
            pictureBox56.Tag = "wall";
            // 
            // pictureBox57
            // 
            pictureBox57.Location = new Point(585, 401);
            pictureBox57.Name = "pictureBox57";
            pictureBox57.Size = new Size(51, 52);
            pictureBox57.TabIndex = 191;
            pictureBox57.TabStop = false;
            pictureBox57.Tag = "wall";
            // 
            // pictureBox58
            // 
            pictureBox58.Location = new Point(585, 353);
            pictureBox58.Name = "pictureBox58";
            pictureBox58.Size = new Size(51, 52);
            pictureBox58.TabIndex = 192;
            pictureBox58.TabStop = false;
            pictureBox58.Tag = "wall";
            // 
            // pictureBox59
            // 
            pictureBox59.Location = new Point(733, 353);
            pictureBox59.Name = "pictureBox59";
            pictureBox59.Size = new Size(51, 52);
            pictureBox59.TabIndex = 193;
            pictureBox59.TabStop = false;
            pictureBox59.Tag = "wall";
            // 
            // pictureBox60
            // 
            pictureBox60.Location = new Point(423, 453);
            pictureBox60.Name = "pictureBox60";
            pictureBox60.Size = new Size(51, 52);
            pictureBox60.TabIndex = 194;
            pictureBox60.TabStop = false;
            pictureBox60.Tag = "wall";
            // 
            // pictureBox61
            // 
            pictureBox61.Location = new Point(473, 453);
            pictureBox61.Name = "pictureBox61";
            pictureBox61.Size = new Size(51, 52);
            pictureBox61.TabIndex = 195;
            pictureBox61.TabStop = false;
            pictureBox61.Tag = "wall";
            // 
            // pictureBox62
            // 
            pictureBox62.Location = new Point(473, 401);
            pictureBox62.Name = "pictureBox62";
            pictureBox62.Size = new Size(51, 52);
            pictureBox62.TabIndex = 196;
            pictureBox62.TabStop = false;
            pictureBox62.Tag = "wall";
            // 
            // pictureBox63
            // 
            pictureBox63.Location = new Point(473, 296);
            pictureBox63.Name = "pictureBox63";
            pictureBox63.Size = new Size(51, 52);
            pictureBox63.TabIndex = 197;
            pictureBox63.TabStop = false;
            pictureBox63.Tag = "wall";
            // 
            // pictureBox64
            // 
            pictureBox64.Location = new Point(473, 349);
            pictureBox64.Name = "pictureBox64";
            pictureBox64.Size = new Size(51, 52);
            pictureBox64.TabIndex = 198;
            pictureBox64.TabStop = false;
            pictureBox64.Tag = "wall";
            // 
            // pictureBox65
            // 
            pictureBox65.Location = new Point(473, 244);
            pictureBox65.Name = "pictureBox65";
            pictureBox65.Size = new Size(51, 52);
            pictureBox65.TabIndex = 199;
            pictureBox65.TabStop = false;
            pictureBox65.Tag = "wall";
            // 
            // pictureBox66
            // 
            pictureBox66.Location = new Point(473, 192);
            pictureBox66.Name = "pictureBox66";
            pictureBox66.Size = new Size(51, 52);
            pictureBox66.TabIndex = 200;
            pictureBox66.TabStop = false;
            pictureBox66.Tag = "wall";
            // 
            // pictureBox67
            // 
            pictureBox67.Location = new Point(473, 145);
            pictureBox67.Name = "pictureBox67";
            pictureBox67.Size = new Size(51, 52);
            pictureBox67.TabIndex = 201;
            pictureBox67.TabStop = false;
            pictureBox67.Tag = "wall";
            // 
            // pictureBox68
            // 
            pictureBox68.Location = new Point(473, 104);
            pictureBox68.Name = "pictureBox68";
            pictureBox68.Size = new Size(51, 44);
            pictureBox68.TabIndex = 202;
            pictureBox68.TabStop = false;
            pictureBox68.Tag = "wall";
            // 
            // pictureBox69
            // 
            pictureBox69.Location = new Point(524, 156);
            pictureBox69.Name = "pictureBox69";
            pictureBox69.Size = new Size(63, 63);
            pictureBox69.TabIndex = 203;
            pictureBox69.TabStop = false;
            pictureBox69.Tag = "wall";
            // 
            // pictureBox70
            // 
            pictureBox70.Location = new Point(585, 156);
            pictureBox70.Name = "pictureBox70";
            pictureBox70.Size = new Size(51, 52);
            pictureBox70.TabIndex = 204;
            pictureBox70.TabStop = false;
            pictureBox70.Tag = "wall";
            // 
            // pictureBox71
            // 
            pictureBox71.Location = new Point(585, 208);
            pictureBox71.Name = "pictureBox71";
            pictureBox71.Size = new Size(51, 52);
            pictureBox71.TabIndex = 205;
            pictureBox71.TabStop = false;
            pictureBox71.Tag = "wall";
            // 
            // pictureBox72
            // 
            pictureBox72.Location = new Point(636, 156);
            pictureBox72.Name = "pictureBox72";
            pictureBox72.Size = new Size(51, 52);
            pictureBox72.TabIndex = 206;
            pictureBox72.TabStop = false;
            pictureBox72.Tag = "wall";
            // 
            // pictureBox73
            // 
            pictureBox73.Location = new Point(585, 104);
            pictureBox73.Name = "pictureBox73";
            pictureBox73.Size = new Size(51, 52);
            pictureBox73.TabIndex = 207;
            pictureBox73.TabStop = false;
            pictureBox73.Tag = "wall";
            // 
            // pictureBox74
            // 
            pictureBox74.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox74.Location = new Point(689, 364);
            pictureBox74.Name = "pictureBox74";
            pictureBox74.Size = new Size(38, 24);
            pictureBox74.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox74.TabIndex = 208;
            pictureBox74.TabStop = false;
            pictureBox74.Tag = "key";
            // 
            // pictureBox75
            // 
            pictureBox75.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox75.Location = new Point(8, 162);
            pictureBox75.Name = "pictureBox75";
            pictureBox75.Size = new Size(38, 24);
            pictureBox75.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox75.TabIndex = 209;
            pictureBox75.TabStop = false;
            pictureBox75.Tag = "key";
            // 
            // pictureBox76
            // 
            pictureBox76.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox76.Location = new Point(8, 417);
            pictureBox76.Name = "pictureBox76";
            pictureBox76.Size = new Size(38, 24);
            pictureBox76.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox76.TabIndex = 210;
            pictureBox76.TabStop = false;
            pictureBox76.Tag = "key";
            // 
            // pictureBox77
            // 
            pictureBox77.Location = new Point(641, 272);
            pictureBox77.Name = "pictureBox77";
            pictureBox77.Size = new Size(24, 24);
            pictureBox77.TabIndex = 211;
            pictureBox77.TabStop = false;
            pictureBox77.Tag = "inimigoEsquerda";
            // 
            // pictureBox78
            // 
            pictureBox78.Location = new Point(299, 255);
            pictureBox78.Name = "pictureBox78";
            pictureBox78.Size = new Size(24, 24);
            pictureBox78.TabIndex = 212;
            pictureBox78.TabStop = false;
            pictureBox78.Tag = "inimigoDireita";
            // 
            // pictureBox79
            // 
            pictureBox79.Location = new Point(155, 417);
            pictureBox79.Name = "pictureBox79";
            pictureBox79.Size = new Size(24, 24);
            pictureBox79.TabIndex = 213;
            pictureBox79.TabStop = false;
            pictureBox79.Tag = "inimigoEsquerda";
            // 
            // pictureBox80
            // 
            pictureBox80.Location = new Point(12, 364);
            pictureBox80.Name = "pictureBox80";
            pictureBox80.Size = new Size(24, 24);
            pictureBox80.TabIndex = 214;
            pictureBox80.TabStop = false;
            pictureBox80.Tag = "inimigoCima";
            // 
            // pictureBox82
            // 
            pictureBox82.Location = new Point(698, 249);
            pictureBox82.Name = "pictureBox82";
            pictureBox82.Size = new Size(24, 24);
            pictureBox82.TabIndex = 216;
            pictureBox82.TabStop = false;
            pictureBox82.Tag = "inimigoCima";
            // 
            // pictureBox83
            // 
            pictureBox83.Location = new Point(437, 261);
            pictureBox83.Name = "pictureBox83";
            pictureBox83.Size = new Size(24, 24);
            pictureBox83.TabIndex = 217;
            pictureBox83.TabStop = false;
            pictureBox83.Tag = "inimigoCima";
            // 
            // pictureBox84
            // 
            pictureBox84.Location = new Point(318, 465);
            pictureBox84.Name = "pictureBox84";
            pictureBox84.Size = new Size(24, 24);
            pictureBox84.TabIndex = 218;
            pictureBox84.TabStop = false;
            pictureBox84.Tag = "inimigoEsquerda";
            // 
            // pictureBox81
            // 
            pictureBox81.Location = new Point(539, 68);
            pictureBox81.Name = "pictureBox81";
            pictureBox81.Size = new Size(24, 24);
            pictureBox81.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox81.TabIndex = 219;
            pictureBox81.TabStop = false;
            pictureBox81.Tag = "inimigoEsquerda";
            // 
            // pictureBox85
            // 
            pictureBox85.Location = new Point(-23, 502);
            pictureBox85.Name = "pictureBox85";
            pictureBox85.Size = new Size(871, 68);
            pictureBox85.TabIndex = 220;
            pictureBox85.TabStop = false;
            pictureBox85.Tag = "wall";
            // 
            // pictureBox86
            // 
            pictureBox86.Location = new Point(-25, -72);
            pictureBox86.Name = "pictureBox86";
            pictureBox86.Size = new Size(871, 68);
            pictureBox86.TabIndex = 221;
            pictureBox86.TabStop = false;
            pictureBox86.Tag = "wall";
            // 
            // pictureBox87
            // 
            pictureBox87.Location = new Point(785, -41);
            pictureBox87.Name = "pictureBox87";
            pictureBox87.Size = new Size(73, 587);
            pictureBox87.TabIndex = 222;
            pictureBox87.TabStop = false;
            pictureBox87.Tag = "wall";
            // 
            // pictureBox88
            // 
            pictureBox88.Location = new Point(-96, -16);
            pictureBox88.Name = "pictureBox88";
            pictureBox88.Size = new Size(95, 580);
            pictureBox88.TabIndex = 223;
            pictureBox88.TabStop = false;
            pictureBox88.Tag = "wall";

            Controls.Add(pictureBox88);
            Controls.Add(pictureBox87);
            Controls.Add(pictureBox86);
            Controls.Add(pictureBox85);
            Controls.Add(pictureBox81);
            Controls.Add(pictureBox84);
            Controls.Add(pictureBox83);
            Controls.Add(pictureBox82);
            Controls.Add(pictureBox80);
            Controls.Add(pictureBox79);
            Controls.Add(pictureBox78);
            Controls.Add(pictureBox77);
            Controls.Add(pictureBox76);
            Controls.Add(pictureBox75);
            Controls.Add(pictureBox74);
            Controls.Add(pictureBox56);
            Controls.Add(pictureBox57);
            Controls.Add(pictureBox55);
            Controls.Add(pictureBox53);
            Controls.Add(pictureBox47);
            Controls.Add(pictureBox48);
            Controls.Add(pictureBox49);
            Controls.Add(pictureBox50);
            Controls.Add(pictureBox51);
            Controls.Add(pictureBox52);
            Controls.Add(pictureBox59);
            Controls.Add(pictureBox58);
            Controls.Add(pictureBox54);
            Controls.Add(pictureBox71);
            Controls.Add(pictureBox70);
            Controls.Add(pictureBox73);
            Controls.Add(pictureBox72);
            Controls.Add(pictureBox69);
            Controls.Add(pictureBox66);
            Controls.Add(pictureBox67);
            Controls.Add(pictureBox68);
            Controls.Add(pictureBox63);
            Controls.Add(pictureBox64);
            Controls.Add(pictureBox62);
            Controls.Add(pictureBox61);
            Controls.Add(pictureBox60);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox33);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox35);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox37);
            Controls.Add(pictureBox39);
            Controls.Add(pictureBox38);
            Controls.Add(pictureBox40);
            Controls.Add(pictureBox41);
            Controls.Add(pictureBox42);
            Controls.Add(pictureBox43);
            Controls.Add(pictureBox44);
            Controls.Add(pictureBox45);
            Controls.Add(pictureBox46);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox65);

            #endregion Mapa
        }

        public void MapaDeserto()
        {
            // Padrões do mapa
            GlobalConfig.qntChavesAtuais = 0;
            GlobalConfig.qntChaves = 2;
            Jogador.Reset(new Point(0, 473), new Point(-84, 399));
            picPorta.Location = new Point(777, 135);
            picArea.Location = new Point(-84, 399);
            picMapa.Image = Properties.Resources.MapaDeserto1;
            picMapa.SizeMode = PictureBoxSizeMode.Normal;
            picJogador.Location = new Point(0, 473);
            if (!GlobalConfig.muteLigado)
            {
                player.URL = "MetalSlug.mp3";
            }

            #region Mapa Deserto --> NÃO MEXA AQUI
            PictureBox pictureBox98 = new PictureBox();
            PictureBox pictureBox97 = new PictureBox();
            PictureBox pictureBox96 = new PictureBox();
            PictureBox pictureBox95 = new PictureBox();
            PictureBox pictureBox94 = new PictureBox();
            PictureBox pictureBox93 = new PictureBox();
            PictureBox pictureBox92 = new PictureBox();
            PictureBox pictureBox91 = new PictureBox();
            PictureBox pictureBox34 = new PictureBox();
            PictureBox pictureBox36 = new PictureBox();
            PictureBox pictureBox33 = new PictureBox();
            PictureBox pictureBox32 = new PictureBox();
            PictureBox pictureBox31 = new PictureBox();
            PictureBox pictureBox30 = new PictureBox();
            PictureBox pictureBox29 = new PictureBox();
            PictureBox pictureBox51 = new PictureBox();
            PictureBox pictureBox52 = new PictureBox();
            PictureBox pictureBox50 = new PictureBox();
            PictureBox pictureBox7 = new PictureBox();
            PictureBox pictureBox49 = new PictureBox();
            PictureBox pictureBox8 = new PictureBox();
            PictureBox pictureBox48 = new PictureBox();
            PictureBox pictureBox6 = new PictureBox();
            PictureBox pictureBox47 = new PictureBox();
            PictureBox pictureBox46 = new PictureBox();
            PictureBox pictureBox45 = new PictureBox();
            PictureBox pictureBox5 = new PictureBox();
            PictureBox pictureBox44 = new PictureBox();
            PictureBox pictureBox43 = new PictureBox();
            PictureBox pictureBox42 = new PictureBox();
            PictureBox pictureBox41 = new PictureBox();
            PictureBox pictureBox4 = new PictureBox();
            PictureBox pictureBox17 = new PictureBox();
            PictureBox pictureBox90 = new PictureBox();
            PictureBox pictureBox18 = new PictureBox();
            PictureBox pictureBox89 = new PictureBox();
            PictureBox pictureBox88 = new PictureBox();
            PictureBox pictureBox19 = new PictureBox();
            PictureBox pictureBox87 = new PictureBox();
            PictureBox pictureBox86 = new PictureBox();
            PictureBox pictureBox85 = new PictureBox();
            PictureBox pictureBox84 = new PictureBox();
            PictureBox pictureBox16 = new PictureBox();
            PictureBox pictureBox83 = new PictureBox();
            PictureBox pictureBox82 = new PictureBox();
            PictureBox pictureBox14 = new PictureBox();
            PictureBox pictureBox81 = new PictureBox();
            PictureBox pictureBox80 = new PictureBox();
            PictureBox pictureBox21 = new PictureBox();
            PictureBox pictureBox79 = new PictureBox();
            PictureBox pictureBox78 = new PictureBox();
            PictureBox pictureBox25 = new PictureBox();
            PictureBox pictureBox77 = new PictureBox();
            PictureBox pictureBox76 = new PictureBox();
            PictureBox pictureBox75 = new PictureBox();
            PictureBox pictureBox74 = new PictureBox();
            PictureBox pictureBox20 = new PictureBox();
            PictureBox pictureBox73 = new PictureBox();
            PictureBox pictureBox24 = new PictureBox();
            PictureBox pictureBox72 = new PictureBox();
            PictureBox pictureBox71 = new PictureBox();
            PictureBox pictureBox70 = new PictureBox();
            PictureBox pictureBox15 = new PictureBox();
            PictureBox pictureBox28 = new PictureBox();
            PictureBox pictureBox69 = new PictureBox();
            PictureBox pictureBox68 = new PictureBox();
            PictureBox pictureBox67 = new PictureBox();
            PictureBox pictureBox26 = new PictureBox();
            PictureBox pictureBox23 = new PictureBox();
            PictureBox pictureBox66 = new PictureBox();
            PictureBox pictureBox22 = new PictureBox();
            PictureBox pictureBox65 = new PictureBox();
            PictureBox pictureBox64 = new PictureBox();
            PictureBox pictureBox61 = new PictureBox();
            PictureBox pictureBox60 = new PictureBox();
            PictureBox pictureBox59 = new PictureBox();
            PictureBox pictureBox12 = new PictureBox();
            PictureBox pictureBox58 = new PictureBox();
            PictureBox pictureBox57 = new PictureBox();
            PictureBox pictureBox11 = new PictureBox();
            PictureBox pictureBox56 = new PictureBox();
            PictureBox pictureBox55 = new PictureBox();
            PictureBox pictureBox10 = new PictureBox();
            PictureBox pictureBox54 = new PictureBox();
            PictureBox pictureBox53 = new PictureBox();
            PictureBox pictureBox9 = new PictureBox();
            PictureBox pictureBox40 = new PictureBox();
            PictureBox pictureBox39 = new PictureBox();
            PictureBox pictureBox38 = new PictureBox();
            PictureBox pictureBox37 = new PictureBox();
            PictureBox pictureBox2 = new PictureBox();
            PictureBox pictureBox3 = new PictureBox();
            PictureBox pictureBox27 = new PictureBox();
            PictureBox pictureBox63 = new PictureBox();
            PictureBox pictureBox62 = new PictureBox();
            PictureBox pictureBox13 = new PictureBox();
            PictureBox pictureBox1 = new PictureBox();
            PictureBox pictureBox35 = new PictureBox();

            // 
            // pictureBox98
            // 
            pictureBox98.BackColor = SystemColors.ActiveCaptionText;
            pictureBox98.Location = new Point(138, 326);
            pictureBox98.Name = "pictureBox98";
            pictureBox98.Size = new Size(24, 24);
            pictureBox98.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox98.TabIndex = 130;
            pictureBox98.TabStop = false;
            pictureBox98.Tag = "inimigoCima";
            // 
            // pictureBox97
            // 
            pictureBox97.BackColor = SystemColors.ActiveCaptionText;
            pictureBox97.Location = new Point(96, 279);
            pictureBox97.Name = "pictureBox97";
            pictureBox97.Size = new Size(24, 24);
            pictureBox97.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox97.TabIndex = 129;
            pictureBox97.TabStop = false;
            pictureBox97.Tag = "inimigoDireita";
            // 
            // pictureBox96
            // 
            pictureBox96.BackColor = SystemColors.ActiveCaptionText;
            pictureBox96.Location = new Point(512, 389);
            pictureBox96.Name = "pictureBox96";
            pictureBox96.Size = new Size(24, 24);
            pictureBox96.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox96.TabIndex = 128;
            pictureBox96.TabStop = false;
            pictureBox96.Tag = "inimigoCima";
            // 
            // pictureBox95
            // 
            pictureBox95.BackColor = SystemColors.ActiveCaptionText;
            pictureBox95.Location = new Point(569, 376);
            pictureBox95.Name = "pictureBox95";
            pictureBox95.Size = new Size(24, 24);
            pictureBox95.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox95.TabIndex = 127;
            pictureBox95.TabStop = false;
            pictureBox95.Tag = "inimigoDireita";
            // 
            // pictureBox94
            // 
            pictureBox94.BackColor = SystemColors.ActiveCaptionText;
            pictureBox94.Location = new Point(587, 464);
            pictureBox94.Name = "pictureBox94";
            pictureBox94.Size = new Size(24, 24);
            pictureBox94.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox94.TabIndex = 126;
            pictureBox94.TabStop = false;
            pictureBox94.Tag = "inimigoDireita";
            // 
            // pictureBox93
            // 
            pictureBox93.BackColor = SystemColors.ActiveCaptionText;
            pictureBox93.Location = new Point(457, 464);
            pictureBox93.Name = "pictureBox93";
            pictureBox93.Size = new Size(24, 24);
            pictureBox93.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox93.TabIndex = 125;
            pictureBox93.TabStop = false;
            pictureBox93.Tag = "inimigoEsquerda";
            // 
            // pictureBox92
            // 
            pictureBox92.BackColor = SystemColors.ActiveCaptionText;
            pictureBox92.Location = new Point(642, 281);
            pictureBox92.Name = "pictureBox92";
            pictureBox92.Size = new Size(24, 24);
            pictureBox92.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox92.TabIndex = 124;
            pictureBox92.TabStop = false;
            pictureBox92.Tag = "inimigoDireita";
            // 
            // pictureBox91
            // 
            pictureBox91.Location = new Point(788, -19);
            pictureBox91.Name = "pictureBox91";
            pictureBox91.Size = new Size(123, 548);
            pictureBox91.TabIndex = 123;
            pictureBox91.TabStop = false;
            pictureBox91.Tag = "wall";
            // 
            // pictureBox34
            // 
            pictureBox34.Location = new Point(0, 505);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(784, 60);
            pictureBox34.TabIndex = 121;
            pictureBox34.TabStop = false;
            pictureBox34.Tag = "wall";
            // 
            // pictureBox36
            // 
            pictureBox36.Location = new Point(-68, -20);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(66, 540);
            pictureBox36.TabIndex = 37;
            pictureBox36.TabStop = false;
            pictureBox36.Tag = "wall";
            // 
            // pictureBox33
            // 
            pictureBox33.Location = new Point(0, -55);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(784, 53);
            pictureBox33.TabIndex = 34;
            pictureBox33.TabStop = false;
            pictureBox33.Tag = "wall";
            // 
            // pictureBox32
            // 
            pictureBox32.BackColor = SystemColors.ActiveCaptionText;
            pictureBox32.Location = new Point(436, 281);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(24, 24);
            pictureBox32.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox32.TabIndex = 33;
            pictureBox32.TabStop = false;
            pictureBox32.Tag = "inimigoEsquerda";
            // 
            // pictureBox31
            // 
            pictureBox31.BackColor = SystemColors.ActiveCaptionText;
            pictureBox31.Location = new Point(365, 104);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(24, 24);
            pictureBox31.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox31.TabIndex = 32;
            pictureBox31.TabStop = false;
            pictureBox31.Tag = "inimigoDireita";
            // 
            // pictureBox30
            // 
            pictureBox30.BackColor = SystemColors.ActiveCaptionText;
            pictureBox30.Location = new Point(118, 187);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(24, 24);
            pictureBox30.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox30.TabIndex = 31;
            pictureBox30.TabStop = false;
            pictureBox30.Tag = "inimigoEsquerda";
            // 
            // pictureBox29
            // 
            pictureBox29.BackColor = SystemColors.ActiveCaptionText;
            pictureBox29.Location = new Point(423, 195);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(24, 24);
            pictureBox29.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox29.TabIndex = 30;
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "inimigoDireita";
            // 
            // pictureBox51
            // 
            pictureBox51.Location = new Point(44, 361);
            pictureBox51.Name = "pictureBox51";
            pictureBox51.Size = new Size(48, 48);
            pictureBox51.TabIndex = 60;
            pictureBox51.TabStop = false;
            pictureBox51.Tag = "wall";
            // 
            // pictureBox52
            // 
            pictureBox52.Location = new Point(0, 361);
            pictureBox52.Name = "pictureBox52";
            pictureBox52.Size = new Size(48, 48);
            pictureBox52.TabIndex = 59;
            pictureBox52.TabStop = false;
            pictureBox52.Tag = "wall";
            // 
            // pictureBox50
            // 
            pictureBox50.Location = new Point(44, 316);
            pictureBox50.Name = "pictureBox50";
            pictureBox50.Size = new Size(48, 48);
            pictureBox50.TabIndex = 57;
            pictureBox50.TabStop = false;
            pictureBox50.Tag = "wall";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(0, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(48, 48);
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "wall";
            // 
            // pictureBox49
            // 
            pictureBox49.Location = new Point(90, 362);
            pictureBox49.Name = "pictureBox49";
            pictureBox49.Size = new Size(47, 47);
            pictureBox49.TabIndex = 55;
            pictureBox49.TabStop = false;
            pictureBox49.Tag = "wall";
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(137, 362);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 47);
            pictureBox8.TabIndex = 54;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "wall";
            // 
            // pictureBox48
            // 
            pictureBox48.Location = new Point(182, 361);
            pictureBox48.Name = "pictureBox48";
            pictureBox48.Size = new Size(46, 48);
            pictureBox48.TabIndex = 53;
            pictureBox48.TabStop = false;
            pictureBox48.Tag = "wall";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(183, 315);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 48);
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "wall";
            // 
            // pictureBox47
            // 
            pictureBox47.Location = new Point(183, 267);
            pictureBox47.Name = "pictureBox47";
            pictureBox47.Size = new Size(45, 48);
            pictureBox47.TabIndex = 51;
            pictureBox47.TabStop = false;
            pictureBox47.Tag = "wall";
            // 
            // pictureBox46
            // 
            pictureBox46.Location = new Point(182, 220);
            pictureBox46.Name = "pictureBox46";
            pictureBox46.Size = new Size(46, 48);
            pictureBox46.TabIndex = 50;
            pictureBox46.TabStop = false;
            pictureBox46.Tag = "wall";
            // 
            // pictureBox45
            // 
            pictureBox45.Location = new Point(137, 220);
            pictureBox45.Name = "pictureBox45";
            pictureBox45.Size = new Size(48, 48);
            pictureBox45.TabIndex = 49;
            pictureBox45.TabStop = false;
            pictureBox45.Tag = "wall";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(90, 220);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 48);
            pictureBox5.TabIndex = 48;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wall";
            // 
            // pictureBox44
            // 
            pictureBox44.Location = new Point(184, 134);
            pictureBox44.Name = "pictureBox44";
            pictureBox44.Size = new Size(48, 48);
            pictureBox44.TabIndex = 47;
            pictureBox44.TabStop = false;
            pictureBox44.Tag = "wall";
            // 
            // pictureBox43
            // 
            pictureBox43.Location = new Point(137, 134);
            pictureBox43.Name = "pictureBox43";
            pictureBox43.Size = new Size(48, 48);
            pictureBox43.TabIndex = 46;
            pictureBox43.TabStop = false;
            pictureBox43.Tag = "wall";
            // 
            // pictureBox42
            // 
            pictureBox42.Location = new Point(90, 134);
            pictureBox42.Name = "pictureBox42";
            pictureBox42.Size = new Size(48, 48);
            pictureBox42.TabIndex = 45;
            pictureBox42.TabStop = false;
            pictureBox42.Tag = "wall";
            // 
            // pictureBox41
            // 
            pictureBox41.Location = new Point(44, 134);
            pictureBox41.Name = "pictureBox41";
            pictureBox41.Size = new Size(48, 48);
            pictureBox41.TabIndex = 44;
            pictureBox41.TabStop = false;
            pictureBox41.Tag = "wall";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(0, 134);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "wall";
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(275, 45);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(48, 48);
            pictureBox17.TabIndex = 118;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "wall";
            // 
            // pictureBox90
            // 
            pictureBox90.Location = new Point(275, 0);
            pictureBox90.Name = "pictureBox90";
            pictureBox90.Size = new Size(48, 48);
            pictureBox90.TabIndex = 117;
            pictureBox90.TabStop = false;
            pictureBox90.Tag = "wall";
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(366, 45);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(48, 48);
            pictureBox18.TabIndex = 116;
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "wall";
            // 
            // pictureBox89
            // 
            pictureBox89.Location = new Point(459, 0);
            pictureBox89.Name = "pictureBox89";
            pictureBox89.Size = new Size(48, 48);
            pictureBox89.TabIndex = 115;
            pictureBox89.TabStop = false;
            pictureBox89.Tag = "wall";
            // 
            // pictureBox88
            // 
            pictureBox88.Location = new Point(459, 45);
            pictureBox88.Name = "pictureBox88";
            pictureBox88.Size = new Size(48, 48);
            pictureBox88.TabIndex = 114;
            pictureBox88.TabStop = false;
            pictureBox88.Tag = "wall";
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(459, 89);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(48, 48);
            pictureBox19.TabIndex = 113;
            pictureBox19.TabStop = false;
            pictureBox19.Tag = "wall";
            // 
            // pictureBox87
            // 
            pictureBox87.Location = new Point(459, 135);
            pictureBox87.Name = "pictureBox87";
            pictureBox87.Size = new Size(48, 46);
            pictureBox87.TabIndex = 112;
            pictureBox87.TabStop = false;
            pictureBox87.Tag = "wall";
            // 
            // pictureBox86
            // 
            pictureBox86.Location = new Point(412, 135);
            pictureBox86.Name = "pictureBox86";
            pictureBox86.Size = new Size(48, 46);
            pictureBox86.TabIndex = 111;
            pictureBox86.TabStop = false;
            pictureBox86.Tag = "wall";
            // 
            // pictureBox85
            // 
            pictureBox85.Location = new Point(368, 135);
            pictureBox85.Name = "pictureBox85";
            pictureBox85.Size = new Size(48, 46);
            pictureBox85.TabIndex = 110;
            pictureBox85.TabStop = false;
            pictureBox85.Tag = "wall";
            // 
            // pictureBox84
            // 
            pictureBox84.Location = new Point(322, 135);
            pictureBox84.Name = "pictureBox84";
            pictureBox84.Size = new Size(48, 46);
            pictureBox84.TabIndex = 109;
            pictureBox84.TabStop = false;
            pictureBox84.Tag = "wall";
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(275, 135);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(48, 46);
            pictureBox16.TabIndex = 108;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "wall";
            // 
            // pictureBox83
            // 
            pictureBox83.Location = new Point(459, 225);
            pictureBox83.Name = "pictureBox83";
            pictureBox83.Size = new Size(48, 48);
            pictureBox83.TabIndex = 107;
            pictureBox83.TabStop = false;
            pictureBox83.Tag = "wall";
            // 
            // pictureBox82
            // 
            pictureBox82.Location = new Point(412, 225);
            pictureBox82.Name = "pictureBox82";
            pictureBox82.Size = new Size(48, 48);
            pictureBox82.TabIndex = 106;
            pictureBox82.TabStop = false;
            pictureBox82.Tag = "wall";
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(368, 225);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(48, 48);
            pictureBox14.TabIndex = 105;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "wall";
            // 
            // pictureBox81
            // 
            pictureBox81.Location = new Point(736, 0);
            pictureBox81.Name = "pictureBox81";
            pictureBox81.Size = new Size(48, 48);
            pictureBox81.TabIndex = 104;
            pictureBox81.TabStop = false;
            pictureBox81.Tag = "wall";
            // 
            // pictureBox80
            // 
            pictureBox80.Location = new Point(691, 0);
            pictureBox80.Name = "pictureBox80";
            pictureBox80.Size = new Size(48, 48);
            pictureBox80.TabIndex = 103;
            pictureBox80.TabStop = false;
            pictureBox80.Tag = "wall";
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(643, 0);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(48, 48);
            pictureBox21.TabIndex = 102;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "wall";
            // 
            // pictureBox79
            // 
            pictureBox79.Location = new Point(735, 181);
            pictureBox79.Name = "pictureBox79";
            pictureBox79.Size = new Size(48, 48);
            pictureBox79.TabIndex = 101;
            pictureBox79.TabStop = false;
            pictureBox79.Tag = "wall";
            // 
            // pictureBox78
            // 
            pictureBox78.Location = new Point(735, 229);
            pictureBox78.Name = "pictureBox78";
            pictureBox78.Size = new Size(48, 48);
            pictureBox78.TabIndex = 100;
            pictureBox78.TabStop = false;
            pictureBox78.Tag = "wall";
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(735, 275);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(48, 44);
            pictureBox25.TabIndex = 99;
            pictureBox25.TabStop = false;
            pictureBox25.Tag = "wall";
            // 
            // pictureBox77
            // 
            pictureBox77.Location = new Point(735, 89);
            pictureBox77.Name = "pictureBox77";
            pictureBox77.Size = new Size(48, 48);
            pictureBox77.TabIndex = 98;
            pictureBox77.TabStop = false;
            pictureBox77.Tag = "wall";
            // 
            // pictureBox76
            // 
            pictureBox76.Location = new Point(691, 89);
            pictureBox76.Name = "pictureBox76";
            pictureBox76.Size = new Size(48, 48);
            pictureBox76.TabIndex = 97;
            pictureBox76.TabStop = false;
            pictureBox76.Tag = "wall";
            // 
            // pictureBox75
            // 
            pictureBox75.Location = new Point(645, 89);
            pictureBox75.Name = "pictureBox75";
            pictureBox75.Size = new Size(48, 48);
            pictureBox75.TabIndex = 96;
            pictureBox75.TabStop = false;
            pictureBox75.Tag = "wall";
            // 
            // pictureBox74
            // 
            pictureBox74.Location = new Point(598, 89);
            pictureBox74.Name = "pictureBox74";
            pictureBox74.Size = new Size(48, 48);
            pictureBox74.TabIndex = 95;
            pictureBox74.TabStop = false;
            pictureBox74.Tag = "wall";
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(550, 89);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(48, 48);
            pictureBox20.TabIndex = 94;
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "wall";
            // 
            // pictureBox73
            // 
            pictureBox73.Location = new Point(642, 181);
            pictureBox73.Name = "pictureBox73";
            pictureBox73.Size = new Size(48, 48);
            pictureBox73.TabIndex = 93;
            pictureBox73.TabStop = false;
            pictureBox73.Tag = "wall";
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(642, 135);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(48, 48);
            pictureBox24.TabIndex = 92;
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "wall";
            // 
            // pictureBox72
            // 
            pictureBox72.Location = new Point(549, 269);
            pictureBox72.Name = "pictureBox72";
            pictureBox72.Size = new Size(48, 48);
            pictureBox72.TabIndex = 91;
            pictureBox72.TabStop = false;
            pictureBox72.Tag = "wall";
            // 
            // pictureBox71
            // 
            pictureBox71.Location = new Point(549, 225);
            pictureBox71.Name = "pictureBox71";
            pictureBox71.Size = new Size(48, 48);
            pictureBox71.TabIndex = 90;
            pictureBox71.TabStop = false;
            pictureBox71.Tag = "wall";
            // 
            // pictureBox70
            // 
            pictureBox70.Location = new Point(598, 225);
            pictureBox70.Name = "pictureBox70";
            pictureBox70.Size = new Size(48, 48);
            pictureBox70.TabIndex = 89;
            pictureBox70.TabStop = false;
            pictureBox70.Tag = "wall";
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(642, 225);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(48, 48);
            pictureBox15.TabIndex = 88;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "wall";
            // 
            // pictureBox28
            // 
            pictureBox28.Location = new Point(735, 453);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(48, 48);
            pictureBox28.TabIndex = 87;
            pictureBox28.TabStop = false;
            pictureBox28.Tag = "wall";
            // 
            // pictureBox69
            // 
            pictureBox69.Location = new Point(645, 407);
            pictureBox69.Name = "pictureBox69";
            pictureBox69.Size = new Size(48, 48);
            pictureBox69.TabIndex = 86;
            pictureBox69.TabStop = false;
            pictureBox69.Tag = "wall";
            // 
            // pictureBox68
            // 
            pictureBox68.Location = new Point(598, 407);
            pictureBox68.Name = "pictureBox68";
            pictureBox68.Size = new Size(48, 48);
            pictureBox68.TabIndex = 85;
            pictureBox68.TabStop = false;
            pictureBox68.Tag = "wall";
            // 
            // pictureBox67
            // 
            pictureBox67.Location = new Point(643, 363);
            pictureBox67.Name = "pictureBox67";
            pictureBox67.Size = new Size(48, 48);
            pictureBox67.TabIndex = 83;
            pictureBox67.TabStop = false;
            pictureBox67.Tag = "wall";
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(691, 362);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(48, 46);
            pictureBox26.TabIndex = 82;
            pictureBox26.TabStop = false;
            pictureBox26.Tag = "wall";
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(645, 316);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(48, 48);
            pictureBox23.TabIndex = 81;
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "wall";
            // 
            // pictureBox66
            // 
            pictureBox66.Location = new Point(598, 316);
            pictureBox66.Name = "pictureBox66";
            pictureBox66.Size = new Size(48, 48);
            pictureBox66.TabIndex = 80;
            pictureBox66.TabStop = false;
            pictureBox66.Tag = "wall";
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(549, 316);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(48, 48);
            pictureBox22.TabIndex = 79;
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "wall";
            // 
            // pictureBox65
            // 
            pictureBox65.Location = new Point(275, 453);
            pictureBox65.Name = "pictureBox65";
            pictureBox65.Size = new Size(46, 48);
            pictureBox65.TabIndex = 78;
            pictureBox65.TabStop = false;
            pictureBox65.Tag = "wall";
            // 
            // pictureBox64
            // 
            pictureBox64.Location = new Point(231, 453);
            pictureBox64.Name = "pictureBox64";
            pictureBox64.Size = new Size(48, 48);
            pictureBox64.TabIndex = 77;
            pictureBox64.TabStop = false;
            pictureBox64.Tag = "wall";
            // 
            // pictureBox61
            // 
            pictureBox61.Location = new Point(275, 408);
            pictureBox61.Name = "pictureBox61";
            pictureBox61.Size = new Size(48, 46);
            pictureBox61.TabIndex = 73;
            pictureBox61.TabStop = false;
            pictureBox61.Tag = "wall";
            // 
            // pictureBox60
            // 
            pictureBox60.Location = new Point(322, 408);
            pictureBox60.Name = "pictureBox60";
            pictureBox60.Size = new Size(48, 46);
            pictureBox60.TabIndex = 72;
            pictureBox60.TabStop = false;
            pictureBox60.Tag = "wall";
            // 
            // pictureBox59
            // 
            pictureBox59.Location = new Point(366, 408);
            pictureBox59.Name = "pictureBox59";
            pictureBox59.Size = new Size(48, 46);
            pictureBox59.TabIndex = 71;
            pictureBox59.TabStop = false;
            pictureBox59.Tag = "wall";
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(412, 408);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(48, 46);
            pictureBox12.TabIndex = 70;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "wall";
            // 
            // pictureBox58
            // 
            pictureBox58.Location = new Point(458, 408);
            pictureBox58.Name = "pictureBox58";
            pictureBox58.Size = new Size(48, 46);
            pictureBox58.TabIndex = 69;
            pictureBox58.TabStop = false;
            pictureBox58.Tag = "wall";
            // 
            // pictureBox57
            // 
            pictureBox57.Location = new Point(459, 363);
            pictureBox57.Name = "pictureBox57";
            pictureBox57.Size = new Size(47, 48);
            pictureBox57.TabIndex = 68;
            pictureBox57.TabStop = false;
            pictureBox57.Tag = "wall";
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(458, 317);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(48, 46);
            pictureBox11.TabIndex = 67;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "wall";
            // 
            // pictureBox56
            // 
            pictureBox56.Location = new Point(412, 317);
            pictureBox56.Name = "pictureBox56";
            pictureBox56.Size = new Size(48, 46);
            pictureBox56.TabIndex = 66;
            pictureBox56.TabStop = false;
            pictureBox56.Tag = "wall";
            // 
            // pictureBox55
            // 
            pictureBox55.Location = new Point(368, 317);
            pictureBox55.Name = "pictureBox55";
            pictureBox55.Size = new Size(48, 46);
            pictureBox55.TabIndex = 65;
            pictureBox55.TabStop = false;
            pictureBox55.Tag = "wall";
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(322, 317);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(48, 46);
            pictureBox10.TabIndex = 64;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "wall";
            // 
            // pictureBox54
            // 
            pictureBox54.Location = new Point(275, 317);
            pictureBox54.Name = "pictureBox54";
            pictureBox54.Size = new Size(47, 48);
            pictureBox54.TabIndex = 63;
            pictureBox54.TabStop = false;
            pictureBox54.Tag = "wall";
            // 
            // pictureBox53
            // 
            pictureBox53.Location = new Point(275, 267);
            pictureBox53.Name = "pictureBox53";
            pictureBox53.Size = new Size(47, 48);
            pictureBox53.TabIndex = 62;
            pictureBox53.TabStop = false;
            pictureBox53.Tag = "wall";
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(275, 220);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(47, 48);
            pictureBox9.TabIndex = 61;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "wall";
            // 
            // pictureBox40
            // 
            pictureBox40.Location = new Point(184, 0);
            pictureBox40.Name = "pictureBox40";
            pictureBox40.Size = new Size(48, 48);
            pictureBox40.TabIndex = 42;
            pictureBox40.TabStop = false;
            pictureBox40.Tag = "wall";
            // 
            // pictureBox39
            // 
            pictureBox39.Location = new Point(137, 0);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(48, 48);
            pictureBox39.TabIndex = 41;
            pictureBox39.TabStop = false;
            pictureBox39.Tag = "wall";
            // 
            // pictureBox38
            // 
            pictureBox38.Location = new Point(90, 0);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(48, 48);
            pictureBox38.TabIndex = 40;
            pictureBox38.TabStop = false;
            pictureBox38.Tag = "wall";
            // 
            // pictureBox37
            // 
            pictureBox37.Location = new Point(44, 0);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(48, 48);
            pictureBox37.TabIndex = 39;
            pictureBox37.TabStop = false;
            pictureBox37.Tag = "wall";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "wall";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(184, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "wall";
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(550, 407);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(48, 48);
            pictureBox27.TabIndex = 84;
            pictureBox27.TabStop = false;
            pictureBox27.Tag = "wall";
            // 
            // pictureBox63
            // 
            pictureBox63.Location = new Point(184, 453);
            pictureBox63.Name = "pictureBox63";
            pictureBox63.Size = new Size(48, 48);
            pictureBox63.TabIndex = 76;
            pictureBox63.TabStop = false;
            pictureBox63.Tag = "wall";
            // 
            // pictureBox62
            // 
            pictureBox62.Location = new Point(137, 453);
            pictureBox62.Name = "pictureBox62";
            pictureBox62.Size = new Size(48, 48);
            pictureBox62.TabIndex = 75;
            pictureBox62.TabStop = false;
            pictureBox62.Tag = "wall";
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(92, 453);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(46, 48);
            pictureBox13.TabIndex = 74;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "wall";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox1.Location = new Point(137, 326);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 131;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "key";
            // 
            // pictureBox35
            // 
            pictureBox35.BackColor = Color.Transparent;
            pictureBox35.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox35.Location = new Point(734, 54);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(38, 24);
            pictureBox35.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox35.TabIndex = 133;
            pictureBox35.TabStop = false;
            pictureBox35.Tag = "key";

            Controls.Add(pictureBox35);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox98);
            Controls.Add(pictureBox97);
            Controls.Add(pictureBox96);
            Controls.Add(pictureBox95);
            Controls.Add(pictureBox94);
            Controls.Add(pictureBox93);
            Controls.Add(pictureBox92);
            Controls.Add(pictureBox91);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox33);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox51);
            Controls.Add(pictureBox52);
            Controls.Add(pictureBox50);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox49);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox48);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox47);
            Controls.Add(pictureBox46);
            Controls.Add(pictureBox45);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox44);
            Controls.Add(pictureBox43);
            Controls.Add(pictureBox42);
            Controls.Add(pictureBox41);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox90);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox89);
            Controls.Add(pictureBox88);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox87);
            Controls.Add(pictureBox86);
            Controls.Add(pictureBox85);
            Controls.Add(pictureBox84);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox83);
            Controls.Add(pictureBox82);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox81);
            Controls.Add(pictureBox80);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox79);
            Controls.Add(pictureBox78);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox77);
            Controls.Add(pictureBox76);
            Controls.Add(pictureBox75);
            Controls.Add(pictureBox74);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox73);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox72);
            Controls.Add(pictureBox71);
            Controls.Add(pictureBox70);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox69);
            Controls.Add(pictureBox68);
            Controls.Add(pictureBox67);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox66);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox65);
            Controls.Add(pictureBox64);
            Controls.Add(pictureBox61);
            Controls.Add(pictureBox60);
            Controls.Add(pictureBox59);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox58);
            Controls.Add(pictureBox57);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox56);
            Controls.Add(pictureBox55);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox54);
            Controls.Add(pictureBox53);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox40);
            Controls.Add(pictureBox39);
            Controls.Add(pictureBox38);
            Controls.Add(pictureBox37);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox63);
            Controls.Add(pictureBox62);
            Controls.Add(pictureBox13);
            #endregion
        }

        public void MapaCidade()
        {
            // Padrões do mapa
            Jogador.Reset(new Point(12, 50), new Point(-44, -30));
            picPorta.Location = new Point(774, 455);
            picArea.Location = new Point(-44, -30);
            picMapa.Image = Properties.Resources.MapaCidade;
            picJogador.Location = new Point(12, 50);
            picMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            GlobalConfig.qntChavesAtuais = 0;
            GlobalConfig.qntChaves = 3;
            if (!GlobalConfig.muteLigado)
            {
                player.URL = "WarLowRider.mp3";
                player.controls.play();
            }

            #region Mapa Cidade --> NÃO MEXA AQUI
            // Mapa cidade
            PictureBox pictureBox113 = new PictureBox();
            PictureBox pictureBox112 = new PictureBox();
            PictureBox pictureBox110 = new PictureBox();
            PictureBox pictureBox109 = new PictureBox();
            PictureBox pictureBox108 = new PictureBox();
            PictureBox pictureBox107 = new PictureBox();
            PictureBox pictureBox106 = new PictureBox();
            PictureBox pictureBox105 = new PictureBox();
            PictureBox pictureBox104 = new PictureBox();
            PictureBox pictureBox103 = new PictureBox();
            PictureBox pictureBox102 = new PictureBox();
            PictureBox pictureBox101 = new PictureBox();
            PictureBox pictureBox100 = new PictureBox();
            PictureBox pictureBox99 = new PictureBox();
            PictureBox pictureBox98 = new PictureBox();
            PictureBox pictureBox17 = new PictureBox();
            PictureBox pictureBox18 = new PictureBox();
            PictureBox pictureBox56 = new PictureBox();
            PictureBox pictureBox46 = new PictureBox();
            PictureBox pictureBox37 = new PictureBox();
            PictureBox pictureBox97 = new PictureBox();
            PictureBox pictureBox96 = new PictureBox();
            PictureBox pictureBox95 = new PictureBox();
            PictureBox pictureBox94 = new PictureBox();
            PictureBox pictureBox93 = new PictureBox();
            PictureBox pictureBox92 = new PictureBox();
            PictureBox pictureBox91 = new PictureBox();
            PictureBox pictureBox90 = new PictureBox();
            PictureBox pictureBox89 = new PictureBox();
            PictureBox pictureBox88 = new PictureBox();
            PictureBox pictureBox87 = new PictureBox();
            PictureBox pictureBox86 = new PictureBox();
            PictureBox pictureBox85 = new PictureBox();
            PictureBox pictureBox84 = new PictureBox();
            PictureBox pictureBox83 = new PictureBox();
            PictureBox pictureBox82 = new PictureBox();
            PictureBox pictureBox78 = new PictureBox();
            PictureBox pictureBox77 = new PictureBox();
            PictureBox pictureBox76 = new PictureBox();
            PictureBox pictureBox75 = new PictureBox();
            PictureBox pictureBox74 = new PictureBox();
            PictureBox pictureBox73 = new PictureBox();
            PictureBox pictureBox72 = new PictureBox();
            PictureBox pictureBox71 = new PictureBox();
            PictureBox pictureBox70 = new PictureBox();
            PictureBox pictureBox69 = new PictureBox();
            PictureBox pictureBox68 = new PictureBox();
            PictureBox pictureBox67 = new PictureBox();
            PictureBox pictureBox66 = new PictureBox();
            PictureBox pictureBox65 = new PictureBox();
            PictureBox pictureBox64 = new PictureBox();
            PictureBox pictureBox63 = new PictureBox();
            PictureBox pictureBox62 = new PictureBox();
            PictureBox pictureBox61 = new PictureBox();
            PictureBox pictureBox60 = new PictureBox();
            PictureBox pictureBox59 = new PictureBox();
            PictureBox pictureBox57 = new PictureBox();
            PictureBox pictureBox58 = new PictureBox();
            PictureBox pictureBox33 = new PictureBox();
            PictureBox pictureBox31 = new PictureBox();
            PictureBox pictureBox55 = new PictureBox();
            PictureBox pictureBox54 = new PictureBox();
            PictureBox pictureBox53 = new PictureBox();
            PictureBox pictureBox52 = new PictureBox();
            PictureBox pictureBox51 = new PictureBox();
            PictureBox pictureBox50 = new PictureBox();
            PictureBox pictureBox49 = new PictureBox();
            PictureBox pictureBox48 = new PictureBox();
            PictureBox pictureBox47 = new PictureBox();
            PictureBox pictureBox45 = new PictureBox();
            PictureBox pictureBox44 = new PictureBox();
            PictureBox pictureBox43 = new PictureBox();
            PictureBox pictureBox42 = new PictureBox();
            PictureBox pictureBox41 = new PictureBox();
            PictureBox pictureBox40 = new PictureBox();
            PictureBox pictureBox39 = new PictureBox();
            PictureBox pictureBox38 = new PictureBox();
            PictureBox pictureBox36 = new PictureBox();
            PictureBox pictureBox35 = new PictureBox();
            PictureBox pictureBox34 = new PictureBox();
            PictureBox pictureBox32 = new PictureBox();
            PictureBox pictureBox30 = new PictureBox();
            PictureBox pictureBox29 = new PictureBox();
            PictureBox pictureBox28 = new PictureBox();
            PictureBox pictureBox27 = new PictureBox();
            PictureBox pictureBox26 = new PictureBox();
            PictureBox pictureBox25 = new PictureBox();
            PictureBox pictureBox24 = new PictureBox();
            PictureBox pictureBox23 = new PictureBox();
            PictureBox pictureBox22 = new PictureBox();
            PictureBox pictureBox21 = new PictureBox();
            PictureBox pictureBox20 = new PictureBox();
            PictureBox pictureBox19 = new PictureBox();
            PictureBox pictureBox16 = new PictureBox();
            PictureBox pictureBox15 = new PictureBox();
            PictureBox pictureBox14 = new PictureBox();
            PictureBox pictureBox13 = new PictureBox();
            PictureBox pictureBox12 = new PictureBox();
            PictureBox pictureBox11 = new PictureBox();
            PictureBox pictureBox10 = new PictureBox();
            PictureBox pictureBox9 = new PictureBox();
            PictureBox pictureBox8 = new PictureBox();
            PictureBox pictureBox7 = new PictureBox();
            PictureBox pictureBox6 = new PictureBox();
            PictureBox pictureBox5 = new PictureBox();
            PictureBox pictureBox4 = new PictureBox();
            PictureBox pictureBox3 = new PictureBox();
            PictureBox pictureBox2 = new PictureBox();
            PictureBox pictureBox1 = new PictureBox();

            // 
            // pictureBox113
            // 
            pictureBox113.BackColor = Color.Transparent;
            pictureBox113.Location = new Point(65, 145);
            pictureBox113.Name = "pictureBox113";
            pictureBox113.Size = new Size(24, 24);
            pictureBox113.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox113.TabIndex = 250;
            pictureBox113.TabStop = false;
            pictureBox113.Tag = "inimigoDireita";
            // 
            // pictureBox112
            // 
            pictureBox112.BackColor = Color.Transparent;
            pictureBox112.Location = new Point(148, 52);
            pictureBox112.Name = "pictureBox112";
            pictureBox112.Size = new Size(24, 24);
            pictureBox112.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox112.TabIndex = 249;
            pictureBox112.TabStop = false;
            pictureBox112.Tag = "inimigoDireita";
            // 
            // pictureBox110
            // 
            pictureBox110.BackColor = Color.Transparent;
            pictureBox110.Location = new Point(211, 112);
            pictureBox110.Name = "pictureBox110";
            pictureBox110.Size = new Size(24, 24);
            pictureBox110.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox110.TabIndex = 247;
            pictureBox110.TabStop = false;
            pictureBox110.Tag = "inimigoBaixo";
            // 
            // pictureBox109
            // 
            pictureBox109.BackColor = Color.Transparent;
            pictureBox109.Location = new Point(37, 392);
            pictureBox109.Name = "pictureBox109";
            pictureBox109.Size = new Size(24, 24);
            pictureBox109.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox109.TabIndex = 246;
            pictureBox109.TabStop = false;
            pictureBox109.Tag = "inimigoBaixo";
            // 
            // pictureBox108
            // 
            pictureBox108.BackColor = Color.Transparent;
            pictureBox108.Location = new Point(37, 342);
            pictureBox108.Name = "pictureBox108";
            pictureBox108.Size = new Size(24, 24);
            pictureBox108.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox108.TabIndex = 245;
            pictureBox108.TabStop = false;
            pictureBox108.Tag = "inimigoCima";
            // 
            // pictureBox107
            // 
            pictureBox107.BackColor = Color.Transparent;
            pictureBox107.Location = new Point(151, 475);
            pictureBox107.Name = "pictureBox107";
            pictureBox107.Size = new Size(24, 24);
            pictureBox107.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox107.TabIndex = 244;
            pictureBox107.TabStop = false;
            pictureBox107.Tag = "inimigoDireita";
            // 
            // pictureBox106
            // 
            pictureBox106.BackColor = Color.Transparent;
            pictureBox106.Location = new Point(561, 472);
            pictureBox106.Name = "pictureBox106";
            pictureBox106.Size = new Size(24, 24);
            pictureBox106.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox106.TabIndex = 243;
            pictureBox106.TabStop = false;
            pictureBox106.Tag = "inimigoEsquerda";
            // 
            // pictureBox105
            // 
            pictureBox105.BackColor = Color.Transparent;
            pictureBox105.Location = new Point(345, 285);
            pictureBox105.Name = "pictureBox105";
            pictureBox105.Size = new Size(24, 24);
            pictureBox105.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox105.TabIndex = 242;
            pictureBox105.TabStop = false;
            pictureBox105.Tag = "inimigoDireita";
            // 
            // pictureBox104
            // 
            pictureBox104.BackColor = Color.Transparent;
            pictureBox104.Location = new Point(471, 4);
            pictureBox104.Name = "pictureBox104";
            pictureBox104.Size = new Size(24, 24);
            pictureBox104.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox104.TabIndex = 241;
            pictureBox104.TabStop = false;
            pictureBox104.Tag = "inimigoEsquerda";
            // 
            // pictureBox103
            // 
            pictureBox103.BackColor = Color.Transparent;
            pictureBox103.Location = new Point(542, 4);
            pictureBox103.Name = "pictureBox103";
            pictureBox103.Size = new Size(24, 24);
            pictureBox103.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox103.TabIndex = 240;
            pictureBox103.TabStop = false;
            pictureBox103.Tag = "inimigoDireita";
            // 
            // pictureBox102
            // 
            pictureBox102.BackColor = Color.Transparent;
            pictureBox102.Location = new Point(600, 385);
            pictureBox102.Name = "pictureBox102";
            pictureBox102.Size = new Size(24, 24);
            pictureBox102.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox102.TabIndex = 239;
            pictureBox102.TabStop = false;
            pictureBox102.Tag = "inimigoDireita";
            // 
            // pictureBox101
            // 
            pictureBox101.BackColor = Color.Transparent;
            pictureBox101.Location = new Point(640, 472);
            pictureBox101.Name = "pictureBox101";
            pictureBox101.Size = new Size(24, 24);
            pictureBox101.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox101.TabIndex = 238;
            pictureBox101.TabStop = false;
            pictureBox101.Tag = "inimigoDireita";
            // 
            // pictureBox100
            // 
            pictureBox100.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox100.Location = new Point(389, 285);
            pictureBox100.Name = "pictureBox100";
            pictureBox100.Size = new Size(38, 24);
            pictureBox100.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox100.TabIndex = 237;
            pictureBox100.TabStop = false;
            pictureBox100.Tag = "key";
            // 
            // pictureBox99
            // 
            pictureBox99.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox99.Location = new Point(459, 1);
            pictureBox99.Name = "pictureBox99";
            pictureBox99.Size = new Size(38, 24);
            pictureBox99.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox99.TabIndex = 236;
            pictureBox99.TabStop = false;
            pictureBox99.Tag = "key";
            // 
            // pictureBox98
            // 
            pictureBox98.Image = global::JogoDUDU.Properties.Resources.chave;
            pictureBox98.Location = new Point(148, 475);
            pictureBox98.Name = "pictureBox98";
            pictureBox98.Size = new Size(38, 24);
            pictureBox98.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox98.TabIndex = 235;
            pictureBox98.TabStop = false;
            pictureBox98.Tag = "key";
            // 
            // picJogador
            // 
            picJogador.BackColor = Color.Transparent;
            picJogador.Location = new Point(30, 52);
            picJogador.Name = "picJogador";
            picJogador.Size = new Size(24, 24);
            picJogador.SizeMode = PictureBoxSizeMode.StretchImage;
            picJogador.TabIndex = 28;
            picJogador.TabStop = false;
            picJogador.Tag = "";
            // 
            // picMapa
            // 
            picMapa.Dock = DockStyle.Fill;
            picMapa.Image = global::JogoDUDU.Properties.Resources.MapaCidade;
            picMapa.Location = new Point(0, 0);
            picMapa.Name = "picMapa";
            picMapa.Size = new Size(784, 501);
            picMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            picMapa.TabIndex = 0;
            picMapa.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Location = new Point(163, 270);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(38, 76);
            pictureBox17.TabIndex = 255;
            pictureBox17.TabStop = false;
            pictureBox17.Tag = "wall";
            // 
            // pictureBox18
            // 
            pictureBox18.Location = new Point(163, 258);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(38, 19);
            pictureBox18.TabIndex = 254;
            pictureBox18.TabStop = false;
            pictureBox18.Tag = "wall";
            // 
            // pictureBox56
            // 
            pictureBox56.Location = new Point(249, 115);
            pictureBox56.Name = "pictureBox56";
            pictureBox56.Size = new Size(70, 66);
            pictureBox56.TabIndex = 253;
            pictureBox56.TabStop = false;
            pictureBox56.Tag = "wall";
            // 
            // pictureBox46
            // 
            pictureBox46.Location = new Point(-7, 82);
            pictureBox46.Name = "pictureBox46";
            pictureBox46.Size = new Size(39, 54);
            pictureBox46.TabIndex = 252;
            pictureBox46.TabStop = false;
            pictureBox46.Tag = "wall";
            // 
            // pictureBox37
            // 
            pictureBox37.Location = new Point(30, 82);
            pictureBox37.Name = "pictureBox37";
            pictureBox37.Size = new Size(59, 54);
            pictureBox37.TabIndex = 251;
            pictureBox37.TabStop = false;
            pictureBox37.Tag = "wall";
            // 
            // pictureBox97
            // 
            pictureBox97.Location = new Point(754, 413);
            pictureBox97.Name = "pictureBox97";
            pictureBox97.Size = new Size(39, 57);
            pictureBox97.TabIndex = 234;
            pictureBox97.TabStop = false;
            pictureBox97.Tag = "wall";
            // 
            // pictureBox96
            // 
            pictureBox96.Location = new Point(735, 31);
            pictureBox96.Name = "pictureBox96";
            pictureBox96.Size = new Size(49, 57);
            pictureBox96.TabIndex = 233;
            pictureBox96.TabStop = false;
            pictureBox96.Tag = "wall";
            // 
            // pictureBox95
            // 
            pictureBox95.Location = new Point(735, 82);
            pictureBox95.Name = "pictureBox95";
            pictureBox95.Size = new Size(49, 57);
            pictureBox95.TabIndex = 232;
            pictureBox95.TabStop = false;
            pictureBox95.Tag = "wall";
            // 
            // pictureBox94
            // 
            pictureBox94.Location = new Point(735, 131);
            pictureBox94.Name = "pictureBox94";
            pictureBox94.Size = new Size(49, 57);
            pictureBox94.TabIndex = 231;
            pictureBox94.TabStop = false;
            pictureBox94.Tag = "wall";
            // 
            // pictureBox93
            // 
            pictureBox93.Location = new Point(735, 188);
            pictureBox93.Name = "pictureBox93";
            pictureBox93.Size = new Size(49, 57);
            pictureBox93.TabIndex = 230;
            pictureBox93.TabStop = false;
            pictureBox93.Tag = "wall";
            // 
            // pictureBox92
            // 
            pictureBox92.Location = new Point(735, 245);
            pictureBox92.Name = "pictureBox92";
            pictureBox92.Size = new Size(49, 57);
            pictureBox92.TabIndex = 229;
            pictureBox92.TabStop = false;
            pictureBox92.Tag = "wall";
            // 
            // pictureBox91
            // 
            pictureBox91.Location = new Point(735, 302);
            pictureBox91.Name = "pictureBox91";
            pictureBox91.Size = new Size(49, 57);
            pictureBox91.TabIndex = 228;
            pictureBox91.TabStop = false;
            pictureBox91.Tag = "wall";
            // 
            // pictureBox90
            // 
            pictureBox90.Location = new Point(735, 359);
            pictureBox90.Name = "pictureBox90";
            pictureBox90.Size = new Size(49, 57);
            pictureBox90.TabIndex = 227;
            pictureBox90.TabStop = false;
            pictureBox90.Tag = "wall";
            // 
            // pictureBox89
            // 
            pictureBox89.Location = new Point(714, 413);
            pictureBox89.Name = "pictureBox89";
            pictureBox89.Size = new Size(49, 57);
            pictureBox89.TabIndex = 226;
            pictureBox89.TabStop = false;
            pictureBox89.Tag = "wall";
            // 
            // pictureBox88
            // 
            pictureBox88.Location = new Point(670, 413);
            pictureBox88.Name = "pictureBox88";
            pictureBox88.Size = new Size(49, 57);
            pictureBox88.TabIndex = 225;
            pictureBox88.TabStop = false;
            pictureBox88.Tag = "wall";
            // 
            // pictureBox87
            // 
            pictureBox87.Location = new Point(624, 413);
            pictureBox87.Name = "pictureBox87";
            pictureBox87.Size = new Size(49, 57);
            pictureBox87.TabIndex = 224;
            pictureBox87.TabStop = false;
            pictureBox87.Tag = "wall";
            // 
            // pictureBox86
            // 
            pictureBox86.Location = new Point(575, 413);
            pictureBox86.Name = "pictureBox86";
            pictureBox86.Size = new Size(49, 57);
            pictureBox86.TabIndex = 223;
            pictureBox86.TabStop = false;
            pictureBox86.Tag = "wall";
            // 
            // pictureBox85
            // 
            pictureBox85.Location = new Point(526, 413);
            pictureBox85.Name = "pictureBox85";
            pictureBox85.Size = new Size(49, 57);
            pictureBox85.TabIndex = 222;
            pictureBox85.TabStop = false;
            pictureBox85.Tag = "wall";
            // 
            // pictureBox84
            // 
            pictureBox84.Location = new Point(477, 413);
            pictureBox84.Name = "pictureBox84";
            pictureBox84.Size = new Size(49, 57);
            pictureBox84.TabIndex = 221;
            pictureBox84.TabStop = false;
            pictureBox84.Tag = "wall";
            // 
            // pictureBox83
            // 
            pictureBox83.Location = new Point(148, 82);
            pictureBox83.Name = "pictureBox83";
            pictureBox83.Size = new Size(49, 54);
            pictureBox83.TabIndex = 220;
            pictureBox83.TabStop = false;
            pictureBox83.Tag = "wall";
            // 
            // pictureBox82
            // 
            pictureBox82.Location = new Point(89, 82);
            pictureBox82.Name = "pictureBox82";
            pictureBox82.Size = new Size(59, 54);
            pictureBox82.TabIndex = 219;
            pictureBox82.TabStop = false;
            pictureBox82.Tag = "wall";
            // 
            // pictureBox78
            // 
            pictureBox78.Location = new Point(459, 31);
            pictureBox78.Name = "pictureBox78";
            pictureBox78.Size = new Size(49, 45);
            pictureBox78.TabIndex = 215;
            pictureBox78.TabStop = false;
            pictureBox78.Tag = "wall";
            // 
            // pictureBox77
            // 
            pictureBox77.Location = new Point(362, 31);
            pictureBox77.Name = "pictureBox77";
            pictureBox77.Size = new Size(65, 45);
            pictureBox77.TabIndex = 214;
            pictureBox77.TabStop = false;
            pictureBox77.Tag = "wall";
            // 
            // pictureBox76
            // 
            pictureBox76.Location = new Point(503, 31);
            pictureBox76.Name = "pictureBox76";
            pictureBox76.Size = new Size(49, 45);
            pictureBox76.TabIndex = 213;
            pictureBox76.TabStop = false;
            pictureBox76.Tag = "wall";
            // 
            // pictureBox75
            // 
            pictureBox75.Location = new Point(423, 31);
            pictureBox75.Name = "pictureBox75";
            pictureBox75.Size = new Size(49, 45);
            pictureBox75.TabIndex = 212;
            pictureBox75.TabStop = false;
            pictureBox75.Tag = "wall";
            // 
            // pictureBox74
            // 
            pictureBox74.Location = new Point(362, 71);
            pictureBox74.Name = "pictureBox74";
            pictureBox74.Size = new Size(65, 45);
            pictureBox74.TabIndex = 211;
            pictureBox74.TabStop = false;
            pictureBox74.Tag = "wall";
            // 
            // pictureBox73
            // 
            pictureBox73.Location = new Point(551, 31);
            pictureBox73.Name = "pictureBox73";
            pictureBox73.Size = new Size(49, 45);
            pictureBox73.TabIndex = 210;
            pictureBox73.TabStop = false;
            pictureBox73.Tag = "wall";
            // 
            // pictureBox72
            // 
            pictureBox72.Location = new Point(600, 31);
            pictureBox72.Name = "pictureBox72";
            pictureBox72.Size = new Size(49, 45);
            pictureBox72.TabIndex = 209;
            pictureBox72.TabStop = false;
            pictureBox72.Tag = "wall";
            // 
            // pictureBox71
            // 
            pictureBox71.Location = new Point(645, 31);
            pictureBox71.Name = "pictureBox71";
            pictureBox71.Size = new Size(49, 65);
            pictureBox71.TabIndex = 208;
            pictureBox71.TabStop = false;
            pictureBox71.Tag = "wall";
            // 
            // pictureBox70
            // 
            pictureBox70.Location = new Point(645, 94);
            pictureBox70.Name = "pictureBox70";
            pictureBox70.Size = new Size(49, 45);
            pictureBox70.TabIndex = 207;
            pictureBox70.TabStop = false;
            pictureBox70.Tag = "wall";
            // 
            // pictureBox69
            // 
            pictureBox69.Location = new Point(645, 136);
            pictureBox69.Name = "pictureBox69";
            pictureBox69.Size = new Size(49, 45);
            pictureBox69.TabIndex = 206;
            pictureBox69.TabStop = false;
            pictureBox69.Tag = "wall";
            // 
            // pictureBox68
            // 
            pictureBox68.Location = new Point(645, 180);
            pictureBox68.Name = "pictureBox68";
            pictureBox68.Size = new Size(49, 45);
            pictureBox68.TabIndex = 205;
            pictureBox68.TabStop = false;
            pictureBox68.Tag = "wall";
            // 
            // pictureBox67
            // 
            pictureBox67.Location = new Point(645, 225);
            pictureBox67.Name = "pictureBox67";
            pictureBox67.Size = new Size(49, 45);
            pictureBox67.TabIndex = 204;
            pictureBox67.TabStop = false;
            pictureBox67.Tag = "wall";
            // 
            // pictureBox66
            // 
            pictureBox66.Location = new Point(575, 71);
            pictureBox66.Name = "pictureBox66";
            pictureBox66.Size = new Size(49, 68);
            pictureBox66.TabIndex = 203;
            pictureBox66.TabStop = false;
            pictureBox66.Tag = "wall";
            // 
            // pictureBox65
            // 
            pictureBox65.Location = new Point(575, 136);
            pictureBox65.Name = "pictureBox65";
            pictureBox65.Size = new Size(49, 45);
            pictureBox65.TabIndex = 202;
            pictureBox65.TabStop = false;
            pictureBox65.Tag = "wall";
            // 
            // pictureBox64
            // 
            pictureBox64.Location = new Point(575, 180);
            pictureBox64.Name = "pictureBox64";
            pictureBox64.Size = new Size(49, 45);
            pictureBox64.TabIndex = 201;
            pictureBox64.TabStop = false;
            pictureBox64.Tag = "wall";
            // 
            // pictureBox63
            // 
            pictureBox63.Location = new Point(575, 225);
            pictureBox63.Name = "pictureBox63";
            pictureBox63.Size = new Size(49, 45);
            pictureBox63.TabIndex = 200;
            pictureBox63.TabStop = false;
            pictureBox63.Tag = "wall";
            // 
            // pictureBox62
            // 
            pictureBox62.Location = new Point(575, 270);
            pictureBox62.Name = "pictureBox62";
            pictureBox62.Size = new Size(49, 45);
            pictureBox62.TabIndex = 199;
            pictureBox62.TabStop = false;
            pictureBox62.Tag = "wall";
            // 
            // pictureBox61
            // 
            pictureBox61.Location = new Point(628, 315);
            pictureBox61.Name = "pictureBox61";
            pictureBox61.Size = new Size(66, 64);
            pictureBox61.TabIndex = 198;
            pictureBox61.TabStop = false;
            pictureBox61.Tag = "wall";
            // 
            // pictureBox60
            // 
            pictureBox60.Location = new Point(575, 315);
            pictureBox60.Name = "pictureBox60";
            pictureBox60.Size = new Size(54, 64);
            pictureBox60.TabIndex = 197;
            pictureBox60.TabStop = false;
            pictureBox60.Tag = "wall";
            // 
            // pictureBox59
            // 
            pictureBox59.Location = new Point(521, 315);
            pictureBox59.Name = "pictureBox59";
            pictureBox59.Size = new Size(54, 64);
            pictureBox59.TabIndex = 196;
            pictureBox59.TabStop = false;
            pictureBox59.Tag = "wall";
            // 
            // pictureBox57
            // 
            pictureBox57.Location = new Point(477, 315);
            pictureBox57.Name = "pictureBox57";
            pictureBox57.Size = new Size(54, 64);
            pictureBox57.TabIndex = 195;
            pictureBox57.TabStop = false;
            pictureBox57.Tag = "wall";
            // 
            // pictureBox58
            // 
            pictureBox58.Location = new Point(645, 270);
            pictureBox58.Name = "pictureBox58";
            pictureBox58.Size = new Size(49, 45);
            pictureBox58.TabIndex = 194;
            pictureBox58.TabStop = false;
            pictureBox58.Tag = "wall";
            // 
            // pictureBox33
            // 
            pictureBox33.Location = new Point(423, 315);
            pictureBox33.Name = "pictureBox33";
            pictureBox33.Size = new Size(54, 64);
            pictureBox33.TabIndex = 192;
            pictureBox33.TabStop = false;
            pictureBox33.Tag = "wall";
            // 
            // pictureBox31
            // 
            pictureBox31.Location = new Point(375, 315);
            pictureBox31.Name = "pictureBox31";
            pictureBox31.Size = new Size(49, 64);
            pictureBox31.TabIndex = 191;
            pictureBox31.TabStop = false;
            pictureBox31.Tag = "wall";
            // 
            // pictureBox55
            // 
            pictureBox55.Location = new Point(163, 0);
            pictureBox55.Name = "pictureBox55";
            pictureBox55.Size = new Size(90, 46);
            pictureBox55.TabIndex = 189;
            pictureBox55.TabStop = false;
            pictureBox55.Tag = "wall";
            // 
            // pictureBox54
            // 
            pictureBox54.Location = new Point(109, 0);
            pictureBox54.Name = "pictureBox54";
            pictureBox54.Size = new Size(54, 46);
            pictureBox54.TabIndex = 188;
            pictureBox54.TabStop = false;
            pictureBox54.Tag = "wall";
            // 
            // pictureBox53
            // 
            pictureBox53.Location = new Point(65, 0);
            pictureBox53.Name = "pictureBox53";
            pictureBox53.Size = new Size(44, 46);
            pictureBox53.TabIndex = 187;
            pictureBox53.TabStop = false;
            pictureBox53.Tag = "wall";
            // 
            // pictureBox52
            // 
            pictureBox52.Location = new Point(0, 0);
            pictureBox52.Name = "pictureBox52";
            pictureBox52.Size = new Size(69, 46);
            pictureBox52.TabIndex = 186;
            pictureBox52.TabStop = false;
            pictureBox52.Tag = "wall";
            // 
            // pictureBox51
            // 
            pictureBox51.Location = new Point(249, 0);
            pictureBox51.Name = "pictureBox51";
            pictureBox51.Size = new Size(70, 38);
            pictureBox51.TabIndex = 185;
            pictureBox51.TabStop = false;
            pictureBox51.Tag = "wall";
            // 
            // pictureBox50
            // 
            pictureBox50.Location = new Point(362, 112);
            pictureBox50.Name = "pictureBox50";
            pictureBox50.Size = new Size(65, 50);
            pictureBox50.TabIndex = 184;
            pictureBox50.TabStop = false;
            pictureBox50.Tag = "wall";
            // 
            // pictureBox49
            // 
            pictureBox49.Location = new Point(249, 36);
            pictureBox49.Name = "pictureBox49";
            pictureBox49.Size = new Size(70, 60);
            pictureBox49.TabIndex = 183;
            pictureBox49.TabStop = false;
            pictureBox49.Tag = "wall";
            // 
            // pictureBox48
            // 
            pictureBox48.Location = new Point(249, 94);
            pictureBox48.Name = "pictureBox48";
            pictureBox48.Size = new Size(70, 22);
            pictureBox48.TabIndex = 182;
            pictureBox48.TabStop = false;
            pictureBox48.Tag = "wall";
            // 
            // pictureBox47
            // 
            pictureBox47.Location = new Point(249, 180);
            pictureBox47.Name = "pictureBox47";
            pictureBox47.Size = new Size(70, 37);
            pictureBox47.TabIndex = 181;
            pictureBox47.TabStop = false;
            pictureBox47.Tag = "wall";
            // 
            // pictureBox45
            // 
            pictureBox45.Location = new Point(471, 136);
            pictureBox45.Name = "pictureBox45";
            pictureBox45.Size = new Size(65, 81);
            pictureBox45.TabIndex = 179;
            pictureBox45.TabStop = false;
            pictureBox45.Tag = "wall";
            // 
            // pictureBox44
            // 
            pictureBox44.Location = new Point(521, 215);
            pictureBox44.Name = "pictureBox44";
            pictureBox44.Size = new Size(15, 62);
            pictureBox44.TabIndex = 178;
            pictureBox44.TabStop = false;
            pictureBox44.Tag = "wall";
            // 
            // pictureBox43
            // 
            pictureBox43.Location = new Point(477, 217);
            pictureBox43.Name = "pictureBox43";
            pictureBox43.Size = new Size(44, 60);
            pictureBox43.TabIndex = 177;
            pictureBox43.TabStop = false;
            pictureBox43.Tag = "wall";
            // 
            // pictureBox42
            // 
            pictureBox42.Location = new Point(423, 217);
            pictureBox42.Name = "pictureBox42";
            pictureBox42.Size = new Size(54, 60);
            pictureBox42.TabIndex = 176;
            pictureBox42.TabStop = false;
            pictureBox42.Tag = "wall";
            // 
            // pictureBox41
            // 
            pictureBox41.Location = new Point(373, 217);
            pictureBox41.Name = "pictureBox41";
            pictureBox41.Size = new Size(54, 60);
            pictureBox41.TabIndex = 175;
            pictureBox41.TabStop = false;
            pictureBox41.Tag = "wall";
            // 
            // pictureBox40
            // 
            pictureBox40.Location = new Point(319, 217);
            pictureBox40.Name = "pictureBox40";
            pictureBox40.Size = new Size(54, 60);
            pictureBox40.TabIndex = 174;
            pictureBox40.TabStop = false;
            pictureBox40.Tag = "wall";
            // 
            // pictureBox39
            // 
            pictureBox39.Location = new Point(249, 217);
            pictureBox39.Name = "pictureBox39";
            pictureBox39.Size = new Size(70, 60);
            pictureBox39.TabIndex = 173;
            pictureBox39.TabStop = false;
            pictureBox39.Tag = "wall";
            // 
            // pictureBox38
            // 
            pictureBox38.Location = new Point(356, 451);
            pictureBox38.Name = "pictureBox38";
            pictureBox38.Size = new Size(49, 50);
            pictureBox38.TabIndex = 172;
            pictureBox38.TabStop = false;
            pictureBox38.Tag = "wall";
            // 
            // pictureBox36
            // 
            pictureBox36.Location = new Point(356, 378);
            pictureBox36.Name = "pictureBox36";
            pictureBox36.Size = new Size(49, 75);
            pictureBox36.TabIndex = 170;
            pictureBox36.TabStop = false;
            pictureBox36.Tag = "wall";
            // 
            // pictureBox35
            // 
            pictureBox35.Location = new Point(327, 315);
            pictureBox35.Name = "pictureBox35";
            pictureBox35.Size = new Size(49, 64);
            pictureBox35.TabIndex = 169;
            pictureBox35.TabStop = false;
            pictureBox35.Tag = "wall";
            // 
            // pictureBox34
            // 
            pictureBox34.Location = new Point(290, 315);
            pictureBox34.Name = "pictureBox34";
            pictureBox34.Size = new Size(38, 64);
            pictureBox34.TabIndex = 168;
            pictureBox34.TabStop = false;
            pictureBox34.Tag = "wall";
            // 
            // pictureBox32
            // 
            pictureBox32.Location = new Point(249, 315);
            pictureBox32.Name = "pictureBox32";
            pictureBox32.Size = new Size(41, 64);
            pictureBox32.TabIndex = 166;
            pictureBox32.TabStop = false;
            pictureBox32.Tag = "wall";
            // 
            // pictureBox30
            // 
            pictureBox30.Location = new Point(75, 427);
            pictureBox30.Name = "pictureBox30";
            pictureBox30.Size = new Size(50, 42);
            pictureBox30.TabIndex = 164;
            pictureBox30.TabStop = false;
            pictureBox30.Tag = "wall";
            // 
            // pictureBox29
            // 
            pictureBox29.Location = new Point(75, 384);
            pictureBox29.Name = "pictureBox29";
            pictureBox29.Size = new Size(38, 42);
            pictureBox29.TabIndex = 163;
            pictureBox29.TabStop = false;
            pictureBox29.Tag = "wall";
            // 
            // pictureBox28
            // 
            pictureBox28.Location = new Point(75, 342);
            pictureBox28.Name = "pictureBox28";
            pictureBox28.Size = new Size(38, 42);
            pictureBox28.TabIndex = 162;
            pictureBox28.TabStop = false;
            pictureBox28.Tag = "wall";
            // 
            // pictureBox27
            // 
            pictureBox27.Location = new Point(75, 270);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(38, 76);
            pictureBox27.TabIndex = 161;
            pictureBox27.TabStop = false;
            pictureBox27.Tag = "wall";
            // 
            // pictureBox26
            // 
            pictureBox26.Location = new Point(75, 258);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(38, 19);
            pictureBox26.TabIndex = 160;
            pictureBox26.TabStop = false;
            pictureBox26.Tag = "wall";
            // 
            // pictureBox25
            // 
            pictureBox25.Location = new Point(75, 217);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(38, 42);
            pictureBox25.TabIndex = 159;
            pictureBox25.TabStop = false;
            pictureBox25.Tag = "wall";
            // 
            // pictureBox24
            // 
            pictureBox24.Location = new Point(125, 427);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(38, 42);
            pictureBox24.TabIndex = 158;
            pictureBox24.TabStop = false;
            pictureBox24.Tag = "wall";
            // 
            // pictureBox23
            // 
            pictureBox23.Location = new Point(239, 413);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(51, 56);
            pictureBox23.TabIndex = 157;
            pictureBox23.TabStop = false;
            pictureBox23.Tag = "wall";
            // 
            // pictureBox22
            // 
            pictureBox22.Location = new Point(201, 413);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(38, 56);
            pictureBox22.TabIndex = 156;
            pictureBox22.TabStop = false;
            pictureBox22.Tag = "wall";
            // 
            // pictureBox21
            // 
            pictureBox21.Location = new Point(163, 427);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(38, 42);
            pictureBox21.TabIndex = 155;
            pictureBox21.TabStop = false;
            pictureBox21.Tag = "wall";
            // 
            // pictureBox20
            // 
            pictureBox20.Location = new Point(163, 384);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(38, 42);
            pictureBox20.TabIndex = 154;
            pictureBox20.TabStop = false;
            pictureBox20.Tag = "wall";
            // 
            // pictureBox19
            // 
            pictureBox19.Location = new Point(163, 342);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(38, 42);
            pictureBox19.TabIndex = 153;
            pictureBox19.TabStop = false;
            pictureBox19.Tag = "wall";
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(163, 217);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(38, 42);
            pictureBox16.TabIndex = 150;
            pictureBox16.TabStop = false;
            pictureBox16.Tag = "wall";
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(151, 175);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(50, 42);
            pictureBox15.TabIndex = 149;
            pictureBox15.TabStop = false;
            pictureBox15.Tag = "wall";
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(113, 175);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(38, 42);
            pictureBox14.TabIndex = 148;
            pictureBox14.TabStop = false;
            pictureBox14.Tag = "wall";
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(75, 175);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(38, 42);
            pictureBox13.TabIndex = 147;
            pictureBox13.TabStop = false;
            pictureBox13.Tag = "wall";
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(-7, 469);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(38, 42);
            pictureBox12.TabIndex = 146;
            pictureBox12.TabStop = false;
            pictureBox12.Tag = "wall";
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(-7, 427);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(38, 42);
            pictureBox11.TabIndex = 145;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "wall";
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(-7, 384);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(38, 42);
            pictureBox10.TabIndex = 144;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "wall";
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(-7, 342);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(38, 42);
            pictureBox9.TabIndex = 143;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "wall";
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(-7, 300);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(38, 42);
            pictureBox8.TabIndex = 142;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "wall";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(-7, 258);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(38, 42);
            pictureBox7.TabIndex = 141;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "wall";
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(-7, 217);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 42);
            pictureBox6.TabIndex = 140;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "wall";
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(-7, 175);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 42);
            pictureBox5.TabIndex = 139;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "wall";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(-89, -36);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(82, 570);
            pictureBox4.TabIndex = 138;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "wall";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(793, -22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 554);
            pictureBox3.TabIndex = 137;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "wall";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(-34, 503);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(878, 58);
            pictureBox2.TabIndex = 136;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "wall";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-28, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(878, 58);
            pictureBox1.TabIndex = 135;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "wall";
            // 
            // picArea
            // 
            picArea.Location = new Point(-44, -30);
            picArea.Name = "picArea";
            picArea.Size = new Size(192, 192);
            picArea.TabIndex = 119;
            picArea.TabStop = false;
            picArea.Tag = "";

            Controls.Add(pictureBox113);
            Controls.Add(pictureBox112);
            Controls.Add(pictureBox110);
            Controls.Add(pictureBox109);
            Controls.Add(pictureBox108);
            Controls.Add(pictureBox107);
            Controls.Add(pictureBox106);
            Controls.Add(pictureBox105);
            Controls.Add(pictureBox104);
            Controls.Add(pictureBox103);
            Controls.Add(pictureBox102);
            Controls.Add(pictureBox101);
            Controls.Add(pictureBox100);
            Controls.Add(pictureBox99);
            Controls.Add(pictureBox98);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox56);
            Controls.Add(pictureBox46);
            Controls.Add(pictureBox37);
            Controls.Add(pictureBox97);
            Controls.Add(pictureBox96);
            Controls.Add(pictureBox95);
            Controls.Add(pictureBox94);
            Controls.Add(pictureBox93);
            Controls.Add(pictureBox92);
            Controls.Add(pictureBox91);
            Controls.Add(pictureBox90);
            Controls.Add(pictureBox89);
            Controls.Add(pictureBox88);
            Controls.Add(pictureBox87);
            Controls.Add(pictureBox86);
            Controls.Add(pictureBox85);
            Controls.Add(pictureBox84);
            Controls.Add(pictureBox83);
            Controls.Add(pictureBox82);
            Controls.Add(pictureBox78);
            Controls.Add(pictureBox77);
            Controls.Add(pictureBox76);
            Controls.Add(pictureBox75);
            Controls.Add(pictureBox74);
            Controls.Add(pictureBox73);
            Controls.Add(pictureBox72);
            Controls.Add(pictureBox71);
            Controls.Add(pictureBox70);
            Controls.Add(pictureBox69);
            Controls.Add(pictureBox68);
            Controls.Add(pictureBox67);
            Controls.Add(pictureBox66);
            Controls.Add(pictureBox65);
            Controls.Add(pictureBox64);
            Controls.Add(pictureBox63);
            Controls.Add(pictureBox62);
            Controls.Add(pictureBox61);
            Controls.Add(pictureBox60);
            Controls.Add(pictureBox59);
            Controls.Add(pictureBox57);
            Controls.Add(pictureBox58);
            Controls.Add(pictureBox33);
            Controls.Add(pictureBox31);
            Controls.Add(pictureBox55);
            Controls.Add(pictureBox54);
            Controls.Add(pictureBox53);
            Controls.Add(pictureBox52);
            Controls.Add(pictureBox51);
            Controls.Add(pictureBox50);
            Controls.Add(pictureBox49);
            Controls.Add(pictureBox48);
            Controls.Add(pictureBox47);
            Controls.Add(pictureBox45);
            Controls.Add(pictureBox44);
            Controls.Add(pictureBox43);
            Controls.Add(pictureBox42);
            Controls.Add(pictureBox41);
            Controls.Add(pictureBox40);
            Controls.Add(pictureBox39);
            Controls.Add(pictureBox38);
            Controls.Add(pictureBox36);
            Controls.Add(pictureBox35);
            Controls.Add(pictureBox34);
            Controls.Add(pictureBox32);
            Controls.Add(pictureBox30);
            Controls.Add(pictureBox29);
            Controls.Add(pictureBox28);
            Controls.Add(pictureBox27);
            Controls.Add(pictureBox26);
            Controls.Add(pictureBox25);
            Controls.Add(pictureBox24);
            Controls.Add(pictureBox23);
            Controls.Add(pictureBox22);
            Controls.Add(pictureBox21);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            #endregion
        }

        public void IniciaInimigo(PictureBox x)
        {
            if ((string)x.Tag == "inimigoDireita")
            {
                x.Image = imagensInimigo.imgDireita;
            }
            else if ((string)x.Tag == "inimigoEsquerda")
            {
                x.Image = imagensInimigo.imgEsquerda;
            }
            else if ((string)x.Tag == "inimigoCima")
            {
                x.Image = imagensInimigo.imgCima;
            }
            else if ((string)x.Tag == "inimigoBaixo")
            {
                x.Image = imagensInimigo.imgBaixo;
            }
        }

        public void CapturaSkinsSelecionadas()
        {
            imagensJogador = DadosSkin.CapturaSkin(DadosSkin.chaveJogador);
            imagensBala = DadosSkin.CapturaSkin(DadosSkin.chaveBala);
            imagensInimigo = DadosSkin.CapturaSkin(DadosSkin.chaveInimigo);

            //CRIAR CONTROLE DE EXCESSÃO
        }

        private void InvokeUI(Action a)
        {
            try
            {
                BeginInvoke(new MethodInvoker(a));
            }
            catch
            {

            }
        }

        private void FormClosed(object sender, FormClosingEventArgs e)
        {
            if (fechaJogo == false)
            {
                jogoPausado = true;
                DialogResult resposta = MessageBox.Show("Realmente deseja fechar o jogo? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resposta == DialogResult.No)
                {
                    e.Cancel = true;
                    jogoPausado = false;
                }
                else
                {
                    player.controls.stop();
                    PadraoDesligado();
                }
            }
        }

        public void CapturaColisoesTela()
        {
            if (Jogador.posicaoBaixo >= 500)
                ManipulaKey.podeBaixo = false;

            if (Jogador.posicaoCima <= 4)
                ManipulaKey.podeCima = false;

            if (Jogador.posicaoDireita >= 780)
                ManipulaKey.podeDireita = false;

            if (Jogador.posicaoEsquerda <= 0)
                ManipulaKey.podeEsquerda = false;
        }

        public void CapturaColisaoParede(Control x)
        {
            // Colisão com parede

            if (picArea.Bounds.Contains(x.Bounds))
            {
                int picEsquerda = x.Location.X;
                int picDireita = x.Location.X + x.Width;
                int picCima = x.Location.Y;
                int picBaixo = x.Location.Y + x.Height;

                // Colisão com a parte de baixo da parede
                if (Jogador.posicaoCima >= picBaixo - 2 && Jogador.posicaoCima <= picBaixo + 2 &&
                   Jogador.posicaoEsquerda <= picDireita - 2 && Jogador.posicaoDireita >= picEsquerda + 2)
                {
                    ManipulaKey.podeCima = false;
                }

                // Colisão com a parte de cima da parede
                if (picCima >= Jogador.posicaoBaixo - 2 && picCima <= Jogador.posicaoBaixo + 2 &&
                    Jogador.posicaoEsquerda <= picDireita - 2 && Jogador.posicaoDireita >= picEsquerda + 2)
                {
                    ManipulaKey.podeBaixo = false;
                }

                // Colisão com a parde da esquerda da parede
                if ((picDireita >= Jogador.posicaoEsquerda - 2 && picDireita <= Jogador.posicaoEsquerda + 2 &&
                   Jogador.posicaoCima <= picBaixo - 2 && Jogador.posicaoBaixo >= picCima + 2) || Jogador.posicaoEsquerda <= 0)
                {
                    ManipulaKey.podeEsquerda = false;
                }

                // Colisão com a parte da direita da parede
                if (picEsquerda >= Jogador.posicaoDireita - 2 && picEsquerda <= Jogador.posicaoDireita + 2 &&
                    Jogador.posicaoCima <= picBaixo - 2 && Jogador.posicaoBaixo >= picCima + 2)
                {
                    ManipulaKey.podeDireita = false;
                }
            }
        }
        public void CapturaColisoesGerais(Control x)
        {
            if ((string)x.Tag == "wall")
            {
                CapturaColisaoParede(x);
                CapturaColisaoBalaParede(x);
            }
        }

        public void CapturaColisaoBalaParede(Control x)
        {

            if (x.Bounds.IntersectsWith(picBala.Bounds))
            {
                Arma.existeBala = false;
                InvokeUI(() =>
                {
                    picBala.Dispose();
                    picBala.Location = new Point(1000, 1000);
                });
            }



        }

        public void CapturaColisaoBalaInimigo(Control x)
        {
            if ((string)x.Tag == "inimigoCima" || (string)x.Tag == "inimigoDireita" || (string)x.Tag == "inimigoBaixo" || (string)x.Tag == "inimigoEsquerda")
            {
                if (x.Bounds.IntersectsWith(picBala.Bounds))
                {
                    GlobalConfig.score += 2;
                    Arma.existeBala = false;
                    InvokeUI(() =>
                    {
                        picBala.Dispose();
                        picBala.Location = new Point(1000, 1000);
                        x.Dispose();
                        Inimigo.velocidade += Inimigo.iteraVelocidade;
                    });
                }
            }
        }

        public void AtualizaPosicaoJogador()
        {
            Jogador.posicaoBaixo = picJogador.Location.Y + picJogador.Height;
            Jogador.posicaoCima = picJogador.Location.Y;
            Jogador.posicaoDireita = picJogador.Location.X + picJogador.Width;
            Jogador.posicaoEsquerda = picJogador.Location.X;
        }

        public void MovimentaBala(Control x)
        {
            if (x == picBala && Arma.existeBala)
            {
                InvokeUI(() =>
                {
                    if ((string)x.Tag == "balacima")
                    {
                        x.Top -= Arma.velocidadeBala;
                    }
                    else if ((string)x.Tag == "balabaixo")
                    {
                        x.Top += Arma.velocidadeBala;
                    }
                    else if ((string)x.Tag == "baladireita")
                    {
                        x.Left += Arma.velocidadeBala;
                    }
                    else if ((string)x.Tag == "balaesquerda")
                    {
                        x.Left -= Arma.velocidadeBala;
                    }
                });
            }
        }

        public void CapturaChave(PictureBox x)
        {
            if ((string)x.Tag == "key")
            {
                if (picJogador.Bounds.IntersectsWith(x.Bounds))
                {
                    GlobalConfig.score += 2;
                    GlobalConfig.qntChavesAtuais++;
                    InvokeUI(() =>
                    {
                        x.Dispose();
                    });
                }
            }
        }

        public void VerificaVitoria()
        {
            if (picPorta.BackColor == Color.Gold && picPorta.Bounds.IntersectsWith(picJogador.Bounds))
            {
                Vitoria();
            }
        }

        public void VerificaGlitch(Control x)
        {
            if ((string)x.Tag == "wall" && x.Bounds.Contains(picJogador.Bounds) && !glitchOk)
            {
                PadraoDesligado();
                glitchOk = true;

                InvokeUI(() =>
                {
                    tempoDecorrido.Stop();
                    player.controls.pause();
                    PadraoDesligado();
                    frPerseguicao glitch = new frPerseguicao();
                    Hide();
                    glitch.ShowDialog();
                    Show();

                    tempoDecorrido.Start();
                    player.controls.play();
                    PadraoLigado();
                });
            }
        }

        public void ThreadJogo()
        {
            while (!gameOver)
            {
                try
                {
                    Thread.Sleep(20);
                    if (!jogoPausado)
                    {
                        AtualizaPosicaoJogador();

                        ManipulaKey.ResetPossibilidadeAndar();

                        CapturaColisoesTela();

                        foreach (Control x in Controls)
                        {
                            CapturaColisoesGerais(x);
                            VerificaGlitch(x);
                        }

                        foreach (PictureBox x in picMapa.Controls)
                        {
                            MovimentaBala(x);
                            InverteInimigo(x);
                            MoveInimigo(x);
                            CapturaChave(x);
                            ColideInimigoJogador(x);
                            CapturaColisaoBalaInimigo(x);
                        }



                        if (ManipulaKey.atira && !Arma.existeBala && Arma.qntBalas > 0)
                        {
                            Arma.qntBalas--;
                            InvokeUI(() =>
                            {
                                Arma.lado = Jogador.lado;
                                Atira();
                            });
                            Arma.existeBala = true;
                        }

                        InvokeUI(() =>
                        {
                            if (Imagens.trocaImagemJogador)
                            {
                                MudaImagemJogador();
                            }
                            MoveJogador();

                            lblQntBalas.Text = "Balas: " + Arma.qntBalas;
                            lblScore.Text = "Score: " + GlobalConfig.score;
                        });

                        if (GlobalConfig.qntChavesAtuais >= GlobalConfig.qntChaves)
                        {
                            picPorta.BackColor = Color.Gold;
                            GlobalConfig.qntChavesAtuais = 0;
                        }
                        VerificaVitoria();


                    }
                }
                catch
                {

                }

            }


        }

        public void ColideInimigoJogador(PictureBox x)
        {
            if ((string)x.Tag == "inimigoCima" || (string)x.Tag == "inimigoDireita" || (string)x.Tag == "inimigoBaixo" || (string)x.Tag == "inimigoEsquerda")
            {
                if (picJogador.Bounds.IntersectsWith(x.Bounds))
                {
                    Derrota();
                }
            }
        }

        public void Derrota()
        {
            player.controls.stop();
            GlobalConfig.dinheiro += GlobalConfig.scoreDerrota;
            string conteudo = $"dinheiro\n{GlobalConfig.dinheiro}";
            File.WriteAllText("dados.txt", conteudo);
            PadraoDesligado();

            MessageBox.Show($"Você perdeu! Seu score --> {GlobalConfig.scoreDerrota}");

            //player.Stop();

            InvokeUI(() =>
            {
                fechaJogo = true;
                Close();
            });


        }

        public void MudaImgeColideInimigo(PictureBox x)
        {
            if ((string)x.Tag == "inimigoDireita")
            {
                x.Tag = "inimigoEsquerda";
                InvokeUI(() =>
                {
                    x.Left -= Inimigo.velocidade;
                    x.Image = imagensInimigo.imgEsquerda;
                });
            }
            else if ((string)x.Tag == "inimigoEsquerda")
            {
                x.Tag = "inimigoDireita";
                InvokeUI(() =>
                {
                    x.Left += Inimigo.velocidade;
                    x.Image = imagensInimigo.imgDireita;
                });
            }
            else if ((string)x.Tag == "inimigoCima")
            {
                x.Tag = "inimigoBaixo";
                InvokeUI(() =>
                {
                    x.Top += Inimigo.velocidade;
                    x.Image = imagensInimigo.imgBaixo;
                });
            }
            else if ((string)x.Tag == "inimigoBaixo")
            {
                x.Tag = "inimigoCima";
                InvokeUI(() =>
                {
                    x.Top -= Inimigo.velocidade;
                    x.Image = imagensInimigo.imgCima;
                });
            }
        }

        public void InverteInimigo(PictureBox x)
        {
            try
            {
                foreach (Control y in Controls)
                {
                    if ((string)y.Tag == "wall" && x.Bounds.IntersectsWith(y.Bounds))
                    {
                        MudaImgeColideInimigo(x);
                    }
                }
            }
            catch
            {

            }
        }

        public void MudaImagemJogador()
        {
            picJogador.Image = Imagens.MudaImagem(imagensJogador, "jogador");
            Imagens.trocaImagemJogador = false;
        }

        public void Atira()
        {
            picBala = Arma.AtiraPicBox(Imagens.MudaImagem(imagensBala, "bala"));


            Controls.Add(picBala);
            picBala.Parent = picMapa;
            picBala.BringToFront();

        }

        public void MoveJogador()
        {
            if (ManipulaKey.jogadorCima && ManipulaKey.podeCima)
            {
                picJogador.Top -= Jogador.velocidade;
                picArea.Top -= Jogador.velocidade;
            }
            if (ManipulaKey.jogadorBaixo && ManipulaKey.podeBaixo)
            {
                picJogador.Top += Jogador.velocidade;
                picArea.Top += Jogador.velocidade;
            }

            if (ManipulaKey.jogadorEsquerda && ManipulaKey.podeEsquerda)
            {
                picJogador.Left -= Jogador.velocidade;
                picArea.Left -= Jogador.velocidade;
            }

            if (ManipulaKey.jogadorDireita && ManipulaKey.podeDireita)
            {
                picJogador.Left += Jogador.velocidade;
                picArea.Left += Jogador.velocidade;
            }
        }

        public void PadraoLigado()
        {
            gameOver = false;

            jogo = new Thread(ThreadJogo);
            jogo.Start();
        }

        public void PadraoJogador()
        {
            Jogador.velocidade = 4;

            picArea.Size = Jogador.tamanhoArea;
            picJogador.Size = Jogador.tamanhoJogador;

            picArea.Location = Jogador.localizacaoArea;
            picJogador.Location = Jogador.localizacaoJogador;
        }

        public void MoveInimigo(Control x)
        {

            if ((string)x.Tag == "inimigoDireita")
            {
                InvokeUI(() =>
                {
                    x.Left += Inimigo.velocidade;
                });
            }
            else if ((string)x.Tag == "inimigoEsquerda")
            {
                InvokeUI(() =>
                {
                    x.Left -= Inimigo.velocidade;
                });

            }
            else if ((string)x.Tag == "inimigoCima")
            {
                InvokeUI(() =>
                {
                    x.Top -= Inimigo.velocidade;
                });

            }
            else if ((string)x.Tag == "inimigoBaixo")
            {
                InvokeUI(() =>
                {
                    x.Top += Inimigo.velocidade;
                });

            }
        }

        public void PadraoDesligado()
        {
            gameOver = true;

            ManipulaKey.Reset();

            Imagens.trocaImagemJogador = false;

            Arma.Reset();
        }

        private void timerTempoTotal_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = Math.Truncate(tempoDecorrido.Elapsed.TotalSeconds).ToString();
        }

        private void lblTempo_Click(object sender, EventArgs e)
        {

        }

        public void Vitoria()
        {
            GlobalConfig.score += GlobalConfig.scoreVitoria;
            GlobalConfig.dinheiro += GlobalConfig.score;
            string conteudo = $"dinheiro\n{GlobalConfig.dinheiro}";
            File.WriteAllText("dados.txt", conteudo);
            tempoTotal = lblTempo.Text;

            PadraoDesligado();
            MessageBox.Show($"Você ganhou! Sua pontuacao --> {GlobalConfig.score}");
            InvokeUI(() =>
            {
                fechaJogo = true;
                player.controls.stop();
                Close();
                frSalvaRecorde salvaRecorde = new frSalvaRecorde();
                salvaRecorde.ShowDialog();
                Show();
            });
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            ManipulaKey.ValidaKeyUp(e.KeyCode);
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            ManipulaKey.ValidaKeyDown(e.KeyCode);
        }
    }
}