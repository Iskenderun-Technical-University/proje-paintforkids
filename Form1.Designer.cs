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
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_circle);
            this.panel1.Controls.Add(this.btn_rectangle);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_Color);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 163);
            this.panel1.TabIndex = 0;
            // 
            // color_picker
            // 
            this.color_picker.Image = global::PaintApp.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(0, -1);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(473, 164);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 8;
            this.color_picker.TabStop = false;
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_circle.Image = global::PaintApp.Properties.Resources.circle;
            this.btn_circle.Location = new System.Drawing.Point(1324, 38);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(111, 93);
            this.btn_circle.TabIndex = 7;
            this.btn_circle.Text = "Çember";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.UseVisualStyleBackColor = false;
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_rectangle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_rectangle.Image = global::PaintApp.Properties.Resources.rectangle;
            this.btn_rectangle.Location = new System.Drawing.Point(1207, 38);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(111, 93);
            this.btn_rectangle.TabIndex = 6;
            this.btn_rectangle.Text = "Dikdörtgen";
            this.btn_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rectangle.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pencil.Image = global::PaintApp.Properties.Resources.pencil;
            this.btn_pencil.Location = new System.Drawing.Point(973, 38);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(111, 93);
            this.btn_pencil.TabIndex = 5;
            this.btn_pencil.Text = "Kalem";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_line.Image = global::PaintApp.Properties.Resources.line;
            this.btn_line.Location = new System.Drawing.Point(1090, 38);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(111, 93);
            this.btn_line.TabIndex = 4;
            this.btn_line.Text = "Çizgi";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_fill.Image = global::PaintApp.Properties.Resources.bucket;
            this.btn_fill.Location = new System.Drawing.Point(856, 38);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(111, 93);
            this.btn_fill.TabIndex = 3;
            this.btn_fill.Text = "Doldur";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_eraser.Image = global::PaintApp.Properties.Resources.eraser;
            this.btn_eraser.Location = new System.Drawing.Point(739, 38);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(111, 93);
            this.btn_eraser.TabIndex = 2;
            this.btn_eraser.Text = "Silgi";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_Color
            // 
            this.btn_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Color.Image = global::PaintApp.Properties.Resources.color;
            this.btn_Color.Location = new System.Drawing.Point(622, 38);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(111, 93);
            this.btn_Color.TabIndex = 1;
            this.btn_Color.Text = "Renkler";
            this.btn_Color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Color.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(507, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 48);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(609, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(841, 125);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 764);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 39);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 163);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1482, 601);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaintforKids";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
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
        private Panel panel3;
        private PictureBox color_picker;
        private PictureBox pic;
    }
}
