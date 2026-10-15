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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelContenido = new Panel();
            pictureEmpty = new FontAwesome.Sharp.IconPictureBox();
            panelPaginacion = new TableLayoutPanel();
            buttonUltimo = new FontAwesome.Sharp.IconButton();
            buttonSiguiente = new FontAwesome.Sharp.IconButton();
            buttonAnterior = new FontAwesome.Sharp.IconButton();
            lblTotalRegistros = new Label();
            lblPagina = new Label();
            buttonPrimero = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            butttonDesactivar = new Guna.UI2.WinForms.Guna2Button();
            buttonEditar = new Guna.UI2.WinForms.Guna2Button();
            buttonAgregar = new Guna.UI2.WinForms.Guna2Button();
            dgvListado = new DataGridView();
            PanelBuscar = new Guna.UI2.WinForms.Guna2GradientPanel();
            txtBuscar = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblListado = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEmpty).BeginInit();
            panelPaginacion.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            PanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenido.BackColor = Color.FromArgb(109, 129, 150);
            panelContenido.Controls.Add(pictureEmpty);
            panelContenido.Controls.Add(panelPaginacion);
            panelContenido.Controls.Add(tableLayoutPanel1);
            panelContenido.Controls.Add(dgvListado);
            panelContenido.Controls.Add(PanelBuscar);
            panelContenido.Controls.Add(lblListado);
            panelContenido.Controls.Add(pictureBox1);
            panelContenido.Location = new Point(30, 31);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1363, 526);
            panelContenido.TabIndex = 0;
            // 
            // pictureEmpty
            // 
            pictureEmpty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureEmpty.BackColor = Color.White;
            pictureEmpty.ForeColor = SystemColors.ControlText;
            pictureEmpty.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            pictureEmpty.IconColor = SystemColors.ControlText;
            pictureEmpty.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureEmpty.IconSize = 158;
            pictureEmpty.Location = new Point(39, 202);
            pictureEmpty.Name = "pictureEmpty";
            pictureEmpty.Size = new Size(1283, 158);
            pictureEmpty.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureEmpty.TabIndex = 5;
            pictureEmpty.TabStop = false;
            // 
            // panelPaginacion
            // 
            panelPaginacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPaginacion.BackColor = Color.WhiteSmoke;
            panelPaginacion.ColumnCount = 6;
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.58107F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.43910027F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.82699776F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.110939F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.51668F));
            panelPaginacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.44763374F));
            panelPaginacion.Controls.Add(buttonUltimo, 5, 0);
            panelPaginacion.Controls.Add(buttonSiguiente, 4, 0);
            panelPaginacion.Controls.Add(buttonAnterior, 2, 0);
            panelPaginacion.Controls.Add(lblTotalRegistros, 0, 0);
            panelPaginacion.Controls.Add(lblPagina, 3, 0);
            panelPaginacion.Controls.Add(buttonPrimero, 1, 0);
            panelPaginacion.Location = new Point(36, 452);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.RowCount = 1;
            panelPaginacion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelPaginacion.Size = new Size(1289, 59);
            panelPaginacion.TabIndex = 4;
            // 
            // buttonUltimo
            // 
            buttonUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUltimo.IconChar = FontAwesome.Sharp.IconChar.FastForward;
            buttonUltimo.IconColor = Color.Black;
            buttonUltimo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonUltimo.Location = new Point(1195, 3);
            buttonUltimo.Name = "buttonUltimo";
            buttonUltimo.Size = new Size(91, 46);
            buttonUltimo.TabIndex = 5;
            buttonUltimo.UseVisualStyleBackColor = true;
            buttonUltimo.Click += buttonUltimo_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSiguiente.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            buttonSiguiente.IconColor = Color.Black;
            buttonSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonSiguiente.Location = new Point(1111, 3);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(78, 46);
            buttonSiguiente.TabIndex = 4;
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // buttonAnterior
            // 
            buttonAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAnterior.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            buttonAnterior.IconColor = Color.Black;
            buttonAnterior.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonAnterior.Location = new Point(858, 3);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(78, 46);
            buttonAnterior.TabIndex = 3;
            buttonAnterior.UseVisualStyleBackColor = true;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(3, 13);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(762, 32);
            lblTotalRegistros.TabIndex = 0;
            lblTotalRegistros.Text = "Total Registros : 0";
            // 
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.Right;
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(947, 13);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(158, 32);
            lblPagina.TabIndex = 1;
            lblPagina.Text = "Pagina 0 de 0";
            // 
            // buttonPrimero
            // 
            buttonPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPrimero.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            buttonPrimero.IconColor = Color.Black;
            buttonPrimero.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonPrimero.Location = new Point(773, 3);
            buttonPrimero.Name = "buttonPrimero";
            buttonPrimero.Size = new Size(75, 46);
            buttonPrimero.TabIndex = 2;
            buttonPrimero.UseVisualStyleBackColor = true;
            buttonPrimero.Click += buttonPrimero_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.FromArgb(109, 129, 150);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(butttonDesactivar, 2, 0);
            tableLayoutPanel1.Controls.Add(buttonEditar, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAgregar, 0, 0);
            tableLayoutPanel1.Location = new Point(833, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(492, 60);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // butttonDesactivar
            // 
            butttonDesactivar.BorderRadius = 25;
            butttonDesactivar.CustomizableEdges = customizableEdges1;
            butttonDesactivar.DisabledState.BorderColor = Color.DarkGray;
            butttonDesactivar.DisabledState.CustomBorderColor = Color.DarkGray;
            butttonDesactivar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            butttonDesactivar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            butttonDesactivar.Font = new Font("Segoe UI", 9F);
            butttonDesactivar.ForeColor = Color.White;
            butttonDesactivar.Location = new Point(331, 3);
            butttonDesactivar.Name = "butttonDesactivar";
            butttonDesactivar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            butttonDesactivar.Size = new Size(158, 54);
            butttonDesactivar.TabIndex = 3;
            butttonDesactivar.Text = "pendiente";
            // 
            // buttonEditar
            // 
            buttonEditar.BorderRadius = 25;
            buttonEditar.CustomizableEdges = customizableEdges3;
            buttonEditar.DisabledState.BorderColor = Color.DarkGray;
            buttonEditar.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditar.Font = new Font("Segoe UI", 9F);
            buttonEditar.ForeColor = Color.White;
            buttonEditar.Location = new Point(167, 3);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonEditar.Size = new Size(158, 54);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            // 
            // buttonAgregar
            // 
            buttonAgregar.BorderRadius = 25;
            buttonAgregar.CustomizableEdges = customizableEdges5;
            buttonAgregar.DisabledState.BorderColor = Color.DarkGray;
            buttonAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonAgregar.Font = new Font("Segoe UI", 9F);
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(3, 3);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            buttonAgregar.Size = new Size(158, 54);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Nueva";
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.BackgroundColor = Color.White;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(36, 117);
            dgvListado.Name = "dgvListado";
            dgvListado.RowHeadersWidth = 82;
            dgvListado.Size = new Size(1289, 329);
            dgvListado.TabIndex = 3;
            dgvListado.CellFormatting += dgvListado_CellFormatting;
            // 
            // PanelBuscar
            // 
            PanelBuscar.BackColor = Color.White;
            PanelBuscar.BorderRadius = 35;
            PanelBuscar.Controls.Add(txtBuscar);
            PanelBuscar.Controls.Add(iconPictureBox1);
            PanelBuscar.CustomizableEdges = customizableEdges7;
            PanelBuscar.Location = new Point(36, 58);
            PanelBuscar.Name = "PanelBuscar";
            PanelBuscar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PanelBuscar.Size = new Size(680, 53);
            PanelBuscar.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBuscar.BackColor = Color.WhiteSmoke;
            txtBuscar.Location = new Point(66, 10);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Registro";
            txtBuscar.Size = new Size(536, 36);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 39;
            iconPictureBox1.Location = new Point(10, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 39);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // lblListado
            // 
            lblListado.AutoSize = true;
            lblListado.Font = new Font("Felix Titling", 10.875F, FontStyle.Bold);
            lblListado.Location = new Point(89, 14);
            lblListado.Name = "lblListado";
            lblListado.Size = new Size(323, 34);
            lblListado.TabIndex = 1;
            lblListado.Text = "Listado de ventas";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(109, 129, 150);
            pictureBox1.Image = Properties.Resources.icon_store_501;
            pictureBox1.Location = new Point(36, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(65, 582);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 48);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.125F, FontStyle.Italic);
            label1.Location = new Point(0, 16);
            label1.Name = "label1";
            label1.Size = new Size(294, 32);
            label1.TabIndex = 0;
            label1.Text = "Alertas de bajo Stock";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(109, 129, 150);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(30, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(1363, 375);
            panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = SystemColors.HighlightText;
            dataGridView2.Location = new Point(35, 18);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(1290, 341);
            dataGridView2.TabIndex = 0;
            // 
            // FrmBaseListado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1416, 1039);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelContenido);
            Name = "FrmBaseListado";
            Text = "FrmBaseListado";
            Shown += FrmBaseListado_Shown;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEmpty).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            PanelBuscar.ResumeLayout(false);
            PanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        public Panel panelContenido;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelBuscar;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private DataGridView dgvListado;
        private DataGridView dataGridView2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Label lblListado;
        public TextBox txtBuscar;
        private TableLayoutPanel tableLayoutPanel1;
        public Guna.UI2.WinForms.Guna2Button buttonAgregar;
        public Guna.UI2.WinForms.Guna2Button butttonDesactivar;
        public Guna.UI2.WinForms.Guna2Button buttonEditar;
        public TableLayoutPanel panelPaginacion;
        private Label lblTotalRegistros;
        public Label lblPagina;
        private FontAwesome.Sharp.IconButton buttonUltimo;
        private FontAwesome.Sharp.IconButton buttonSiguiente;
        private FontAwesome.Sharp.IconButton buttonAnterior;
        public FontAwesome.Sharp.IconButton buttonPrimero;
        private FontAwesome.Sharp.IconPictureBox pictureEmpty;
    }
}