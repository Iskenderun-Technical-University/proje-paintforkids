namespace PaintApp
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.btn_rectangle);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_Color);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 163);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 733);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1459, 39);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(221, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 48);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Color
            // 
            this.btn_Color.BackColor = System.Drawing.Color.White;
            this.btn_Color.Image = global::PaintApp.Properties.Resources.color;
            this.btn_Color.Location = new System.Drawing.Point(337, 29);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(111, 93);
            this.btn_Color.TabIndex = 1;
            this.btn_Color.Text = "Renkler";
            this.btn_Color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Color.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::PaintApp.Properties.Resources.eraser;
            this.btn_eraser.Location = new System.Drawing.Point(454, 29);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(111, 93);
            this.btn_eraser.TabIndex = 2;
            this.btn_eraser.Text = "Silgi";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::PaintApp.Properties.Resources.bucket;
            this.btn_fill.Location = new System.Drawing.Point(571, 29);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(111, 93);
            this.btn_fill.TabIndex = 3;
            this.btn_fill.Text = "Doldur";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.White;
            this.btn_line.Image = global::PaintApp.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(805, 29);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(111, 93);
            this.btn_line.TabIndex = 4;
            this.btn_line.Text = "Çizgi";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::PaintApp.Properties.Resources.pencil;
            this.btn_pencil.Location = new System.Drawing.Point(688, 29);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(111, 93);
            this.btn_pencil.TabIndex = 5;
            this.btn_pencil.Text = "Kalem";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.Color.White;
            this.btn_rectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_rectangle.Image = global::PaintApp.Properties.Resources.rectangle;
            this.btn_rectangle.Location = new System.Drawing.Point(922, 29);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(111, 93);
            this.btn_rectangle.TabIndex = 6;
            this.btn_rectangle.Text = "Dikdörtgen";
            this.btn_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.White;
            this.btn_circle.Image = global::PaintApp.Properties.Resources.circle;
            this.btn_circle.Location = new System.Drawing.Point(1039, 29);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(111, 93);
            this.btn_circle.TabIndex = 7;
            this.btn_circle.Text = "Çember";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btn_fill;
        private Button btn_eraser;
        private Button btn_Color;
        private Button button1;
        private Panel panel2;
        private Button btn_circle;
        private Button btn_rectangle;
        private Button btn_pencil;
        private Button btn_line;
    }
}