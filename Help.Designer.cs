using System.ComponentModel;
using System.Windows.Forms;

namespace Poker
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.lbLeftLine = new System.Windows.Forms.Label();
            this.lbTopLine = new System.Windows.Forms.Label();
            this.bHow = new System.Windows.Forms.Button();
            this.bHotkeys = new System.Windows.Forms.Button();
            this.bCombinations = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pCombinations = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pHot = new System.Windows.Forms.Panel();
            this.bReset = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.HotFold = new System.Windows.Forms.TextBox();
            this.HotCheck = new System.Windows.Forms.TextBox();
            this.HotCall = new System.Windows.Forms.TextBox();
            this.HotRaise = new System.Windows.Forms.TextBox();
            this.LRaise = new System.Windows.Forms.Label();
            this.LCall = new System.Windows.Forms.Label();
            this.LCheck = new System.Windows.Forms.Label();
            this.Lintro = new System.Windows.Forms.Label();
            this.LFold = new System.Windows.Forms.Label();
            this.bSettings = new System.Windows.Forms.Button();
            this.pSettings = new System.Windows.Forms.Panel();
            this.pThink = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbThink = new System.Windows.Forms.TextBox();
            this.bThinkTime = new System.Windows.Forms.Button();
            this.cbSkipThinkTime = new System.Windows.Forms.CheckBox();
            this.cbThinkTime = new System.Windows.Forms.CheckBox();
            this.bClearStatistics = new System.Windows.Forms.Button();
            this.cbStatistics = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbH1 = new System.Windows.Forms.TextBox();
            this.pCombinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pHot.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.pThink.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLeftLine
            // 
            this.lbLeftLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLeftLine.Location = new System.Drawing.Point(227, 12);
            this.lbLeftLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLeftLine.Name = "lbLeftLine";
            this.lbLeftLine.Size = new System.Drawing.Size(2, 393);
            this.lbLeftLine.TabIndex = 0;
            // 
            // lbTopLine
            // 
            this.lbTopLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTopLine.Location = new System.Drawing.Point(240, 49);
            this.lbTopLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTopLine.Name = "lbTopLine";
            this.lbTopLine.Size = new System.Drawing.Size(513, 2);
            this.lbTopLine.TabIndex = 1;
            // 
            // bHow
            // 
            this.bHow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bHow.Location = new System.Drawing.Point(16, 61);
            this.bHow.Margin = new System.Windows.Forms.Padding(4);
            this.bHow.Name = "bHow";
            this.bHow.Size = new System.Drawing.Size(203, 41);
            this.bHow.TabIndex = 2;
            this.bHow.Text = "Как играть";
            this.bHow.UseVisualStyleBackColor = true;
            this.bHow.Click += new System.EventHandler(this.bHow_Click);
            // 
            // bHotkeys
            // 
            this.bHotkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bHotkeys.Location = new System.Drawing.Point(17, 186);
            this.bHotkeys.Margin = new System.Windows.Forms.Padding(4);
            this.bHotkeys.Name = "bHotkeys";
            this.bHotkeys.Size = new System.Drawing.Size(203, 41);
            this.bHotkeys.TabIndex = 3;
            this.bHotkeys.Text = "Горячие клавиши";
            this.bHotkeys.UseVisualStyleBackColor = true;
            this.bHotkeys.Click += new System.EventHandler(this.bHotkeys_Click);
            // 
            // bCombinations
            // 
            this.bCombinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCombinations.Location = new System.Drawing.Point(16, 122);
            this.bCombinations.Margin = new System.Windows.Forms.Padding(4);
            this.bCombinations.Name = "bCombinations";
            this.bCombinations.Size = new System.Drawing.Size(203, 41);
            this.bCombinations.TabIndex = 4;
            this.bCombinations.Text = "Комбинации";
            this.bCombinations.UseVisualStyleBackColor = true;
            this.bCombinations.Click += new System.EventHandler(this.bCombinations_Click);
            // 
            // bAbout
            // 
            this.bAbout.Location = new System.Drawing.Point(16, 361);
            this.bAbout.Margin = new System.Windows.Forms.Padding(4);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(209, 44);
            this.bAbout.TabIndex = 15;
            this.bAbout.Text = "Закрыть меню";
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, -1);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Помошник по игре в Техасский Холдем";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCombinations
            // 
            this.pCombinations.AutoScroll = true;
            this.pCombinations.Controls.Add(this.textBox1);
            this.pCombinations.Controls.Add(this.pictureBox1);
            this.pCombinations.Controls.Add(this.textBox2);
            this.pCombinations.Controls.Add(this.pictureBox2);
            this.pCombinations.Controls.Add(this.textBox3);
            this.pCombinations.Controls.Add(this.pictureBox3);
            this.pCombinations.Controls.Add(this.textBox4);
            this.pCombinations.Controls.Add(this.pictureBox4);
            this.pCombinations.Controls.Add(this.textBox5);
            this.pCombinations.Controls.Add(this.pictureBox5);
            this.pCombinations.Controls.Add(this.textBox6);
            this.pCombinations.Controls.Add(this.pictureBox6);
            this.pCombinations.Controls.Add(this.textBox7);
            this.pCombinations.Controls.Add(this.pictureBox7);
            this.pCombinations.Controls.Add(this.textBox8);
            this.pCombinations.Controls.Add(this.pictureBox8);
            this.pCombinations.Controls.Add(this.textBox9);
            this.pCombinations.Controls.Add(this.pictureBox9);
            this.pCombinations.Location = new System.Drawing.Point(1071, 11);
            this.pCombinations.Margin = new System.Windows.Forms.Padding(4);
            this.pCombinations.Name = "pCombinations";
            this.pCombinations.Size = new System.Drawing.Size(513, 338);
            this.pCombinations.TabIndex = 12;
            this.pCombinations.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 126);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Флеш-рояль : самая известная покерная комбинация. Это непобедимая рука. Она состо" +
    "ит из туза, короля, дамы, Валета и 10ки - все карты одной масти.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(4, 138);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(219, 126);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Стрит-флеш : Пять карт идущих подряд. В случае, если у 2 игроков такая комбинация" +
    ", выигрывает старший стрит-флеш";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 138);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(4, 272);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(219, 126);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Каре : четыре карты одного вида. В случае, если у 2 игроков такая комбинация, выи" +
    "грывает каре, состоящее из старших карт";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(231, 272);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(4, 406);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(219, 126);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Фулл-хаус : три одинаковых карты и пара. В случае, если у 2 игроков такая комбина" +
    "ция, выигрывает тот, у кого старшая карта.";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(231, 406);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(4, 540);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(219, 126);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Флеш : Пять непоследовательных карт одной масти. В случае, если у 2 игроков такая" +
    " комбинация, выигрывает тот, у кого старшая карта.";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(231, 540);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(163, 103);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(4, 674);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(219, 126);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Стрит : Пять карт подряд разной масти, но поочерёдного достоинства. В случае, есл" +
    "и у 2 игроков такая комбинация, выигрывает тот, у кого старшая карта.";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(231, 674);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(163, 103);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(4, 808);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(219, 126);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "Сет : три карты одного достоинства. В случае, если у 2 игроков такая комбинация, " +
    "выигрывает тот, у кого достоинство карт, составляющих сет, выше.";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(231, 808);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(163, 103);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(4, 942);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(219, 126);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "Две пары: две пары разных достоинств. Одна из пар, которая выше достоинством, наз" +
    "ываемая кикер. В случае, если 2 игрокаимеют одинаковые пары выигрывает тот, у ко" +
    "того кикер выше.";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(231, 942);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(163, 103);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(4, 1076);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(219, 126);
            this.textBox9.TabIndex = 17;
            this.textBox9.Text = "Пара : Две карты одного ранга. В случае, если у 2 игроков одна и та же пара, то вы" +
    "игрывает тот, у кого самая старшая карта.";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(231, 1076);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(163, 103);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pHot
            // 
            this.pHot.Controls.Add(this.bReset);
            this.pHot.Controls.Add(this.bApply);
            this.pHot.Controls.Add(this.HotFold);
            this.pHot.Controls.Add(this.HotCheck);
            this.pHot.Controls.Add(this.HotCall);
            this.pHot.Controls.Add(this.HotRaise);
            this.pHot.Controls.Add(this.LRaise);
            this.pHot.Controls.Add(this.LCall);
            this.pHot.Controls.Add(this.LCheck);
            this.pHot.Controls.Add(this.Lintro);
            this.pHot.Controls.Add(this.LFold);
            this.pHot.Location = new System.Drawing.Point(57, 492);
            this.pHot.Margin = new System.Windows.Forms.Padding(4);
            this.pHot.Name = "pHot";
            this.pHot.Size = new System.Drawing.Size(513, 338);
            this.pHot.TabIndex = 13;
            this.pHot.Visible = false;
            // 
            // bReset
            // 
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReset.Location = new System.Drawing.Point(132, 255);
            this.bReset.Margin = new System.Windows.Forms.Padding(4);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(200, 70);
            this.bReset.TabIndex = 13;
            this.bReset.Text = "Значения по умолчанию";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bApply
            // 
            this.bApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.Location = new System.Drawing.Point(24, 282);
            this.bApply.Margin = new System.Windows.Forms.Padding(4);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(100, 28);
            this.bApply.TabIndex = 12;
            this.bApply.Text = "Принять";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // HotFold
            // 
            this.HotFold.Location = new System.Drawing.Point(81, 85);
            this.HotFold.Margin = new System.Windows.Forms.Padding(4);
            this.HotFold.Name = "HotFold";
            this.HotFold.Size = new System.Drawing.Size(132, 22);
            this.HotFold.TabIndex = 11;
            // 
            // HotCheck
            // 
            this.HotCheck.Location = new System.Drawing.Point(81, 122);
            this.HotCheck.Margin = new System.Windows.Forms.Padding(4);
            this.HotCheck.Name = "HotCheck";
            this.HotCheck.Size = new System.Drawing.Size(132, 22);
            this.HotCheck.TabIndex = 10;
            // 
            // HotCall
            // 
            this.HotCall.Location = new System.Drawing.Point(81, 162);
            this.HotCall.Margin = new System.Windows.Forms.Padding(4);
            this.HotCall.Name = "HotCall";
            this.HotCall.Size = new System.Drawing.Size(132, 22);
            this.HotCall.TabIndex = 9;
            // 
            // HotRaise
            // 
            this.HotRaise.Location = new System.Drawing.Point(81, 206);
            this.HotRaise.Margin = new System.Windows.Forms.Padding(4);
            this.HotRaise.Name = "HotRaise";
            this.HotRaise.Size = new System.Drawing.Size(132, 22);
            this.HotRaise.TabIndex = 8;
            // 
            // LRaise
            // 
            this.LRaise.AutoSize = true;
            this.LRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LRaise.Location = new System.Drawing.Point(20, 206);
            this.LRaise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRaise.Name = "LRaise";
            this.LRaise.Size = new System.Drawing.Size(42, 18);
            this.LRaise.TabIndex = 7;
            this.LRaise.Text = "Райз";
            // 
            // LCall
            // 
            this.LCall.AutoSize = true;
            this.LCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCall.Location = new System.Drawing.Point(20, 164);
            this.LCall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCall.Name = "LCall";
            this.LCall.Size = new System.Drawing.Size(45, 18);
            this.LCall.TabIndex = 6;
            this.LCall.Text = "Колл";
            // 
            // LCheck
            // 
            this.LCheck.AutoSize = true;
            this.LCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LCheck.Location = new System.Drawing.Point(20, 123);
            this.LCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCheck.Name = "LCheck";
            this.LCheck.Size = new System.Drawing.Size(34, 18);
            this.LCheck.TabIndex = 5;
            this.LCheck.Text = "Чек";
            // 
            // Lintro
            // 
            this.Lintro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lintro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lintro.Location = new System.Drawing.Point(24, 14);
            this.Lintro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lintro.Name = "Lintro";
            this.Lintro.Size = new System.Drawing.Size(425, 28);
            this.Lintro.TabIndex = 1;
            this.Lintro.Text = "Здесь вы можете назначить горячие клавиши";
            // 
            // LFold
            // 
            this.LFold.AutoSize = true;
            this.LFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LFold.Location = new System.Drawing.Point(20, 86);
            this.LFold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFold.Name = "LFold";
            this.LFold.Size = new System.Drawing.Size(54, 18);
            this.LFold.TabIndex = 0;
            this.LFold.Text = "Выход";
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSettings.Location = new System.Drawing.Point(16, 249);
            this.bSettings.Margin = new System.Windows.Forms.Padding(4);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(203, 41);
            this.bSettings.TabIndex = 14;
            this.bSettings.Text = "Настройки";
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.pThink);
            this.pSettings.Controls.Add(this.cbSkipThinkTime);
            this.pSettings.Controls.Add(this.cbThinkTime);
            this.pSettings.Controls.Add(this.bClearStatistics);
            this.pSettings.Controls.Add(this.cbStatistics);
            this.pSettings.Controls.Add(this.label5);
            this.pSettings.Location = new System.Drawing.Point(823, 433);
            this.pSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(513, 338);
            this.pSettings.TabIndex = 14;
            this.pSettings.Visible = false;
            // 
            // pThink
            // 
            this.pThink.Controls.Add(this.label4);
            this.pThink.Controls.Add(this.tbThink);
            this.pThink.Controls.Add(this.bThinkTime);
            this.pThink.Location = new System.Drawing.Point(19, 120);
            this.pThink.Margin = new System.Windows.Forms.Padding(4);
            this.pThink.Name = "pThink";
            this.pThink.Size = new System.Drawing.Size(400, 100);
            this.pThink.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Время боту на подумать";
            // 
            // tbThink
            // 
            this.tbThink.Location = new System.Drawing.Point(205, 16);
            this.tbThink.Margin = new System.Windows.Forms.Padding(4);
            this.tbThink.Name = "tbThink";
            this.tbThink.Size = new System.Drawing.Size(39, 22);
            this.tbThink.TabIndex = 14;
            this.tbThink.Text = "3";
            // 
            // bThinkTime
            // 
            this.bThinkTime.Location = new System.Drawing.Point(250, 15);
            this.bThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.bThinkTime.Name = "bThinkTime";
            this.bThinkTime.Size = new System.Drawing.Size(100, 28);
            this.bThinkTime.TabIndex = 17;
            this.bThinkTime.Text = "Принять";
            this.bThinkTime.UseVisualStyleBackColor = true;
            this.bThinkTime.Click += new System.EventHandler(this.bThinkTime_Click);
            //
            //cbSkipThinkTime
            //
            this.cbSkipThinkTime.AutoSize = true;
            this.cbSkipThinkTime.Location = new System.Drawing.Point(20, 62);
            this.cbSkipThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbSkipThinkTime.Name = "cbSkipThinkTime";
            this.cbSkipThinkTime.Size = new System.Drawing.Size(185, 21);
            this.cbSkipThinkTime.TabIndex = 19;
            this.cbSkipThinkTime.Text = "Пропускать ходы ботов";
            this.cbSkipThinkTime.UseVisualStyleBackColor = true;
            this.cbSkipThinkTime.CheckedChanged += new System.EventHandler(this.cbSkipThinkTime_CheckedChanged);
            // 
            // cbThinkTime
            // 
            this.cbThinkTime.AutoSize = true;
            this.cbThinkTime.Location = new System.Drawing.Point(20, 87);
            this.cbThinkTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbThinkTime.Name = "cbThinkTime";
            this.cbThinkTime.Size = new System.Drawing.Size(350, 21);
            this.cbThinkTime.TabIndex = 18;
            this.cbThinkTime.Text = "Ожидать решение ботов";
            this.cbThinkTime.UseVisualStyleBackColor = true;
            // 
            // bClearStatistics
            // 
            this.bClearStatistics.Location = new System.Drawing.Point(20, 300);
            this.bClearStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.bClearStatistics.Name = "bClearStatistics";
            this.bClearStatistics.Size = new System.Drawing.Size(139, 26);
            this.bClearStatistics.TabIndex = 16;
            this.bClearStatistics.Text = "Очистить";
            this.bClearStatistics.UseVisualStyleBackColor = true;
            this.bClearStatistics.Click += new System.EventHandler(this.bClearStatistics_Click);
            // 
            // cbStatistics
            // 
            this.cbStatistics.AutoSize = true;
            this.cbStatistics.Location = new System.Drawing.Point(20, 280);
            this.cbStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatistics.Name = "cbStatistics";
            this.cbStatistics.Size = new System.Drawing.Size(188, 21);
            this.cbStatistics.TabIndex = 15;
            this.cbStatistics.Text = "Отображать статистику";
            this.cbStatistics.UseVisualStyleBackColor = true;
            this.cbStatistics.CheckedChanged += new System.EventHandler(this.cbStatistics_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 21;
            // 
            // tbH1
            // 
            this.tbH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbH1.Location = new System.Drawing.Point(240, 49);
            this.tbH1.Margin = new System.Windows.Forms.Padding(4);
            this.tbH1.Multiline = true;
            this.tbH1.Name = "tbH1";
            this.tbH1.ReadOnly = true;
            this.tbH1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbH1.Size = new System.Drawing.Size(512, 338);
            this.tbH1.TabIndex = 0;
            this.tbH1.Visible = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 420);
            this.Controls.Add(this.pCombinations);
            this.Controls.Add(this.pSettings);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.pHot);
            this.Controls.Add(this.tbH1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.bCombinations);
            this.Controls.Add(this.bHotkeys);
            this.Controls.Add(this.bHow);
            this.Controls.Add(this.lbTopLine);
            this.Controls.Add(this.lbLeftLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Help";
            this.Text = "Помощь";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Help_Load);
            this.pCombinations.ResumeLayout(false);
            this.pCombinations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pHot.ResumeLayout(false);
            this.pHot.PerformLayout();
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.pThink.ResumeLayout(false);
            this.pThink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lbLeftLine;
        private Label lbTopLine;
        private Button bHow;
        private Button bHotkeys;
        private Button bCombinations;
        private Button bAbout;
        private Label label3;
        private FlowLayoutPanel pCombinations;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private TextBox textBox4;
        private PictureBox pictureBox4;
        private TextBox textBox5;
        private PictureBox pictureBox5;
        private TextBox textBox6;
        private PictureBox pictureBox6;
        private TextBox textBox7;
        private PictureBox pictureBox7;
        private TextBox textBox8;
        private PictureBox pictureBox8;
        private TextBox textBox9;
        private PictureBox pictureBox9;
        private Panel pHot;
        private TextBox HotFold;
        private TextBox HotCheck;
        private TextBox HotCall;
        private TextBox HotRaise;
        private Label LRaise;
        private Label LCall;
        private Label LCheck;
        private Label Lintro;
        private Label LFold;
        private Button bReset;
        private Button bApply;
        private Button bSettings;
        private Panel pSettings;
        private Label label4;
        private Label label5;
        private TextBox tbThink;
        private CheckBox cbStatistics;
        private Button bClearStatistics;
        private Button bThinkTime;
        private Panel pThink;
        private CheckBox cbSkipThinkTime;
        private CheckBox cbThinkTime;
        private TextBox tbH1;
    }
}