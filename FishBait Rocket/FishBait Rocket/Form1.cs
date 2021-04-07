using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchAPI;

namespace FishBait_Rocket
{
    public partial class Form1 : Form
    {
        Arch dll = new Arch();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
                TopMost = true;
            else
                TopMost = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text;
            dll.Execute(script);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dll.Attach();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("bin");
            Directory.CreateDirectory("workspace");
            Directory.CreateDirectory("autoexec");
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                autoattach.Enabled = true;
            }
        }

        private void autoattach_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(7000);
            if (Arch.isRobloxOn())
            {
                if (!dll.isArchAttached())
                {
                    dll.Attach();
                }
                else
                {
                    return;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/3725149043/Super-Doomspire");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/6228356703/Minerscraft-Like-Minecraft");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/3851622790/Break-In-Story");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/2041312716/Ragdoll-Engine");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/4531385883/Alpha-Infection");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/606849621/CREWS-Jailbreak");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start("https://web.roblox.com/games/6447798030/ZARDY-Funky-Friday");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/fishbait-rocket/fishbait-rocket/main/vapehub.txt");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/fishbait-rocket/fishbait-rocket/main/sniffhub.txt");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/fishbait-rocket/fishbait-rocket/main/1k2hub.txt");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string vapehub = "loadstring(game: HttpGet(\"https://raw.githubusercontent.com/vep1032/VepStuff/main/Vape%20Hub\"))()";
            dll.Execute(vapehub);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string sniffhub = "loadstring(game:HttpGet(\'https://raw.githubusercontent.com/2dgeneralspam1/scripts-and-stuff/master/shit%20script%20pack/CheatX\'))()";
            dll.Execute(sniffhub);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string onektwohub = "loadstring(game:HttpGet(\"https://pastebin.com/raw/kmpN8iN9\"))();";
            dll.Execute(onektwohub);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string infyield = "loadstring(game:HttpGet(\'https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source\'))()";
            dll.Execute(infyield);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string uniaimbot = "loadstring(game:HttpGet(\"https://pastebin.com/raw/jz1PUQdh\"))()";
            dll.Execute(uniaimbot);
        }        private void button8_Click(object sender, EventArgs e)
        {
            string minerscraft = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/fishbait-rocket/fishbait-rocket/main/ROBLOX%20MINECRAFT%20KILL%20AURA%2C%20ANTI%20FALL%20DAMAGE%20%26%20FULLBRIGHT.txt\"))()";
            dll.Execute(minerscraft);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string breakin = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/Toxic-Mods/BreakInGUI/master/BreakInGUI.lua\"))();";
            dll.Execute(breakin);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ragdollengine = "loadstring(game:HttpGet((\'https://gitlab.com/Tsuniox/lua-stuff/-/raw/master/RagdollEngineGUI.lua\'),true))()";
            dll.Execute(ragdollengine);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string infection = "loadstring(game:HttpGet((\'https://raw.githubusercontent.com/fishbait-rocket/fishbait-rocket/main/infecsctript.txt\'))()";
            dll.Execute(infection);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string jailbreak = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/opBandwidth/_Paragon_/main/main.lua\"))()";
            dll.Execute(jailbreak);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string funkyfriday = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/fishbait-rocket/fishbait-rocket/main/Funky%20Friday%20AUTO%20PLAYER%20%5BMODIFIED%5D.txt\"))()";
            dll.Execute(funkyfriday);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            foreach (Process robloxProcess in Process.GetProcessesByName("RobloxPlayerBeta"))
                robloxProcess.Kill();
        }
    }
}
