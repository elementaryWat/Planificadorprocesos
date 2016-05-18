namespace WindowsFormsApplication3
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FlujoEjec = new System.Windows.Forms.DataGridView();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Listo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ejecucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosFlow = new System.Windows.Forms.DataGridView();
            this.Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arribo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Estadisticaspromedio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticasEjec = new System.Windows.Forms.DataGridView();
            this.Id_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiemporetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempoirrupcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempoespera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instantefinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempoarribo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempoderetorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instanteprimerrespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiemporespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FlujoEjec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFlow)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Estadisticaspromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticasEjec)).BeginInit();
            this.SuspendLayout();
            // 
            // FlujoEjec
            // 
            this.FlujoEjec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlujoEjec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tiempo,
            this.Listo,
            this.Ejecucion,
            this.Bloqueado,
            this.ColaCPU,
            this.CEntrada,
            this.CSalida,
            this.UCPU,
            this.UEntrada,
            this.USalida});
            this.FlujoEjec.Location = new System.Drawing.Point(0, 3);
            this.FlujoEjec.Name = "FlujoEjec";
            this.FlujoEjec.Size = new System.Drawing.Size(1046, 374);
            this.FlujoEjec.TabIndex = 0;
            this.FlujoEjec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Listo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Listo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Listo.HeaderText = "Listo";
            this.Listo.Name = "Listo";
            // 
            // Ejecucion
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Ejecucion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ejecucion.HeaderText = "Ejecucion";
            this.Ejecucion.Name = "Ejecucion";
            // 
            // Bloqueado
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Bloqueado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.Name = "Bloqueado";
            // 
            // ColaCPU
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ColaCPU.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColaCPU.HeaderText = "Cola de CPU";
            this.ColaCPU.Name = "ColaCPU";
            // 
            // CEntrada
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CEntrada.DefaultCellStyle = dataGridViewCellStyle5;
            this.CEntrada.HeaderText = "Cola de Entrada";
            this.CEntrada.Name = "CEntrada";
            // 
            // CSalida
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CSalida.DefaultCellStyle = dataGridViewCellStyle6;
            this.CSalida.HeaderText = "Cola de Salida";
            this.CSalida.Name = "CSalida";
            // 
            // UCPU
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UCPU.DefaultCellStyle = dataGridViewCellStyle7;
            this.UCPU.HeaderText = "Uso de CPU";
            this.UCPU.Name = "UCPU";
            // 
            // UEntrada
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UEntrada.DefaultCellStyle = dataGridViewCellStyle8;
            this.UEntrada.HeaderText = "Uso de Entrada";
            this.UEntrada.Name = "UEntrada";
            // 
            // USalida
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.USalida.DefaultCellStyle = dataGridViewCellStyle9;
            this.USalida.HeaderText = "Uso de Salida";
            this.USalida.Name = "USalida";
            // 
            // DatosFlow
            // 
            this.DatosFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosFlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proceso,
            this.Arribo,
            this.CPU,
            this.Entrada,
            this.CPU2,
            this.Salida,
            this.CPU3});
            this.DatosFlow.Location = new System.Drawing.Point(95, 12);
            this.DatosFlow.Name = "DatosFlow";
            this.DatosFlow.Size = new System.Drawing.Size(747, 153);
            this.DatosFlow.TabIndex = 1;
            this.DatosFlow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Proceso
            // 
            this.Proceso.HeaderText = "Proceso";
            this.Proceso.Name = "Proceso";
            // 
            // Arribo
            // 
            this.Arribo.HeaderText = "Arribo";
            this.Arribo.Name = "Arribo";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            // 
            // CPU2
            // 
            this.CPU2.HeaderText = "CPU2";
            this.CPU2.Name = "CPU2";
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            // 
            // CPU3
            // 
            this.CPU3.HeaderText = "CPU3";
            this.CPU3.Name = "CPU3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar datos ejercicio 7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Iniciar ejecucion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 410);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FlujoEjec);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Ejecucion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Estadisticaspromedio);
            this.tabPage2.Controls.Add(this.estadisticasEjec);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estadisticas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Estadisticaspromedio
            // 
            this.Estadisticaspromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Estadisticaspromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.Estadisticaspromedio.Location = new System.Drawing.Point(0, 205);
            this.Estadisticaspromedio.Name = "Estadisticaspromedio";
            this.Estadisticaspromedio.Size = new System.Drawing.Size(348, 118);
            this.Estadisticaspromedio.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tiempo de espera medio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tiempo de retorno medio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Tiempo de respuesta medio";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // estadisticasEjec
            // 
            this.estadisticasEjec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadisticasEjec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Proceso,
            this.Tiemporetorno,
            this.Tiempoirrupcion,
            this.Tiempoespera,
            this.Instantefinalizacion,
            this.Tiempoarribo,
            this.Tiempoderetorno,
            this.Instanteprimerrespuesta,
            this.Tiemporespuesta});
            this.estadisticasEjec.Location = new System.Drawing.Point(4, 7);
            this.estadisticasEjec.Name = "estadisticasEjec";
            this.estadisticasEjec.Size = new System.Drawing.Size(1038, 183);
            this.estadisticasEjec.TabIndex = 0;
            // 
            // Id_Proceso
            // 
            this.Id_Proceso.HeaderText = "Id_Proceso";
            this.Id_Proceso.Name = "Id_Proceso";
            // 
            // Tiemporetorno
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Aquamarine;
            this.Tiemporetorno.DefaultCellStyle = dataGridViewCellStyle10;
            this.Tiemporetorno.HeaderText = "Tiempo retorno(TR) ";
            this.Tiemporetorno.Name = "Tiemporetorno";
            // 
            // Tiempoirrupcion
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Lime;
            this.Tiempoirrupcion.DefaultCellStyle = dataGridViewCellStyle11;
            this.Tiempoirrupcion.HeaderText = "Tiempo de irrupcion (TI)";
            this.Tiempoirrupcion.Name = "Tiempoirrupcion";
            // 
            // Tiempoespera
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tiempoespera.DefaultCellStyle = dataGridViewCellStyle12;
            this.Tiempoespera.HeaderText = "Tiempo de espera (TR-TI)";
            this.Tiempoespera.Name = "Tiempoespera";
            // 
            // Instantefinalizacion
            // 
            this.Instantefinalizacion.HeaderText = "Instante de finalizacion (Tt)";
            this.Instantefinalizacion.Name = "Instantefinalizacion";
            // 
            // Tiempoarribo
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Lime;
            this.Tiempoarribo.DefaultCellStyle = dataGridViewCellStyle13;
            this.Tiempoarribo.HeaderText = "Tiempo de arribo (TA)";
            this.Tiempoarribo.Name = "Tiempoarribo";
            // 
            // Tiempoderetorno
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tiempoderetorno.DefaultCellStyle = dataGridViewCellStyle14;
            this.Tiempoderetorno.HeaderText = "Tiempo retorno(Tt-TA) ";
            this.Tiempoderetorno.Name = "Tiempoderetorno";
            // 
            // Instanteprimerrespuesta
            // 
            this.Instanteprimerrespuesta.HeaderText = "Instante primer respuesta (PR)";
            this.Instanteprimerrespuesta.Name = "Instanteprimerrespuesta";
            // 
            // Tiemporespuesta
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Tiemporespuesta.DefaultCellStyle = dataGridViewCellStyle15;
            this.Tiemporespuesta.HeaderText = "Tiempo de respuesta (PR-TA)";
            this.Tiemporespuesta.Name = "Tiemporespuesta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Referencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(855, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(855, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cola de recursos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(855, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Uso de recursos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Limpiar datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatosFlow);
            this.Name = "Form1";
            this.Text = "Planificador de procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlujoEjec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFlow)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Estadisticaspromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticasEjec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FlujoEjec;
        private System.Windows.Forms.DataGridView DatosFlow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arribo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView estadisticasEjec;
        private System.Windows.Forms.DataGridView Estadisticaspromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiemporetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempoirrupcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempoespera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instantefinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempoarribo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempoderetorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instanteprimerrespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiemporespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Listo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ejecucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn UEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn USalida;
        private System.Windows.Forms.Button button3;
    }
}

