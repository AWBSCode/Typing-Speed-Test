namespace Typing_Speed_Test
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimerCounter = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbPreviewText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWriteArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimerCounter
            // 
            this.lblTimerCounter.AutoSize = true;
            this.lblTimerCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerCounter.Location = new System.Drawing.Point(61, 157);
            this.lblTimerCounter.Name = "lblTimerCounter";
            this.lblTimerCounter.Size = new System.Drawing.Size(84, 37);
            this.lblTimerCounter.TabIndex = 0;
            this.lblTimerCounter.Text = "00:00";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(33, 209);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbPreviewText
            // 
            this.tbPreviewText.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPreviewText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPreviewText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreviewText.ForeColor = System.Drawing.Color.Gray;
            this.tbPreviewText.Location = new System.Drawing.Point(248, 35);
            this.tbPreviewText.Multiline = true;
            this.tbPreviewText.Name = "tbPreviewText";
            this.tbPreviewText.ReadOnly = true;
            this.tbPreviewText.Size = new System.Drawing.Size(711, 159);
            this.tbPreviewText.TabIndex = 2;
            this.tbPreviewText.Text = "Write This";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "original text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "your text";
            // 
            // tbWriteArea
            // 
            this.tbWriteArea.BackColor = System.Drawing.SystemColors.Menu;
            this.tbWriteArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbWriteArea.Enabled = false;
            this.tbWriteArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWriteArea.ForeColor = System.Drawing.Color.Gray;
            this.tbWriteArea.Location = new System.Drawing.Point(248, 101);
            this.tbWriteArea.Multiline = true;
            this.tbWriteArea.Name = "tbWriteArea";
            this.tbWriteArea.Size = new System.Drawing.Size(711, 159);
            this.tbWriteArea.TabIndex = 4;
            this.tbWriteArea.TextChanged += new System.EventHandler(this.tbWriteArea_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWriteArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPreviewText);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimerCounter);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimerCounter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbPreviewText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWriteArea;
    }
}

