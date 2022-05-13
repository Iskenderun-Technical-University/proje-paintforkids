namespace PaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
            this.Width = 1500;
            this.Height = 850;
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
        int index;
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            /*Kullanıcı canvas'a tıklarsa paint degiskenini true yap ve
            tıklama noktasını py'ye atama işlemi*/
            paint = true;
            py = e.Location;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
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
                pic.Refresh();
            }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }


        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

    }
}
