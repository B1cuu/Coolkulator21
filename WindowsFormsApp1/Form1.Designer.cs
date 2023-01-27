namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.bBMI = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bKal = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bTemp = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bBMI
			// 
			this.bBMI.Location = new System.Drawing.Point(42, 120);
			this.bBMI.Name = "bBMI";
			this.bBMI.Size = new System.Drawing.Size(187, 44);
			this.bBMI.TabIndex = 0;
			this.bBMI.Text = "Oblicz bmi";
			this.bBMI.UseVisualStyleBackColor = true;
			this.bBMI.Click += new System.EventHandler(this.bBMI_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(224, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(477, 39);
			this.label1.TabIndex = 1;
			this.label1.Text = "Witaj w aplikacji Coolkulator";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(37, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(192, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Oblicz swoje BMI";
			// 
			// bKal
			// 
			this.bKal.Location = new System.Drawing.Point(42, 214);
			this.bKal.Name = "bKal";
			this.bKal.Size = new System.Drawing.Size(187, 44);
			this.bKal.TabIndex = 3;
			this.bKal.Text = "Licz";
			this.bKal.UseVisualStyleBackColor = true;
			this.bKal.Click += new System.EventHandler(this.bKal_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(37, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Prosty Kalkulator";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(37, 286);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(254, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Przelicznik Temperatur";
			// 
			// bTemp
			// 
			this.bTemp.Location = new System.Drawing.Point(42, 326);
			this.bTemp.Name = "bTemp";
			this.bTemp.Size = new System.Drawing.Size(249, 44);
			this.bTemp.TabIndex = 6;
			this.bTemp.Text = "Oblicz";
			this.bTemp.UseVisualStyleBackColor = true;
			this.bTemp.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(386, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(315, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Wzory skroconego mnozenia";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(440, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 44);
			this.button1.TabIndex = 8;
			this.button1.Text = "Pokaz mi";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(907, 485);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bTemp);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bKal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bBMI);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Aplikacja";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bBMI;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bKal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bTemp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
	}
}

