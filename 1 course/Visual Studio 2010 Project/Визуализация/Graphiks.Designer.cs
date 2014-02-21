namespace Визуализация
{
    partial class Graphiks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphiks));
            this.label1 = new System.Windows.Forms.Label();
            this.lastiteration = new System.Windows.Forms.Button();
            this.nextiteration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BestX = new System.Windows.Forms.Label();
            this.BestY = new System.Windows.Forms.Label();
            this.WorstY = new System.Windows.Forms.Label();
            this.WorstX = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.KolIter = new System.Windows.Forms.Label();
            this.VypolnitAuto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Stop_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.IterNow = new System.Windows.Forms.Label();
            this.Population = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.KolZnakov = new System.Windows.Forms.NumericUpDown();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.NewPopulation = new System.Windows.Forms.Button();
            this.GraphFunOpen = new System.Windows.Forms.Button();
            this.GraphSupport = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KolZnakov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "График оптимизации:";
            // 
            // lastiteration
            // 
            this.lastiteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastiteration.Location = new System.Drawing.Point(538, 39);
            this.lastiteration.Name = "lastiteration";
            this.lastiteration.Size = new System.Drawing.Size(254, 22);
            this.lastiteration.TabIndex = 2;
            this.lastiteration.Text = "Предыдущая итерация";
            this.lastiteration.UseVisualStyleBackColor = true;
            this.lastiteration.Click += new System.EventHandler(this.lastiteration_Click);
            // 
            // nextiteration
            // 
            this.nextiteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextiteration.Location = new System.Drawing.Point(538, 67);
            this.nextiteration.Name = "nextiteration";
            this.nextiteration.Size = new System.Drawing.Size(254, 23);
            this.nextiteration.TabIndex = 3;
            this.nextiteration.Text = "Следующая итерация";
            this.nextiteration.UseVisualStyleBackColor = true;
            this.nextiteration.Click += new System.EventHandler(this.nextiteration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Лучший агент:";
            // 
            // BestX
            // 
            this.BestX.AutoSize = true;
            this.BestX.Location = new System.Drawing.Point(46, 42);
            this.BestX.Name = "BestX";
            this.BestX.Size = new System.Drawing.Size(98, 13);
            this.BestX.TabIndex = 7;
            this.BestX.Text = "Координата Х: 0,0";
            // 
            // BestY
            // 
            this.BestY.AutoSize = true;
            this.BestY.Location = new System.Drawing.Point(46, 64);
            this.BestY.Name = "BestY";
            this.BestY.Size = new System.Drawing.Size(98, 13);
            this.BestY.TabIndex = 8;
            this.BestY.Text = "Координата Y: 0,0";
            // 
            // WorstY
            // 
            this.WorstY.AutoSize = true;
            this.WorstY.Location = new System.Drawing.Point(46, 132);
            this.WorstY.Name = "WorstY";
            this.WorstY.Size = new System.Drawing.Size(98, 13);
            this.WorstY.TabIndex = 11;
            this.WorstY.Text = "Координата Y: 0,0";
            // 
            // WorstX
            // 
            this.WorstX.AutoSize = true;
            this.WorstX.Location = new System.Drawing.Point(46, 109);
            this.WorstX.Name = "WorstX";
            this.WorstX.Size = new System.Drawing.Size(98, 13);
            this.WorstX.TabIndex = 10;
            this.WorstX.Text = "Координата Х: 0,0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Худший агент:";
            // 
            // KolIter
            // 
            this.KolIter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KolIter.AutoSize = true;
            this.KolIter.Location = new System.Drawing.Point(550, 217);
            this.KolIter.Name = "KolIter";
            this.KolIter.Size = new System.Drawing.Size(119, 13);
            this.KolIter.TabIndex = 12;
            this.KolIter.Text = "Количество итераций:";
            // 
            // VypolnitAuto
            // 
            this.VypolnitAuto.Location = new System.Drawing.Point(6, 76);
            this.VypolnitAuto.Name = "VypolnitAuto";
            this.VypolnitAuto.Size = new System.Drawing.Size(124, 23);
            this.VypolnitAuto.TabIndex = 13;
            this.VypolnitAuto.Text = "Выполнить";
            this.VypolnitAuto.UseVisualStyleBackColor = true;
            this.VypolnitAuto.Click += new System.EventHandler(this.VypolnitAuto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Пауза между итерациями:";
            // 
            // TimeTrackBar
            // 
            this.TimeTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeTrackBar.LargeChange = 1;
            this.TimeTrackBar.Location = new System.Drawing.Point(6, 36);
            this.TimeTrackBar.Maximum = 5;
            this.TimeTrackBar.Minimum = 1;
            this.TimeTrackBar.Name = "TimeTrackBar";
            this.TimeTrackBar.Size = new System.Drawing.Size(241, 45);
            this.TimeTrackBar.TabIndex = 16;
            this.TimeTrackBar.Value = 1;
            this.TimeTrackBar.Scroll += new System.EventHandler(this.TimeTrackBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Stop_button);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VypolnitAuto);
            this.groupBox1.Controls.Add(this.TimeTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(539, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 108);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозапуск итераций";
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(136, 76);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(111, 23);
            this.Stop_button.TabIndex = 17;
            this.Stop_button.Text = "Остановить";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.Stop_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BestY);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.WorstY);
            this.groupBox2.Controls.Add(this.BestX);
            this.groupBox2.Controls.Add(this.WorstX);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(539, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 153);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об агентах:";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // IterNow
            // 
            this.IterNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IterNow.AutoSize = true;
            this.IterNow.Location = new System.Drawing.Point(676, 217);
            this.IterNow.Name = "IterNow";
            this.IterNow.Size = new System.Drawing.Size(13, 13);
            this.IterNow.TabIndex = 18;
            this.IterNow.Text = "0";
            // 
            // Population
            // 
            this.Population.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Population.Location = new System.Drawing.Point(538, 425);
            this.Population.Name = "Population";
            this.Population.Size = new System.Drawing.Size(254, 22);
            this.Population.TabIndex = 19;
            this.Population.Text = "Действующая популяция";
            this.Population.UseVisualStyleBackColor = true;
            this.Population.Click += new System.EventHandler(this.Population_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Количество знаков дробной части:";
            // 
            // KolZnakov
            // 
            this.KolZnakov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KolZnakov.Location = new System.Drawing.Point(740, 240);
            this.KolZnakov.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.KolZnakov.Name = "KolZnakov";
            this.KolZnakov.Size = new System.Drawing.Size(39, 20);
            this.KolZnakov.TabIndex = 21;
            this.KolZnakov.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.KolZnakov.ValueChanged += new System.EventHandler(this.KolZnakov_ValueChanged);
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zedGraph.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraph.Location = new System.Drawing.Point(12, 39);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(504, 436);
            this.zedGraph.TabIndex = 22;
            this.zedGraph.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedGraph_PointValueEvent);
            // 
            // NewPopulation
            // 
            this.NewPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPopulation.Location = new System.Drawing.Point(538, 453);
            this.NewPopulation.Name = "NewPopulation";
            this.NewPopulation.Size = new System.Drawing.Size(254, 22);
            this.NewPopulation.TabIndex = 23;
            this.NewPopulation.Text = "Новая популяция\r\n";
            this.NewPopulation.UseVisualStyleBackColor = true;
            this.NewPopulation.Click += new System.EventHandler(this.NewPopulation_Click);
            // 
            // GraphFunOpen
            // 
            this.GraphFunOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GraphFunOpen.Location = new System.Drawing.Point(263, 8);
            this.GraphFunOpen.MinimumSize = new System.Drawing.Size(253, 22);
            this.GraphFunOpen.Name = "GraphFunOpen";
            this.GraphFunOpen.Size = new System.Drawing.Size(253, 22);
            this.GraphFunOpen.TabIndex = 24;
            this.GraphFunOpen.Text = "График функции";
            this.GraphFunOpen.UseVisualStyleBackColor = true;
            this.GraphFunOpen.Click += new System.EventHandler(this.GraphFunOpen_Click);
            // 
            // Graphiks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 493);
            this.Controls.Add(this.GraphFunOpen);
            this.Controls.Add(this.NewPopulation);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.KolZnakov);
            this.Controls.Add(this.Population);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IterNow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.KolIter);
            this.Controls.Add(this.nextiteration);
            this.Controls.Add(this.lastiteration);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(830, 532);
            this.Name = "Graphiks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графическое представление";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KolZnakov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BestX;
        private System.Windows.Forms.Label BestY;
        private System.Windows.Forms.Label WorstY;
        private System.Windows.Forms.Label WorstX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button VypolnitAuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TimeTrackBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lastiteration;
        private System.Windows.Forms.Button nextiteration;
        private System.Windows.Forms.Label KolIter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label IterNow;
        private System.Windows.Forms.Button Population;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown KolZnakov;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button NewPopulation;
        private System.Windows.Forms.Button GraphFunOpen;
        private System.Windows.Forms.ToolTip GraphSupport;
    }
}