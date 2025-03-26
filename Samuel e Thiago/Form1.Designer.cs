namespace Samuel_e_Thiago
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
            btngerar = new Button();
            txtnum = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btngerar
            // 
            btngerar.Location = new Point(138, 326);
            btngerar.Name = "btngerar";
            btngerar.Size = new Size(90, 49);
            btngerar.TabIndex = 0;
            btngerar.Text = "gerar";
            btngerar.UseVisualStyleBackColor = true;
            btngerar.Click += btngerar_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(326, 46);
            txtnum.Multiline = true;
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(100, 182);
            txtnum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 78);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Gerar numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtnum);
            Controls.Add(btngerar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngerar;
        private TextBox txtnum;
        private Label label1;
    }
}
