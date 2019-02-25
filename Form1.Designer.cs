namespace Dithering
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
            this._PictureBox1 = new System.Windows.Forms.PictureBox();
            this._PictureBox2 = new System.Windows.Forms.PictureBox();
            this._ButtonImage = new MetroFramework.Controls.MetroButton();
            this._ButtonDithering = new MetroFramework.Controls.MetroButton();
            this._ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // _PictureBox1
            // 
            this._PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PictureBox1.Location = new System.Drawing.Point(23, 100);
            this._PictureBox1.Name = "_PictureBox1";
            this._PictureBox1.Size = new System.Drawing.Size(373, 250);
            this._PictureBox1.TabIndex = 0;
            this._PictureBox1.TabStop = false;
            // 
            // _PictureBox2
            // 
            this._PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PictureBox2.Location = new System.Drawing.Point(402, 100);
            this._PictureBox2.Name = "_PictureBox2";
            this._PictureBox2.Size = new System.Drawing.Size(373, 250);
            this._PictureBox2.TabIndex = 1;
            this._PictureBox2.TabStop = false;
            // 
            // _ButtonImage
            // 
            this._ButtonImage.Location = new System.Drawing.Point(287, 379);
            this._ButtonImage.Name = "_ButtonImage";
            this._ButtonImage.Size = new System.Drawing.Size(109, 23);
            this._ButtonImage.Style = MetroFramework.MetroColorStyle.Blue;
            this._ButtonImage.TabIndex = 2;
            this._ButtonImage.Text = "Image";
            this._ButtonImage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._ButtonImage.UseSelectable = true;
            this._ButtonImage.Click += new System.EventHandler(this._ButtonImage_Click);
            // 
            // _ButtonDithering
            // 
            this._ButtonDithering.Location = new System.Drawing.Point(402, 379);
            this._ButtonDithering.Name = "_ButtonDithering";
            this._ButtonDithering.Size = new System.Drawing.Size(109, 23);
            this._ButtonDithering.Style = MetroFramework.MetroColorStyle.Blue;
            this._ButtonDithering.TabIndex = 3;
            this._ButtonDithering.Text = "Dithering";
            this._ButtonDithering.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._ButtonDithering.UseSelectable = true;
            this._ButtonDithering.Click += new System.EventHandler(this._ButtonDithering_Click);
            // 
            // _ProgressBar
            // 
            this._ProgressBar.Location = new System.Drawing.Point(484, 225);
            this._ProgressBar.Name = "_ProgressBar";
            this._ProgressBar.Size = new System.Drawing.Size(221, 10);
            this._ProgressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this._ProgressBar.TabIndex = 8;
            this._ProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this._ProgressBar);
            this.Controls.Add(this._ButtonDithering);
            this.Controls.Add(this._ButtonImage);
            this.Controls.Add(this._PictureBox2);
            this.Controls.Add(this._PictureBox1);
            this.Name = "Form1";
            this.Text = "Dithering";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _PictureBox1;
        private System.Windows.Forms.PictureBox _PictureBox2;
        private MetroFramework.Controls.MetroButton _ButtonImage;
        private MetroFramework.Controls.MetroButton _ButtonDithering;
        private MetroFramework.Controls.MetroProgressBar _ProgressBar;
    }
}

