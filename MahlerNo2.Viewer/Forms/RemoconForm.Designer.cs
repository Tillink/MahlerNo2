﻿using System.Windows.Forms;
using MahlerNo2.Viewer.Controls;

namespace MahlerNo2.Viewer.Forms
{
    partial class RemoconForm
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
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLast = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnN = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnNN = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnNNN = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnP = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnPP = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnPPP = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnFirst = new MahlerNo2.Viewer.Controls.MoveButton();
            this.btnBrighten = new Button();
            this.btnDarken = new Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new Button();
            this.btnRatio = new Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTime.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(6, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(146, 32);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "12:34:56";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Image = global::MahlerNo2.Viewer.Properties.Resources.Last;
            this.btnLast.Location = new System.Drawing.Point(120, 96);
            this.btnLast.Name = "btnLast";
            this.btnLast.Second = 0;
            this.btnLast.Size = new System.Drawing.Size(32, 32);
            this.btnLast.TabIndex = 7;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnN
            // 
            this.btnN.Image = global::MahlerNo2.Viewer.Properties.Resources.N;
            this.btnN.Location = new System.Drawing.Point(6, 96);
            this.btnN.Name = "btnN";
            this.btnN.Second = 0;
            this.btnN.Size = new System.Drawing.Size(32, 32);
            this.btnN.TabIndex = 6;
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnNN
            // 
            this.btnNN.Image = global::MahlerNo2.Viewer.Properties.Resources.NN;
            this.btnNN.Location = new System.Drawing.Point(44, 96);
            this.btnNN.Name = "btnNN";
            this.btnNN.Second = 0;
            this.btnNN.Size = new System.Drawing.Size(32, 32);
            this.btnNN.TabIndex = 5;
            this.btnNN.UseVisualStyleBackColor = true;
            this.btnNN.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnNNN
            // 
            this.btnNNN.Image = global::MahlerNo2.Viewer.Properties.Resources.NNN;
            this.btnNNN.Location = new System.Drawing.Point(82, 96);
            this.btnNNN.Name = "btnNNN";
            this.btnNNN.Second = 0;
            this.btnNNN.Size = new System.Drawing.Size(32, 32);
            this.btnNNN.TabIndex = 4;
            this.btnNNN.UseVisualStyleBackColor = true;
            this.btnNNN.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnP
            // 
            this.btnP.Image = global::MahlerNo2.Viewer.Properties.Resources.P;
            this.btnP.Location = new System.Drawing.Point(120, 58);
            this.btnP.Name = "btnP";
            this.btnP.Second = 0;
            this.btnP.Size = new System.Drawing.Size(32, 32);
            this.btnP.TabIndex = 3;
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnPP
            // 
            this.btnPP.Image = global::MahlerNo2.Viewer.Properties.Resources.PP;
            this.btnPP.Location = new System.Drawing.Point(82, 58);
            this.btnPP.Name = "btnPP";
            this.btnPP.Second = 0;
            this.btnPP.Size = new System.Drawing.Size(32, 32);
            this.btnPP.TabIndex = 2;
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnPPP
            // 
            this.btnPPP.Image = global::MahlerNo2.Viewer.Properties.Resources.PPP;
            this.btnPPP.Location = new System.Drawing.Point(44, 58);
            this.btnPPP.Name = "btnPPP";
            this.btnPPP.Second = 0;
            this.btnPPP.Size = new System.Drawing.Size(32, 32);
            this.btnPPP.TabIndex = 1;
            this.btnPPP.UseVisualStyleBackColor = true;
            this.btnPPP.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Image = global::MahlerNo2.Viewer.Properties.Resources.First;
            this.btnFirst.Location = new System.Drawing.Point(6, 58);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Second = 0;
            this.btnFirst.Size = new System.Drawing.Size(32, 32);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnBrighten
            // 
            this.btnBrighten.Image = global::MahlerNo2.Viewer.Properties.Resources.Brighten;
            this.btnBrighten.Location = new System.Drawing.Point(44, 20);
            this.btnBrighten.Name = "btnBrighten";
            this.btnBrighten.Size = new System.Drawing.Size(32, 32);
            this.btnBrighten.TabIndex = 10;
            this.btnBrighten.UseVisualStyleBackColor = true;
            this.btnBrighten.Click += new System.EventHandler(this.btnBrighten_Click);
            // 
            // btnDarken
            // 
            this.btnDarken.Image = global::MahlerNo2.Viewer.Properties.Resources.Darken;
            this.btnDarken.Location = new System.Drawing.Point(6, 20);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(32, 32);
            this.btnDarken.TabIndex = 11;
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFirst);
            this.groupBox1.Controls.Add(this.btnPPP);
            this.groupBox1.Controls.Add(this.btnPP);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.btnP);
            this.groupBox1.Controls.Add(this.btnLast);
            this.groupBox1.Controls.Add(this.btnN);
            this.groupBox1.Controls.Add(this.btnNNN);
            this.groupBox1.Controls.Add(this.btnNN);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 133);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "이동";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDarken);
            this.groupBox2.Controls.Add(this.btnBrighten);
            this.groupBox2.Location = new System.Drawing.Point(169, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 61);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "투명";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRatio);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(169, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(83, 60);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도구";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::MahlerNo2.Viewer.Properties.Resources.Refresh;
            this.btnRefresh.Location = new System.Drawing.Point(6, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRatio
            // 
            this.btnRatio.Image = global::MahlerNo2.Viewer.Properties.Resources.Ratio;
            this.btnRatio.Location = new System.Drawing.Point(44, 20);
            this.btnRatio.Name = "btnRatio";
            this.btnRatio.Size = new System.Drawing.Size(32, 32);
            this.btnRatio.TabIndex = 12;
            this.btnRatio.UseVisualStyleBackColor = true;
            this.btnRatio.Click += new System.EventHandler(this.btnRatio_Click);
            // 
            // RemoconForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 144);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoconForm";
            this.Opacity = 0.5D;
            this.Text = "리모콘";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MoveButton btnFirst;
        private MoveButton btnPPP;
        private MoveButton btnPP;
        private MoveButton btnP;
        private MoveButton btnNNN;
        private MoveButton btnNN;
        private MoveButton btnN;
        private MoveButton btnLast;
        private System.Windows.Forms.Label lblTime;
        private Button btnBrighten;
        private Button btnDarken;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Button btnRatio;
        private Button btnRefresh;
    }
}