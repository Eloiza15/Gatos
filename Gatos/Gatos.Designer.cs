namespace Gatos
{
    partial class Gatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gatos));
            panelSuperior = new Panel();
            pbxMinimizar = new PictureBox();
            pbxFechar = new PictureBox();
            panel1 = new Panel();
            lblTitle = new Label();
            btnGetCat = new Button();
            pictureBoxCat = new PictureBox();
            lblIcon = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFechar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Indigo;
            panelSuperior.Controls.Add(lblIcon);
            panelSuperior.Controls.Add(pbxMinimizar);
            panelSuperior.Controls.Add(pbxFechar);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(676, 33);
            panelSuperior.TabIndex = 0;
            panelSuperior.MouseDown += panelSuperior_MouseDown;
            // 
            // pbxMinimizar
            // 
            pbxMinimizar.Image = (Image)resources.GetObject("pbxMinimizar.Image");
            pbxMinimizar.Location = new Point(601, 6);
            pbxMinimizar.Name = "pbxMinimizar";
            pbxMinimizar.Size = new Size(24, 24);
            pbxMinimizar.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxMinimizar.TabIndex = 1;
            pbxMinimizar.TabStop = false;
            pbxMinimizar.Click += pbxMinimizar_Click;
            // 
            // pbxFechar
            // 
            pbxFechar.Image = (Image)resources.GetObject("pbxFechar.Image");
            pbxFechar.Location = new Point(640, 6);
            pbxFechar.Name = "pbxFechar";
            pbxFechar.Size = new Size(24, 24);
            pbxFechar.SizeMode = PictureBoxSizeMode.AutoSize;
            pbxFechar.TabIndex = 1;
            pbxFechar.TabStop = false;
            pbxFechar.Click += pbxFechar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnGetCat);
            panel1.Controls.Add(pictureBoxCat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 565);
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Indigo;
            lblTitle.Location = new Point(184, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 22);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Visualizador de Gatos Aleatórios";
            // 
            // btnGetCat
            // 
            btnGetCat.BackColor = Color.GhostWhite;
            btnGetCat.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetCat.ForeColor = Color.Indigo;
            btnGetCat.Location = new Point(255, 491);
            btnGetCat.Name = "btnGetCat";
            btnGetCat.Size = new Size(159, 44);
            btnGetCat.TabIndex = 1;
            btnGetCat.Text = "Buscar Gato 🐱";
            btnGetCat.UseVisualStyleBackColor = false;
            btnGetCat.Click += btnGetCat_Click;
            // 
            // pictureBoxCat
            // 
            pictureBoxCat.Location = new Point(136, 74);
            pictureBoxCat.Name = "pictureBoxCat";
            pictureBoxCat.Size = new Size(400, 400);
            pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCat.TabIndex = 0;
            pictureBoxCat.TabStop = false;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIcon.ForeColor = SystemColors.Window;
            lblIcon.Location = new Point(3, 3);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(33, 24);
            lblIcon.TabIndex = 3;
            lblIcon.Text = "🐱";
            // 
            // Gatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 598);
            Controls.Add(panel1);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Gatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFechar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private PictureBox pbxFechar;
        private PictureBox pbxMinimizar;
        private Panel panel1;
        private Button btnGetCat;
        private PictureBox pictureBoxCat;
        private Label lblTitle;
        private Label lblIcon;
    }
}
