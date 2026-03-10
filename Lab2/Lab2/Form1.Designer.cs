namespace Lab2
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
            labelrad = new Label();
            labelodmor = new Label();
            label3 = new Label();
            textBoxrad = new TextBox();
            textBoxodmor = new TextBox();
            buttonStartStop = new Button();
            buttonReset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelrad
            // 
            labelrad.AutoSize = true;
            labelrad.Location = new Point(289, 47);
            labelrad.Name = "labelrad";
            labelrad.Size = new Size(24, 15);
            labelrad.TabIndex = 0;
            labelrad.Text = "rad";
            // 
            // labelodmor
            // 
            labelodmor.AutoSize = true;
            labelodmor.Location = new Point(563, 47);
            labelodmor.Name = "labelodmor";
            labelodmor.Size = new Size(43, 15);
            labelodmor.TabIndex = 1;
            labelodmor.Text = "odmor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(396, 195);
            label3.Name = "label3";
            label3.Size = new Size(83, 37);
            label3.TabIndex = 2;
            label3.Text = "25:00";
            label3.Click += label3_Click;
            // 
            // textBoxrad
            // 
            textBoxrad.Location = new Point(236, 65);
            textBoxrad.Name = "textBoxrad";
            textBoxrad.Size = new Size(100, 23);
            textBoxrad.TabIndex = 3;
            // 
            // textBoxodmor
            // 
            textBoxodmor.Location = new Point(520, 65);
            textBoxodmor.Name = "textBoxodmor";
            textBoxodmor.Size = new Size(100, 23);
            textBoxodmor.TabIndex = 4;
            // 
            // buttonStartStop
            // 
            buttonStartStop.Location = new Point(212, 314);
            buttonStartStop.Name = "buttonStartStop";
            buttonStartStop.Size = new Size(75, 23);
            buttonStartStop.TabIndex = 6;
            buttonStartStop.Text = "start/stop";
            buttonStartStop.UseVisualStyleBackColor = true;
            buttonStartStop.Click += buttonStartStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(563, 314);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReset);
            Controls.Add(buttonStartStop);
            Controls.Add(textBoxodmor);
            Controls.Add(textBoxrad);
            Controls.Add(label3);
            Controls.Add(labelodmor);
            Controls.Add(labelrad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelrad;
        private Label labelodmor;
        private Label label3;
        private TextBox textBoxrad;
        private TextBox textBoxodmor;
        private Button buttonStartStop;
        private Button buttonReset;
        private System.Windows.Forms.Timer timer1;
    }
}
