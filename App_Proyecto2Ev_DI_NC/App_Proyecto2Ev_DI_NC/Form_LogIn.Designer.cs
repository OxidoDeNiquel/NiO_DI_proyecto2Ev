namespace App_Proyecto2Ev_DI_NC
{
    partial class Form_LogIn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LogIn));
            tableLayoutPanel = new TableLayoutPanel();
            label_login = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            pictureBox1 = new PictureBox();
            button_login = new Button();
            button1 = new Button();
            toolTip_ayuda = new ToolTip(components);
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(label_login, 0, 1);
            tableLayoutPanel.Controls.Add(label1, 0, 2);
            tableLayoutPanel.Controls.Add(label2, 0, 4);
            tableLayoutPanel.Controls.Add(textBox_username, 0, 3);
            tableLayoutPanel.Controls.Add(textBox_password, 0, 5);
            tableLayoutPanel.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel.Controls.Add(button_login, 0, 6);
            tableLayoutPanel.Controls.Add(button1, 0, 7);
            tableLayoutPanel.Location = new Point(36, 40);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 8;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 43.25349F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.650699F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.74668F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.650699F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.74668F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.650699F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.650699F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8.650364F));
            tableLayoutPanel.Size = new Size(246, 350);
            tableLayoutPanel.TabIndex = 0;
            // 
            // label_login
            // 
            label_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_login.AutoSize = true;
            label_login.BackColor = Color.Transparent;
            label_login.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_login.ForeColor = Color.SteelBlue;
            label_login.Location = new Point(51, 151);
            label_login.Name = "label_login";
            label_login.Size = new Size(144, 30);
            label_login.TabIndex = 0;
            label_login.Text = "Iniciar Sesión";
            label_login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(3, 189);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(3, 242);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(3, 207);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(240, 23);
            textBox_username.TabIndex = 3;
            toolTip_ayuda.SetToolTip(textBox_username, "Ingresa tu nombre de usuario previamente registrado. Este campo \r\nes sensible a mayúsculas y minúsculas");
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(3, 260);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(240, 23);
            textBox_password.TabIndex = 4;
            toolTip_ayuda.SetToolTip(textBox_password, "Proporciona tu contraseña asociada al nombre de usuario. Recuerda que la \r\ncontraseña es sensible a mayúsculas y minúsculas.");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_login.BackColor = SystemColors.ActiveCaption;
            button_login.Location = new Point(3, 290);
            button_login.Name = "button_login";
            button_login.Size = new Size(240, 24);
            button_login.TabIndex = 6;
            button_login.Text = "Iniciar sesión";
            toolTip_ayuda.SetToolTip(button_login, "Haz clic en este botón para acceder a tu cuenta. Asegúrate de ingresar \r\ncorrectamente tu nombre de usuario y contraseña.");
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 320);
            button1.Name = "button1";
            button1.Size = new Size(240, 23);
            button1.TabIndex = 7;
            button1.Text = "Soy un nuevo cliente";
            toolTip_ayuda.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolTip_ayuda
            // 
            toolTip_ayuda.IsBalloon = true;
            toolTip_ayuda.ShowAlways = true;
            toolTip_ayuda.ToolTipIcon = ToolTipIcon.Info;
            // 
            // Form_LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(315, 450);
            Controls.Add(tableLayoutPanel);
            Name = "Form_LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label label_login;
        private Label label1;
        private Label label2;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private PictureBox pictureBox1;
        private Button button_login;
        private Button button1;
        private ToolTip toolTip_ayuda;
    }
}