namespace App_Proyecto2Ev_DI_NC
{
    partial class Form_SignIn
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_signin = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox_username = new TextBox();
            label_password = new Label();
            textBox_password = new TextBox();
            label_username = new Label();
            label_codpostal = new Label();
            textBox_codpostal = new TextBox();
            label_apellido2 = new Label();
            textBox_apellido2 = new TextBox();
            label_apellido1 = new Label();
            textBox_apellido1 = new TextBox();
            label_nombre = new Label();
            textBox_nombre = new TextBox();
            button_cancelar = new Button();
            button_crear = new Button();
            pictureBox_logo = new PictureBox();
            toolTip_ayuda = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label_signin, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox_logo, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.4501858F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.225092F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.5756454F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.74907732F));
            tableLayoutPanel1.Size = new Size(551, 443);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label_signin
            // 
            label_signin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_signin.AutoSize = true;
            label_signin.BackColor = Color.Transparent;
            label_signin.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_signin.ForeColor = Color.SteelBlue;
            label_signin.Location = new Point(186, 81);
            label_signin.Name = "label_signin";
            label_signin.Size = new Size(179, 40);
            label_signin.TabIndex = 2;
            label_signin.Text = "Crear una cuenta";
            label_signin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.9166679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.0833321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel2.Controls.Add(textBox_username, 1, 0);
            tableLayoutPanel2.Controls.Add(label_password, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox_password, 1, 1);
            tableLayoutPanel2.Controls.Add(label_username, 0, 0);
            tableLayoutPanel2.Controls.Add(label_codpostal, 0, 6);
            tableLayoutPanel2.Controls.Add(textBox_codpostal, 1, 6);
            tableLayoutPanel2.Controls.Add(label_apellido2, 0, 5);
            tableLayoutPanel2.Controls.Add(textBox_apellido2, 1, 5);
            tableLayoutPanel2.Controls.Add(label_apellido1, 0, 4);
            tableLayoutPanel2.Controls.Add(textBox_apellido1, 1, 4);
            tableLayoutPanel2.Controls.Add(label_nombre, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox_nombre, 1, 3);
            tableLayoutPanel2.Controls.Add(button_cancelar, 0, 8);
            tableLayoutPanel2.Controls.Add(button_crear, 1, 8);
            tableLayoutPanel2.Location = new Point(3, 124);
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
            // textBox_username
            // 
            textBox_username.Anchor = AnchorStyles.Left;
            textBox_username.Location = new Point(191, 4);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(196, 23);
            textBox_username.TabIndex = 3;
            toolTip_ayuda.SetToolTip(textBox_username, "Ingresa un nombre de usuario único que utilizarás para iniciar sesión. \r\nPuede contener letras, números y caracteres especiales.");
            // 
            // label_password
            // 
            label_password.Anchor = AnchorStyles.Right;
            label_password.AutoSize = true;
            label_password.BackColor = Color.Transparent;
            label_password.Location = new Point(113, 39);
            label_password.Name = "label_password";
            label_password.Size = new Size(72, 15);
            label_password.TabIndex = 8;
            label_password.Text = "Contraseña*";
            // 
            // textBox_password
            // 
            textBox_password.Anchor = AnchorStyles.Left;
            textBox_password.Location = new Point(191, 35);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(196, 23);
            textBox_password.TabIndex = 9;
            toolTip_ayuda.SetToolTip(textBox_password, "Crea una contraseña segura con al menos 8 caracteres, incluyendo letras mayúsculas, \r\nminúsculas, números y caracteres especiales.");
            // 
            // label_username
            // 
            label_username.Anchor = AnchorStyles.Right;
            label_username.AutoSize = true;
            label_username.BackColor = Color.Transparent;
            label_username.Location = new Point(71, 8);
            label_username.Name = "label_username";
            label_username.Size = new Size(114, 15);
            label_username.TabIndex = 2;
            label_username.Text = "Nombre de usuario*";
            // 
            // label_codpostal
            // 
            label_codpostal.Anchor = AnchorStyles.Right;
            label_codpostal.AutoSize = true;
            label_codpostal.BackColor = Color.Transparent;
            label_codpostal.Location = new Point(99, 194);
            label_codpostal.Name = "label_codpostal";
            label_codpostal.Size = new Size(86, 15);
            label_codpostal.TabIndex = 10;
            label_codpostal.Text = "Código postal*";
            // 
            // textBox_codpostal
            // 
            textBox_codpostal.Anchor = AnchorStyles.Left;
            textBox_codpostal.Location = new Point(191, 190);
            textBox_codpostal.Name = "textBox_codpostal";
            textBox_codpostal.Size = new Size(196, 23);
            textBox_codpostal.TabIndex = 11;
            toolTip_ayuda.SetToolTip(textBox_codpostal, "Ingresa el código postal de tu dirección. Este campo acepta solo números y \r\ndebe tener el formato correspondiente al país.");
            // 
            // label_apellido2
            // 
            label_apellido2.Anchor = AnchorStyles.Right;
            label_apellido2.AutoSize = true;
            label_apellido2.BackColor = Color.Transparent;
            label_apellido2.Location = new Point(111, 163);
            label_apellido2.Name = "label_apellido2";
            label_apellido2.Size = new Size(74, 15);
            label_apellido2.TabIndex = 6;
            label_apellido2.Text = "2do Apellido";
            // 
            // textBox_apellido2
            // 
            textBox_apellido2.Anchor = AnchorStyles.Left;
            textBox_apellido2.Location = new Point(191, 159);
            textBox_apellido2.Name = "textBox_apellido2";
            textBox_apellido2.Size = new Size(196, 23);
            textBox_apellido2.TabIndex = 7;
            toolTip_ayuda.SetToolTip(textBox_apellido2, "En caso de tener un segundo apellido, introdúcelo aquí. Si no, déjalo en blanco. \r\nUtiliza solo letras, sin caracteres especiales o números.");
            // 
            // label_apellido1
            // 
            label_apellido1.Anchor = AnchorStyles.Right;
            label_apellido1.AutoSize = true;
            label_apellido1.BackColor = Color.Transparent;
            label_apellido1.Location = new Point(129, 132);
            label_apellido1.Name = "label_apellido1";
            label_apellido1.Size = new Size(56, 15);
            label_apellido1.TabIndex = 4;
            label_apellido1.Text = "Apellido*";
            // 
            // textBox_apellido1
            // 
            textBox_apellido1.Anchor = AnchorStyles.Left;
            textBox_apellido1.Location = new Point(191, 128);
            textBox_apellido1.Name = "textBox_apellido1";
            textBox_apellido1.Size = new Size(196, 23);
            textBox_apellido1.TabIndex = 5;
            toolTip_ayuda.SetToolTip(textBox_apellido1, "Ingresa tu primer apellido. Utiliza solo letras, sin caracteres especiales o números.");
            // 
            // label_nombre
            // 
            label_nombre.Anchor = AnchorStyles.Right;
            label_nombre.AutoSize = true;
            label_nombre.Location = new Point(129, 101);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(56, 15);
            label_nombre.TabIndex = 15;
            label_nombre.Text = "Nombre*";
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(191, 96);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(196, 23);
            textBox_nombre.TabIndex = 14;
            toolTip_ayuda.SetToolTip(textBox_nombre, "Proporciona tu nombre real. Solo letras y espacios son permitidos, \r\nsin caracteres especiales o números.");
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.Right;
            button_cancelar.Location = new Point(90, 252);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(95, 23);
            button_cancelar.TabIndex = 13;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_crear
            // 
            button_crear.Anchor = AnchorStyles.Left;
            button_crear.BackColor = Color.LightBlue;
            button_crear.Location = new Point(191, 252);
            button_crear.Name = "button_crear";
            button_crear.Size = new Size(196, 23);
            button_crear.TabIndex = 12;
            button_crear.Text = "Crear cuenta";
            toolTip_ayuda.SetToolTip(button_crear, "Haz clic en este botón para finalizar el proceso y crear tu cuenta. Asegúrate \r\nde que todos los campos estén completos y correctos antes de proceder.");
            button_crear.UseVisualStyleBackColor = false;
            button_crear.Click += button_crear_Click;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_logo.Image = Properties.Resources.logo;
            pictureBox_logo.Location = new Point(3, 3);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(545, 75);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 1;
            pictureBox_logo.TabStop = false;
            // 
            // toolTip_ayuda
            // 
            toolTip_ayuda.IsBalloon = true;
            toolTip_ayuda.ShowAlways = true;
            toolTip_ayuda.Tag = "";
            toolTip_ayuda.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form_SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(575, 467);
            Controls.Add(tableLayoutPanel1);
            Name = "Form_SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo cliente";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox_logo;
        private Label label_signin;
        private Label label_username;
        private Label label_codpostal;
        private TextBox textBox_codpostal;
        private Label label_password;
        private TextBox textBox_password;
        private Label label_apellido2;
        private TextBox textBox_apellido2;
        private Label label_apellido1;
        private TextBox textBox_apellido1;
        private TextBox textBox_username;
        private Button button_crear;
        private Button button_cancelar;
        private TextBox textBox_nombre;
        private Label label_nombre;
        private ToolTip toolTip_ayuda;
    }
}