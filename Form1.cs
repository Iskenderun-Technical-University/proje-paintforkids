namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            this.Width = 1650;
            this.Height = 900;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White);
        int index;
        int x,y,sX,sY,cX,cY;

       

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {   //Mouse'a basıldıgında olacak olaylar 
            /*Kullanıcı canvas'a tıklarsa paint degiskenini true yap ve
            tıklama noktasını py'ye atama işlemi*/
            paint = true;
            py = e.Location;
            
            /*Mouse'un bir düğmesine basıldıgında(MouseDown eventi) çizim için 
             * x,y kordinatlarını ayarlama*/
            cX = e.X;
            cY = e.Y;
        }

  
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {   //Mouse hareket ettiginde olacak olaylar 
            /* paint degişkeni true ve index 1 ise kurşun kalem için serbest çizim yöntemi,
            * kullanıcı tıklar ve mouse'u hareket ettirir*/
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                pic.Refresh();

                /*Mouse hareket ettiğinde yükseklik ve genişlik için başlangıç ve bitiş
                noktalarını ayarlama*/
                x = e.X;
                y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
            }
        }


        private void pic_MouseUp(object sender, MouseEventArgs e)
        {   
            //Mouse'a basıldıktan sonra bırakıldıgında olacak olaylar
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if(index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if(index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if(index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

       

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Eğer bir çizim yapılacaksa seçili indekse ait şekli mevcut çizim konumlarına göre çizme işlemi
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }
    }
}
