namespace MyGallery
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbGallery = new System.Windows.Forms.PictureBox();
            this.rbPictureOne = new System.Windows.Forms.RadioButton();
            this.rbPictureTwo = new System.Windows.Forms.RadioButton();
            this.rbPictureThree = new System.Windows.Forms.RadioButton();
            this.rbPictureFour = new System.Windows.Forms.RadioButton();
            this.rbPictureFive = new System.Windows.Forms.RadioButton();
            this.btnStartShow = new System.Windows.Forms.Button();
            this.btnStopShow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGallery
            // 
            this.pbGallery.Image = global::MyGallery.Properties.Resources.photo_1526346698789_22fd84314424;
            this.pbGallery.Location = new System.Drawing.Point(144, 57);
            this.pbGallery.Name = "pbGallery";
            this.pbGallery.Size = new System.Drawing.Size(459, 349);
            this.pbGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGallery.TabIndex = 0;
            this.pbGallery.TabStop = false;
            // 
            // rbPictureOne
            // 
            this.rbPictureOne.AutoSize = true;
            this.rbPictureOne.Location = new System.Drawing.Point(668, 297);
            this.rbPictureOne.Name = "rbPictureOne";
            this.rbPictureOne.Size = new System.Drawing.Size(49, 17);
            this.rbPictureOne.TabIndex = 1;
            this.rbPictureOne.TabStop = true;
            this.rbPictureOne.Text = "Pic 1";
            this.rbPictureOne.UseVisualStyleBackColor = true;
            this.rbPictureOne.CheckedChanged += new System.EventHandler(this.rbPictureOne_CheckedChanged);
            // 
            // rbPictureTwo
            // 
            this.rbPictureTwo.AutoSize = true;
            this.rbPictureTwo.Location = new System.Drawing.Point(668, 320);
            this.rbPictureTwo.Name = "rbPictureTwo";
            this.rbPictureTwo.Size = new System.Drawing.Size(49, 17);
            this.rbPictureTwo.TabIndex = 2;
            this.rbPictureTwo.TabStop = true;
            this.rbPictureTwo.Text = "Pic 2";
            this.rbPictureTwo.UseVisualStyleBackColor = true;
            this.rbPictureTwo.CheckedChanged += new System.EventHandler(this.rbPictureTwo_CheckedChanged);
            // 
            // rbPictureThree
            // 
            this.rbPictureThree.AutoSize = true;
            this.rbPictureThree.Location = new System.Drawing.Point(668, 343);
            this.rbPictureThree.Name = "rbPictureThree";
            this.rbPictureThree.Size = new System.Drawing.Size(49, 17);
            this.rbPictureThree.TabIndex = 3;
            this.rbPictureThree.TabStop = true;
            this.rbPictureThree.Text = "Pic 3";
            this.rbPictureThree.UseVisualStyleBackColor = true;
            this.rbPictureThree.CheckedChanged += new System.EventHandler(this.rbPictureThree_CheckedChanged);
            // 
            // rbPictureFour
            // 
            this.rbPictureFour.AutoSize = true;
            this.rbPictureFour.Location = new System.Drawing.Point(668, 366);
            this.rbPictureFour.Name = "rbPictureFour";
            this.rbPictureFour.Size = new System.Drawing.Size(49, 17);
            this.rbPictureFour.TabIndex = 4;
            this.rbPictureFour.TabStop = true;
            this.rbPictureFour.Text = "Pic 4";
            this.rbPictureFour.UseVisualStyleBackColor = true;
            // 
            // rbPictureFive
            // 
            this.rbPictureFive.AutoSize = true;
            this.rbPictureFive.Location = new System.Drawing.Point(668, 389);
            this.rbPictureFive.Name = "rbPictureFive";
            this.rbPictureFive.Size = new System.Drawing.Size(49, 17);
            this.rbPictureFive.TabIndex = 5;
            this.rbPictureFive.TabStop = true;
            this.rbPictureFive.Text = "Pic 5";
            this.rbPictureFive.UseVisualStyleBackColor = true;
            // 
            // btnStartShow
            // 
            this.btnStartShow.Location = new System.Drawing.Point(697, 34);
            this.btnStartShow.Name = "btnStartShow";
            this.btnStartShow.Size = new System.Drawing.Size(75, 23);
            this.btnStartShow.TabIndex = 6;
            this.btnStartShow.Text = "Start";
            this.btnStartShow.UseVisualStyleBackColor = true;
            this.btnStartShow.Click += new System.EventHandler(this.btnStartShow_Click);
            // 
            // btnStopShow
            // 
            this.btnStopShow.Location = new System.Drawing.Point(697, 63);
            this.btnStopShow.Name = "btnStopShow";
            this.btnStopShow.Size = new System.Drawing.Size(75, 23);
            this.btnStopShow.TabIndex = 7;
            this.btnStopShow.Text = "Stop";
            this.btnStopShow.UseVisualStyleBackColor = true;
            this.btnStopShow.Click += new System.EventHandler(this.btnStopShow_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLarge
            // 
            this.btnLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLarge.Location = new System.Drawing.Point(248, 426);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 42);
            this.btnLarge.TabIndex = 8;
            this.btnLarge.Text = "+";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSmall.Location = new System.Drawing.Point(446, 424);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 46);
            this.btnSmall.TabIndex = 9;
            this.btnSmall.Text = "-";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRight.Location = new System.Drawing.Point(626, 206);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 47);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeft.Location = new System.Drawing.Point(46, 206);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 47);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnStopShow);
            this.Controls.Add(this.btnStartShow);
            this.Controls.Add(this.rbPictureFive);
            this.Controls.Add(this.rbPictureFour);
            this.Controls.Add(this.rbPictureThree);
            this.Controls.Add(this.rbPictureTwo);
            this.Controls.Add(this.rbPictureOne);
            this.Controls.Add(this.pbGallery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGallery;
        private System.Windows.Forms.RadioButton rbPictureOne;
        private System.Windows.Forms.RadioButton rbPictureTwo;
        private System.Windows.Forms.RadioButton rbPictureThree;
        private System.Windows.Forms.RadioButton rbPictureFour;
        private System.Windows.Forms.RadioButton rbPictureFive;
        private System.Windows.Forms.Button btnStartShow;
        private System.Windows.Forms.Button btnStopShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}

