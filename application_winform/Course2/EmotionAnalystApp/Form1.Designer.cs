namespace EmotionAnalystApp
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
            Button buttonAnalyst;
            label1 = new Label();
            richTextBoxComment = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelPostive = new Label();
            labelNegative = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonAnalyst = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 15.6831684F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 49);
            label1.Name = "label1";
            label1.Size = new Size(180, 26);
            label1.TabIndex = 0;
            label1.Text = "CLIENT SAID?";
            label1.Click += label1_Click;
            // 
            // richTextBoxComment
            // 
            richTextBoxComment.Location = new Point(160, 96);
            richTextBoxComment.Name = "richTextBoxComment";
            richTextBoxComment.Size = new Size(319, 95);
            richTextBoxComment.TabIndex = 1;
            richTextBoxComment.Text = "";
            // 
            // buttonAnalyst
            // 
            buttonAnalyst.Font = new Font("Segoe UI", 9.980198F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnalyst.Location = new Point(160, 215);
            buttonAnalyst.Name = "buttonAnalyst";
            buttonAnalyst.Size = new Size(162, 23);
            buttonAnalyst.TabIndex = 2;
            buttonAnalyst.Text = "ANALYST";
            buttonAnalyst.UseVisualStyleBackColor = true;
            buttonAnalyst.Click += buttonAnalyst_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 256);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 4;
            label3.Text = "POSITIVE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 302);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 5;
            label4.Text = "NEGATIVE";
            // 
            // labelPostive
            // 
            labelPostive.AutoSize = true;
            labelPostive.Location = new Point(285, 256);
            labelPostive.Name = "labelPostive";
            labelPostive.Size = new Size(55, 16);
            labelPostive.TabIndex = 6;
            labelPostive.Text = "unknow";
            // 
            // labelNegative
            // 
            labelNegative.AutoSize = true;
            labelNegative.Location = new Point(285, 302);
            labelNegative.Name = "labelNegative";
            labelNegative.Size = new Size(55, 16);
            labelNegative.TabIndex = 7;
            labelNegative.Text = "unknow";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 256);
            label7.Name = "label7";
            label7.Size = new Size(15, 16);
            label7.TabIndex = 8;
            label7.Text = "%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 302);
            label8.Name = "label8";
            label8.Size = new Size(15, 16);
            label8.TabIndex = 9;
            label8.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 476);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(labelNegative);
            Controls.Add(labelPostive);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonAnalyst);
            Controls.Add(richTextBoxComment);
            Controls.Add(label1);
            Font = new Font("SF Mono", 9.267326F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxComment;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelPostive;
        private Label labelNegative;
        private Label label7;
        private Label label8;
    }
}
