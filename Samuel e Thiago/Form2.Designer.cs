namespace Samuel_e_Thiago
{
    partial class frmmenu
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
            menuStrip1 = new MenuStrip();
            exercicio1ToolStripMenuItem = new ToolStripMenuItem();
            mediaToolStripMenuItem = new ToolStripMenuItem();
            numerosAleatoriosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercicio1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1021, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercicio1ToolStripMenuItem
            // 
            exercicio1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mediaToolStripMenuItem, numerosAleatoriosToolStripMenuItem });
            exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            exercicio1ToolStripMenuItem.Size = new Size(88, 24);
            exercicio1ToolStripMenuItem.Text = "exercicios";
            exercicio1ToolStripMenuItem.Click += exercicio1ToolStripMenuItem_Click;
            // 
            // mediaToolStripMenuItem
            // 
            mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            mediaToolStripMenuItem.Size = new Size(224, 26);
            mediaToolStripMenuItem.Text = "Media";
            mediaToolStripMenuItem.Click += mediaToolStripMenuItem_Click;
            // 
            // numerosAleatoriosToolStripMenuItem
            // 
            numerosAleatoriosToolStripMenuItem.Name = "numerosAleatoriosToolStripMenuItem";
            numerosAleatoriosToolStripMenuItem.Size = new Size(224, 26);
            numerosAleatoriosToolStripMenuItem.Text = "Numeros aleatorios";
            numerosAleatoriosToolStripMenuItem.Click += numerosAleatoriosToolStripMenuItem_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 590);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmmenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercicio1ToolStripMenuItem;
        private ToolStripMenuItem mediaToolStripMenuItem;
        private ToolStripMenuItem numerosAleatoriosToolStripMenuItem;
    }
}