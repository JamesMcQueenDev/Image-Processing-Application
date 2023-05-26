
namespace GUI
{
    partial class PictureApplication
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FlipY = new System.Windows.Forms.Button();
            this.FlipX = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.AnticlockwiseRotate = new System.Windows.Forms.Button();
            this.ClockwiseRotate = new System.Windows.Forms.Button();
            this.ResolutionLabel = new System.Windows.Forms.Label();
            this.Previous_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.BrightnessStepDown = new System.Windows.Forms.Button();
            this.BrightnessStepUp = new System.Windows.Forms.Button();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContrastStepUp = new System.Windows.Forms.Button();
            this.ContrastStepDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SaturationStepUp = new System.Windows.Forms.Button();
            this.SaturationStepDown = new System.Windows.Forms.Button();
            this.PictureList = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.CropButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ScaleUp = new System.Windows.Forms.Button();
            this.ScaleDown = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(154, 21);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(622, 341);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(21, 578);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(121, 26);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(810, 529);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 26);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FlipY
            // 
            this.FlipY.Location = new System.Drawing.Point(21, 58);
            this.FlipY.Margin = new System.Windows.Forms.Padding(2);
            this.FlipY.Name = "FlipY";
            this.FlipY.Size = new System.Drawing.Size(121, 26);
            this.FlipY.TabIndex = 4;
            this.FlipY.Text = "FlipY";
            this.FlipY.UseVisualStyleBackColor = true;
            this.FlipY.Click += new System.EventHandler(this.FlipY_Click);
            // 
            // FlipX
            // 
            this.FlipX.Location = new System.Drawing.Point(21, 88);
            this.FlipX.Margin = new System.Windows.Forms.Padding(2);
            this.FlipX.Name = "FlipX";
            this.FlipX.Size = new System.Drawing.Size(121, 26);
            this.FlipX.TabIndex = 5;
            this.FlipX.Text = "FlipX";
            this.FlipX.UseVisualStyleBackColor = true;
            this.FlipX.Click += new System.EventHandler(this.FlipX_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(810, 575);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(121, 26);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Exit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // AnticlockwiseRotate
            // 
            this.AnticlockwiseRotate.Location = new System.Drawing.Point(14, 195);
            this.AnticlockwiseRotate.Margin = new System.Windows.Forms.Padding(2);
            this.AnticlockwiseRotate.Name = "AnticlockwiseRotate";
            this.AnticlockwiseRotate.Size = new System.Drawing.Size(32, 26);
            this.AnticlockwiseRotate.TabIndex = 8;
            this.AnticlockwiseRotate.Text = "<";
            this.AnticlockwiseRotate.UseVisualStyleBackColor = true;
            this.AnticlockwiseRotate.Click += new System.EventHandler(this.AnticlockwiseRotate_Click);
            // 
            // ClockwiseRotate
            // 
            this.ClockwiseRotate.Location = new System.Drawing.Point(111, 195);
            this.ClockwiseRotate.Margin = new System.Windows.Forms.Padding(2);
            this.ClockwiseRotate.Name = "ClockwiseRotate";
            this.ClockwiseRotate.Size = new System.Drawing.Size(32, 26);
            this.ClockwiseRotate.TabIndex = 7;
            this.ClockwiseRotate.Text = ">";
            this.ClockwiseRotate.UseVisualStyleBackColor = true;
            this.ClockwiseRotate.Click += new System.EventHandler(this.ClockwiseRotate_Click);
            // 
            // ResolutionLabel
            // 
            this.ResolutionLabel.AutoSize = true;
            this.ResolutionLabel.Location = new System.Drawing.Point(341, 367);
            this.ResolutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResolutionLabel.Name = "ResolutionLabel";
            this.ResolutionLabel.Size = new System.Drawing.Size(0, 13);
            this.ResolutionLabel.TabIndex = 9;
            // 
            // Previous_Button
            // 
            this.Previous_Button.Location = new System.Drawing.Point(21, 377);
            this.Previous_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Previous_Button.Name = "Previous_Button";
            this.Previous_Button.Size = new System.Drawing.Size(121, 26);
            this.Previous_Button.TabIndex = 10;
            this.Previous_Button.Text = "Previous";
            this.Previous_Button.UseVisualStyleBackColor = true;
            this.Previous_Button.Click += new System.EventHandler(this.Previous_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.Location = new System.Drawing.Point(21, 430);
            this.Next_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(121, 26);
            this.Next_Button.TabIndex = 11;
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // BrightnessStepDown
            // 
            this.BrightnessStepDown.Location = new System.Drawing.Point(810, 94);
            this.BrightnessStepDown.Margin = new System.Windows.Forms.Padding(2);
            this.BrightnessStepDown.Name = "BrightnessStepDown";
            this.BrightnessStepDown.Size = new System.Drawing.Size(32, 26);
            this.BrightnessStepDown.TabIndex = 12;
            this.BrightnessStepDown.Text = "-";
            this.BrightnessStepDown.UseVisualStyleBackColor = true;
            this.BrightnessStepDown.Click += new System.EventHandler(this.BrightnessStepDown_Click);
            // 
            // BrightnessStepUp
            // 
            this.BrightnessStepUp.Location = new System.Drawing.Point(907, 95);
            this.BrightnessStepUp.Margin = new System.Windows.Forms.Padding(2);
            this.BrightnessStepUp.Name = "BrightnessStepUp";
            this.BrightnessStepUp.Size = new System.Drawing.Size(32, 26);
            this.BrightnessStepUp.TabIndex = 13;
            this.BrightnessStepUp.Text = "+";
            this.BrightnessStepUp.UseVisualStyleBackColor = true;
            this.BrightnessStepUp.Click += new System.EventHandler(this.BrightnessStepUp_Click);
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(846, 101);
            this.BrightnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.BrightnessLabel.TabIndex = 14;
            this.BrightnessLabel.Text = "Brightness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(851, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contrast";
            // 
            // ContrastStepUp
            // 
            this.ContrastStepUp.Location = new System.Drawing.Point(907, 133);
            this.ContrastStepUp.Margin = new System.Windows.Forms.Padding(2);
            this.ContrastStepUp.Name = "ContrastStepUp";
            this.ContrastStepUp.Size = new System.Drawing.Size(32, 26);
            this.ContrastStepUp.TabIndex = 16;
            this.ContrastStepUp.Text = "+";
            this.ContrastStepUp.UseVisualStyleBackColor = true;
            this.ContrastStepUp.Click += new System.EventHandler(this.ContrastStepUp_Click);
            // 
            // ContrastStepDown
            // 
            this.ContrastStepDown.Location = new System.Drawing.Point(810, 132);
            this.ContrastStepDown.Margin = new System.Windows.Forms.Padding(2);
            this.ContrastStepDown.Name = "ContrastStepDown";
            this.ContrastStepDown.Size = new System.Drawing.Size(32, 26);
            this.ContrastStepDown.TabIndex = 15;
            this.ContrastStepDown.Text = "-";
            this.ContrastStepDown.UseVisualStyleBackColor = true;
            this.ContrastStepDown.Click += new System.EventHandler(this.ContrastStepDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Saturation";
            // 
            // SaturationStepUp
            // 
            this.SaturationStepUp.Location = new System.Drawing.Point(907, 172);
            this.SaturationStepUp.Margin = new System.Windows.Forms.Padding(2);
            this.SaturationStepUp.Name = "SaturationStepUp";
            this.SaturationStepUp.Size = new System.Drawing.Size(32, 26);
            this.SaturationStepUp.TabIndex = 19;
            this.SaturationStepUp.Text = "+";
            this.SaturationStepUp.UseVisualStyleBackColor = true;
            this.SaturationStepUp.Click += new System.EventHandler(this.SaturationStepUp_Click);
            // 
            // SaturationStepDown
            // 
            this.SaturationStepDown.Location = new System.Drawing.Point(810, 171);
            this.SaturationStepDown.Margin = new System.Windows.Forms.Padding(2);
            this.SaturationStepDown.Name = "SaturationStepDown";
            this.SaturationStepDown.Size = new System.Drawing.Size(32, 26);
            this.SaturationStepDown.TabIndex = 18;
            this.SaturationStepDown.Text = "-";
            this.SaturationStepDown.UseVisualStyleBackColor = true;
            this.SaturationStepDown.Click += new System.EventHandler(this.SaturationStepDown_Click);
            // 
            // PictureList
            // 
            this.PictureList.HideSelection = false;
            this.PictureList.Location = new System.Drawing.Point(154, 377);
            this.PictureList.Margin = new System.Windows.Forms.Padding(2);
            this.PictureList.Name = "PictureList";
            this.PictureList.Size = new System.Drawing.Size(623, 230);
            this.PictureList.TabIndex = 21;
            this.PictureList.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rotate";
            // 
            // CropButton
            // 
            this.CropButton.Location = new System.Drawing.Point(21, 141);
            this.CropButton.Margin = new System.Windows.Forms.Padding(2);
            this.CropButton.Name = "CropButton";
            this.CropButton.Size = new System.Drawing.Size(121, 26);
            this.CropButton.TabIndex = 24;
            this.CropButton.Text = "Crop";
            this.CropButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(859, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Scale";
            // 
            // ScaleUp
            // 
            this.ScaleUp.Location = new System.Drawing.Point(907, 21);
            this.ScaleUp.Margin = new System.Windows.Forms.Padding(2);
            this.ScaleUp.Name = "ScaleUp";
            this.ScaleUp.Size = new System.Drawing.Size(32, 26);
            this.ScaleUp.TabIndex = 26;
            this.ScaleUp.Text = "+";
            this.ScaleUp.UseVisualStyleBackColor = true;
            this.ScaleUp.Click += new System.EventHandler(this.ScaleUp_Click);
            // 
            // ScaleDown
            // 
            this.ScaleDown.Location = new System.Drawing.Point(810, 20);
            this.ScaleDown.Margin = new System.Windows.Forms.Padding(2);
            this.ScaleDown.Name = "ScaleDown";
            this.ScaleDown.Size = new System.Drawing.Size(32, 26);
            this.ScaleDown.TabIndex = 25;
            this.ScaleDown.Text = "-";
            this.ScaleDown.UseVisualStyleBackColor = true;
            this.ScaleDown.Click += new System.EventHandler(this.ScaleDown_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(22, 257);
            this.undoButton.Margin = new System.Windows.Forms.Padding(2);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(121, 26);
            this.undoButton.TabIndex = 28;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.Location = new System.Drawing.Point(21, 305);
            this.redoButton.Margin = new System.Windows.Forms.Padding(2);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(121, 26);
            this.redoButton.TabIndex = 29;
            this.redoButton.Text = "Redo";
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // PictureApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 627);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ScaleUp);
            this.Controls.Add(this.ScaleDown);
            this.Controls.Add(this.CropButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaturationStepUp);
            this.Controls.Add(this.SaturationStepDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContrastStepUp);
            this.Controls.Add(this.ContrastStepDown);
            this.Controls.Add(this.BrightnessLabel);
            this.Controls.Add(this.BrightnessStepUp);
            this.Controls.Add(this.BrightnessStepDown);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Previous_Button);
            this.Controls.Add(this.ResolutionLabel);
            this.Controls.Add(this.AnticlockwiseRotate);
            this.Controls.Add(this.ClockwiseRotate);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FlipX);
            this.Controls.Add(this.FlipY);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PictureApplication";
            this.Text = "Picture Manipulation";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button FlipY;
        private System.Windows.Forms.Button FlipX;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button AnticlockwiseRotate;
        private System.Windows.Forms.Button ClockwiseRotate;
        private System.Windows.Forms.Label ResolutionLabel;
        private System.Windows.Forms.Button Previous_Button;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.Button BrightnessStepDown;
        private System.Windows.Forms.Button BrightnessStepUp;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ContrastStepUp;
        private System.Windows.Forms.Button ContrastStepDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaturationStepUp;
        private System.Windows.Forms.Button SaturationStepDown;
        private System.Windows.Forms.ListView PictureList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CropButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ScaleUp;
        private System.Windows.Forms.Button ScaleDown;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
    }
}

