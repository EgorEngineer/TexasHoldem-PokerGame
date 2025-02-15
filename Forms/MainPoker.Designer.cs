using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Poker.Properties;
using Poker.Users;

namespace Poker
{
    partial class MainPoker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bFold = new System.Windows.Forms.Button();
            this.bCheck = new System.Windows.Forms.Button();
            this.bCall = new System.Windows.Forms.Button();
            this.bRaise = new System.Windows.Forms.Button();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.tbChips = new System.Windows.Forms.TextBox();
            this.tbBotChips5 = new System.Windows.Forms.TextBox();
            this.tbBotChips4 = new System.Windows.Forms.TextBox();
            this.tbBotChips3 = new System.Windows.Forms.TextBox();
            this.tbBotChips2 = new System.Windows.Forms.TextBox();
            this.tbBotChips1 = new System.Windows.Forms.TextBox();
            this.tbPot = new System.Windows.Forms.TextBox();
            this.bBB = new System.Windows.Forms.Button();
            this.tbSB = new System.Windows.Forms.TextBox();
            this.bSB = new System.Windows.Forms.Button();
            this.tbBB = new System.Windows.Forms.TextBox();
            this.b5Status = new System.Windows.Forms.Label();
            this.b4Status = new System.Windows.Forms.Label();
            this.b3Status = new System.Windows.Forms.Label();
            this.b2Status = new System.Windows.Forms.Label();
            this.b1Status = new System.Windows.Forms.Label();
            this.pStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRaise = new System.Windows.Forms.TextBox();
            this.pChipsTop = new System.Windows.Forms.Label();
            this.listStatistics = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрешениеЭкранаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклВыклМузыкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jingleJangleJingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigIronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueMoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loneStarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBlindsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerName = new System.Windows.Forms.Label();
            this.bot1Name = new System.Windows.Forms.Label();
            this.bot2Name = new System.Windows.Forms.Label();
            this.bot3Name = new System.Windows.Forms.Label();
            this.bot4Name = new System.Windows.Forms.Label();
            this.bot5Name = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bFold
            // 
            this.bFold.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFold.Location = new System.Drawing.Point(673, 929);
            this.bFold.Name = "bFold";
            this.bFold.Size = new System.Drawing.Size(130, 53);
            this.bFold.TabIndex = 0;
            this.bFold.Text = "Выход";
            this.bFold.UseVisualStyleBackColor = true;
            this.bFold.Click += new System.EventHandler(this.bFold_Click);
            // 
            // bCheck
            // 
            this.bCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCheck.Location = new System.Drawing.Point(830, 929);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(130, 53);
            this.bCheck.TabIndex = 2;
            this.bCheck.Text = "Чек";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // bCall
            // 
            this.bCall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCall.Location = new System.Drawing.Point(988, 929);
            this.bCall.Name = "bCall";
            this.bCall.Size = new System.Drawing.Size(130, 53);
            this.bCall.TabIndex = 3;
            this.bCall.Text = "Колл";
            this.bCall.UseVisualStyleBackColor = true;
            this.bCall.Click += new System.EventHandler(this.bCall_Click);
            // 
            // bRaise
            // 
            this.bRaise.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRaise.Location = new System.Drawing.Point(1152, 929);
            this.bRaise.Name = "bRaise";
            this.bRaise.Size = new System.Drawing.Size(130, 53);
            this.bRaise.TabIndex = 4;
            this.bRaise.Text = "Райз";
            this.bRaise.UseVisualStyleBackColor = true;
            this.bRaise.Click += new System.EventHandler(this.bRaise_Click);
            // 
            // pbTimer
            // 
            this.pbTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbTimer.BackColor = System.Drawing.SystemColors.Control;
            this.pbTimer.Location = new System.Drawing.Point(673, 890);
            this.pbTimer.Maximum = 1000;
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(610, 22);
            this.pbTimer.TabIndex = 5;
            this.pbTimer.Value = 1000;
            // 
            // tbChips
            // 
            this.tbChips.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbChips.Enabled = false;
            this.tbChips.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChips.Location = new System.Drawing.Point(1138, 763);
            this.tbChips.Multiline = true;
            this.tbChips.Name = "tbChips";
            this.tbChips.Size = new System.Drawing.Size(125, 20);
            this.tbChips.TabIndex = 6;
            this.tbChips.Text = "Фишки : 0";
            // 
            // tbBotChips5
            // 
            this.tbBotChips5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBotChips5.Enabled = false;
            this.tbBotChips5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBotChips5.Location = new System.Drawing.Point(1771, 599);
            this.tbBotChips5.Multiline = true;
            this.tbBotChips5.Name = "tbBotChips5";
            this.tbBotChips5.Size = new System.Drawing.Size(124, 20);
            this.tbBotChips5.TabIndex = 9;
            this.tbBotChips5.Text = "Фишки : 0";
            // 
            // tbBotChips4
            // 
            this.tbBotChips4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBotChips4.Enabled = false;
            this.tbBotChips4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBotChips4.Location = new System.Drawing.Point(1470, 192);
            this.tbBotChips4.Multiline = true;
            this.tbBotChips4.Name = "tbBotChips4";
            this.tbBotChips4.Size = new System.Drawing.Size(125, 20);
            this.tbBotChips4.TabIndex = 10;
            this.tbBotChips4.Text = "Фишки : 0";
            // 
            // tbBotChips3
            // 
            this.tbBotChips3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBotChips3.Enabled = false;
            this.tbBotChips3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBotChips3.Location = new System.Drawing.Point(456, 192);
            this.tbBotChips3.Multiline = true;
            this.tbBotChips3.Name = "tbBotChips3";
            this.tbBotChips3.Size = new System.Drawing.Size(125, 20);
            this.tbBotChips3.TabIndex = 11;
            this.tbBotChips3.Text = "Фишки : 0";
            // 
            // tbBotChips2
            // 
            this.tbBotChips2.Enabled = false;
            this.tbBotChips2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBotChips2.Location = new System.Drawing.Point(68, 301);
            this.tbBotChips2.Multiline = true;
            this.tbBotChips2.Name = "tbBotChips2";
            this.tbBotChips2.Size = new System.Drawing.Size(125, 20);
            this.tbBotChips2.TabIndex = 12;
            this.tbBotChips2.Text = "Фишки : 0";
            // 
            // tbBotChips1
            // 
            this.tbBotChips1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbBotChips1.Enabled = false;
            this.tbBotChips1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBotChips1.Location = new System.Drawing.Point(55, 732);
            this.tbBotChips1.Multiline = true;
            this.tbBotChips1.Name = "tbBotChips1";
            this.tbBotChips1.Size = new System.Drawing.Size(125, 20);
            this.tbBotChips1.TabIndex = 13;
            this.tbBotChips1.Text = "Фишки : 0";
            // 
            // tbPot
            // 
            this.tbPot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPot.Enabled = false;
            this.tbPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPot.Location = new System.Drawing.Point(902, 327);
            this.tbPot.Name = "tbPot";
            this.tbPot.Size = new System.Drawing.Size(125, 23);
            this.tbPot.TabIndex = 14;
            this.tbPot.Text = "0";
            // 
            // bBB
            // 
            this.bBB.Location = new System.Drawing.Point(0, 80);
            this.bBB.Name = "bBB";
            this.bBB.Size = new System.Drawing.Size(75, 23);
            this.bBB.TabIndex = 16;
            this.bBB.Text = "Большой блайнд";
            this.bBB.UseVisualStyleBackColor = true;
            this.bBB.Visible = false;
            this.bBB.Click += new System.EventHandler(this.bBB_Click);
            // 
            // tbSB
            // 
            this.tbSB.Location = new System.Drawing.Point(1, 55);
            this.tbSB.Name = "tbSB";
            this.tbSB.Size = new System.Drawing.Size(75, 20);
            this.tbSB.TabIndex = 17;
            this.tbSB.Text = "250";
            this.tbSB.Visible = false;
            // 
            // bSB
            // 
            this.bSB.Location = new System.Drawing.Point(0, 26);
            this.bSB.Name = "bSB";
            this.bSB.Size = new System.Drawing.Size(75, 23);
            this.bSB.TabIndex = 18;
            this.bSB.Text = "Малый блайнд";
            this.bSB.UseVisualStyleBackColor = true;
            this.bSB.Visible = false;
            this.bSB.Click += new System.EventHandler(this.bSB_Click);
            // 
            // tbBB
            // 
            this.tbBB.Location = new System.Drawing.Point(0, 109);
            this.tbBB.Name = "tbBB";
            this.tbBB.Size = new System.Drawing.Size(75, 20);
            this.tbBB.TabIndex = 19;
            this.tbBB.Text = "500";
            this.tbBB.Visible = false;
            // 
            // b5Status
            // 
            this.b5Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b5Status.Location = new System.Drawing.Point(1768, 622);
            this.b5Status.Name = "b5Status";
            this.b5Status.Size = new System.Drawing.Size(125, 30);
            this.b5Status.TabIndex = 26;
            // 
            // b4Status
            // 
            this.b4Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b4Status.Location = new System.Drawing.Point(1468, 217);
            this.b4Status.Name = "b4Status";
            this.b4Status.Size = new System.Drawing.Size(125, 30);
            this.b4Status.TabIndex = 27;
            // 
            // b3Status
            // 
            this.b3Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b3Status.Location = new System.Drawing.Point(456, 215);
            this.b3Status.Name = "b3Status";
            this.b3Status.Size = new System.Drawing.Size(125, 30);
            this.b3Status.TabIndex = 28;
            // 
            // b2Status
            // 
            this.b2Status.Location = new System.Drawing.Point(67, 324);
            this.b2Status.Name = "b2Status";
            this.b2Status.Size = new System.Drawing.Size(125, 30);
            this.b2Status.TabIndex = 31;
            // 
            // b1Status
            // 
            this.b1Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b1Status.Location = new System.Drawing.Point(53, 754);
            this.b1Status.Name = "b1Status";
            this.b1Status.Size = new System.Drawing.Size(125, 30);
            this.b1Status.TabIndex = 29;
            // 
            // pStatus
            // 
            this.pStatus.Location = new System.Drawing.Point(1137, 786);
            this.pStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(126, 47);
            this.pStatus.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(934, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Банк";
            // 
            // tbRaise
            // 
            this.tbRaise.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbRaise.Location = new System.Drawing.Point(1162, 988);
            this.tbRaise.Name = "tbRaise";
            this.tbRaise.Size = new System.Drawing.Size(108, 20);
            this.tbRaise.TabIndex = 0;
            // 
            // pChipsTop
            // 
            this.pChipsTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pChipsTop.Enabled = false;
            this.pChipsTop.Location = new System.Drawing.Point(0, 1067);
            this.pChipsTop.Name = "pChipsTop";
            this.pChipsTop.Size = new System.Drawing.Size(1920, 13);
            this.pChipsTop.TabIndex = 33;
            this.pChipsTop.Text = "label2";
            this.pChipsTop.Visible = false;
            // 
            // listStatistics
            // 
            this.listStatistics.HideSelection = false;
            this.listStatistics.Location = new System.Drawing.Point(1172, 552);
            this.listStatistics.Name = "listStatistics";
            this.listStatistics.Size = new System.Drawing.Size(243, 97);
            this.listStatistics.TabIndex = 34;
            this.listStatistics.UseCompatibleStateImageBehavior = false;
            this.listStatistics.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.разрешениеЭкранаToolStripMenuItem,
            this.вклВыклМузыкуToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1920, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // разрешениеЭкранаToolStripMenuItem
            // 
            this.разрешениеЭкранаToolStripMenuItem.Name = "разрешениеЭкранаToolStripMenuItem";
            this.разрешениеЭкранаToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.разрешениеЭкранаToolStripMenuItem.Text = "Разрешение экрана";
            this.разрешениеЭкранаToolStripMenuItem.Click += new System.EventHandler(this.разрешениеЭкранаToolStripMenuItem_Click);
            // 
            // вклВыклМузыкуToolStripMenuItem
            // 
            this.вклВыклМузыкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jingleJangleJingleToolStripMenuItem,
            this.bigIronToolStripMenuItem,
            this.blueMoonToolStripMenuItem,
            this.loneStarToolStripMenuItem,
            this.выключитьToolStripMenuItem});
            this.вклВыклМузыкуToolStripMenuItem.Name = "вклВыклМузыкуToolStripMenuItem";
            this.вклВыклМузыкуToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.вклВыклМузыкуToolStripMenuItem.Text = "Вкл/Выкл Музыку";
            // 
            // jingleJangleJingleToolStripMenuItem
            // 
            this.jingleJangleJingleToolStripMenuItem.Name = "jingleJangleJingleToolStripMenuItem";
            this.jingleJangleJingleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.jingleJangleJingleToolStripMenuItem.Text = "Jingle_Jangle_Jingle";
            this.jingleJangleJingleToolStripMenuItem.Click += new System.EventHandler(this.jingleJangleJingleToolStripMenuItem_Click);
            // 
            // bigIronToolStripMenuItem
            // 
            this.bigIronToolStripMenuItem.Name = "bigIronToolStripMenuItem";
            this.bigIronToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.bigIronToolStripMenuItem.Text = "Big Iron";
            this.bigIronToolStripMenuItem.Click += new System.EventHandler(this.bigIronToolStripMenuItem_Click);
            // 
            // blueMoonToolStripMenuItem
            // 
            this.blueMoonToolStripMenuItem.Name = "blueMoonToolStripMenuItem";
            this.blueMoonToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.blueMoonToolStripMenuItem.Text = "Blue Moon";
            this.blueMoonToolStripMenuItem.Click += new System.EventHandler(this.blueMoonToolStripMenuItem_Click);
            // 
            // loneStarToolStripMenuItem
            // 
            this.loneStarToolStripMenuItem.Name = "loneStarToolStripMenuItem";
            this.loneStarToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loneStarToolStripMenuItem.Text = "Lone Star";
            this.loneStarToolStripMenuItem.Click += new System.EventHandler(this.loneStarToolStripMenuItem_Click);
            // 
            // выключитьToolStripMenuItem
            // 
            this.выключитьToolStripMenuItem.Name = "выключитьToolStripMenuItem";
            this.выключитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.выключитьToolStripMenuItem.Text = "Выключить";
            this.выключитьToolStripMenuItem.Click += new System.EventHandler(this.выключитьToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsHelpToolStripMenuItem,
            this.editBlindsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.settingsToolStripMenuItem.Text = "Настройки/Помощь";
            // 
            // settingsHelpToolStripMenuItem
            // 
            this.settingsHelpToolStripMenuItem.Name = "settingsHelpToolStripMenuItem";
            this.settingsHelpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingsHelpToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.settingsHelpToolStripMenuItem.Text = "Настройки/Помощь";
            this.settingsHelpToolStripMenuItem.Click += new System.EventHandler(this.settingsHelpToolStripMenuItem_Click);
            // 
            // editBlindsToolStripMenuItem
            // 
            this.editBlindsToolStripMenuItem.Name = "editBlindsToolStripMenuItem";
            this.editBlindsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.editBlindsToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.editBlindsToolStripMenuItem.Text = "Задать блайнды";
            this.editBlindsToolStripMenuItem.Click += new System.EventHandler(this.editBlindsToolStripMenuItem_Click);
            // 
            // playerName
            // 
            this.playerName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerName.Location = new System.Drawing.Point(720, 665);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 36;
            this.playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bot1Name
            // 
            this.bot1Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot1Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bot1Name.Location = new System.Drawing.Point(67, 696);
            this.bot1Name.Name = "bot1Name";
            this.bot1Name.Size = new System.Drawing.Size(100, 20);
            this.bot1Name.TabIndex = 37;
            this.bot1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bot1Name.Visible = false;
            // 
            // bot2Name
            // 
            this.bot2Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot2Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bot2Name.Location = new System.Drawing.Point(78, 268);
            this.bot2Name.Name = "bot2Name";
            this.bot2Name.Size = new System.Drawing.Size(100, 20);
            this.bot2Name.TabIndex = 38;
            this.bot2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bot2Name.Visible = false;
            // 
            // bot3Name
            // 
            this.bot3Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot3Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bot3Name.Location = new System.Drawing.Point(481, 80);
            this.bot3Name.Name = "bot3Name";
            this.bot3Name.Size = new System.Drawing.Size(100, 20);
            this.bot3Name.TabIndex = 39;
            this.bot3Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bot3Name.Visible = false;
            // 
            // bot4Name
            // 
            this.bot4Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot4Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bot4Name.Location = new System.Drawing.Point(1330, 211);
            this.bot4Name.Name = "bot4Name";
            this.bot4Name.Size = new System.Drawing.Size(100, 20);
            this.bot4Name.TabIndex = 40;
            this.bot4Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bot4Name.Visible = false;
            // 
            // bot5Name
            // 
            this.bot5Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bot5Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot5Name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bot5Name.Location = new System.Drawing.Point(1780, 561);
            this.bot5Name.Name = "bot5Name";
            this.bot5Name.Size = new System.Drawing.Size(100, 20);
            this.bot5Name.TabIndex = 41;
            this.bot5Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bot5Name.Visible = false;
            // 
            // MainPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poker.Properties.Resources.deck;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.bot5Name);
            this.Controls.Add(this.bot4Name);
            this.Controls.Add(this.bot3Name);
            this.Controls.Add(this.bot2Name);
            this.Controls.Add(this.bot1Name);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.listStatistics);
            this.Controls.Add(this.pChipsTop);
            this.Controls.Add(this.tbRaise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b2Status);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.b1Status);
            this.Controls.Add(this.b3Status);
            this.Controls.Add(this.b4Status);
            this.Controls.Add(this.b5Status);
            this.Controls.Add(this.tbBB);
            this.Controls.Add(this.bSB);
            this.Controls.Add(this.tbSB);
            this.Controls.Add(this.bBB);
            this.Controls.Add(this.tbPot);
            this.Controls.Add(this.tbBotChips1);
            this.Controls.Add(this.tbBotChips2);
            this.Controls.Add(this.tbBotChips3);
            this.Controls.Add(this.tbBotChips4);
            this.Controls.Add(this.tbBotChips5);
            this.Controls.Add(this.tbChips);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.bRaise);
            this.Controls.Add(this.bCall);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.bFold);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::Poker.Properties.Resources.TexHoldIcon;
            this.KeyPreview = true;
            this.Name = "MainPoker";
            this.Text = "TexasHoldem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPoker_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button bFold;
        private Button bCheck;
        private Button bRaise;
        private ProgressBar pbTimer;
        private TextBox tbBotChips5;
        private TextBox tbBotChips4;
        private TextBox tbBotChips3;
        private TextBox tbBotChips2;
        private TextBox tbBotChips1;
        private Button bBB;
        private TextBox tbSB;
        private Button bSB;
        private TextBox tbBB;
        private Label b5Status;
        private Label b4Status;
        private Label b3Status;
        private Label b1Status;
        private Label pStatus;
        private Label b2Status;
        private Label label1;
        private TextBox tbRaise;
        private Label pChipsTop;
        public Button bCall;
        public ListView listStatistics;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem settingsHelpToolStripMenuItem;
        private ToolStripMenuItem editBlindsToolStripMenuItem;
        public TextBox tbChips;
        public TextBox tbPot;
        private Label playerName;
        private Label bot1Name;
        private Label bot2Name;
        private Label bot3Name;
        private Label bot4Name;
        private Label bot5Name;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem разрешениеЭкранаToolStripMenuItem;
        private ToolStripMenuItem вклВыклМузыкуToolStripMenuItem;
        private ToolStripMenuItem jingleJangleJingleToolStripMenuItem;
        private ToolStripMenuItem bigIronToolStripMenuItem;
        private ToolStripMenuItem blueMoonToolStripMenuItem;
        private ToolStripMenuItem loneStarToolStripMenuItem;
        private ToolStripMenuItem выключитьToolStripMenuItem;
    }
}

