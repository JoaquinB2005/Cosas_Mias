namespace My_QuickCarry
{
    partial class formLogin
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnIniciar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(31, 76);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(230, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.Tag = "";
            txtUsuario.TextChanged += etiUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(31, 119);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Contraseña";
            txtContraseña.Size = new Size(230, 27);
            txtContraseña.TabIndex = 1;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 26);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 2;
            label1.Text = "Inicio de sesión";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Location = new Point(343, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 234);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnIniciar
            // 
            btnIniciar.AutoSize = true;
            btnIniciar.BackColor = Color.RoyalBlue;
            btnIniciar.CausesValidation = false;
            btnIniciar.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(63, 169);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(167, 31);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // formLogin
            // 
            AcceptButton = btnIniciar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoInicio1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(999, 614);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formLogin";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Panel panel1;
        private Button btnIniciar;
    }
}