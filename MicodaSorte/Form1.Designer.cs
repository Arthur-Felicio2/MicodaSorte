namespace MicodaSorte
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btSpin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrSpin = new System.Windows.Forms.Timer(this.components);
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btSpin
            // 
            this.btSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpin.Location = new System.Drawing.Point(307, 335);
            this.btSpin.Name = "btSpin";
            this.btSpin.Size = new System.Drawing.Size(200, 73);
            this.btSpin.TabIndex = 0;
            this.btSpin.Text = "Girar";
            this.btSpin.UseVisualStyleBackColor = true;
            this.btSpin.Click += new System.EventHandler(this.btSpin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(446, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tmrSpin
            // 
            this.tmrSpin.Tick += new System.EventHandler(this.tmrSpin_Tick);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(561, 374);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(170, 20);
            this.txtBox.TabIndex = 4;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSpin);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "MicoDaSorte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSpin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrSpin;
        private System.Windows.Forms.TextBox txtBox;
    }
}

