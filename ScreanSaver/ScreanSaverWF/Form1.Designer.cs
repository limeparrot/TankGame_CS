﻿
namespace ScreanSaverWF
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(8, 7);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(700, 700);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(746, 366);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(826, 366);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "label2";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(732, 57);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(125, 27);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "1";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(732, 106);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(125, 27);
      this.textBox2.TabIndex = 4;
      this.textBox2.Text = "1";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(732, 153);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(125, 27);
      this.textBox3.TabIndex = 5;
      this.textBox3.Text = "1";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(732, 204);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(125, 27);
      this.textBox4.TabIndex = 6;
      this.textBox4.Text = "1";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(732, 250);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(196, 65);
      this.button1.TabIndex = 7;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(732, 408);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(196, 94);
      this.button2.TabIndex = 8;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(965, 716);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Timer timer1;
  }
}

