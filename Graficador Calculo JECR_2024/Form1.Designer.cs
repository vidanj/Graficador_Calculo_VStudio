namespace Graficador_Calculo_JECR_2024
{
    partial class Form1
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
            this.dgvTablaXY = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cBoxRangoManual = new System.Windows.Forms.CheckBox();
            this.txtRangoAuto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDerivada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDerivada = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPendiente0 = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaXY
            // 
            this.dgvTablaXY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaXY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaXY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgvTablaXY.Location = new System.Drawing.Point(530, 156);
            this.dgvTablaXY.Name = "dgvTablaXY";
            this.dgvTablaXY.Size = new System.Drawing.Size(242, 500);
            this.dgvTablaXY.TabIndex = 36;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 3;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Rango Y-:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rango X-:";
            // 
            // btnGraph
            // 
            this.btnGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraph.Location = new System.Drawing.Point(567, 81);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(159, 56);
            this.btnGraph.TabIndex = 33;
            this.btnGraph.Text = "Graficar";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // txtYmax
            // 
            this.txtYmax.Enabled = false;
            this.txtYmax.Location = new System.Drawing.Point(200, 130);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(63, 20);
            this.txtYmax.TabIndex = 32;
            this.txtYmax.Text = "10.0";
            this.txtYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Rango Y+:";
            // 
            // txtYmin
            // 
            this.txtYmin.Enabled = false;
            this.txtYmin.Location = new System.Drawing.Point(69, 130);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(63, 20);
            this.txtYmin.TabIndex = 30;
            this.txtYmin.Text = "-10.0";
            this.txtYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXmax
            // 
            this.txtXmax.Enabled = false;
            this.txtXmax.Location = new System.Drawing.Point(200, 104);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(63, 20);
            this.txtXmax.TabIndex = 29;
            this.txtXmax.Text = "10.0";
            this.txtXmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rango X+:";
            // 
            // txtXmin
            // 
            this.txtXmin.Enabled = false;
            this.txtXmin.Location = new System.Drawing.Point(69, 104);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(63, 20);
            this.txtXmin.TabIndex = 27;
            this.txtXmin.Text = "-10.0";
            this.txtXmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEquation
            // 
            this.txtEquation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEquation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquation.Location = new System.Drawing.Point(74, 35);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(1333, 20);
            this.txtEquation.TabIndex = 26;
            this.txtEquation.Text = "Math.Pow(x, 2) - 4 * x + 7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Equación f(x):";
            // 
            // picGraph
            // 
            this.picGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph.Location = new System.Drawing.Point(12, 156);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(500, 500);
            this.picGraph.TabIndex = 24;
            this.picGraph.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(882, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 37;
            this.button1.Text = "Calcular Max/Min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBoxRangoManual
            // 
            this.cBoxRangoManual.AutoSize = true;
            this.cBoxRangoManual.Location = new System.Drawing.Point(278, 119);
            this.cBoxRangoManual.Name = "cBoxRangoManual";
            this.cBoxRangoManual.Size = new System.Drawing.Size(96, 17);
            this.cBoxRangoManual.TabIndex = 38;
            this.cBoxRangoManual.Text = "Rango Manual";
            this.cBoxRangoManual.UseVisualStyleBackColor = true;
            this.cBoxRangoManual.CheckedChanged += new System.EventHandler(this.cBoxRangoManual_CheckedChanged);
            // 
            // txtRangoAuto
            // 
            this.txtRangoAuto.Location = new System.Drawing.Point(141, 78);
            this.txtRangoAuto.Name = "txtRangoAuto";
            this.txtRangoAuto.Size = new System.Drawing.Size(63, 20);
            this.txtRangoAuto.TabIndex = 40;
            this.txtRangoAuto.Text = "15";
            this.txtRangoAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Rango Auto:";
            // 
            // txtDerivada
            // 
            this.txtDerivada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDerivada.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDerivada.Location = new System.Drawing.Point(882, 220);
            this.txtDerivada.Name = "txtDerivada";
            this.txtDerivada.Size = new System.Drawing.Size(525, 20);
            this.txtDerivada.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 43;
            this.label7.Text = "Derivada:";
            // 
            // lblDerivada
            // 
            this.lblDerivada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDerivada.AutoSize = true;
            this.lblDerivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerivada.Location = new System.Drawing.Point(1022, 119);
            this.lblDerivada.Name = "lblDerivada";
            this.lblDerivada.Size = new System.Drawing.Size(54, 31);
            this.lblDerivada.TabIndex = 44;
            this.lblDerivada.Text = "----";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(876, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 31);
            this.label8.TabIndex = 45;
            this.label8.Text = "Ecuación: ";
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcuacion.Location = new System.Drawing.Point(1022, 92);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(54, 31);
            this.lblEcuacion.TabIndex = 46;
            this.lblEcuacion.Text = "----";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1106, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(301, 31);
            this.label9.TabIndex = 47;
            this.label9.Text = "Formato ax^2 + bx + c";
            // 
            // lblPendiente0
            // 
            this.lblPendiente0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendiente0.AutoSize = true;
            this.lblPendiente0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente0.Location = new System.Drawing.Point(879, 270);
            this.lblPendiente0.Name = "lblPendiente0";
            this.lblPendiente0.Size = new System.Drawing.Size(178, 31);
            this.lblPendiente0.TabIndex = 48;
            this.lblPendiente0.Text = "Pendiente 0:";
            // 
            // btnPotencia
            // 
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(74, 12);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(43, 23);
            this.btnPotencia.TabIndex = 49;
            this.btnPotencia.Text = "x^n";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(123, 12);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(43, 23);
            this.btnRaiz.TabIndex = 50;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1332, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(172, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(43, 23);
            this.btnLog.TabIndex = 52;
            this.btnLog.Text = "ln";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(220, 12);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(43, 23);
            this.btnExp.TabIndex = 53;
            this.btnExp.Text = "e";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 666);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.lblPendiente0);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblEcuacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDerivada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDerivada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRangoAuto);
            this.Controls.Add(this.cBoxRangoManual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTablaXY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.txtYmax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYmin);
            this.Controls.Add(this.txtXmax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXmin);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGraph);
            this.MinimumSize = new System.Drawing.Size(1448, 705);
            this.Name = "Form1";
            this.Text = "Graficadora JECR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaXY;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cBoxRangoManual;
        private System.Windows.Forms.TextBox txtRangoAuto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDerivada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDerivada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPendiente0;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExp;
    }
}

