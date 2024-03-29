﻿namespace Tolotu_Desktop.Views {

  partial class Login {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.lblTitulo = new System.Windows.Forms.Label();
      this.btnEntrar = new System.Windows.Forms.Button();
      this.btnCrearCuenta = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.txtContraseña = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
      this.lblTitulo.Location = new System.Drawing.Point(273, 58);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(292, 73);
      this.lblTitulo.TabIndex = 0;
      this.lblTitulo.Text = "TOLOTU";
      // 
      // btnEntrar
      // 
      this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
      this.btnEntrar.FlatAppearance.BorderSize = 3;
      this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(98)))), ((int)(((byte)(221)))));
      this.btnEntrar.Location = new System.Drawing.Point(336, 386);
      this.btnEntrar.Name = "btnEntrar";
      this.btnEntrar.Size = new System.Drawing.Size(212, 35);
      this.btnEntrar.TabIndex = 1;
      this.btnEntrar.Text = "Iniciar Sesión";
      this.btnEntrar.UseVisualStyleBackColor = true;
      this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
      // 
      // btnCrearCuenta
      // 
      this.btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
      this.btnCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
      this.btnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
      this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(129)))), ((int)(((byte)(228)))));
      this.btnCrearCuenta.Location = new System.Drawing.Point(364, 438);
      this.btnCrearCuenta.Name = "btnCrearCuenta";
      this.btnCrearCuenta.Size = new System.Drawing.Size(146, 23);
      this.btnCrearCuenta.TabIndex = 4;
      this.btnCrearCuenta.Text = "Crear cuenta";
      this.btnCrearCuenta.UseVisualStyleBackColor = true;
      this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfo.Location = new System.Drawing.Point(310, 181);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(213, 39);
      this.lblInfo.TabIndex = 5;
      this.lblInfo.Text = "Inicio Sesión";
      // 
      // txtUsuario
      // 
      this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
      this.txtUsuario.Location = new System.Drawing.Point(306, 266);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(273, 19);
      this.txtUsuario.TabIndex = 6;
      this.txtUsuario.Text = "Ingresa tu usuario";
      this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
      this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
      // 
      // txtContraseña
      // 
      this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
      this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtContraseña.ForeColor = System.Drawing.Color.DarkGray;
      this.txtContraseña.Location = new System.Drawing.Point(306, 311);
      this.txtContraseña.Name = "txtContraseña";
      this.txtContraseña.PasswordChar = '*';
      this.txtContraseña.Size = new System.Drawing.Size(273, 19);
      this.txtContraseña.TabIndex = 7;
      this.txtContraseña.Text = "Ingresa tu contraseña";
      this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
      this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(883, 550);
      this.Controls.Add(this.txtContraseña);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnCrearCuenta);
      this.Controls.Add(this.btnEntrar);
      this.Controls.Add(this.lblTitulo);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Login";
      this.Text = "Tolotu";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.TextBox txtContraseña;
    private System.Windows.Forms.Button btnEntrar;
    private System.Windows.Forms.Button btnCrearCuenta;
  }
}

