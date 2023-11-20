namespace RealPaint
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.oval_btn = new System.Windows.Forms.Button();
            this.circle_btn = new System.Windows.Forms.Button();
            this.paintFunction_pnl = new System.Windows.Forms.Panel();
            this.FileEdit_pnl = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.color_pnl = new System.Windows.Forms.Panel();
            this.undo_btn = new System.Windows.Forms.Button();
            this.saveFile_btn = new System.Windows.Forms.Button();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.rectangle_btn = new System.Windows.Forms.Button();
            this.square_btn = new System.Windows.Forms.Button();
            this.star_btn = new System.Windows.Forms.Button();
            this.pentagon_btn = new System.Windows.Forms.Button();
            this.triangle_btn = new System.Windows.Forms.Button();
            this.formatColorFill_btn = new System.Windows.Forms.Button();
            this.line_btn = new System.Windows.Forms.Button();
            this.borderColor_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.marker_btn = new System.Windows.Forms.Button();
            this.eraser_btn = new System.Windows.Forms.Button();
            this.pencil_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.presentColor = new System.Windows.Forms.PictureBox();
            this.whiteColor_btn = new System.Windows.Forms.Button();
            this.grayColor_btn = new System.Windows.Forms.Button();
            this.dimGrayColor_btn = new System.Windows.Forms.Button();
            this.blackColor_btn = new System.Windows.Forms.Button();
            this.LinenColor_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.paintFunction_pnl.SuspendLayout();
            this.FileEdit_pnl.SuspendLayout();
            this.color_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentColor)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // oval_btn
            // 
            this.oval_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.oval_btn.Location = new System.Drawing.Point(53, 280);
            this.oval_btn.Name = "oval_btn";
            this.oval_btn.Size = new System.Drawing.Size(40, 34);
            this.oval_btn.TabIndex = 12;
            this.oval_btn.Text = "oval";
            this.oval_btn.UseVisualStyleBackColor = true;
            // 
            // circle_btn
            // 
            this.circle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circle_btn.Location = new System.Drawing.Point(7, 280);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(40, 34);
            this.circle_btn.TabIndex = 13;
            this.circle_btn.Text = "circle";
            this.circle_btn.UseVisualStyleBackColor = true;
            // 
            // paintFunction_pnl
            // 
            this.paintFunction_pnl.BackColor = System.Drawing.Color.White;
            this.paintFunction_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paintFunction_pnl.Controls.Add(this.oval_btn);
            this.paintFunction_pnl.Controls.Add(this.circle_btn);
            this.paintFunction_pnl.Controls.Add(this.rectangle_btn);
            this.paintFunction_pnl.Controls.Add(this.square_btn);
            this.paintFunction_pnl.Controls.Add(this.star_btn);
            this.paintFunction_pnl.Controls.Add(this.pentagon_btn);
            this.paintFunction_pnl.Controls.Add(this.triangle_btn);
            this.paintFunction_pnl.Controls.Add(this.formatColorFill_btn);
            this.paintFunction_pnl.Controls.Add(this.line_btn);
            this.paintFunction_pnl.Controls.Add(this.borderColor_btn);
            this.paintFunction_pnl.Controls.Add(this.button1);
            this.paintFunction_pnl.Controls.Add(this.marker_btn);
            this.paintFunction_pnl.Controls.Add(this.eraser_btn);
            this.paintFunction_pnl.Controls.Add(this.pencil_btn);
            this.paintFunction_pnl.Location = new System.Drawing.Point(12, 137);
            this.paintFunction_pnl.Name = "paintFunction_pnl";
            this.paintFunction_pnl.Size = new System.Drawing.Size(107, 390);
            this.paintFunction_pnl.TabIndex = 4;
            // 
            // FileEdit_pnl
            // 
            this.FileEdit_pnl.BackColor = System.Drawing.Color.White;
            this.FileEdit_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FileEdit_pnl.Controls.Add(this.undo_btn);
            this.FileEdit_pnl.Controls.Add(this.saveFile_btn);
            this.FileEdit_pnl.Controls.Add(this.openFile_btn);
            this.FileEdit_pnl.Location = new System.Drawing.Point(12, 26);
            this.FileEdit_pnl.Name = "FileEdit_pnl";
            this.FileEdit_pnl.Size = new System.Drawing.Size(107, 96);
            this.FileEdit_pnl.TabIndex = 5;
            // 
            // color_pnl
            // 
            this.color_pnl.BackColor = System.Drawing.Color.White;
            this.color_pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.color_pnl.Controls.Add(this.button8);
            this.color_pnl.Controls.Add(this.button7);
            this.color_pnl.Controls.Add(this.button6);
            this.color_pnl.Controls.Add(this.button5);
            this.color_pnl.Controls.Add(this.button4);
            this.color_pnl.Controls.Add(this.button3);
            this.color_pnl.Controls.Add(this.button2);
            this.color_pnl.Controls.Add(this.LinenColor_btn);
            this.color_pnl.Controls.Add(this.blackColor_btn);
            this.color_pnl.Controls.Add(this.dimGrayColor_btn);
            this.color_pnl.Controls.Add(this.grayColor_btn);
            this.color_pnl.Controls.Add(this.whiteColor_btn);
            this.color_pnl.Controls.Add(this.presentColor);
            this.color_pnl.Location = new System.Drawing.Point(12, 548);
            this.color_pnl.Name = "color_pnl";
            this.color_pnl.Size = new System.Drawing.Size(107, 161);
            this.color_pnl.TabIndex = 6;
            // 
            // undo_btn
            // 
            this.undo_btn.BackgroundImage = global::RealPaint.Properties.Resources.undo_FILL0_wght400_GRAD0_opsz24;
            this.undo_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.undo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.undo_btn.Location = new System.Drawing.Point(7, 53);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(40, 34);
            this.undo_btn.TabIndex = 2;
            this.undo_btn.UseVisualStyleBackColor = true;
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.BackgroundImage = global::RealPaint.Properties.Resources.save;
            this.saveFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFile_btn.Location = new System.Drawing.Point(7, 8);
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(40, 34);
            this.saveFile_btn.TabIndex = 1;
            this.saveFile_btn.UseVisualStyleBackColor = true;
            // 
            // openFile_btn
            // 
            this.openFile_btn.BackgroundImage = global::RealPaint.Properties.Resources.folder_open_FILL0_wght400_GRAD0_opsz24;
            this.openFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openFile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFile_btn.Location = new System.Drawing.Point(60, 8);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(40, 34);
            this.openFile_btn.TabIndex = 0;
            this.openFile_btn.UseVisualStyleBackColor = true;
            // 
            // rectangle_btn
            // 
            this.rectangle_btn.BackgroundImage = global::RealPaint.Properties.Resources.rectangle_FILL0_wght400_GRAD0_opsz24;
            this.rectangle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rectangle_btn.Location = new System.Drawing.Point(7, 190);
            this.rectangle_btn.Name = "rectangle_btn";
            this.rectangle_btn.Size = new System.Drawing.Size(40, 34);
            this.rectangle_btn.TabIndex = 11;
            this.rectangle_btn.UseVisualStyleBackColor = true;
            // 
            // square_btn
            // 
            this.square_btn.BackgroundImage = global::RealPaint.Properties.Resources.square_FILL0_wght400_GRAD0_opsz24;
            this.square_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.square_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square_btn.Location = new System.Drawing.Point(53, 190);
            this.square_btn.Name = "square_btn";
            this.square_btn.Size = new System.Drawing.Size(40, 34);
            this.square_btn.TabIndex = 10;
            this.square_btn.UseVisualStyleBackColor = true;
            // 
            // star_btn
            // 
            this.star_btn.BackgroundImage = global::RealPaint.Properties.Resources.star_FILL0_wght400_GRAD0_opsz24;
            this.star_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.star_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.star_btn.Location = new System.Drawing.Point(7, 235);
            this.star_btn.Name = "star_btn";
            this.star_btn.Size = new System.Drawing.Size(40, 34);
            this.star_btn.TabIndex = 16;
            this.star_btn.UseVisualStyleBackColor = true;
            // 
            // pentagon_btn
            // 
            this.pentagon_btn.BackgroundImage = global::RealPaint.Properties.Resources.pentagon_FILL0_wght400_GRAD0_opsz24;
            this.pentagon_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pentagon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pentagon_btn.Location = new System.Drawing.Point(53, 235);
            this.pentagon_btn.Name = "pentagon_btn";
            this.pentagon_btn.Size = new System.Drawing.Size(40, 34);
            this.pentagon_btn.TabIndex = 15;
            this.pentagon_btn.UseVisualStyleBackColor = true;
            // 
            // triangle_btn
            // 
            this.triangle_btn.BackgroundImage = global::RealPaint.Properties.Resources.change_history_FILL0_wght400_GRAD0_opsz24;
            this.triangle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.triangle_btn.Location = new System.Drawing.Point(53, 145);
            this.triangle_btn.Name = "triangle_btn";
            this.triangle_btn.Size = new System.Drawing.Size(40, 34);
            this.triangle_btn.TabIndex = 14;
            this.triangle_btn.UseVisualStyleBackColor = true;
            // 
            // formatColorFill_btn
            // 
            this.formatColorFill_btn.BackgroundImage = global::RealPaint.Properties.Resources.format_color_fill_FILL0_wght400_GRAD0_opsz24;
            this.formatColorFill_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.formatColorFill_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.formatColorFill_btn.Location = new System.Drawing.Point(53, 100);
            this.formatColorFill_btn.Name = "formatColorFill_btn";
            this.formatColorFill_btn.Size = new System.Drawing.Size(40, 34);
            this.formatColorFill_btn.TabIndex = 9;
            this.formatColorFill_btn.UseVisualStyleBackColor = true;
            // 
            // line_btn
            // 
            this.line_btn.BackgroundImage = global::RealPaint.Properties.Resources.horizontal_rule_FILL0_wght400_GRAD0_opsz24;
            this.line_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.line_btn.Location = new System.Drawing.Point(7, 145);
            this.line_btn.Name = "line_btn";
            this.line_btn.Size = new System.Drawing.Size(40, 34);
            this.line_btn.TabIndex = 17;
            this.line_btn.UseVisualStyleBackColor = true;
            // 
            // borderColor_btn
            // 
            this.borderColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borderColor_btn.Image = global::RealPaint.Properties.Resources.border_color_FILL0_wght400_GRAD0_opsz24;
            this.borderColor_btn.Location = new System.Drawing.Point(7, 100);
            this.borderColor_btn.Name = "borderColor_btn";
            this.borderColor_btn.Size = new System.Drawing.Size(40, 34);
            this.borderColor_btn.TabIndex = 8;
            this.borderColor_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RealPaint.Properties.Resources.crop;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(53, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // marker_btn
            // 
            this.marker_btn.BackgroundImage = global::RealPaint.Properties.Resources.marker;
            this.marker_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.marker_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.marker_btn.Location = new System.Drawing.Point(7, 55);
            this.marker_btn.Name = "marker_btn";
            this.marker_btn.Size = new System.Drawing.Size(40, 34);
            this.marker_btn.TabIndex = 6;
            this.marker_btn.UseVisualStyleBackColor = true;
            // 
            // eraser_btn
            // 
            this.eraser_btn.BackgroundImage = global::RealPaint.Properties.Resources.eraser;
            this.eraser_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eraser_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eraser_btn.Location = new System.Drawing.Point(53, 10);
            this.eraser_btn.Name = "eraser_btn";
            this.eraser_btn.Size = new System.Drawing.Size(40, 34);
            this.eraser_btn.TabIndex = 5;
            this.eraser_btn.UseVisualStyleBackColor = true;
            // 
            // pencil_btn
            // 
            this.pencil_btn.BackgroundImage = global::RealPaint.Properties.Resources.pencil;
            this.pencil_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pencil_btn.FlatAppearance.BorderSize = 0;
            this.pencil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pencil_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pencil_btn.Location = new System.Drawing.Point(7, 10);
            this.pencil_btn.Name = "pencil_btn";
            this.pencil_btn.Size = new System.Drawing.Size(40, 34);
            this.pencil_btn.TabIndex = 4;
            this.pencil_btn.UseVisualStyleBackColor = true;
            this.pencil_btn.Click += new System.EventHandler(this.pencil_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(137, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 683);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // presentColor
            // 
            this.presentColor.BackColor = System.Drawing.Color.Silver;
            this.presentColor.Location = new System.Drawing.Point(26, 3);
            this.presentColor.Name = "presentColor";
            this.presentColor.Size = new System.Drawing.Size(40, 37);
            this.presentColor.TabIndex = 0;
            this.presentColor.TabStop = false;
            this.presentColor.Click += new System.EventHandler(this.presentColor_Click);
            // 
            // whiteColor_btn
            // 
            this.whiteColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.whiteColor_btn.Location = new System.Drawing.Point(4, 46);
            this.whiteColor_btn.Name = "whiteColor_btn";
            this.whiteColor_btn.Size = new System.Drawing.Size(22, 18);
            this.whiteColor_btn.TabIndex = 1;
            this.whiteColor_btn.UseVisualStyleBackColor = true;
            // 
            // grayColor_btn
            // 
            this.grayColor_btn.BackColor = System.Drawing.Color.Silver;
            this.grayColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grayColor_btn.Location = new System.Drawing.Point(3, 70);
            this.grayColor_btn.Name = "grayColor_btn";
            this.grayColor_btn.Size = new System.Drawing.Size(22, 18);
            this.grayColor_btn.TabIndex = 2;
            this.grayColor_btn.UseVisualStyleBackColor = false;
            // 
            // dimGrayColor_btn
            // 
            this.dimGrayColor_btn.BackColor = System.Drawing.Color.DimGray;
            this.dimGrayColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dimGrayColor_btn.Location = new System.Drawing.Point(4, 94);
            this.dimGrayColor_btn.Name = "dimGrayColor_btn";
            this.dimGrayColor_btn.Size = new System.Drawing.Size(22, 18);
            this.dimGrayColor_btn.TabIndex = 4;
            this.dimGrayColor_btn.UseVisualStyleBackColor = false;
            // 
            // blackColor_btn
            // 
            this.blackColor_btn.BackColor = System.Drawing.Color.DimGray;
            this.blackColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blackColor_btn.Location = new System.Drawing.Point(3, 118);
            this.blackColor_btn.Name = "blackColor_btn";
            this.blackColor_btn.Size = new System.Drawing.Size(22, 18);
            this.blackColor_btn.TabIndex = 5;
            this.blackColor_btn.UseVisualStyleBackColor = false;
            // 
            // LinenColor_btn
            // 
            this.LinenColor_btn.BackColor = System.Drawing.Color.Linen;
            this.LinenColor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LinenColor_btn.Location = new System.Drawing.Point(32, 46);
            this.LinenColor_btn.Name = "LinenColor_btn";
            this.LinenColor_btn.Size = new System.Drawing.Size(22, 18);
            this.LinenColor_btn.TabIndex = 6;
            this.LinenColor_btn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(32, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 18);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(32, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 18);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(31, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(22, 18);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(60, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 18);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LavenderBlush;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(60, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(22, 18);
            this.button6.TabIndex = 11;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Ivory;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(60, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(22, 18);
            this.button7.TabIndex = 12;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lime;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(59, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(22, 18);
            this.button8.TabIndex = 13;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1227, 733);
            this.Controls.Add(this.color_pnl);
            this.Controls.Add(this.FileEdit_pnl);
            this.Controls.Add(this.paintFunction_pnl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainInTheAss";
            this.paintFunction_pnl.ResumeLayout(false);
            this.FileEdit_pnl.ResumeLayout(false);
            this.color_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pencil_btn;
        private System.Windows.Forms.Button eraser_btn;
        private System.Windows.Forms.Button marker_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button borderColor_btn;
        private System.Windows.Forms.Button formatColorFill_btn;
        private System.Windows.Forms.Button square_btn;
        private System.Windows.Forms.Button rectangle_btn;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.Button oval_btn;
        private System.Windows.Forms.Button triangle_btn;
        private System.Windows.Forms.Button pentagon_btn;
        private System.Windows.Forms.Button star_btn;
        private System.Windows.Forms.Button line_btn;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Button saveFile_btn;
        private System.Windows.Forms.Panel paintFunction_pnl;
        private System.Windows.Forms.Panel FileEdit_pnl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel color_pnl;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.PictureBox presentColor;
        private System.Windows.Forms.Button whiteColor_btn;
        private System.Windows.Forms.Button dimGrayColor_btn;
        private System.Windows.Forms.Button grayColor_btn;
        private System.Windows.Forms.Button LinenColor_btn;
        private System.Windows.Forms.Button blackColor_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

