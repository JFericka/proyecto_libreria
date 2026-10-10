namespace ProyecLibreria.UI.Formularios.Base
{
    partial class FrmBaseListado
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panelContenido = new DataGridView();
            PanelBuscar = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblListado = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelContenido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panelContenido);
            panel1.Controls.Add(PanelBuscar);
            panel1.Controls.Add(lblListado);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(34, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1353, 533);
            panel1.TabIndex = 0;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackgroundColor = Color.White;
            panelContenido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panelContenido.Location = new Point(36, 85);
            panelContenido.Name = "panelContenido";
            panelContenido.RowHeadersWidth = 82;
            panelContenido.Size = new Size(1279, 433);
            panelContenido.TabIndex = 3;
            // 
            // PanelBuscar
            // 
            PanelBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBuscar.BackColor = Color.Silver;
            PanelBuscar.BorderRadius = 35;
            PanelBuscar.CustomizableEdges = customizableEdges1;
            PanelBuscar.Location = new Point(843, 8);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PanelBuscar.Size = new Size(510, 56);
            PanelBuscar.TabIndex = 2;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Felix Titling", 10.875F, FontStyle.Bold);
            lblListado.Location = new Point(111, 20);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(323, 34);
            lblListado.TabIndex = 1;
            lblListado.Text = "Listado de ventas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_store_501;
            pictureBox1.Location = new Point(36, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(35, 673);
            panel2.Name = "panel2";
            panel2.Size = new Size(1352, 375);
            panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = SystemColors.HighlightText;
            dataGridView2.Location = new Point(35, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1279, 338);
            dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(35, 611);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 56);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.125F, FontStyle.Italic);
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 0;
            label1.Text = "Alertas de bajo Stock";
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            guna2GradientPanel1.BackColor = Color.Silver;
            guna2GradientPanel1.BorderRadius = 35;
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Location = new Point(877, 611);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientPanel1.Size = new Size(510, 56);
            guna2GradientPanel1.TabIndex = 3;
            // 
            // FrmBaseListado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 1048);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmBaseListado";
            Text = "FrmBaseListado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelContenido).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        public Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelBuscar;
        private Label lblListado;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private DataGridView panelContenido;
        private DataGridView dataGridView2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}