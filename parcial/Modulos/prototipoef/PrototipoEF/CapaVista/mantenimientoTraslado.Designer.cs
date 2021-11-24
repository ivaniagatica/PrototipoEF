
namespace CapaVista
{
    partial class otro
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
            this.txtId = new System.Windows.Forms.DataGridView();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.navegador1 = new DLL.nav.navegador();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbidproducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtsalida = new System.Windows.Forms.DateTimePicker();
            this.dtentrada = new System.Windows.Forms.DateTimePicker();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtsalida = new System.Windows.Forms.TextBox();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtId.Location = new System.Drawing.Point(540, 149);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.RowHeadersWidth = 51;
            this.txtId.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.txtId.Size = new System.Drawing.Size(967, 455);
            this.txtId.TabIndex = 37;
            this.txtId.SelectionChanged += new System.EventHandler(this.dvgCuentas_SelectionChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(176, 246);
            this.cmbEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(160, 24);
            this.cmbEmpleado.TabIndex = 33;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Datos Traslados:";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Location = new System.Drawing.Point(67, 249);
            this.lblempleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(47, 17);
            this.lblempleado.TabIndex = 30;
            this.lblempleado.Text = "Salida";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1585, 107);
            this.navegador1.TabIndex = 90;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(354, 246);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(64, 22);
            this.txtEmpleado.TabIndex = 95;
            this.txtEmpleado.Tag = "fkidbodegaA";
            this.txtEmpleado.Visible = false;
            this.txtEmpleado.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(69, 519);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(31, 36);
            this.rdbActivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(67, 21);
            this.rdbActivo.TabIndex = 46;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(31, 76);
            this.rdbInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(77, 21);
            this.rdbInactivo.TabIndex = 47;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(373, 569);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(59, 22);
            this.txtEstado.TabIndex = 97;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(67, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "Destino";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(176, 291);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(160, 24);
            this.cmbDestino.TabIndex = 99;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(354, 291);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(64, 22);
            this.txtDestino.TabIndex = 100;
            this.txtDestino.Tag = "fkidbodegaB";
            this.txtDestino.Visible = false;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(67, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 101;
            this.label3.Text = "ID";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(176, 210);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(160, 22);
            this.txtcod.TabIndex = 102;
            this.txtcod.Tag = "pkId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(67, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 103;
            this.label4.Tag = "";
            this.label4.Text = "Fecha salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(67, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 104;
            this.label5.Tag = "";
            this.label5.Text = "Fecha ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(67, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 105;
            this.label6.Tag = "";
            this.label6.Text = "Id producto";
            // 
            // cmbidproducto
            // 
            this.cmbidproducto.FormattingEnabled = true;
            this.cmbidproducto.Location = new System.Drawing.Point(176, 418);
            this.cmbidproducto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbidproducto.Name = "cmbidproducto";
            this.cmbidproducto.Size = new System.Drawing.Size(160, 24);
            this.cmbidproducto.TabIndex = 106;
            this.cmbidproducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(67, 459);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 107;
            this.label7.Tag = "";
            this.label7.Text = "Cantidad";
            // 
            // dtsalida
            // 
            this.dtsalida.Location = new System.Drawing.Point(176, 341);
            this.dtsalida.Name = "dtsalida";
            this.dtsalida.Size = new System.Drawing.Size(200, 22);
            this.dtsalida.TabIndex = 109;
            this.dtsalida.ValueChanged += new System.EventHandler(this.dtFechaEmision_ValueChanged);
            // 
            // dtentrada
            // 
            this.dtentrada.Location = new System.Drawing.Point(176, 380);
            this.dtentrada.Name = "dtentrada";
            this.dtentrada.Size = new System.Drawing.Size(200, 22);
            this.dtentrada.TabIndex = 110;
            this.dtentrada.ValueChanged += new System.EventHandler(this.dtFechaentrada_ValueChanged);
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(354, 420);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(64, 22);
            this.txtidproducto.TabIndex = 111;
            this.txtidproducto.Tag = "fkidproducto";
            this.txtidproducto.Visible = false;
            this.txtidproducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtsalida
            // 
            this.txtsalida.Location = new System.Drawing.Point(395, 341);
            this.txtsalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtsalida.Name = "txtsalida";
            this.txtsalida.Size = new System.Drawing.Size(64, 22);
            this.txtsalida.TabIndex = 112;
            this.txtsalida.Tag = "fecha_salida";
            this.txtsalida.Visible = false;
            this.txtsalida.TextChanged += new System.EventHandler(this.txtFechaEm_TextChanged);
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(395, 380);
            this.txtentrada.Margin = new System.Windows.Forms.Padding(4);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(64, 22);
            this.txtentrada.TabIndex = 113;
            this.txtentrada.Tag = "fecha_ingreso";
            this.txtentrada.Visible = false;
            this.txtentrada.TextChanged += new System.EventHandler(this.txtFechaentrada_TextChanged);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(176, 456);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(160, 22);
            this.txtcant.TabIndex = 114;
            this.txtcant.Tag = "cantidad";
            // 
            // otro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 643);
            this.Controls.Add(this.dtentrada);
            this.Controls.Add(this.dtsalida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbidproducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.txtentrada);
            this.Controls.Add(this.txtsalida);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "otro";
            this.Tag = "cantidad";
            this.Text = "Fecha salida";
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView txtId;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblempleado;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbidproducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtsalida;
        private System.Windows.Forms.DateTimePicker dtentrada;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtsalida;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.TextBox txtcant;
    }
}