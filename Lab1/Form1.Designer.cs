namespace Lab1
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
            klikni = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            imeprezime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // klikni
            // 
            klikni.Location = new Point(307, 182);
            klikni.Name = "klikni";
            klikni.Size = new Size(75, 23);
            klikni.TabIndex = 0;
            klikni.Text = "button1";
            klikni.UseVisualStyleBackColor = true;
            klikni.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += this.contextMenuStrip1_Opening;
            // 
            // imeprezime
            // 
            imeprezime.Location = new Point(456, 183);
            imeprezime.Name = "imeprezime";
            imeprezime.Size = new Size(100, 23);
            imeprezime.TabIndex = 4;
            imeprezime.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 257);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 182);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 6;
            label2.Text = "Unesi ime i prezime";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imeprezime);
            Controls.Add(klikni);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button klikni;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox imeprezime;
        private Label label1;
        private Label label2;
    }
}
