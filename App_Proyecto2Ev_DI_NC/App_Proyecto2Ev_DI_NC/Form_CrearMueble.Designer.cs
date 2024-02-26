﻿namespace App_Proyecto2Ev_DI_NC
{
    partial class Form_CrearMueble
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label_title = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label_nombre = new Label();
            label_tipo = new Label();
            label_establecimiento = new Label();
            textBox_nombre = new TextBox();
            checkBox_expo = new CheckBox();
            button_crear = new Button();
            button_cancelar = new Button();
            label_s_almacen = new Label();
            textBox_s_almacen = new TextBox();
            comboBox_tipo = new ComboBox();
            comboBox_establecimiento = new ComboBox();
            pictureBox_logo = new PictureBox();
            label_stock = new Label();
            textBox_stock = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_title, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox_logo, 0, 0);
            tableLayoutPanel1.Location = new Point(11, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4501858F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.225092F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.5756454F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.74907732F));
            tableLayoutPanel1.Size = new Size(551, 466);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label_title
            // 
            label_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_title.AutoSize = true;
            label_title.BackColor = Color.Transparent;
            label_title.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_title.ForeColor = Color.SteelBlue;
            label_title.Location = new Point(163, 85);
            label_title.Name = "label_title";
            label_title.Size = new Size(225, 42);
            label_title.TabIndex = 2;
            label_title.Text = "Crear registro mueble";
            label_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.6789F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.3211F));
            tableLayoutPanel2.Controls.Add(label_nombre, 0, 0);
            tableLayoutPanel2.Controls.Add(label_tipo, 0, 1);
            tableLayoutPanel2.Controls.Add(label_establecimiento, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox_nombre, 1, 0);
            tableLayoutPanel2.Controls.Add(checkBox_expo, 1, 4);
            tableLayoutPanel2.Controls.Add(button_crear, 1, 8);
            tableLayoutPanel2.Controls.Add(button_cancelar, 0, 8);
            tableLayoutPanel2.Controls.Add(comboBox_tipo, 1, 1);
            tableLayoutPanel2.Controls.Add(comboBox_establecimiento, 1, 2);
            tableLayoutPanel2.Controls.Add(label_s_almacen, 0, 5);
            tableLayoutPanel2.Controls.Add(textBox_s_almacen, 1, 5);
            tableLayoutPanel2.Controls.Add(label_stock, 0, 6);
            tableLayoutPanel2.Controls.Add(textBox_stock, 1, 6);
            tableLayoutPanel2.Location = new Point(3, 130);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1105595F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1105556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1105556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1105556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1105556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1105556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1127777F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1127739F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel2.Size = new Size(545, 280);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label_nombre
            // 
            label_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label_nombre.AutoSize = true;
            label_nombre.BackColor = Color.White;
            label_nombre.Location = new Point(130, 0);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(56, 31);
            label_nombre.TabIndex = 0;
            label_nombre.Text = "Nombre*";
            label_nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_tipo
            // 
            label_tipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label_tipo.AutoSize = true;
            label_tipo.BackColor = Color.White;
            label_tipo.Location = new Point(151, 31);
            label_tipo.Name = "label_tipo";
            label_tipo.Size = new Size(35, 31);
            label_tipo.TabIndex = 1;
            label_tipo.Text = "Tipo*";
            label_tipo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_establecimiento
            // 
            label_establecimiento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label_establecimiento.AutoSize = true;
            label_establecimiento.BackColor = Color.White;
            label_establecimiento.Location = new Point(90, 62);
            label_establecimiento.Name = "label_establecimiento";
            label_establecimiento.Size = new Size(96, 31);
            label_establecimiento.TabIndex = 2;
            label_establecimiento.Text = "Establecimiento*";
            label_establecimiento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(192, 3);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(193, 23);
            textBox_nombre.TabIndex = 6;
            // 
            // checkBox_expo
            // 
            checkBox_expo.Anchor = AnchorStyles.Left;
            checkBox_expo.AutoSize = true;
            checkBox_expo.Location = new Point(192, 130);
            checkBox_expo.Name = "checkBox_expo";
            checkBox_expo.Size = new Size(83, 19);
            checkBox_expo.TabIndex = 12;
            checkBox_expo.Text = "Exposición";
            checkBox_expo.UseVisualStyleBackColor = true;
            // 
            // button_crear
            // 
            button_crear.Anchor = AnchorStyles.Left;
            button_crear.BackColor = Color.LightBlue;
            button_crear.Location = new Point(192, 252);
            button_crear.Name = "button_crear";
            button_crear.Size = new Size(193, 23);
            button_crear.TabIndex = 14;
            button_crear.Text = "Crear mueble";
            button_crear.UseVisualStyleBackColor = false;
            button_crear.Click += button_crear_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.Right;
            button_cancelar.Location = new Point(91, 252);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(95, 23);
            button_cancelar.TabIndex = 15;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // label_s_almacen
            // 
            label_s_almacen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label_s_almacen.AutoSize = true;
            label_s_almacen.BackColor = Color.White;
            label_s_almacen.Location = new Point(88, 155);
            label_s_almacen.Name = "label_s_almacen";
            label_s_almacen.Size = new Size(98, 31);
            label_s_almacen.TabIndex = 5;
            label_s_almacen.Text = "Sección Almacén";
            label_s_almacen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_s_almacen
            // 
            textBox_s_almacen.Location = new Point(192, 158);
            textBox_s_almacen.Name = "textBox_s_almacen";
            textBox_s_almacen.Size = new Size(193, 23);
            textBox_s_almacen.TabIndex = 11;
            textBox_s_almacen.TextChanged += textBox6_TextChanged;
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Items.AddRange(new object[] { "Baño", "Cocina", "Dormitorio", "Salón", "Sala de estar" });
            comboBox_tipo.Location = new Point(192, 34);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(193, 23);
            comboBox_tipo.TabIndex = 16;
            // 
            // comboBox_establecimiento
            // 
            comboBox_establecimiento.FormattingEnabled = true;
            comboBox_establecimiento.Items.AddRange(new object[] { "Barcelona", "Madrid", "Zaragoza" });
            comboBox_establecimiento.Location = new Point(192, 65);
            comboBox_establecimiento.Name = "comboBox_establecimiento";
            comboBox_establecimiento.Size = new Size(193, 23);
            comboBox_establecimiento.TabIndex = 17;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_logo.Image = Properties.Resources.logo;
            pictureBox_logo.Location = new Point(3, 3);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(545, 79);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 1;
            pictureBox_logo.TabStop = false;
            // 
            // label_stock
            // 
            label_stock.Anchor = AnchorStyles.Right;
            label_stock.AutoSize = true;
            label_stock.Location = new Point(150, 194);
            label_stock.Name = "label_stock";
            label_stock.Size = new Size(36, 15);
            label_stock.TabIndex = 18;
            label_stock.Text = "Stock";
            // 
            // textBox_stock
            // 
            textBox_stock.Location = new Point(192, 189);
            textBox_stock.Name = "textBox_stock";
            textBox_stock.Size = new Size(193, 23);
            textBox_stock.TabIndex = 19;
            // 
            // Form_CrearMueble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(573, 471);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_CrearMueble";
            Text = "Form_CrearMueble";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label_title;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox_logo;
        private Label label_nombre;
        private Label label_tipo;
        private Label label_establecimiento;
        private Label label_s_almacen;
        private TextBox textBox_nombre;
        private TextBox textBox3;
        private TextBox textBox_s_almacen;
        private CheckBox checkBox_expo;
        private Button button_crear;
        private Button button_cancelar;
        private ComboBox comboBox_tipo;
        private ComboBox comboBox_establecimiento;
        private Label label_stock;
        private TextBox textBox_stock;
    }
}