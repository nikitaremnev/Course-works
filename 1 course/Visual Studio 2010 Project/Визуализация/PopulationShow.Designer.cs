namespace Визуализация
{
    partial class PopulationShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopulationShow));
            this.label1 = new System.Windows.Forms.Label();
            this.Iteration = new System.Windows.Forms.Label();
            this.Population = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.KolZnakov = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Population)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolZnakov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Итерация: ";
            // 
            // Iteration
            // 
            this.Iteration.AutoSize = true;
            this.Iteration.Location = new System.Drawing.Point(80, 9);
            this.Iteration.Name = "Iteration";
            this.Iteration.Size = new System.Drawing.Size(13, 13);
            this.Iteration.TabIndex = 1;
            this.Iteration.Text = "0";
            // 
            // Population
            // 
            this.Population.AllowUserToAddRows = false;
            this.Population.AllowUserToDeleteRows = false;
            this.Population.AllowUserToResizeColumns = false;
            this.Population.AllowUserToResizeRows = false;
            this.Population.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Population.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Population.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Population.Location = new System.Drawing.Point(15, 36);
            this.Population.Name = "Population";
            this.Population.ReadOnly = true;
            this.Population.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Population.RowHeadersWidth = 50;
            this.Population.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Population.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Population.Size = new System.Drawing.Size(380, 366);
            this.Population.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество знаков дробной части:";
            // 
            // KolZnakov
            // 
            this.KolZnakov.Location = new System.Drawing.Point(327, 7);
            this.KolZnakov.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.KolZnakov.Name = "KolZnakov";
            this.KolZnakov.Size = new System.Drawing.Size(43, 20);
            this.KolZnakov.TabIndex = 4;
            this.KolZnakov.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.KolZnakov.ValueChanged += new System.EventHandler(this.KolZnakov_ValueChanged);
            // 
            // PopulationShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 414);
            this.Controls.Add(this.KolZnakov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Population);
            this.Controls.Add(this.Iteration);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(423, 453);
            this.MinimumSize = new System.Drawing.Size(423, 453);
            this.Name = "PopulationShow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Популяция на данной итерации";
            ((System.ComponentModel.ISupportInitialize)(this.Population)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolZnakov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Iteration;
        private System.Windows.Forms.DataGridView Population;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown KolZnakov;
    }
}