﻿namespace App_Proyecto2Ev_DI_NC
{
    partial class Form_C_PagPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_C_PagPrincipal));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox_logo = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox_perfil = new PictureBox();
            pictureBox_cesta = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            button_fcocina = new Button();
            button_fsde = new Button();
            button_fsalon = new Button();
            button_fbano = new Button();
            button_fdorm = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView_muebles = new DataGridView();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_perfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cesta).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_muebles).BeginInit();
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3098583F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.69014F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_logo.BackColor = Color.Transparent;
            pictureBox_logo.Image = (Image)resources.GetObject("pictureBox_logo.Image");
            pictureBox_logo.Location = new Point(3, 3);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(122, 71);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo.TabIndex = 0;
            pictureBox_logo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel2.Controls.Add(pictureBox_perfil, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox_cesta, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Location = new Point(131, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(642, 71);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox_perfil
            // 
            pictureBox_perfil.Image = Properties.Resources.perfil_icono;
            pictureBox_perfil.Location = new Point(555, 3);
            pictureBox_perfil.Name = "pictureBox_perfil";
            pictureBox_perfil.Size = new Size(38, 29);
            pictureBox_perfil.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_perfil.TabIndex = 0;
            pictureBox_perfil.TabStop = false;
            // 
            // pictureBox_cesta
            // 
            pictureBox_cesta.Image = (Image)resources.GetObject("pictureBox_cesta.Image");
            pictureBox_cesta.Location = new Point(599, 3);
            pictureBox_cesta.Name = "pictureBox_cesta";
            pictureBox_cesta.Size = new Size(40, 29);
            pictureBox_cesta.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_cesta.TabIndex = 1;
            pictureBox_cesta.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0000038F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Controls.Add(button_fcocina, 1, 0);
            tableLayoutPanel3.Controls.Add(button_fsde, 3, 0);
            tableLayoutPanel3.Controls.Add(button_fsalon, 4, 0);
            tableLayoutPanel3.Controls.Add(button_fbano, 0, 0);
            tableLayoutPanel3.Controls.Add(button_fdorm, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 38);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(546, 30);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // button_fcocina
            // 
            button_fcocina.BackColor = Color.LightBlue;
            button_fcocina.Location = new Point(112, 3);
            button_fcocina.Name = "button_fcocina";
            button_fcocina.Size = new Size(103, 23);
            button_fcocina.TabIndex = 1;
            button_fcocina.Text = "Cocina";
            button_fcocina.UseVisualStyleBackColor = false;
            // 
            // button_fsde
            // 
            button_fsde.BackColor = Color.LightBlue;
            button_fsde.Location = new Point(330, 3);
            button_fsde.Name = "button_fsde";
            button_fsde.Size = new Size(103, 23);
            button_fsde.TabIndex = 3;
            button_fsde.Text = "Sala de estar";
            button_fsde.UseVisualStyleBackColor = false;
            // 
            // button_fsalon
            // 
            button_fsalon.BackColor = Color.LightBlue;
            button_fsalon.Location = new Point(439, 3);
            button_fsalon.Name = "button_fsalon";
            button_fsalon.Size = new Size(104, 23);
            button_fsalon.TabIndex = 0;
            button_fsalon.Text = "Salón";
            button_fsalon.UseVisualStyleBackColor = false;
            // 
            // button_fbano
            // 
            button_fbano.BackColor = Color.LightBlue;
            button_fbano.Location = new Point(3, 3);
            button_fbano.Name = "button_fbano";
            button_fbano.Size = new Size(103, 23);
            button_fbano.TabIndex = 2;
            button_fbano.Text = "Baño";
            button_fbano.UseVisualStyleBackColor = false;
            // 
            // button_fdorm
            // 
            button_fdorm.BackColor = Color.LightBlue;
            button_fdorm.Location = new Point(221, 3);
            button_fdorm.Name = "button_fdorm";
            button_fdorm.Size = new Size(103, 23);
            button_fdorm.TabIndex = 4;
            button_fdorm.Text = "Dormitorio";
            button_fdorm.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(dataGridView_muebles, 0, 0);
            tableLayoutPanel4.Location = new Point(131, 80);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.21283F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7871723F));
            tableLayoutPanel4.Size = new Size(642, 343);
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
            dataGridView_muebles.Size = new Size(636, 300);
            dataGridView_muebles.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Location = new Point(3, 80);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 4;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel6.Size = new Size(122, 337);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // Form_C_PagPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_C_PagPrincipal";
            Text = "Form_C_PagPrincipal";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_perfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cesta).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_muebles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox_logo;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox_perfil;
        private PictureBox pictureBox_cesta;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button_fsalon;
        private Button button_fcocina;
        private Button button_fbano;
        private Button button_fsde;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView_muebles;
        private Button button_fdorm;
        private TableLayoutPanel tableLayoutPanel6;
    }
}