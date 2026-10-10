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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panelContenido = new DataGridView();
            PanelBuscar = new Guna.UI2.WinForms.Guna2GradientPanel();
            lblListado = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBuscar = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            panelPaginacion = new TableLayoutPanel();
            lblTotalRegistros = new Label();
            lblPagina = new Label();
            buttonPrimero = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelContenido).BeginInit();
            PanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panelPaginacion);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panelContenido);
            panel1.Controls.Add(PanelBuscar);
            panel1.Controls.Add(lblListado);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(34, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1353, 645);
            panel1.TabIndex = 0;
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackgroundColor = Color.White;
            panelContenido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panelContenido.Location = new Point(36, 117);
            panelContenido.Name = "panelContenido";
            panelContenido.RowHeadersWidth = 82;
            panelContenido.Size = new Size(1279, 448);
            panelContenido.TabIndex = 3;
            // 
            // PanelBuscar
            // 
            PanelBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBuscar.BackColor = Color.Silver;
            PanelBuscar.BorderRadius = 35;
            PanelBuscar.Controls.Add(txtBuscar);
            PanelBuscar.Controls.Add(iconPictureBox1);
            PanelBuscar.CustomizableEdges = customizableEdges17;
            PanelBuscar.Location = new Point(36, 51);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.ShadowDecoration.CustomizableEdges = customizableEdges18;
            PanelBuscar.Size = new Size(589, 60);
            PanelBuscar.TabIndex = 2;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Felix Titling", 10.875F, FontStyle.Bold);
            lblListado.Location = new Point(66, 14);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(323, 34);
            lblListado.TabIndex = 1;
            lblListado.Text = "Listado de ventas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_store_501;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(35, 737);
            panel2.Name = "panel2";
            panel2.Size = new Size(1352, 311);
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
            dataGridView2.Size = new Size(1279, 274);
            dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(70, 675);
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
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Silver;
            iconPictureBox1.ForeColor = SystemColors.ActiveCaptionText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = SystemColors.ActiveCaptionText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 46;
            iconPictureBox1.Location = new Point(13, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(126, 46);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BackColor = Color.Silver;
            txtBuscar.Location = new Point(66, 7);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Registro";
            txtBuscar.Size = new Size(520, 43);
            txtBuscar.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Silver;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(guna2Button3, 2, 0);
            tableLayoutPanel1.Controls.Add(guna2Button2, 1, 0);
            tableLayoutPanel1.Controls.Add(guna2Button1, 0, 0);
            tableLayoutPanel1.Location = new Point(885, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(430, 64);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges19;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(3, 3);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Button1.Size = new Size(137, 58);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "guna2Button1";
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges21;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Location = new Point(146, 3);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Button2.Size = new Size(137, 58);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "guna2Button2";
            // 
            // guna2Button3
            // 
            guna2Button3.CustomizableEdges = customizableEdges23;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.White;
            guna2Button3.Location = new Point(289, 3);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges24;
            guna2Button3.Size = new Size(137, 58);
            guna2Button3.TabIndex = 3;
            guna2Button3.Text = "guna2Button3";
            // 
            // panelPaginacion
            // 
            panelPaginacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPaginacion.BackColor = Color.White;
            panelPaginacion.ColumnCount = 6;
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            panelPaginacion.Controls.Add(iconButton4, 5, 0);
            panelPaginacion.Controls.Add(iconButton3, 4, 0);
            panelPaginacion.Controls.Add(iconButton2, 2, 0);
            panelPaginacion.Controls.Add(lblTotalRegistros, 0, 0);
            panelPaginacion.Controls.Add(lblPagina, 3, 0);
            panelPaginacion.Controls.Add(buttonPrimero, 1, 0);
            panelPaginacion.Location = new Point(36, 571);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.RowCount = 1;
            panelPaginacion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelPaginacion.Size = new Size(1279, 59);
            panelPaginacion.TabIndex = 4;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(3, 13);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(505, 32);
            lblTotalRegistros.TabIndex = 0;
            lblTotalRegistros.Text = "Total Registros : 0";
            // 
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(768, 13);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(249, 32);
            lblPagina.TabIndex = 1;
            lblPagina.Text = "Pagina 0 de 0";
            // 
            // buttonPrimero
            // 
            buttonPrimero.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            buttonPrimero.IconColor = Color.Black;
            buttonPrimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonPrimero.Location = new Point(514, 3);
            buttonPrimero.Name = "buttonPrimero";
            buttonPrimero.Size = new Size(121, 46);
            buttonPrimero.TabIndex = 2;
            buttonPrimero.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(641, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(121, 46);
            iconButton2.TabIndex = 3;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(1023, 3);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(121, 46);
            iconButton3.TabIndex = 4;
            iconButton3.Text = "iconButton3";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(1150, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(121, 46);
            iconButton4.TabIndex = 5;
            iconButton4.Text = "iconButton4";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // FrmBaseListado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 1048);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmBaseListado";
            Text = "FrmBaseListado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelContenido).EndInit();
            PanelBuscar.ResumeLayout(false);
            PanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        public Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelBuscar;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private DataGridView panelContenido;
        private DataGridView dataGridView2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Label lblListado;
        public TextBox txtBuscar;
        private TableLayoutPanel tableLayoutPanel1;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button guna2Button3;
        public Guna.UI2.WinForms.Guna2Button guna2Button2;
        public TableLayoutPanel panelPaginacion;
        private Label lblTotalRegistros;
        public Label lblPagina;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton buttonPrimero;
    }
}