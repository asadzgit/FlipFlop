namespace flip_flop_1_
{
    partial class gamewindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.exitbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cardsholder = new System.Windows.Forms.Panel();
            this.movesCounter = new System.Windows.Forms.Label();
            this.movesLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.selectLevel = new System.Windows.Forms.Button();
            this.level1 = new System.Windows.Forms.Button();
            this.playagain = new System.Windows.Forms.Button();
            this.resumeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pause_resume = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeValueLabel = new System.Windows.Forms.Label();
            this.pb13 = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pb14 = new System.Windows.Forms.PictureBox();
            this.pb15 = new System.Windows.Forms.PictureBox();
            this.pb16 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.gamename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.levelDetail = new System.Windows.Forms.Label();
            this.cardsholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.PeachPuff;
            this.exitbutton.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbutton.Font = new System.Drawing.Font("Tekton Pro Ext", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Goldenrod;
            this.exitbutton.Location = new System.Drawing.Point(152, 374);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(133, 46);
            this.exitbutton.TabIndex = 31;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // cardsholder
            // 
            this.cardsholder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardsholder.BackColor = System.Drawing.Color.Transparent;
            this.cardsholder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardsholder.Controls.Add(this.movesCounter);
            this.cardsholder.Controls.Add(this.movesLabel);
            this.cardsholder.Controls.Add(this.back);
            this.cardsholder.Controls.Add(this.level2);
            this.cardsholder.Controls.Add(this.selectLevel);
            this.cardsholder.Controls.Add(this.level1);
            this.cardsholder.Controls.Add(this.playagain);
            this.cardsholder.Controls.Add(this.exitbutton);
            this.cardsholder.Controls.Add(this.resumeButton);
            this.cardsholder.Controls.Add(this.startButton);
            this.cardsholder.Controls.Add(this.timeValueLabel);
            this.cardsholder.Controls.Add(this.pb13);
            this.cardsholder.Controls.Add(this.timeLabel);
            this.cardsholder.Controls.Add(this.pb14);
            this.cardsholder.Controls.Add(this.pb15);
            this.cardsholder.Controls.Add(this.pb16);
            this.cardsholder.Controls.Add(this.pb12);
            this.cardsholder.Controls.Add(this.pb9);
            this.cardsholder.Controls.Add(this.pb10);
            this.cardsholder.Controls.Add(this.pb11);
            this.cardsholder.Controls.Add(this.pb2);
            this.cardsholder.Controls.Add(this.pb3);
            this.cardsholder.Controls.Add(this.pb4);
            this.cardsholder.Controls.Add(this.pb5);
            this.cardsholder.Controls.Add(this.pb6);
            this.cardsholder.Controls.Add(this.pb8);
            this.cardsholder.Controls.Add(this.pb7);
            this.cardsholder.Controls.Add(this.pb1);
            this.cardsholder.Controls.Add(this.gamename);
            this.cardsholder.Location = new System.Drawing.Point(413, 77);
            this.cardsholder.Name = "cardsholder";
            this.cardsholder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cardsholder.Size = new System.Drawing.Size(453, 548);
            this.cardsholder.TabIndex = 0;
            // 
            // movesCounter
            // 
            this.movesCounter.AutoSize = true;
            this.movesCounter.Font = new System.Drawing.Font("Tekton Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesCounter.ForeColor = System.Drawing.Color.Goldenrod;
            this.movesCounter.Location = new System.Drawing.Point(356, 6);
            this.movesCounter.Name = "movesCounter";
            this.movesCounter.Size = new System.Drawing.Size(26, 25);
            this.movesCounter.TabIndex = 39;
            this.movesCounter.Text = "0";
            // 
            // movesLabel
            // 
            this.movesLabel.BackColor = System.Drawing.Color.Firebrick;
            this.movesLabel.Font = new System.Drawing.Font("Tekton Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.movesLabel.Location = new System.Drawing.Point(273, -2);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(68, 33);
            this.movesLabel.TabIndex = 38;
            this.movesLabel.Text = "Moves";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.PeachPuff;
            this.back.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Goldenrod;
            this.back.Location = new System.Drawing.Point(152, 374);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(133, 46);
            this.back.TabIndex = 35;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.PeachPuff;
            this.level2.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.level2.FlatAppearance.BorderSize = 0;
            this.level2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.level2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level2.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2.ForeColor = System.Drawing.Color.Goldenrod;
            this.level2.Location = new System.Drawing.Point(223, 325);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(133, 46);
            this.level2.TabIndex = 34;
            this.level2.Text = "Level 2";
            this.level2.UseVisualStyleBackColor = false;
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // selectLevel
            // 
            this.selectLevel.BackColor = System.Drawing.Color.PeachPuff;
            this.selectLevel.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.selectLevel.FlatAppearance.BorderSize = 0;
            this.selectLevel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.selectLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectLevel.Font = new System.Drawing.Font("Tekton Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLevel.ForeColor = System.Drawing.Color.Goldenrod;
            this.selectLevel.Location = new System.Drawing.Point(152, 323);
            this.selectLevel.Name = "selectLevel";
            this.selectLevel.Size = new System.Drawing.Size(133, 46);
            this.selectLevel.TabIndex = 33;
            this.selectLevel.Text = "Select Level";
            this.selectLevel.UseVisualStyleBackColor = false;
            this.selectLevel.Click += new System.EventHandler(this.selectLevel_Click);
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.PeachPuff;
            this.level1.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.level1.FlatAppearance.BorderSize = 0;
            this.level1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.level1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.level1.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.ForeColor = System.Drawing.Color.Goldenrod;
            this.level1.Location = new System.Drawing.Point(64, 325);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(133, 46);
            this.level1.TabIndex = 32;
            this.level1.Text = "Level 1";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // playagain
            // 
            this.playagain.BackColor = System.Drawing.Color.PeachPuff;
            this.playagain.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.playagain.FlatAppearance.BorderSize = 0;
            this.playagain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.playagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagain.Font = new System.Drawing.Font("Tekton Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain.ForeColor = System.Drawing.Color.Goldenrod;
            this.playagain.Location = new System.Drawing.Point(152, 427);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(133, 46);
            this.playagain.TabIndex = 26;
            this.playagain.Text = "Play Again";
            this.playagain.UseVisualStyleBackColor = false;
            this.playagain.TextChanged += new System.EventHandler(this.gamewindows_Load);
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // resumeButton
            // 
            this.resumeButton.BackColor = System.Drawing.Color.PeachPuff;
            this.resumeButton.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.resumeButton.FlatAppearance.BorderSize = 0;
            this.resumeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resumeButton.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.resumeButton.Location = new System.Drawing.Point(152, 323);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(133, 46);
            this.resumeButton.TabIndex = 31;
            this.resumeButton.Text = "Resume";
            this.resumeButton.UseVisualStyleBackColor = false;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.PeachPuff;
            this.startButton.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Tekton Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.startButton.Location = new System.Drawing.Point(152, 271);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(133, 46);
            this.startButton.TabIndex = 27;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pause_resume
            // 
            this.pause_resume.BackColor = System.Drawing.Color.PeachPuff;
            this.pause_resume.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.pause_resume.FlatAppearance.BorderSize = 0;
            this.pause_resume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pause_resume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pause_resume.Font = new System.Drawing.Font("Tekton Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_resume.ForeColor = System.Drawing.Color.Goldenrod;
            this.pause_resume.Location = new System.Drawing.Point(935, 162);
            this.pause_resume.Name = "pause_resume";
            this.pause_resume.Size = new System.Drawing.Size(65, 33);
            this.pause_resume.TabIndex = 30;
            this.pause_resume.Text = "Pause";
            this.pause_resume.UseVisualStyleBackColor = false;
            this.pause_resume.Click += new System.EventHandler(this.pause_resume_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.PeachPuff;
            this.resetButton.BackgroundImage = global::flip_flop_1_.Properties.Resources.btn22;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Tekton Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.resetButton.Location = new System.Drawing.Point(1026, 164);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(68, 31);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // timeValueLabel
            // 
            this.timeValueLabel.AutoSize = true;
            this.timeValueLabel.Font = new System.Drawing.Font("Tekton Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeValueLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.timeValueLabel.Location = new System.Drawing.Point(75, 5);
            this.timeValueLabel.Name = "timeValueLabel";
            this.timeValueLabel.Size = new System.Drawing.Size(26, 25);
            this.timeValueLabel.TabIndex = 25;
            this.timeValueLabel.Text = "0";
            this.timeValueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb13
            // 
            this.pb13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb13.Location = new System.Drawing.Point(11, 407);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(91, 118);
            this.pb13.TabIndex = 23;
            this.pb13.TabStop = false;
            this.pb13.Tag = "10";
            this.pb13.Click += new System.EventHandler(this.pb19_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Firebrick;
            this.timeLabel.Font = new System.Drawing.Font("Tekton Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.timeLabel.Location = new System.Drawing.Point(11, -2);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(60, 33);
            this.timeLabel.TabIndex = 24;
            this.timeLabel.Text = "Time";
            this.timeLabel.Click += new System.EventHandler(this.score_Click);
            // 
            // pb14
            // 
            this.pb14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb14.Location = new System.Drawing.Point(107, 407);
            this.pb14.Name = "pb14";
            this.pb14.Size = new System.Drawing.Size(91, 118);
            this.pb14.TabIndex = 22;
            this.pb14.TabStop = false;
            this.pb14.Tag = "10";
            this.pb14.Click += new System.EventHandler(this.pb20_Click);
            // 
            // pb15
            // 
            this.pb15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb15.Location = new System.Drawing.Point(203, 407);
            this.pb15.Name = "pb15";
            this.pb15.Size = new System.Drawing.Size(91, 118);
            this.pb15.TabIndex = 21;
            this.pb15.TabStop = false;
            this.pb15.Tag = "11";
            this.pb15.Click += new System.EventHandler(this.pb21_Click);
            // 
            // pb16
            // 
            this.pb16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb16.Location = new System.Drawing.Point(299, 407);
            this.pb16.Name = "pb16";
            this.pb16.Size = new System.Drawing.Size(91, 118);
            this.pb16.TabIndex = 20;
            this.pb16.TabStop = false;
            this.pb16.Tag = "11";
            this.pb16.Click += new System.EventHandler(this.pb22_Click);
            // 
            // pb12
            // 
            this.pb12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb12.Location = new System.Drawing.Point(299, 283);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(91, 118);
            this.pb12.TabIndex = 11;
            this.pb12.TabStop = false;
            this.pb12.Tag = "8";
            this.pb12.Click += new System.EventHandler(this.pb16_Click);
            // 
            // pb9
            // 
            this.pb9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Location = new System.Drawing.Point(11, 283);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(91, 118);
            this.pb9.TabIndex = 10;
            this.pb9.TabStop = false;
            this.pb9.Tag = "7";
            this.pb9.Click += new System.EventHandler(this.pb13_Click);
            // 
            // pb10
            // 
            this.pb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb10.Location = new System.Drawing.Point(107, 283);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(91, 118);
            this.pb10.TabIndex = 9;
            this.pb10.TabStop = false;
            this.pb10.Tag = "7";
            this.pb10.Click += new System.EventHandler(this.pb14_Click);
            // 
            // pb11
            // 
            this.pb11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb11.Location = new System.Drawing.Point(203, 283);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(91, 118);
            this.pb11.TabIndex = 8;
            this.pb11.TabStop = false;
            this.pb11.Tag = "8";
            this.pb11.Click += new System.EventHandler(this.pb15_Click);
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Location = new System.Drawing.Point(107, 34);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(91, 118);
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            this.pb2.Tag = "1";
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb3
            // 
            this.pb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Location = new System.Drawing.Point(203, 34);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(91, 118);
            this.pb3.TabIndex = 6;
            this.pb3.TabStop = false;
            this.pb3.Tag = "2";
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb4
            // 
            this.pb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Location = new System.Drawing.Point(299, 34);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(91, 118);
            this.pb4.TabIndex = 5;
            this.pb4.TabStop = false;
            this.pb4.Tag = "2";
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb5
            // 
            this.pb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Location = new System.Drawing.Point(11, 159);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(91, 118);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Tag = "4";
            this.pb5.Click += new System.EventHandler(this.pb7_Click);
            // 
            // pb6
            // 
            this.pb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Location = new System.Drawing.Point(108, 159);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(91, 118);
            this.pb6.TabIndex = 3;
            this.pb6.TabStop = false;
            this.pb6.Tag = "4";
            this.pb6.Click += new System.EventHandler(this.pb8_Click);
            // 
            // pb8
            // 
            this.pb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Location = new System.Drawing.Point(299, 158);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(91, 118);
            this.pb8.TabIndex = 2;
            this.pb8.TabStop = false;
            this.pb8.Tag = "5";
            this.pb8.Click += new System.EventHandler(this.pb10_Click);
            // 
            // pb7
            // 
            this.pb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Location = new System.Drawing.Point(203, 159);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(91, 118);
            this.pb7.TabIndex = 1;
            this.pb7.TabStop = false;
            this.pb7.Tag = "5";
            this.pb7.Click += new System.EventHandler(this.pb9_Click);
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Location = new System.Drawing.Point(11, 34);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(91, 118);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // gamename
            // 
            this.gamename.BackColor = System.Drawing.Color.Transparent;
            this.gamename.Font = new System.Drawing.Font("Snap ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamename.ForeColor = System.Drawing.Color.DarkOrange;
            this.gamename.Location = new System.Drawing.Point(21, 134);
            this.gamename.Name = "gamename";
            this.gamename.Size = new System.Drawing.Size(358, 309);
            this.gamename.TabIndex = 28;
            this.gamename.Text = "FLIP FLOP GAME";
            this.gamename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gamename.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(415, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 59);
            this.label1.TabIndex = 31;
            this.label1.Text = "FLIP FLOP GAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // levelDetail
            // 
            this.levelDetail.Font = new System.Drawing.Font("Tekton Pro", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelDetail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.levelDetail.Location = new System.Drawing.Point(939, 229);
            this.levelDetail.Name = "levelDetail";
            this.levelDetail.Size = new System.Drawing.Size(171, 169);
            this.levelDetail.TabIndex = 36;
            this.levelDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.levelDetail.Click += new System.EventHandler(this.level1Detail_Click);
            // 
            // gamewindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1287, 688);
            this.Controls.Add(this.levelDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardsholder);
            this.Controls.Add(this.pause_resume);
            this.Controls.Add(this.resetButton);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "gamewindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "memorymatching";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.gamewindows_Load);
            this.cardsholder.ResumeLayout(false);
            this.cardsholder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cardsholder;
        private System.Windows.Forms.PictureBox pb13;
        private System.Windows.Forms.PictureBox pb14;
        private System.Windows.Forms.PictureBox pb15;
        private System.Windows.Forms.PictureBox pb16;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeValueLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label gamename;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button pause_resume;
        private System.Windows.Forms.Button resumeButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button level2;
        private System.Windows.Forms.Button selectLevel;
        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Label levelDetail;
        private System.Windows.Forms.Label movesCounter;
        private System.Windows.Forms.Label movesLabel;
    }
}

