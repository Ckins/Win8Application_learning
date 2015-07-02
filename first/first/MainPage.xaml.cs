using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace first
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private delegate string AnimalSaying(object sender, myEventArgs e); //声明一个委托
        private event AnimalSaying Say ; // 委托声明一个事件Say
        private string itsName = ""; //事件参数itsname
        public MainPage()
        {
            this.InitializeComponent();
        }

        class myEventArgs : EventArgs
        {
            public string tmpName = "";
            public myEventArgs(string t)
            {
                this.tmpName = t;
            }
        }

        interface Animal
        {
            //方法
            string saying(object sender, myEventArgs e);
            //属性

        }
        class pig : Animal
        {
            TextBlock word;
            public pig(TextBlock w) {
                this.word = w;
             }
            public string saying(object sender, myEventArgs e)
            {
                this.word.Text += e.tmpName + " : This is " + e.tmpName + " speaking.\n";
                return "";
            }
            
        }
        class cat : Animal
        {
            TextBlock word;
            public cat(TextBlock w) {
                this.word = w;
             }
            public string saying(object sender, myEventArgs e)
            {
                this.word.Text += "cat : " + "This is Cat speaking.\n";
                return "";
            }
            
        }
        class dog : Animal
        {
            TextBlock word;
            public dog(TextBlock w) {
                this.word = w;
            }
            public string saying(object sender, myEventArgs e)
            {
                this.word.Text += "dog : " + "This is Dog speaking.\n";
                return "";
            }
            
        }
        private cat c;
        private dog d;
        private pig p;

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            itsName = Input.Text;
            if (itsName == "cat") {

                c = new cat(words);

                //注册事件
                Say += new AnimalSaying(c.saying);

                //执行事件
                Say(this, new myEventArgs(itsName));//事件中传递参数itsName

                Say -= new AnimalSaying(c.saying);//注销事件*/
            }

            else if (itsName == "dog")
            {

                d = new dog(words);

                //注册事件
                Say += new AnimalSaying(d.saying);

                //执行事件
                Say(this, new myEventArgs(itsName));//事件中传递参数itsName

                Say -= new AnimalSaying(d.saying);//注销事件*/
            }

            else if (itsName == "pig")
            {

                p = new pig(words);

                //注册事件
                Say += new AnimalSaying(p.saying);

                //执行事件
                Say(this, new myEventArgs(itsName));//事件中传递参数itsName

                Say -= new AnimalSaying(p.saying);//注销事件*/
            }


            Input.Text = "";
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void Bt2_Click_1(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            int RandKey = ran.Next(1, 4);
            

            if (RandKey == 1)
            {

                c = new cat(words);

                //注册事件
                Say += new AnimalSaying(c.saying);

                //执行事件
                Say(this, new myEventArgs(itsName));//事件中传递参数itsName

                Say -= new AnimalSaying(c.saying);//注销事件*/
            }

            else if (RandKey == 2)
            {

                d = new dog(words);

                //注册事件
                Say += new AnimalSaying(d.saying);

                //执行事件
                Say(this, new myEventArgs(itsName));//事件中传递参数itsName

                Say -= new AnimalSaying(d.saying);//注销事件*/
            }

            else if (RandKey == 3)
            {
                itsName = "pig";
                p = new pig(words);

                //注册事件
                Say += new AnimalSaying(p.saying);

                //执行事件
                Say(this, new myEventArgs(itsName));//事件中传递参数itsName

                Say -= new AnimalSaying(p.saying);//注销事件*/
            }
        }     
    }
}

