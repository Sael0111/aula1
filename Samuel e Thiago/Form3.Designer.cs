namespace Samuel_e_Thiago
{
    partial class frmnota
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
            label1 = new Label();
            label2 = new Label();
            txtnota = new TextBox();
            txtmedia = new TextBox();
            btnnotas = new Button();
            btnmedia = new Button();
            lblmensagem = new Label();
            btnlimpar = new Button();
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 61);
            label1.Name = "label1";
            label1.Size = new Size(52, 28);
            label1.TabIndex = 0;
            label1.Text = "nota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(533, 49);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "a media é";
            // 
            // txtnota
            // 
            txtnota.Location = new Point(87, 105);
            txtnota.Name = "txtnota";
            txtnota.Size = new Size(125, 27);
            txtnota.TabIndex = 2;
            // 
            // txtmedia
            // 
            txtmedia.Location = new Point(533, 93);
            txtmedia.Name = "txtmedia";
            txtmedia.Size = new Size(125, 27);
            txtmedia.TabIndex = 3;
            // 
            // btnnotas
            // 
            btnnotas.Location = new Point(250, 56);
            btnnotas.Name = "btnnotas";
            btnnotas.Size = new Size(139, 76);
            btnnotas.TabIndex = 4;
            btnnotas.Text = "Digite as notas";
            btnnotas.UseVisualStyleBackColor = true;
            btnnotas.Click += button1_Click;
            // 
            // btnmedia
            // 
            btnmedia.Location = new Point(782, 44);
            btnmedia.Name = "btnmedia";
            btnmedia.Size = new Size(139, 76);
            btnmedia.TabIndex = 5;
            btnmedia.Text = "Calcular media";
            btnmedia.UseVisualStyleBackColor = true;
            btnmedia.Click += btnmedia_Click;
            // 
            // lblmensagem
            // 
            lblmensagem.AutoSize = true;
            lblmensagem.Location = new Point(830, 203);
            lblmensagem.Name = "lblmensagem";
            lblmensagem.Size = new Size(0, 20);
            lblmensagem.TabIndex = 6;
            lblmensagem.Visible = false;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(87, 291);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(152, 76);
            btnlimpar.TabIndex = 7;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(544, 291);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(127, 76);
            btnvoltar.TabIndex = 8;
            btnvoltar.Text = "voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmnota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 532);
            Controls.Add(btnvoltar);
            Controls.Add(btnlimpar);
            Controls.Add(lblmensagem);
            Controls.Add(btnmedia);
            Controls.Add(btnnotas);
            Controls.Add(txtmedia);
            Controls.Add(txtnota);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmnota";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnota;
        private TextBox txtmedia;
        private Button btnnotas;
        private Button btnmedia;
        private Label lblmensagem;
        private Button btnlimpar;
        private Button btnvoltar;
    }
}