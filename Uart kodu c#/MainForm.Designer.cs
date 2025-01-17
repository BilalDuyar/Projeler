/*
 * Created by SharpDevelop.
 * User: Bilal
 * Date: 9.12.2024
 * Time: 13:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace serial
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textcom;
		private System.Windows.Forms.TextBox textBaudrate;
		private System.Windows.Forms.TextBox textDatabits;
		private System.Windows.Forms.TextBox textGonderilecekVeri;
		private System.Windows.Forms.TextBox textGelenveri;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.IO.Ports.SerialPort serialPort1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textcom = new System.Windows.Forms.TextBox();
			this.textBaudrate = new System.Windows.Forms.TextBox();
			this.textDatabits = new System.Windows.Forms.TextBox();
			this.textGonderilecekVeri = new System.Windows.Forms.TextBox();
			this.textGelenveri = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(612, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "Port Aç";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(612, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 39);
			this.button2.TabIndex = 1;
			this.button2.Text = "Port Kapat";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(131, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 35);
			this.button3.TabIndex = 2;
			this.button3.Text = "YOLLA";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textcom
			// 
			this.textcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textcom.Location = new System.Drawing.Point(412, 13);
			this.textcom.Name = "textcom";
			this.textcom.Size = new System.Drawing.Size(183, 26);
			this.textcom.TabIndex = 3;
			this.textcom.Text = "Com";
			// 
			// textBaudrate
			// 
			this.textBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBaudrate.Location = new System.Drawing.Point(413, 56);
			this.textBaudrate.Name = "textBaudrate";
			this.textBaudrate.Size = new System.Drawing.Size(182, 26);
			this.textBaudrate.TabIndex = 4;
			this.textBaudrate.Text = "baudrate";
			// 
			// textDatabits
			// 
			this.textDatabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textDatabits.Location = new System.Drawing.Point(413, 105);
			this.textDatabits.Name = "textDatabits";
			this.textDatabits.Size = new System.Drawing.Size(183, 26);
			this.textDatabits.TabIndex = 5;
			this.textDatabits.Text = "DATABITS";
			// 
			// textGonderilecekVeri
			// 
			this.textGonderilecekVeri.Location = new System.Drawing.Point(42, 56);
			this.textGonderilecekVeri.Multiline = true;
			this.textGonderilecekVeri.Name = "textGonderilecekVeri";
			this.textGonderilecekVeri.Size = new System.Drawing.Size(286, 74);
			this.textGonderilecekVeri.TabIndex = 6;
			this.textGonderilecekVeri.TextChanged += new System.EventHandler(this.TextGonderilecekVeriTextChanged);
			// 
			// textGelenveri
			// 
			this.textGelenveri.Location = new System.Drawing.Point(42, 219);
			this.textGelenveri.Multiline = true;
			this.textGelenveri.Name = "textGelenveri";
			this.textGelenveri.Size = new System.Drawing.Size(286, 69);
			this.textGelenveri.TabIndex = 7;
			this.textGelenveri.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(42, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Gönderilen Veri";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(42, 291);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Gelen Veri";
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 526);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textGelenveri);
			this.Controls.Add(this.textGonderilecekVeri);
			this.Controls.Add(this.textDatabits);
			this.Controls.Add(this.textBaudrate);
			this.Controls.Add(this.textcom);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "serial";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
