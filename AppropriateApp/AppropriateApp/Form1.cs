using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace 適当なアプリ_
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("853535702259204096", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("853535702259204096", ref this.handlers, true, null);
            this.presence.details = "Running...";
            this.presence.state = "Preview Version v1.2";
            this.presence.largeImageKey = "tekitou1";
            this.presence.smallImageKey = "tekitou1";
            this.presence.largeImageText = "Created by WhistlerGamer";
            DiscordRpc.UpdatePresence(ref this.presence);
        }


        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        private void button1_Click(object sender, EventArgs e)
        {
            FakeSoftwareUpdateCreator fakesoft = new FakeSoftwareUpdateCreator();
            {
                fakesoft.Show();
            };
        }

        private void isATricToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            versioninfo versioninfo = new versioninfo();
            versioninfo.ShowDialog();
        }
    }
    }
    public class DiscordRpc
    {

        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
        public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);


        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
        public static extern void RunCallbacks();


        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
        public static extern void Shutdown();


        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
        public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

        internal static void Initialize(string v1, ref object handlers, bool v2, object p)
        {
            throw new NotImplementedException();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void DisconnectedCallback(int errorCode, string message);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ErrorCallback(int errorCode, string message);


        public struct EventHandlers
        {

            public DiscordRpc.ReadyCallback readyCallback;


            public DiscordRpc.DisconnectedCallback disconnectedCallback;


            public DiscordRpc.ErrorCallback errorCallback;
        }


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ReadyCallback();


        [Serializable]
        public struct RichPresence
        {

            public string state;


            public string details;


            public long startTimestamp;


            public long endTimestamp;


            public string largeImageKey;


            public string largeImageText;


            public string smallImageKey;


            public string smallImageText;


            public string partyId;


            public int partySize;


            public int partyMax;


            public string matchSecret;


            public string joinSecret;


            public string spectateSecret;


            public bool instance;

        }

    }

