﻿namespace DemoAutoMLSentiment
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 9.267326F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 33);
            label1.Name = "label1";
            label1.Size = new Size(239, 16);
            label1.TabIndex = 0;
            label1.Text = "KHACH HANG NOI CAI LON GI VAY";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(73, 103);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(449, 65);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("SF Mono", 9.267326F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(73, 191);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 2;
            button1.Text = "PREDICT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(17, 17);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 9.267326F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 270);
            label2.Name = "label2";
            label2.Size = new Size(71, 16);
            label2.TabIndex = 4;
            label2.Text = "Tich Cuc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 9.267326F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 308);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 5;
            label3.Text = "Tieu Cuc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 269);
            label4.Name = "label4";
            label4.Size = new Size(19, 17);
            label4.TabIndex = 6;
            label4.Text = "%";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 307);
            label5.Name = "label5";
            label5.Size = new Size(19, 17);
            label5.TabIndex = 7;
            label5.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
