namespace WouldYouRather
{
    partial class WouldYouRather
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.countdown = new System.Windows.Forms.Label();
            this.redCount = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.blueCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you rather:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(49, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 238);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(370, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 238);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(293, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 238);
            this.button3.TabIndex = 3;
            this.button3.Text = "SKIP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countdown.Location = new System.Drawing.Point(319, 386);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(0, 20);
            this.countdown.TabIndex = 4;
            // 
            // redCount
            // 
            this.redCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redCount.BackColor = System.Drawing.Color.LightCoral;
            this.redCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redCount.Location = new System.Drawing.Point(152, 303);
            this.redCount.Name = "redCount";
            this.redCount.Size = new System.Drawing.Size(33, 13);
            this.redCount.TabIndex = 5;
            this.redCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.redCount.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Add Choice";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // blueCount
            // 
            this.blueCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blueCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.blueCount.Location = new System.Drawing.Point(473, 303);
            this.blueCount.Name = "blueCount";
            this.blueCount.Size = new System.Drawing.Size(33, 13);
            this.blueCount.TabIndex = 8;
            this.blueCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blueCount.Visible = false;
            // 
            // WouldYouRather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.blueCount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.redCount);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "WouldYouRather";
            this.Text = "Would You Rather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label redCount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label blueCount;
    }
}

