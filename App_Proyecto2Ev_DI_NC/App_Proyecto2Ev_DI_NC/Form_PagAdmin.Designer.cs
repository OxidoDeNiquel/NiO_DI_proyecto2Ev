namespace App_Proyecto2Ev_DI_NC
{
    partial class Form_PagAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PagAdmin));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox_logo = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox_perfil = new PictureBox();
            label_titulo = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView_muebles = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            button_delete = new Button();
            button_insert = new Button();
            button_actualizar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            button_refresh = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_perfil).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_muebles).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.62371F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.37629F));
            tableLayoutPanel1.Controls.Add(pictureBox_logo, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3098583F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.69014F));
            tableLayoutPanel1.Size = new Size(872, 485);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_logo.BackColor = Color.Transparent;
            pictureBox_logo.Image = (Image)resources.GetObject("pictureBox_logo.Image");
            pictureBox_logo.Location = new Point(3, 3);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(138, 82);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo.TabIndex = 0;
            pictureBox_logo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.90697F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.09303331F));
            tableLayoutPanel2.Controls.Add(pictureBox_perfil, 1, 0);
            tableLayoutPanel2.Controls.Add(label_titulo, 0, 0);
            tableLayoutPanel2.Location = new Point(147, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(722, 82);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox_perfil
            // 
            pictureBox_perfil.Image = Properties.Resources.perfil_icono;
            pictureBox_perfil.Location = new Point(681, 3);
            pictureBox_perfil.Name = "pictureBox_perfil";
            pictureBox_perfil.Size = new Size(34, 29);
            pictureBox_perfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_perfil.TabIndex = 1;
            pictureBox_perfil.TabStop = false;
            pictureBox_perfil.Click += pictureBox_perfil_Click;
            // 
            // label_titulo
            // 
            label_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.ForeColor = Color.SteelBlue;
            label_titulo.Location = new Point(3, 0);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(672, 41);
            label_titulo.TabIndex = 2;
            label_titulo.Text = "Administrador";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dataGridView_muebles, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Location = new Point(147, 91);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.21283F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7871723F));
            tableLayoutPanel4.Size = new Size(722, 391);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // dataGridView_muebles
            // 
            dataGridView_muebles.BackgroundColor = Color.White;
            dataGridView_muebles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_muebles.GridColor = SystemColors.ControlLightLight;
            dataGridView_muebles.Location = new Point(3, 3);
            dataGridView_muebles.Name = "dataGridView_muebles";
            dataGridView_muebles.RowTemplate.Height = 25;
            dataGridView_muebles.Size = new Size(716, 342);
            dataGridView_muebles.TabIndex = 2;
            dataGridView_muebles.CellClick += dataGridView_muebles_CellClick;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(button_delete, 0, 0);
            tableLayoutPanel5.Controls.Add(button_insert, 2, 0);
            tableLayoutPanel5.Controls.Add(button_actualizar, 1, 0);
            tableLayoutPanel5.Location = new Point(3, 351);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(716, 37);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_delete.BackColor = Color.FromArgb(255, 192, 192);
            button_delete.ForeColor = SystemColors.ControlText;
            button_delete.Location = new Point(3, 3);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(232, 31);
            button_delete.TabIndex = 0;
            button_delete.Text = "Eliminar articulo";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_insert
            // 
            button_insert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_insert.BackColor = SystemColors.GradientActiveCaption;
            button_insert.Location = new Point(479, 3);
            button_insert.Name = "button_insert";
            button_insert.Size = new Size(234, 31);
            button_insert.TabIndex = 1;
            button_insert.Text = "Insertar articulo";
            button_insert.UseVisualStyleBackColor = false;
            button_insert.Click += button_insert_Click;
            // 
            // button_actualizar
            // 
            button_actualizar.Location = new Point(241, 3);
            button_actualizar.Name = "button_actualizar";
            button_actualizar.Size = new Size(232, 31);
            button_actualizar.TabIndex = 2;
            button_actualizar.Text = "Actualizar artículo";
            button_actualizar.UseVisualStyleBackColor = true;
            button_actualizar.Click += button_actualizar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button_refresh, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 91);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Size = new Size(138, 391);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // button_refresh
            // 
            button_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_refresh.Location = new Point(3, 3);
            button_refresh.Name = "button_refresh";
            button_refresh.Size = new Size(132, 33);
            button_refresh.TabIndex = 0;
            button_refresh.Text = "Actualizar tabla";
            button_refresh.UseVisualStyleBackColor = true;
            button_refresh.Click += button_refresh_Click;
            // 
            // Form_PagAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(896, 509);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_PagAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_perfil).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_muebles).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox_logo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView_muebles;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button_delete;
        private Button button_insert;
        private PictureBox pictureBox_perfil;
        private Label label_titulo;
        private Button button_actualizar;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button_refresh;
    }
}