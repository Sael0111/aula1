namespace Samuel_e_Thiago
{
    partial class frmnum
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
            btnlimpar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btngerar
            // 
            btngerar.Location = new Point(158, 435);
            btngerar.Margin = new Padding(3, 4, 3, 4);
            btngerar.Name = "btngerar";
            btngerar.Size = new Size(103, 65);
            btngerar.TabIndex = 0;
            btngerar.Text = "gerar";
            btngerar.UseVisualStyleBackColor = true;
            btngerar.Click += btngerar_Click;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(373, 61);
            txtnum.Margin = new Padding(3, 4, 3, 4);
            txtnum.Multiline = true;
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(59, 176);
            txtnum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 104);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Gerar numero";
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(373, 435);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(116, 65);
            btnlimpar.TabIndex = 3;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(644, 435);
            button1.Name = "button1";
            button1.Size = new Size(130, 65);
            button1.TabIndex = 4;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmnum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(btnlimpar);
            Controls.Add(label1);
            Controls.Add(txtnum);
            Controls.Add(btngerar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmnum";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngerar;
        private TextBox txtnum;
        private Label label1;
        private Button btnlimpar;
        private Button button1;
    }
}
