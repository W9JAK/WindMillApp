namespace WindMillApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnChangeDirection = new System.Windows.Forms.Button();
            this.pictureBoxMill = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlades = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(60, 66);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 75);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnChangeDirection
            // 
            this.btnChangeDirection.Location = new System.Drawing.Point(60, 147);
            this.btnChangeDirection.Name = "btnChangeDirection";
            this.btnChangeDirection.Size = new System.Drawing.Size(151, 75);
            this.btnChangeDirection.TabIndex = 1;
            this.btnChangeDirection.Text = "Сменить направление";
            this.btnChangeDirection.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMill
            // 
            this.pictureBoxMill.Location = new System.Drawing.Point(280, 28);
            this.pictureBoxMill.Name = "pictureBoxMill";
            this.pictureBoxMill.Size = new System.Drawing.Size(382, 372);
            this.pictureBoxMill.TabIndex = 6;
            this.pictureBoxMill.TabStop = false;
            // 
            // pictureBoxBlades
            // 
            this.pictureBoxBlades.Location = new System.Drawing.Point(280, 118);
            this.pictureBoxBlades.Name = "pictureBoxBlades";
            this.pictureBoxBlades.Size = new System.Drawing.Size(382, 318);
            this.pictureBoxBlades.TabIndex = 5;
            this.pictureBoxBlades.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 264);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(183, 69);
            this.trackBar1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(60, 339);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 472);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBoxMill);
            this.Controls.Add(this.pictureBoxBlades);
            this.Controls.Add(this.btnChangeDirection);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnChangeDirection;
        private System.Windows.Forms.PictureBox pictureBoxBlades;
        private System.Windows.Forms.PictureBox pictureBoxMill;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
