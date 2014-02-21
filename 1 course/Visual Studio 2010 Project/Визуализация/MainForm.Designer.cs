namespace Визуализация
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MaxX = new System.Windows.Forms.TextBox();
            this.MaxY = new System.Windows.Forms.TextBox();
            this.MinY = new System.Windows.Forms.TextBox();
            this.MinX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.Kol_It_Number = new System.Windows.Forms.TextBox();
            this.Kol_It_TrackBar = new System.Windows.Forms.TrackBar();
            this.Mistake_minX = new System.Windows.Forms.ErrorProvider(this.components);
            this.Mistake_minY = new System.Windows.Forms.ErrorProvider(this.components);
            this.Mistake_maxX = new System.Windows.Forms.ErrorProvider(this.components);
            this.Mistake_maxY = new System.Windows.Forms.ErrorProvider(this.components);
            this.GraphOpen = new System.Windows.Forms.Button();
            this.Maximum = new System.Windows.Forms.RadioButton();
            this.Minimum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Function = new System.Windows.Forms.PictureBox();
            this.IterationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MinXToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MaxXToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MinYToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MaxYToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FuncToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Kol_It_TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_minX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_minY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_maxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_maxY)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Function)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxX
            // 
            this.MaxX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxX.Location = new System.Drawing.Point(306, 64);
            this.MaxX.Name = "MaxX";
            this.MaxX.Size = new System.Drawing.Size(76, 20);
            this.MaxX.TabIndex = 6;
            this.MaxX.TextChanged += new System.EventHandler(this.MaxX_TextChanged);
            this.MaxX.Leave += new System.EventHandler(this.MaxX_Leave);
            // 
            // MaxY
            // 
            this.MaxY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxY.Location = new System.Drawing.Point(306, 61);
            this.MaxY.Name = "MaxY";
            this.MaxY.Size = new System.Drawing.Size(76, 20);
            this.MaxY.TabIndex = 7;
            this.MaxY.TextChanged += new System.EventHandler(this.MaxY_TextChanged);
            this.MaxY.Leave += new System.EventHandler(this.MaxY_Leave);
            // 
            // MinY
            // 
            this.MinY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinY.Location = new System.Drawing.Point(306, 29);
            this.MinY.Name = "MinY";
            this.MinY.Size = new System.Drawing.Size(76, 20);
            this.MinY.TabIndex = 5;
            this.MinY.TextChanged += new System.EventHandler(this.MinY_TextChanged);
            this.MinY.Leave += new System.EventHandler(this.MinY_Leave);
            // 
            // MinX
            // 
            this.MinX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinX.Location = new System.Drawing.Point(306, 29);
            this.MinX.Name = "MinX";
            this.MinX.Size = new System.Drawing.Size(76, 20);
            this.MinX.TabIndex = 4;
            this.MinX.TextChanged += new System.EventHandler(this.MinX_TextChanged);
            this.MinX.Leave += new System.EventHandler(this.MinX_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "минимальная граница промежутка по переменной Х:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "максимальная граница промежутка по переменной Х:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "минимальная граница промежутка по переменной Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "максимальная граница промежутка по переменной Y:";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 558);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(190, 30);
            this.Result.TabIndex = 8;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Kol_It_Number
            // 
            this.Kol_It_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Kol_It_Number.Location = new System.Drawing.Point(333, 22);
            this.Kol_It_Number.Name = "Kol_It_Number";
            this.Kol_It_Number.Size = new System.Drawing.Size(49, 20);
            this.Kol_It_Number.TabIndex = 4;
            this.Kol_It_Number.Text = "1";
            this.Kol_It_Number.TextChanged += new System.EventHandler(this.Kol_It_Number_TextChanged);
            // 
            // Kol_It_TrackBar
            // 
            this.Kol_It_TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kol_It_TrackBar.LargeChange = 10;
            this.Kol_It_TrackBar.Location = new System.Drawing.Point(9, 22);
            this.Kol_It_TrackBar.Maximum = 1000;
            this.Kol_It_TrackBar.Minimum = 1;
            this.Kol_It_TrackBar.Name = "Kol_It_TrackBar";
            this.Kol_It_TrackBar.Size = new System.Drawing.Size(313, 45);
            this.Kol_It_TrackBar.SmallChange = 10;
            this.Kol_It_TrackBar.TabIndex = 3;
            this.Kol_It_TrackBar.TickFrequency = 100;
            this.Kol_It_TrackBar.Value = 1;
            this.Kol_It_TrackBar.Scroll += new System.EventHandler(this.Kol_It_TrackBar_Scroll);
            // 
            // Mistake_minX
            // 
            this.Mistake_minX.BlinkRate = 0;
            this.Mistake_minX.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Mistake_minX.ContainerControl = this;
            // 
            // Mistake_minY
            // 
            this.Mistake_minY.BlinkRate = 0;
            this.Mistake_minY.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Mistake_minY.ContainerControl = this;
            // 
            // Mistake_maxX
            // 
            this.Mistake_maxX.BlinkRate = 0;
            this.Mistake_maxX.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Mistake_maxX.ContainerControl = this;
            // 
            // Mistake_maxY
            // 
            this.Mistake_maxY.BlinkRate = 0;
            this.Mistake_maxY.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Mistake_maxY.ContainerControl = this;
            // 
            // GraphOpen
            // 
            this.GraphOpen.Location = new System.Drawing.Point(222, 558);
            this.GraphOpen.Name = "GraphOpen";
            this.GraphOpen.Size = new System.Drawing.Size(190, 30);
            this.GraphOpen.TabIndex = 14;
            this.GraphOpen.Text = "График";
            this.GraphOpen.UseVisualStyleBackColor = true;
            this.GraphOpen.Click += new System.EventHandler(this.GraphOpen_Click);
            // 
            // Maximum
            // 
            this.Maximum.AutoSize = true;
            this.Maximum.Location = new System.Drawing.Point(6, 19);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(204, 17);
            this.Maximum.TabIndex = 15;
            this.Maximum.TabStop = true;
            this.Maximum.Text = "максимум функции на промежутке";
            this.Maximum.UseVisualStyleBackColor = true;
            // 
            // Minimum
            // 
            this.Minimum.AutoSize = true;
            this.Minimum.Location = new System.Drawing.Point(6, 42);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(198, 17);
            this.Minimum.TabIndex = 16;
            this.Minimum.TabStop = true;
            this.Minimum.Text = "минимум функции на промежутке";
            this.Minimum.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Maximum);
            this.groupBox1.Controls.Add(this.Minimum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 73);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры поиска:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kol_It_TrackBar);
            this.groupBox2.Controls.Add(this.Kol_It_Number);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 73);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество итераций:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.MinX);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.MaxX);
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 100);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Границы промежутка по переменной X:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.MaxY);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.MinY);
            this.groupBox4.Location = new System.Drawing.Point(12, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 100);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Границы промежутка по переменной Y:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Function);
            this.groupBox5.Location = new System.Drawing.Point(47, 427);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(322, 110);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выбор функции:";
            // 
            // Function
            // 
            this.Function.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Function.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Function.Location = new System.Drawing.Point(18, 19);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(283, 77);
            this.Function.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Function.TabIndex = 17;
            this.Function.TabStop = false;
            this.Function.Click += new System.EventHandler(this.Function_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(425, 600);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GraphOpen);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(431, 629);
            this.MinimumSize = new System.Drawing.Size(431, 629);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа";
            ((System.ComponentModel.ISupportInitialize)(this.Kol_It_TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_minX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_minY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_maxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mistake_maxY)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Function)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MaxX;
        private System.Windows.Forms.TextBox MaxY;
        private System.Windows.Forms.TextBox MinY;
        private System.Windows.Forms.TextBox MinX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.TextBox Kol_It_Number;
        private System.Windows.Forms.TrackBar Kol_It_TrackBar;
        private System.Windows.Forms.ErrorProvider Mistake_minX;
        private System.Windows.Forms.ErrorProvider Mistake_minY;
        private System.Windows.Forms.ErrorProvider Mistake_maxX;
        private System.Windows.Forms.ErrorProvider Mistake_maxY;
        private System.Windows.Forms.Button GraphOpen;
        private System.Windows.Forms.RadioButton Minimum;
        private System.Windows.Forms.RadioButton Maximum;
        private System.Windows.Forms.PictureBox Function;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip IterationToolTip;
        private System.Windows.Forms.ToolTip MinXToolTip;
        private System.Windows.Forms.ToolTip MaxXToolTip;
        private System.Windows.Forms.ToolTip MinYToolTip;
        private System.Windows.Forms.ToolTip MaxYToolTip;
        private System.Windows.Forms.ToolTip FuncToolTip;
    }
}

