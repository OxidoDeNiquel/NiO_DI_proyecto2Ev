namespace App_Proyecto2Ev_DI_NC
{
    partial class Form_PerfilCliente
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
            tableLayoutPanel2 = new TableLayoutPanel();
            button_logout = new Button();
            button_volver = new Button();
            pictureBox1 = new PictureBox();
            label_titulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(label_titulo, 0, 0);
            tableLayoutPanel1.Location = new Point(9, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(230, 345);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button_logout, 1, 0);
            tableLayoutPanel2.Controls.Add(button_volver, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 313);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(224, 29);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button_logout
            // 
            button_logout.BackColor = Color.RosyBrown;
            button_logout.ForeColor = SystemColors.ControlText;
            button_logout.Location = new Point(115, 3);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(106, 23);
            button_logout.TabIndex = 1;
            button_logout.Text = "Cerrar sesión";
            button_logout.UseVisualStyleBackColor = false;
            button_logout.Click += button_logout_Click;
            // 
            // button_volver
            // 
            button_volver.Location = new Point(3, 3);
            button_volver.Name = "button_volver";
            button_volver.Size = new Size(106, 23);
            button_volver.TabIndex = 0;
            button_volver.Text = "Volver";
            button_volver.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_titulo
            // 
            label_titulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_titulo.Location = new Point(3, 0);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(224, 34);
            label_titulo.TabIndex = 2;
            label_titulo.Text = "Perfil Cliente";
            label_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_PerfilCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(249, 367);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_PerfilCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_PerfilCliente";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_logout;
        private Button button_volver;
        private PictureBox pictureBox1;
        private Label label_titulo;
    }
}