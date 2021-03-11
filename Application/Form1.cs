using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;

namespace Application
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream
                ("Application.uhoh.wav"));
            sp.Play();
        }

        private void monke_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 5);
            switch (num)
            {
                case 1:
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    SoundPlayer sp = new SoundPlayer(assembly.GetManifestResourceStream
                        ("Application.monke_1.wav"));
                    sp.Play();
                    break;

                case 2:
                    Assembly assembly2 = Assembly.GetExecutingAssembly();
                    SoundPlayer sp2 = new SoundPlayer(assembly2.GetManifestResourceStream
                        ("Application.monke_2.wav"));
                    sp2.Play();
                    break;

                case 3:
                    Assembly assembly3 = Assembly.GetExecutingAssembly();
                    SoundPlayer sp3 = new SoundPlayer(assembly3.GetManifestResourceStream
                        ("Application.monke_3.wav"));
                    sp3.Play();
                    break;

                case 4:
                    Assembly assembly4 = Assembly.GetExecutingAssembly();
                    SoundPlayer sp4 = new SoundPlayer(assembly4.GetManifestResourceStream
                        ("Application.monke_4.wav"));
                    sp4.Play();
                    break;
            }

        }
    }
}
