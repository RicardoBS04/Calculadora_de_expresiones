namespace Interfaz
{
    partial class frmCalc
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPor = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnParDer = new System.Windows.Forms.Button();
            this.btnParIzq = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnPot = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnXor = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPor
            // 
            this.btnPor.BackColor = System.Drawing.Color.White;
            this.btnPor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPor.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPor.Location = new System.Drawing.Point(324, 215);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(50, 40);
            this.btnPor.TabIndex = 0;
            this.btnPor.Text = "x";
            this.btnPor.UseVisualStyleBackColor = false;
            this.btnPor.Click += new System.EventHandler(this.btnPor_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpresion.Location = new System.Drawing.Point(30, 46);
            this.txtExpresion.Multiline = true;
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.ReadOnly = true;
            this.txtExpresion.Size = new System.Drawing.Size(416, 83);
            this.txtExpresion.TabIndex = 1;
            this.txtExpresion.TextChanged += new System.EventHandler(this.txtExpresion_TextChanged);
            // 
            // btnParDer
            // 
            this.btnParDer.BackColor = System.Drawing.Color.White;
            this.btnParDer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnParDer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnParDer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnParDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParDer.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParDer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParDer.Location = new System.Drawing.Point(324, 169);
            this.btnParDer.Name = "btnParDer";
            this.btnParDer.Size = new System.Drawing.Size(50, 40);
            this.btnParDer.TabIndex = 2;
            this.btnParDer.Text = "(";
            this.btnParDer.UseVisualStyleBackColor = false;
            this.btnParDer.Click += new System.EventHandler(this.btnParDer_Click);
            // 
            // btnParIzq
            // 
            this.btnParIzq.BackColor = System.Drawing.Color.White;
            this.btnParIzq.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnParIzq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnParIzq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnParIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParIzq.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParIzq.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnParIzq.Location = new System.Drawing.Point(395, 169);
            this.btnParIzq.Name = "btnParIzq";
            this.btnParIzq.Size = new System.Drawing.Size(50, 40);
            this.btnParIzq.TabIndex = 3;
            this.btnParIzq.Text = ")";
            this.btnParIzq.UseVisualStyleBackColor = false;
            this.btnParIzq.Click += new System.EventHandler(this.btnParIzq_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.White;
            this.btnDiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDiv.Location = new System.Drawing.Point(395, 215);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(50, 40);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnPot
            // 
            this.btnPot.BackColor = System.Drawing.Color.White;
            this.btnPot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPot.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPot.Location = new System.Drawing.Point(324, 261);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(50, 40);
            this.btnPot.TabIndex = 5;
            this.btnPot.Text = "^";
            this.btnPot.UseVisualStyleBackColor = false;
            this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.White;
            this.btnMod.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMod.Location = new System.Drawing.Point(395, 261);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(50, 40);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.White;
            this.btnMas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMas.Location = new System.Drawing.Point(324, 307);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(50, 40);
            this.btnMas.TabIndex = 7;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenos.Location = new System.Drawing.Point(395, 307);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(50, 40);
            this.btnMenos.TabIndex = 8;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnNot
            // 
            this.btnNot.BackColor = System.Drawing.Color.White;
            this.btnNot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNot.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNot.Location = new System.Drawing.Point(320, 353);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(58, 40);
            this.btnNot.TabIndex = 9;
            this.btnNot.Text = "NOT";
            this.btnNot.UseVisualStyleBackColor = false;
            this.btnNot.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.BackColor = System.Drawing.Color.White;
            this.btnAnd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnd.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnd.Location = new System.Drawing.Point(391, 353);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(58, 40);
            this.btnAnd.TabIndex = 10;
            this.btnAnd.Text = "AND";
            this.btnAnd.UseVisualStyleBackColor = false;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOr
            // 
            this.btnOr.BackColor = System.Drawing.Color.White;
            this.btnOr.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOr.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOr.Location = new System.Drawing.Point(320, 399);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(58, 40);
            this.btnOr.TabIndex = 11;
            this.btnOr.Text = "OR";
            this.btnOr.UseVisualStyleBackColor = false;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnXor
            // 
            this.btnXor.BackColor = System.Drawing.Color.White;
            this.btnXor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnXor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnXor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnXor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXor.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXor.Location = new System.Drawing.Point(391, 399);
            this.btnXor.Name = "btnXor";
            this.btnXor.Size = new System.Drawing.Size(58, 40);
            this.btnXor.TabIndex = 12;
            this.btnXor.Text = "XOR";
            this.btnXor.UseVisualStyleBackColor = false;
            this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.White;
            this.btnCero.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCero.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCero.Location = new System.Drawing.Point(30, 399);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(50, 40);
            this.btnCero.TabIndex = 13;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click_1);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.White;
            this.btnUno.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnUno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUno.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUno.Location = new System.Drawing.Point(119, 399);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(50, 40);
            this.btnUno.TabIndex = 14;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click_1);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.White;
            this.btnDos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDos.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDos.Location = new System.Drawing.Point(214, 399);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(50, 40);
            this.btnDos.TabIndex = 15;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click_1);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.White;
            this.btnTres.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTres.Location = new System.Drawing.Point(30, 331);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(50, 40);
            this.btnTres.TabIndex = 16;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.White;
            this.btnCuatro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCuatro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuatro.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCuatro.Location = new System.Drawing.Point(119, 331);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(50, 40);
            this.btnCuatro.TabIndex = 17;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click_1);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.White;
            this.btnCinco.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCinco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCinco.Location = new System.Drawing.Point(214, 331);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(50, 40);
            this.btnCinco.TabIndex = 18;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click_1);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.White;
            this.btnSeis.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSeis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSeis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeis.Location = new System.Drawing.Point(30, 261);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(50, 40);
            this.btnSeis.TabIndex = 19;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.White;
            this.btnSiete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSiete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSiete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiete.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiete.Location = new System.Drawing.Point(119, 261);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(50, 40);
            this.btnSiete.TabIndex = 20;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.White;
            this.btnOcho.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnOcho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOcho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcho.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOcho.Location = new System.Drawing.Point(214, 261);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(50, 40);
            this.btnOcho.TabIndex = 21;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.White;
            this.btnNueve.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNueve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNueve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueve.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNueve.Location = new System.Drawing.Point(30, 194);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(50, 40);
            this.btnNueve.TabIndex = 22;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(114, 194);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 40);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(486, 483);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnXor);
            this.Controls.Add(this.btnOr);
            this.Controls.Add(this.btnAnd);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnPot);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnParIzq);
            this.Controls.Add(this.btnParDer);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.btnPor);
            this.Name = "frmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de Expresiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnParDer;
        private System.Windows.Forms.Button btnParIzq;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPot;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnXor;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnCalcular;
    }
}

