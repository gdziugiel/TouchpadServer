using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TouchpadServer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private int port;
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point point);
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, uint dwExtraInfo);
        private const int lewyDol = 0x02;
        private const int lewyGora = 0x04;
        private const int srodkowyDol = 0x20;
        private const int srodkowyGora = 0x40;
        private const int prawyDol = 0x08;
        private const int prawyGora = 0x10;
        private const int kolko = 0x0800;
        private Thread watekPolacz, watekPozycja;
        private Socket polaczenie, gniazdo;
        private NetworkStream strumien;
        private string wiadomosc = "", poprzedniaWiadomosc = ".", tekst, przelacznikVal = "Off";
        private int ex = 0, ey = 0, ksx = 0, ksy = 0, kkx = 0, kky = 0;
        delegate void pozycjaDelegat();
        delegate void akcjaDelegat(string tekst);
        public Form1()
        {
            InitializeComponent();
        }
        private void polacz()
        {
            try
            {
                using (gniazdo = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp))
                {
                    gniazdo.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, 0);
                    gniazdo.Bind(new IPEndPoint(IPAddress.IPv6Any, port));
                    gniazdo.Listen(20);
                    while (true)
                    {
                        using (polaczenie = gniazdo.Accept())
                        using (strumien = new NetworkStream(polaczenie, true))
                        using (StreamWriter pisanie = new StreamWriter(strumien, Encoding.ASCII))
                        using (StreamReader czytanie = new StreamReader(strumien, Encoding.UTF8))
                        {
                            pozycja();
                            pisanie.WriteLine(ksx + " x " + ksy);
                            pisanie.Flush();
                            wiadomosc = czytanie.ReadLine();
                            if (wiadomosc != null)
                            {
                                if (wiadomosc.Equals("start"))
                                {
                                    pisanie.WriteLine(ex + " x " + ey);
                                    pisanie.Flush();
                                    akcja(wiadomosc);
                                }
                                else if (wiadomosc != poprzedniaWiadomosc)
                                {
                                    if (wiadomosc.Equals("lewy2"))
                                    {
                                        akcja("lewy");
                                    }
                                    else
                                    {
                                        akcja(wiadomosc);
                                    }
                                    poprzedniaWiadomosc = wiadomosc;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e) { }
        }
        private void pozycja()
        {
            Point punkt = new Point();
            GetCursorPos(out punkt);
            ksx = punkt.X;
            ksy = punkt.Y;
            if (this.pozycjaVal.InvokeRequired)
            {
                pozycjaDelegat delegat = new pozycjaDelegat(pozycja);
                this.Invoke(delegat, new object[] { });
            }
            else
            {
                this.pozycjaVal.Text = "x: " + ksx + " | y: " + ksy;
            }
        }
        private void akcja(String wiadomosc)
        {
            switch (wiadomosc)
            {
                case "lewy":
                    mouse_event(lewyDol | lewyGora, kkx, kky, 0, 0);
                    tekst = "Lewy przycisk";
                    break;
                case "srodkowy":
                    mouse_event(srodkowyDol | srodkowyGora, kkx, kky, 0, 0);
                    tekst = "Środkowy przycisk";
                    break;
                case "prawy":
                    mouse_event(prawyDol | prawyGora, kkx, kky, 0, 0);
                    tekst = "Prawy przycisk";
                    break;
                case "przytrzymanieWlacz":
                    mouse_event(lewyDol, kkx, kky, 0, 0);
                    tekst = "Przytrzymywanie";
                    break;
                case "przytrzymanieWylacz":
                    mouse_event(lewyGora, kkx, kky, 0, 0);
                    tekst = "Przytrzymywanie";
                    break;
                case "start":
                    tekst = "Klient podłączony";
                    break;
                case "stop":
                    tekst = "Klient odłączony";
                    break;
                default:
                    if (wiadomosc[0] == 'k')
                    {
                        wiadomosc = wiadomosc.Substring(1);
                        mouse_event(kolko, 0, 0, Int32.Parse(wiadomosc), 0);
                        tekst = "Ruch kółkiem";
                    }
                    else
                    {
                        String[] xy = wiadomosc.Split('x');
                        kkx = int.Parse(xy[0]);
                        kky = int.Parse(xy[1]);
                        SetCursorPos(kkx, kky);
                        wyswietlPozycje();
                        tekst = "Ruch";
                    }
                    break;
            }
            wpiszTekst(tekst);
        }
        private string getIp()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in hostEntry.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }
        private string getNazwa()
        {
            return Dns.GetHostName();
        }
        private void rozdzielczosc()
        {
            ex = Screen.PrimaryScreen.Bounds.Width;
            ey = Screen.PrimaryScreen.Bounds.Height;
            this.rozdzielczoscVal.Text = ex + " x " + ey;
        }
        private void wyswietlPozycje()
        {
            ksx = kkx;
            ksy = kky;
            if (this.pozycjaVal.InvokeRequired)
            {
                pozycjaDelegat delegat = new pozycjaDelegat(wyswietlPozycje);
                this.Invoke(delegat, new object[] { });
            }
            else
            {
                this.pozycjaVal.Text = "x: " + ksx + " | y: " + ksy;
            }
        }
        private void wpiszTekst(String tekst)
        {
            if (this.akcjaVal.InvokeRequired)
            {
                akcjaDelegat delegat = new akcjaDelegat(wpiszTekst);
                this.Invoke(delegat, new object[] { tekst });
            }
            else
            {
                this.akcjaVal.Text = tekst;
            }
        }
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            przelacznikVal = this.przelacznik.Text;
            if (przelacznikVal.Equals("On"))
            {
                if (portVal.Text != "")
                {
                    port = Convert.ToInt32(portVal.Text);
                    if (port >= 49152 && port <= 65535)
                    {
                        this.portVal.Enabled = false;
                        watekPolacz = new Thread(polacz);
                        watekPolacz.Start();
                        this.nazwaVal.Text = getNazwa();
                        this.ipVal.Text = getIp();
                        rozdzielczosc();
                        watekPozycja = new Thread(pozycja);
                        watekPozycja.Start();
                        this.akcjaVal.Text = "Włączono";
                    }
                    else
                    {
                        this.akcjaVal.Text = "Nieprawidłowy port";
                        this.przelacznik.Checked = false;
                    }
                }
                else
                {
                    this.akcjaVal.Text = "Wprowadź port";
                    this.przelacznik.Checked = false;
                }
            }
            else
            {
                if (!this.akcjaVal.Text.Equals("Nieprawidłowy port") && !this.akcjaVal.Text.Equals("Wprowadź port"))
                {
                    gniazdo.Close();
                    if (strumien != null)
                    {
                        strumien.Flush();
                        strumien.Dispose();
                    }
                    watekPolacz.Join();
                    watekPozycja.Join();
                    this.portVal.Enabled = true;
                    this.nazwaVal.Text = "";
                    this.ipVal.Text = "0.0.0.0";
                    this.rozdzielczoscVal.Text = "0 x 0";
                    this.pozycjaVal.Text = "x: 0 | y: 0";
                    this.akcjaVal.Text = "Wyłączono";
                }
            }
        }
        private void info_Click(object sender, EventArgs e)
        {
            Form2 info = new Form2();
            info.Show();
        }
        private void portVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
