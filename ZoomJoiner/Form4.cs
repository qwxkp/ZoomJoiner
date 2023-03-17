﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomJoiner
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void Timer()
        {
            var t = Task.Delay(5000); //1 second/1000 ms ждет
            t.Wait(); // ждет
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private static void LeftMouseClick(int Xposition, int Yposition)
        {
            SetCursorPos(Xposition, Yposition);
            mouse_event(MOUSEEVENTF_LEFTDOWN, Xposition, Yposition, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Xposition, Yposition, 0, 0);
        }

        void NotifyIconshow()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = $"Working... ({DateTime.Now.DayOfWeek})";
            this.Visible = false;
            this.components = new System.ComponentModel.Container();
        }
        void NotifyIconhide()
        {

            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            notifyIcon1.Text = $"Have a nice day!";
            this.Visible = true;
            this.components = new System.ComponentModel.Container();
        }
        void AutoClick()
        {
            var t2 = Task.Delay(45000);
            t2.Wait();
            LeftMouseClick(132, 1049);
        }

        void AutoUrok1(string link)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(10);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }
        void AutoUrok2(string link, int time)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(time);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }
        void AutoUrok3(string link, int time)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(time);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }
        void AutoUrok4(string link, int time)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(time);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }
        void AutoUrok5(string link, int time)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(time);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }
        void AutoUrok6(string link, int time)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(time);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }
        void AutoUrok7(string link, int time)
        {
            var t = Task.Run(async delegate
            {
                await Task.Delay(time);
                return 42;
            });
            t.Wait();
            Process.Start($"{link}");
            AutoClick();
        }







        string jointext = "Joined!";
        public void ButtonUkr_Click(object sender, EventArgs e)
        {
            ButtonUkr.Enabled = false;
            ButtonUkr.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1"); // открывает ссылку
            Timer();
            ButtonUkr.Text = "Укр.Мова";
            ButtonUkr.Enabled = true; // возвращает в дефолт цвет
        }

        public void ButtonChemistry_Click(object sender, EventArgs e)
        {
            ButtonChemistry.Enabled = false;
            ButtonChemistry.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1"); // открывает ссылку
            Timer();
            ButtonChemistry.Text = "Химия";
            ButtonChemistry.Enabled = true; // возвращает в дефолт цвет
        }

        public void ButtonPravo_Click(object sender, EventArgs e)
        {
            ButtonPravo.Enabled = false;
            ButtonPravo.Text = jointext;
            Process.Start("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09"); // открывает ссылку
            Timer();
            ButtonPravo.Text = "Захист Вітчизни";
            ButtonPravo.Enabled = true; // возвращает в дефолт цвет

        }

        public void ButtonMath_Click(object sender, EventArgs e)
        {
            ButtonMath.Enabled = true;
            ButtonMath.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1");
            Timer();
            ButtonMath.Text = "Алгебра Геометрия";
            ButtonMath.Enabled = true;
        }

        public void ButtonBioliga_Click(object sender, EventArgs e)
        {
            ButtonBioliga.Enabled = false;
            ButtonBioliga.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1");
            Timer();
            ButtonBioliga.Text = "Биология";
            ButtonBioliga.Enabled = true; // возвращает в дефолт цвет
        }

        public void ButtonArt_Click(object sender, EventArgs e)
        {
            ButtonArt.Enabled = false;
            ButtonArt.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1");
            Timer();
            ButtonArt.Text = "Мистецтво";
            ButtonArt.Enabled = true; // возвращает в дефолт цвет

        }

        public void ButtonLibrary_Click(object sender, EventArgs e)
        {
            ButtonLibrary.Enabled = false;
            ButtonLibrary.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/73177828356?pwd=MHVKSjZ0cFNSMkt5a05qOXJyclRLUT09"); // открывает ссылку
            Timer();
            ButtonLibrary.Text = "Литра";
            ButtonLibrary.Enabled = true; // возвращает в дефолт цвет
        }

        public void ButtonGeugraphy_Click(object sender, EventArgs e)
        {
            ButtonGeugraphy.Enabled = false;
            ButtonGeugraphy.Text = jointext;
            Process.Start("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09"); // открывает ссылку
            Timer();
            ButtonGeugraphy.Text = "География";
            ButtonGeugraphy.Enabled = true; // включает, и ставит адекватный цвет
        }

        public void ButtonPhysics_Click(object sender, EventArgs e)
        {
            ButtonPhysics.Enabled = false;
            ButtonPhysics.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1"); // открывает ссылку
            Timer();
            ButtonPhysics.Text = "Физика";
            ButtonPhysics.Enabled = true; // включает, и ставит адекватный цвет
        }

        public void ButtonHistory_Click(object sender, EventArgs e)
        {
            ButtonHistory.Enabled = false;
            ButtonHistory.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1"); // открывает ссылку
            Timer();
            ButtonHistory.Text = "История";
            ButtonHistory.Enabled = true; // включает, и ставит адекватный цвет
        }

        public void ButtonEng_Click(object sender, EventArgs e)
        {
            ButtonEng.Enabled = false;
            ButtonEng.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1"); // открывает ссылку
            Timer();
            ButtonEng.Text = "Английский";
            ButtonEng.Enabled = true; // включает, и ставит адекватный цвет
        }

        public void ButtonOsvita_Click(object sender, EventArgs e)
        {
            ButtonOsvita.Enabled = false;
            ButtonOsvita.Text = jointext;
            Process.Start("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09"); // открывает ссылку
            Timer();
            ButtonOsvita.Text = "Громадянська освіта";
            ButtonOsvita.Enabled = true; // включает, и ставит адекватный цвет
        }


        public void ButtonTo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string checkboxx = "Working...";
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                if (DateTime.Now.Hour == 8 & DateTime.Now.Minute >= 25 & DateTime.Now.Minute <= 35)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok1("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09");
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok3("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok4("https://www.youtube.com/", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 9 & DateTime.Now.Minute >= 20 & DateTime.Now.Minute <= 30)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok3("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok4("https://web.telegram.org/z/", 3240000);
                    AutoUrok5("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute >= 15 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok3("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok4("https://web.telegram.org/z/", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 11 & DateTime.Now.Minute >= 10 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok4("https://web.telegram.org/z/", 100);
                    AutoUrok5("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 12 & DateTime.Now.Minute >= 5 & DateTime.Now.Minute <= 15)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok5("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1", 100);
                    AutoUrok6("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok6("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09", 100);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 14 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 100);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else
                {
                    Msgbox1("Попробуйте позже", "Error");
                }


            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                if (DateTime.Now.Hour == 8 & DateTime.Now.Minute >= 25 & DateTime.Now.Minute <= 35)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok1("https://us04web.zoom.us/j/73177828356?pwd=MHVKSjZ0cFNSMkt5a05qOXJyclRLUT09");
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok3("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok4("https://web.telegram.org/z/", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/77560815613?pwd=DnW2ZGGGL0h89VSjZaFaPWbZMIkjXX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 9 & DateTime.Now.Minute >= 20 & DateTime.Now.Minute <= 30)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok3("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok4("https://web.telegram.org/z/", 3240000);
                    AutoUrok5("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute >= 15 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok3("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 100);
                    AutoUrok4("https://web.telegram.org/z/", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 11 & DateTime.Now.Minute >= 10 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok4("https://web.telegram.org/z/", 100);
                    AutoUrok5("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 12 & DateTime.Now.Minute >= 5 & DateTime.Now.Minute <= 15)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok5("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 100);
                    AutoUrok6("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok6("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 100);
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 14 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok7("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 100);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else
                {
                    Msgbox1("Попробуйте позже", "Error");
                }



            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                if (DateTime.Now.Hour == 8 & DateTime.Now.Minute >= 25 & DateTime.Now.Minute <= 35)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok1("https://us04web.zoom.us/j/73177828356?pwd=MHVKSjZ0cFNSMkt5a05qOXJyclRLUT09");
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok3("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 3240000);
                    AutoUrok4("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3255000);
                    AutoUrok5("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 9 & DateTime.Now.Minute >= 20 & DateTime.Now.Minute <= 30)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok3("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 3240000);
                    AutoUrok4("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok5("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09",  3240000);
                    AutoUrok6("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1",3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute >= 15 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok3("https://us04web.zoom.us/j/72252888239?pwd=93bbPv3FHfqaSQWMAUbYeug8oaa1qs.1", 100);
                    AutoUrok4("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok5("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09",  3240000);
                    AutoUrok6("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 11 & DateTime.Now.Minute >= 10 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok4("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 100);
                    AutoUrok5("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09",  3240000);
                    AutoUrok6("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 12 & DateTime.Now.Minute >= 5 & DateTime.Now.Minute <= 15)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok5("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09", 100);
                    AutoUrok6("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok6("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 14 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok7("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 100);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else
                {
                    Msgbox1("Попробуйте позже", "Error");
                }

            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
            {

                if (DateTime.Now.Hour == 8 & DateTime.Now.Minute >= 25 & DateTime.Now.Minute <= 35)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok1("https://us04web.zoom.us/j/3626675144?pwd=YTBVMEJWcXZrVERqbHFNcEc4UE1qZz09");
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok3("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok4("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3255000);
                    AutoUrok5("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 9 & DateTime.Now.Minute >= 20 & DateTime.Now.Minute <= 30)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok2("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok3("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    AutoUrok4("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok5("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1",3240000);
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute >= 15 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok3("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    AutoUrok4("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3255000);
                    AutoUrok5("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1",3240000);
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 11 & DateTime.Now.Minute >= 10 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok4("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 100);
                    AutoUrok5("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1",3240000);
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 12 & DateTime.Now.Minute >= 5 & DateTime.Now.Minute <= 15)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok5("https://us05web.zoom.us/j/81793137250?pwd=dFEvM21GSHlmb05KYVlWeURJaTR2QT09", 100);
                    AutoUrok6("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1",3240000);
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok6("https://us04web.zoom.us/j/74535513574?pwd=ox6Yr29SKYjnnfrVf0Zy0MlAudaUf8.1", 100);
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 14 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok7("https://us04web.zoom.us/j/77139151153?pwd=t1NaCuhRdQhA6YglMRoql6dqF6d7cT.1", 100);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";

                }
                else
                {
                    Msgbox1("Попробуйте позже", "Error");
                }

            }

            else if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                if (DateTime.Now.Hour == 8 & DateTime.Now.Minute >= 25 & DateTime.Now.Minute <= 35)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok1("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1");
                    AutoUrok2("https://youtube.com", 3240000);
                    AutoUrok3("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok4("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 9 & DateTime.Now.Minute >= 20 & DateTime.Now.Minute <= 30)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok2("https://youtube.com", 100);
                    AutoUrok3("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 3240000);
                    AutoUrok4("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 10 & DateTime.Now.Minute >= 15 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok3("https://us04web.zoom.us/j/72161361348?pwd=azbctGwbaIjGEgcL5OiusFFfvLEH1r.1", 100);
                    AutoUrok4("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09", 3255000);
                    AutoUrok5("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 11 & DateTime.Now.Minute >= 10 & DateTime.Now.Minute <= 25)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok4("https://us05web.zoom.us/j/6764523122?pwd=YWtiWGdpRzZiWjE0WTlDb2lqTUpWQT09", 100);
                    AutoUrok5("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 3240000);
                    AutoUrok6("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 12 & DateTime.Now.Minute >= 5 & DateTime.Now.Minute <= 15)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok5("https://us04web.zoom.us/j/75913045961?pwd=qbtU4bFPc1ELoy842dk6hGXPZfI3OX.1", 100);
                    AutoUrok6("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 3240000);
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 13 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok6("https://us04web.zoom.us/j/7733527729?pwd=f780aruX8l4AhGSaWpBRj2sPs58jnx.1", 100);
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 3240000);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else if (DateTime.Now.Hour == 14 & DateTime.Now.Minute >= 0 & DateTime.Now.Minute <= 10)
                {
                    checkBox2.Text = checkboxx;
                    NotifyIconshow();
                    AutoUrok7("https://us04web.zoom.us/j/79248404114?pwd=AyLWCMjZnzxtI6ZTRRbpDQyYdXXSqy.1", 100);
                    var time = Task.Delay(10000);
                    time.Wait();
                    NotifyIconhide();
                    Msgbox1("Have a nice day!", "Woohoo!");
                    checkBox2.Text = "Done!";
                }
                else
                {
                    Msgbox1("Попробуйте позже", "Error");
                }

            }
            else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                Msgbox1("Bro, weekend, chill!", "Weekend");
            }
            else
            {
                Msgbox1("Попробуйте позже", "Error");
            }



            void Msgbox1(string name, string name2)
            {
                MessageBox.Show(name, name2, MessageBoxButtons.OK);
            }


        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Для того чтобы использовать авто-подключение\nНужно нажимать на checkbox приблизительно по расписанию (в начало урока)\n \n \nMade by Skedén#8149", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_MouseEnter_1(object sender, EventArgs e)
        {
            label1.Text = "           Click to Info...";
        }

        private void label1_MouseLeave_1(object sender, EventArgs e)
        {
            label1.Text = "Vladislav Priymak, v1.1.5";
        }
    }
}
