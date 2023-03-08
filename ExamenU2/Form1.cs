using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenU2
{
    public partial class Form1 : Form
    {
        //Dimenciones del papel
        public Graphics lienzo;
        //Fondo blanco
        Graphics g;
        //Fondo papel
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int B = 0;
        int tamanioPincel = 3;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        SolidBrush relleno = new SolidBrush(Color.Black);
        //Para el fondo
        Bitmap bm;
        Point py, px;
        public Form1()
        {
            InitializeComponent();
            //Dimenciones del papel de guardado
            papel = pictureBox1.CreateGraphics();

            
            
         
            pen = new Pen(Color.FromArgb(R, G, B), tamanioPincel);
            //Papel
            pictureBox1.Image = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            //para que no se vea pixeleado 
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = bm;
            tamanioPincel = trackBar1.Value;
            R = int.Parse(txtbR.Text);
            G = int.Parse(txtbG.Text);
            B = int.Parse(txtbB.Text);
            // los lazos inicien y terminen de forma ovalada 
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

          
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height); 
            g = Graphics.FromImage(bm);
            //Color del papel
            g.Clear(Color.White);
            pictureBox1.Image = bm;


        }
        private void cambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBar1.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //realizar trazo con pincel
            if (moviendo && pintar)
            {
                CambiarPincel(int.Parse(txtbR.Text), int.Parse(txtbG.Text), int.Parse(txtbB.Text));
                //Dibujamos una linea en la posición actual hasta donde nos movamos 
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                px = e.Location;
                g.DrawLine(pen, px, py);
                py = px;

                // termina el trazo en un punto y empieza en otro 

            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moviendo = true;
            x = e.X; // ESTO PARA QUE LA LINEA SE DIBUJARA DONDE PONES CLICK
            y = e.Y; // IGUAL
                pictureBox1.Cursor = Cursors.Cross;


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moviendo = false;
        }
        // le pasamos el valor actual del trackbar a la variable y modificamos el label con el valor del trackbar 
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();

        }

        private void btn3P_Click(object sender, EventArgs e)
        {
            pintar = true;
        }
        //para pasar a color negro la brocha 
        private void pictureBoxN_Click(object sender, EventArgs e)
        {
             
                pen = new Pen(Color.Black);
            relleno = new SolidBrush(Color.Black);
            txtbR.Text = 0.ToString();
            txtbG.Text = 0.ToString();
            txtbB.Text = 0.ToString();
        
            }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(colorDialog1.Color);
                relleno = new SolidBrush(colorDialog1.Color);
                // asignar a los textbox el color seleccionado
                txtbR.Text = colorDialog1.Color.R.ToString();
                txtbG.Text = colorDialog1.Color.G.ToString();
                txtbB.Text = colorDialog1.Color.B.ToString();
            }
        }
        private void CambiarPincel(int R, int G, int B)
        {
            pen = new Pen(Color.FromArgb(R, G, B), trackBar1.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void btn1i_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            //para abrir los archivos y escoger la imagen 
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abrirImagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bm.Save(saveFileDialog1.FileName);
        }

        private void btn2G_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
           

               /* SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
                btm.Save(guardar.FileName, ImageFormat.Png);


            }*/

        }
        

      
    }
    
}