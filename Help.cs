using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker
{
    public partial class Help : Form
    {
        private readonly List<Bitmap> _rotateBacks = new List<Bitmap>();
        private readonly List<Bitmap> _rotatePacks = new List<Bitmap>();

        public string NewPack { get; set; }
        public string NewBack { get; set; }

 
        private readonly List<string> pressedButtons = new List<string>();
        private readonly List<string> buttonNames = new List<string> { "HowButtons", "CombButtons", "HotButtons", "AButtons", "SButtons" };
        private readonly List<Panel> _panels = new List<Panel>();
        private Button[] howButtons = new Button[3];
        private Button[] combButtons = new Button[1];
        private Button[] hotButtons = new Button[1];
        private Button[] aButtons = new Button[3];
        private Button[] sButtons = new Button[1];
        private Button[] achiButtons = new Button[1];

        public Help()
        {
            InitializeComponent();
        }

        private readonly MainPoker _mainForm;

        public Help(Form callingForm)
        {
            _mainForm = callingForm as MainPoker;
            InitializeComponent();
        }

        private void bHow_Click(object sender, EventArgs e)
        {
            var buttonNames = new List<string> { "Раздача карт", "Блайнды", "Стадии игры" };
            var labelTexts = new List<string>
            {
                @"Assets\Help\How To Play\EHtexts\EHtext1.txt",
                @"Assets\Help\How To Play\EHtexts\EHtext2.txt",
                @"Assets\Help\How To Play\EHtexts\EHtext3.txt"
            };
            CheckHs("HowButtons", buttonNames, ref howButtons, 3);
            pHot.Visible = false;
            pCombinations.Visible = false;
            pSettings.Visible = false;
            DisplayText(ref howButtons, labelTexts, tbH1);
        }
        private void bCombinations_Click(object sender, EventArgs e)
        {
            List<string> buttonNames = new List<string> { "Комбинации" };
            CheckHs("CombButtons", buttonNames, ref combButtons, 1);
            HidePanels(pCombinations);
        }
        private void bHotkeys_Click(object sender, EventArgs e)
        {
            List<string> buttonNames = new List<string> { "Горячие клавиши" };
            CheckHs("HotButtons", buttonNames, ref hotButtons, 1);
            HidePanels(pHot);
        }
        private void bSettings_Click(object sender, EventArgs e)
        {
            List<string> buttonNames = new List<string> { "Настройки" };
            CheckHs("SButtons", buttonNames, ref sButtons, 1);
            HidePanels(pSettings);
        }

        private void HidePanels(IDisposable currentPanel)
        {
            tbH1.Visible = false;
            int visiblePanel = 0;
            for (int i = 0; i < _panels.Count; i++)
            {
                if (Equals(currentPanel, _panels[i]))
                    visiblePanel = i;
            }
            foreach (var panel in _panels)
            {
                panel.Visible = false;
            }
            _panels[visiblePanel].Location = new Point(lbTopLine.Location.X, lbTopLine.Location.Y + 5);
            _panels[visiblePanel].Visible = !_panels[visiblePanel].Visible;
        }

        private Button[] CreatingButtons(int n, IReadOnlyList<string> names)
        {
            Button[] buttons = new Button[n];
            const int height = 33;
            int width = lbTopLine.Width / buttons.Length;
            int horizontal = lbTopLine.Location.X;
            int vertical = lbTopLine.Location.Y - height;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button
                {
                    Height = height,
                    Width = width
                };
                Controls.Add(buttons[i]);
                buttons[i].Text = names[i];
                buttons[i].TextAlign = ContentAlignment.MiddleCenter;
                buttons[i].Location = new Point(horizontal, vertical);
                horizontal += buttons[i].Width;
            }
            return buttons;
        }

        private void CheckHs(string current, IReadOnlyList<string> currentButtonNames, ref Button[] buttonArray, int n)
        {
            if (!pressedButtons.Contains(current))
            {
                pressedButtons.Add(current);
                buttonArray = CreatingButtons(n, currentButtonNames);
            }
            else
            {
                foreach (Button t in buttonArray)
                {
                    t.Visible = false;
                }
                pressedButtons.Clear();
            }
            if (pressedButtons.ToArray().Length > 1)
            {
                pressedButtons.Remove(current);
                for (int i = 0; i < buttonNames.ToArray().Length; i++)
                {
                    if (pressedButtons[0] != buttonNames[i]) continue;
                    HideB(0, i);
                    HideB(1, i);
                    HideB(2, i);
                    HideB(3, i);
                    HideB(4, i);
                    HideB(5, i);
                    break;
                }
                pressedButtons.Clear();
                pressedButtons.Add(current);
            }
        }
        private void HideB(int x, int i)
        {
            var hideButtons = new Button[1];
            if (x == 0)
            {
                hideButtons = howButtons;
            }
            if (x == 1)
            {
                hideButtons = combButtons;
            }
            if (x == 2)
            {
                hideButtons = hotButtons;
            }
            if (x == 3)
            {
                hideButtons = aButtons;
            }
            if (x == 4)
            {
                hideButtons = sButtons;
            }
            if (i == x)
            {
                foreach (Button t in hideButtons)
                {
                    t.Visible = false;
                }
            }
        }

        private static void DisplayText(ref Button[] arrayB, IReadOnlyList<string> paths, TextBox display)
        {
            for (int i = 0; i < arrayB.Length; i++)
            {
                int j = i;
                arrayB[j].Click += (o, k) =>
                {
                    using (var streamReader = new StreamReader(paths[j], Encoding.UTF8))
                    {
                        display.Visible = true;
                        display.Text = streamReader.ReadToEnd();
                    }
                };
            }
        }

        private static void DisplayText(ref Button[] arrayB, IReadOnlyList<Panel> panels)
        {
            if (arrayB.Length > 1)
            {
                for (int i = 0; i < arrayB.Length; i++)
                {
                    int j = i;
                    arrayB[j].Click += (o, k) =>
                    {
                        panels[j].Visible = true;
                        try
                        {
                            panels[j - 1].Visible = false;
                        }
                        catch (Exception)
                        {
                            panels[j + 1].Visible = false;
                        }
                    };
                }
            }
            else
            {
                arrayB[0].Click += (o, k) =>
                {
                    panels[0].Visible = true;
                };
            }
        }
        
        private void bReset_Click(object sender, EventArgs e)
        {
            HotFold.Text = @"S";
            HotCheck.Text = @"A";
            HotCall.Text = @"D";
            HotRaise.Text = @"W";
            Properties.Settings.Default.FoldHotkey = "S";
            Properties.Settings.Default.CheckHotkey = "A";
            Properties.Settings.Default.CallHotkey = "D";
            Properties.Settings.Default.RaiseHotkey = "W";
            Properties.Settings.Default.Save();
            MessageBox.Show(@"Горячие клавиши возвращены к стандартным значениям.","Горячие клавиши");
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            bool finish = false;
            string[] duplicates = { HotFold.Text, HotCheck.Text, HotCall.Text, HotRaise.Text };
            for (int i = 0; i < duplicates.Length; i++)
            {
                for (int j = i + 1; j < duplicates.Length; j++)
                {
                    if (duplicates[i] != duplicates[j] && duplicates[i] != duplicates[j].ToUpper() &&
                        duplicates[i].ToUpper() != duplicates[j]) continue;
                    if (finish) continue;
                    MessageBox.Show(@"Вы можете назначить только одну клавишу на каждое действие!", "Горячие клавиши");
                    bReset_Click(sender, e);
                    finish = true;
                }
            }
            if (finish) return;
            if (HotFold.Text.Length > 1 || HotCheck.Text.Length > 1 ||
                HotCall.Text.Length > 1 || HotRaise.Text.Length > 1)
            {
                MessageBox.Show(@"Нельзя назначить комбинацию клавиш в качестве горячей клавиши !","Горячие клавиши");
                bReset_Click(sender, e);
            }
            else
            {
                Properties.Settings.Default.FoldHotkey = HotFold.Text;
                Properties.Settings.Default.CheckHotkey = HotCheck.Text;
                Properties.Settings.Default.CallHotkey = HotCall.Text;
                Properties.Settings.Default.RaiseHotkey = HotRaise.Text;
                Properties.Settings.Default.Save();
                AutoCloseMsb.Show("Изменения сохранены!", "Горячие клавиши", 2000);
            }
        }

        public static string ConvertString(int? number)
        {
            string newNumber = number + "";
            if (number < 1000 && number > 0)
            {
                newNumber = number + "";
            }

            if (number > 999)
            {
                newNumber = number / 1000 + "k";
            }
            return newNumber;
        }

        private void Help_Load(object sender, EventArgs e)
        {
            _panels.Add(pCombinations);
            _panels.Add(pSettings);
            _panels.Add(pHot);

            ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;

            tbThink.Text = (Properties.Settings.Default.ThinkingTime / 1000).ToString();
            HotFold.Text = Properties.Settings.Default.FoldHotkey;
            HotCheck.Text = Properties.Settings.Default.CheckHotkey;
            HotCall.Text = Properties.Settings.Default.CallHotkey;
            HotRaise.Text = Properties.Settings.Default.RaiseHotkey;
            cbStatistics.Checked = Properties.Settings.Default.Statistics;

            if (Properties.Settings.Default.ThinkCheck)
            {
                cbThinkTime.Checked = true;
                cbSkipThinkTime.Checked = false;
                pThink.Visible = true;
            }

            else
            {
                cbThinkTime.Checked = false;
                cbSkipThinkTime.Checked = true;
                pThink.Visible = false;
            }
        }

        public void cbStatistics_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStatistics.Checked)
            {
                _mainForm.listStatistics.Visible = true;
                Properties.Settings.Default.Statistics = true;
            }

            else
            {
                _mainForm.listStatistics.Visible = false;
                Properties.Settings.Default.Statistics = false;
            }
            Properties.Settings.Default.Save();
        }
        private void bClearStatistics_Click(object sender, EventArgs e)
        {
            _mainForm.Folds = 0;
            _mainForm.WonHands = 0;
            _mainForm.LostHands = 0;
            _mainForm.PlayedHands1 = 0;
            _mainForm.UpdateStatistics(_mainForm.Folds, _mainForm.PlayedHands1, _mainForm.LostHands, _mainForm.WonHands);
        }
        private void cbThinkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbThinkTime.Checked)
            {
                cbSkipThinkTime.Checked = false;
                pThink.Visible = true;
                Properties.Settings.Default.ThinkCheck = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                cbSkipThinkTime.Checked = false;
                pThink.Visible = false;
                Properties.Settings.Default.ThinkCheck = false;
                Properties.Settings.Default.Save();
            }
        }
        private void cbSkipThinkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSkipThinkTime.Checked)
            {
                cbThinkTime.Checked = false;
                Properties.Settings.Default.ThinkingTime = 3000;
                tbThink.Text = (Properties.Settings.Default.ThinkingTime / 1000).ToString();
                Properties.Settings.Default.Save();
            }
            else
            {
                cbThinkTime.Checked = true;
                pThink.Visible = true;
            }
        }
        private void bThinkTime_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(tbThink.Text, out parsedValue))
            {
                MessageBox.Show(@"Можно вводить только цифры или числа","Время на подумать");
            }
            else
            {
                if (int.Parse(tbThink.Text) <= 0 || int.Parse(tbThink.Text) > 100)
                {
                    MessageBox.Show(@"Можно вводить числа из интервала от 0 до 100.", "Время на подумать");
                }

                else
                {
                    MainPoker.ThinkTime = int.Parse(tbThink.Text) * 1000;
                    AutoCloseMsb.Show("Изменения сохранены !", "Время на подумать", 2000);
                    Properties.Settings.Default.ThinkingTime = MainPoker.ThinkTime;
                    Properties.Settings.Default.Save();

                }
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            MainPoker.Updates.Start();
            MainPoker.Timer.Start();
        }

        public static unsafe bool AreEqual(Bitmap b1, Bitmap b2) 
        {
            if (b1 == b2)
                return true;
            if (b1.Size != b2.Size || b1.PixelFormat != b2.PixelFormat)
                return false;

            Rectangle rect = new Rectangle(0, 0, b1.Width, b1.Height);
            BitmapData data1
                = b1.LockBits(rect, ImageLockMode.ReadOnly, b1.PixelFormat);
            BitmapData data2
                = b2.LockBits(rect, ImageLockMode.ReadOnly, b1.PixelFormat);
            int* p1 = (int*)data1.Scan0;
            int* p2 = (int*)data2.Scan0;
            int byteCount = b1.Height * data1.Stride / 4; 

            bool result = true;
            for (int i = 0; i < byteCount; ++i)
            {
                if (*p1++ == *p2++) continue;
                result = false;
                break;
            }

            b1.UnlockBits(data1);
            b2.UnlockBits(data2);

            return result;
        }

        private void bAbout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}